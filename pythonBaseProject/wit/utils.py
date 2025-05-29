import hashlib
import os
import shutil
import time


def create_folder(path):
    os.makedirs(path, exist_ok=True)
def copy_file(file_name, src, target):
    try:
        shutil.copy(os.path.join(src, file_name), target)
    except Exception as e:
        print(f"Error copying file: {e}")
def generate_hash(message):
        try:
            current_time = str(time.time())
            combined_string = current_time + message
            hash_object = hashlib.sha256(combined_string.encode())
            return hash_object.hexdigest()
        except Exception as e:
            print(f"Error generating hash: {e}")

def copy_directory_contents(src, dest):
    if not os.path.exists(dest):
        os.makedirs(dest)

    for item in os.listdir(src):
        if item.startswith('.'):
            continue
        s = os.path.join(src, item)
        d = os.path.join(dest, item)
        if os.path.exists(d):
            continue
        if os.path.isdir(s):
            shutil.copytree(s, d, False, None)
        else:
            shutil.copy2(s, d)
def delete_directory_contents(dir_path):
    if os.path.exists(dir_path):
        for item in os.listdir(dir_path):
            item_path = os.path.join(dir_path, item)
            if os.path.isdir(item_path):
                shutil.rmtree(item_path)
            else:
                os.remove(item_path)
