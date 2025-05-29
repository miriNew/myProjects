from datetime import datetime


class Commit:
    def __init__(self,hash_code,message):
       self.hash_code=hash_code
       self.message= message
       self.date=datetime.now()


