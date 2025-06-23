import matplotlib.pyplot as plt
import os

def plot_function_length_histogram(function_lengths):
    # יצירת גרף
    function_names = list(function_lengths.keys())
    lengths = list(function_lengths.values())

    bars = plt.bar(function_names, lengths, color=['red' if length > 20 else 'blue' for length in lengths])
    # הוספת מספר השורות מעל כל עמודה
    for bar in bars:
        yval = bar.get_height()  # מקבל את גובה העמודה
        plt.text(bar.get_x() + bar.get_width() / 2, yval, str(yval), ha='center', va='bottom')  # מוסיף את הטקסט

    plt.axhline(y=20, color='green', linestyle='--')  # קו חצייה עבור 20 שורות
    plt.title('Function Lengths')
    plt.xlabel('Function Names')
    plt.ylabel('Number of Lines')
    plt.xticks(rotation=45)
    plt.tight_layout()  # מתאימים את הגרף
    plt.show()
    plt.close()

def plot_issue_type_pie_chart(issue_counts, output_path):
    labels = list(issue_counts.keys())
    sizes = list(issue_counts.values())

    plt.figure(figsize=(6, 6))
    plt.pie(sizes, labels=labels, autopct="%1.1f%%", startangle=140)
    plt.title("Issues by Type")
    plt.axis("equal")
    plt.tight_layout()
    plt.savefig(os.path.join(output_path, "issues_by_type_pie.png"))
    plt.show()
    plt.close()

def plot_issues_per_file_bar_chart(file_issues, output_path):
    files = list(file_issues.keys())
    counts = list(file_issues.values())

    plt.figure(figsize=(10, 5))
    plt.bar(files, counts, color='salmon', edgecolor='black')
    plt.title("Number of Issues per File")
    plt.xlabel("File Name")
    plt.ylabel("Issues Count")
    plt.xticks(rotation=45, ha='right')
    plt.tight_layout()
    plt.savefig(os.path.join(output_path, "issues_per_file_bar.png"))
    plt.show()
    plt.close()

# def plot_issues_over_time(dates, issue_counts, output_path):
#     plt.figure(figsize=(8, 5))
#     plt.plot(dates, issue_counts, marker='o', linestyle='-', color='green')
#     plt.title("Issues Over Time")
#     plt.xlabel("Date")
#     plt.ylabel("Number of Issues")
#     plt.grid(True)
#     plt.xticks(rotation=45)
#     plt.tight_layout()
#     plt.savefig(os.path.join(output_path, "issues_over_time_line.png"))
#     plt.show()
#     plt.close()
