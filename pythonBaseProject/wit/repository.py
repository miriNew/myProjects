import shutil
import hashlib
import os
from datetime import datetime

from commit import Commit
from utils import generate_hash, copy_directory_contents, delete_directory_contents, copy_file

from utils import create_folder


class Repository:
    commits_log = {}
    static_path = r"C:\Users\user1\Desktop\מירי\לימודים\פייתון\הפרויקט\ניהול גרסאות לדוגמא"
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



# דוגמה לשימוש במחלקה
myRepo = Repository()
myRepo.wit_init()
myRepo.wit_add(r"C:\Users\user1\Desktop\מירי\לימודים\פייתון\הפרויקט\ניהול גרסאות לדוגמא\kkk.txt")
commit_dir = myRepo.wit_commit("Initial commit: Added main feature")
print(f"Commit directory: {commit_dir}")
