from fastapi import FastAPI, File, UploadFile, HTTPException
from fastapi.staticfiles import StaticFiles
import os
import ast

from test_utils import (
    functions_length,
    count_ast_lines,
    find_unused_variables,
    find_missing_docstrings
)
from analyze import (
    plot_function_length_histogram,
    plot_issue_type_pie_chart,
    plot_issues_per_file_bar_chart
)

app = FastAPI()
app.mount("/graphs", StaticFiles(directory="graphs"), name="graphs")

ALLOWED_EXTENSIONS = {'.py'}

def is_code_file(filename: str, content: str) -> bool:
    _, ext = os.path.splitext(filename)
    if ext.lower() not in ALLOWED_EXTENSIONS:
        return False
    keywords = ['def ', 'class ', 'import ']
    return any(keyword in content for keyword in keywords)

@app.post("/alerts")
async def alerts(files: list[UploadFile] = File(...)):
    all_warnings = []

    for file in files:
        try:
            code_bytes = await file.read()
            code_text = code_bytes.decode("utf-8", errors="ignore")

            if not is_code_file(file.filename, code_text):
                raise HTTPException(status_code=400, detail=f"'{file.filename}' is not a Python file.")

            tree = ast.parse(code_text)
            length_map, long_funcs = functions_length(code_text)
            unused_vars, _ = find_unused_variables(code_text)
            missing_docs = find_missing_docstrings(code_text)
            ast_total, _ = count_ast_lines(code_text)

            all_warnings.append({
                "filename": file.filename,
                "total_lines_by_ast": ast_total,
                "long_functions": long_funcs,
                "unused_variables": unused_vars,
                "missing_docstrings": [
                    {"name": name, "line": lineno, "type": kind}
                    for name, lineno, kind in missing_docs
                ],
                "issue_summary": {
                    "Too Long Functions": len(long_funcs),
                    "Unused Variables": len(unused_vars),
                    "Missing Docstrings": len(missing_docs),
                }
            })
        except Exception as e:
            all_warnings.append({
                "filename": file.filename,
                "error": str(e)
            })

    return all_warnings

@app.post("/analyze")
async def analyze(files: list[UploadFile] = File(...)):
    results = []
    issues_per_file = {}

    for file in files:
        try:
            content = await file.read()
            code_text = content.decode("utf-8", errors="ignore")

            if not is_code_file(file.filename, code_text):
                raise HTTPException(status_code=400, detail=f"'{file.filename}' is not a Python file.")

            length_map, long_funcs = functions_length(code_text)
            unused_vars, _ = find_unused_variables(code_text)
            missing_docs = find_missing_docstrings(code_text)

            pie_name = plot_issue_type_pie_chart({
                "Long functions": len(long_funcs),
                "Unused vars": len(unused_vars),
                "Missing docstrings": len(missing_docs)
            })

            hist_name = plot_function_length_histogram(length_map)

            issues_count = len(long_funcs) + len(unused_vars) + len(missing_docs)
            issues_per_file[file.filename] = issues_count

            results.append({
                "filename": file.filename,
                "function_length_graph": f"/graphs/{hist_name}",
                "issues_pie_chart": f"/graphs/{pie_name}"
            })

        except Exception as e:
            results.append({
                "filename": file.filename,
                "error": str(e)
            })

    bar_name = plot_issues_per_file_bar_chart(issues_per_file)

    return {
        "files": results,
        "issues_bar_chart": f"/graphs/{bar_name}"
    }

if __name__ == "__main__":
    import uvicorn
    uvicorn.run("main:app", host="127.0.0.1", port=8000, reload=True)
