import ast


def functions_length(code):
        tree = ast.parse(code)  # מנתח את הקוד ל-AST
        functions_length = {}  # מילון לשמירת מספר השורות של כל פונקציה
        long_funcs=[]

        for node in ast.walk(tree):  # עובר על כל הצמתים בעץ
            if isinstance(node, ast.FunctionDef):  # אם הצומת הוא פונקציה
                start_line = node.lineno  # שורת התחלה של הפונקציה
                end_line = node.end_lineno  # שורת סיום של הפונקציה
                length = end_line - start_line + 1  # סופר את השורות
                if length > 20:
                    long_funcs.append({"name": node.name, "length": length})
                functions_length[node.name] = length  # שומר את מספר השורות במילון

        return functions_length,long_funcs  # מחזיר את המילון


def count_ast_lines(source_code: str):
    tree = ast.parse(source_code)
    min_lineno = float('inf')
    max_lineno = 0

    for node in ast.walk(tree):
        if hasattr(node, 'lineno'):
            min_lineno = min(min_lineno, node.lineno)
            if hasattr(node, 'end_lineno'):
                max_lineno = max(max_lineno, node.end_lineno)
            else:
                max_lineno = max(max_lineno, node.lineno)

    if min_lineno == float('inf'):
        return 0, False  # אין שורות בכלל

    total_lines = max_lineno - min_lineno + 1
    is_too_long = total_lines > 50

    return total_lines, is_too_long



def find_unused_variables(source_code: str):
    assigned_vars = set()
    used_vars = set()

    tree = ast.parse(source_code)

    for node in ast.walk(tree):
        if isinstance(node, ast.Name):
            if isinstance(node.ctx, ast.Store):
                assigned_vars.add(node.id)
            elif isinstance(node.ctx, ast.Load):
                used_vars.add(node.id)

    unused_vars = assigned_vars - used_vars
    return list(unused_vars), len(unused_vars)


def find_missing_docstrings(source_code: str):
    tree = ast.parse(source_code)
    missing_docs = []

    for node in ast.walk(tree):
        if isinstance(node, (ast.FunctionDef, ast.AsyncFunctionDef, ast.ClassDef)):
            docstring = ast.get_docstring(node)
            if docstring is None:
                missing_docs.append((node.name, node.lineno, type(node).__name__))

    return missing_docs
