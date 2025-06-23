import shutil
import hashlib
import requests
import os
from datetime import datetime

from commit import Commit
from utils import generate_hash, copy_directory_contents, delete_directory_contents, copy_file

from utils import create_folder


class Repository:
    commits_log = {}
    static_path = r"C:\Users\user1\Desktop\מירי\לימודים\פייתון\pythonProject\ניהול גרסאות לדוגמא"
    staging_area =static_path + '\.wit\staging_area'
    commit_area = static_path + '\.wit\history'

    def wit_init(self):
        try:
            print(f"Initializing repository at: {self.static_path}")
            create_folder(self.static_path + '\.wit')
            create_folder(self.static_path + '\.wit\history')
            create_folder(self.static_path + '\.wit\staging_area')
            print("Repository initialized successfully.")
        except Exception as e:
            print(f"Failed to initialize repository: {e}")

    def wit_add(self, file_name):
        copy_file(file_name, self.static_path, self.staging_area)

    def wit_commit(self, message):
        commit = Commit(generate_hash(message), message)
        files = os.listdir(self.staging_area)
        num_files = len([f for f in files if os.path.isfile(os.path.join(self.staging_area, f))])
        if (num_files == 0):
            print(f"On branch master \n nothing to commit, working tree clean")
        else:
            print(f"[master 45d5845] {message} {num_files} files changed")
            create_folder(os.path.join(self.commit_area, commit.hash_code))
            copy_directory_contents(self.staging_area, os.path.join(self.commit_area, commit.hash_code))
            copy_directory_contents(self.static_path, os.path.join(self.commit_area, commit.hash_code))
            delete_directory_contents(self.staging_area)
            self.commits_log[commit.hash_code] = commit

    def wit_log(self):
        if not self.commits_log:
            print("No commits found.")
        else:
            print(f"LOG of all commits:")
            for commit_hash, message in self.commits_log.items():
                print(f"Commit {commit_hash}:")
                print(f"  Date: {message['date']}")
                print(f"  Message: {message['message']}")

    def wit_status(self):
        try:
            files_in_staging = set(os.listdir(self.staging_area)) if os.path.exists(self.staging_area) else set()

            files_in_working = set(os.listdir(self.static_path)) - {".wit"}  # הסרה של תיקיית .wit מהרשימה
            print("on branch master")

            if files_in_staging:
                print("Changes to be committed:")
                for file_name in files_in_staging:
                    print(f"\n modified:  {file_name}")
            else:
                print("No files in staging area.")

            untracked_files = files_in_working - files_in_staging
            if untracked_files:
                print("\nFiles in working copy (not added):")
                for file_name in untracked_files:
                    print(f"- {file_name}")
            else:
                print("\nNo untracked files in working copy.")

        except Exception as e:
         print(f"An error occurred while checking the status: {e}")

    def wit_checkout(self, hash_code):
            delete_directory_contents(self.static_path)
            copy_directory_contents(os.path.join(self.commit_area, hash_code), self.static_path)

    def wit_push(self):
        url_alerts = "http://127.0.0.1:8000/alerts"
        url_analyze = "http://127.0.0.1:8000/analyze"

        # בדיקה האם יש קומיטים חדשים להעלות
        if not self.commits_log:
            print("No commits to push.")
            return

        # ניקח את הקומיט האחרון
        last_commit_hash = list(self.commits_log.keys())[-1]
        commit_path = os.path.join(self.commit_area, last_commit_hash)

        if not os.path.exists(commit_path):
            print(f"Commit folder {commit_path} does not exist.")
            return

        files_to_send = []
        for root, _, files in os.walk(commit_path):
            for file_name in files:
                full_path = os.path.join(root, file_name)
                # נשלח את הקובץ עם הנתיב היחסי מתוך התיקייה commit_path
                relative_path = os.path.relpath(full_path, commit_path)
                try:
                    f = open(full_path, 'rb')
                    files_to_send.append(('files', (relative_path, f, 'text/x-python')))
                except Exception as e:
                    print(f"Failed to open file {full_path}: {e}")

        if not files_to_send:
            print("No files found in the last commit to push.")
            return

        print("📤 Sending files of last commit to server...")

        try:
            response_alerts = requests.post(url_alerts, files=files_to_send)
            if response_alerts.ok:
                print("⚠ Alerts:")
                for file in response_alerts.json():
                    print(f"\n📄 File: {file['filename']}")
                    if "error" in file:
                        print(f"❌ Error: {file['error']}")
                        continue
                    for key, value in file.items():
                        if key not in ['filename', 'error']:
                            print(f"{key}: {value}")
            else:
                print(f"Failed to send alerts: {response_alerts.status_code} {response_alerts.text}")

        except Exception as e:
            print(f"Error sending alerts: {e}")

        # סגירת כל הקבצים
        for _, (name, file_obj, _) in files_to_send:
            file_obj.close()

        # פתיחת הקבצים שוב עבור הקריאה השנייה
        files_to_send = []
        for root, _, files in os.walk(commit_path):
            for file_name in files:
                full_path = os.path.join(root, file_name)
                relative_path = os.path.relpath(full_path, commit_path)
                try:
                    f = open(full_path, 'rb')
                    files_to_send.append(('files', (relative_path, f, 'text/x-python')))
                except Exception as e:
                    print(f"Failed to open file {full_path}: {e}")

        try:
            response_analyze = requests.post(url_analyze, files=files_to_send)
            if response_analyze.ok:
                print("\n📊 Graphs generated successfully!")
                print(f"Graphs saved in: http://127.0.0.1:8000{response_analyze.json()['issues_bar_chart']}")
            else:
                print(f"Failed to analyze: {response_analyze.status_code} {response_analyze.text}")
        except Exception as e:
            print(f"Error sending analyze: {e}")

        for _, (name, file_obj, _) in files_to_send:
            file_obj.close()


# דוגמה לשימוש במחלקה
#myRepo = Repository()
#myRepo.wit_init()
#myRepo.wit_add(r"C:\Users\user1\Desktop\מירי\לימודים\פייתון\הפרויקט\ניהול גרסאות לדוגמא\kkk.txt")
#commit_dir = myRepo.wit_commit("Initial commit: Added main feature")
#print(f"Commit directory: {commit_dir}")
