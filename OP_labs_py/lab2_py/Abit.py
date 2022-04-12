from datetime import *


class Abit:
    def __init__(self, name: str, birth: str, sex: str):
        self.fullName = name
        self.birthDay = birth
        self.sexType = sex

    def get_info(self):
        return f"Fullname: {self.fullName}\nBirthday: {self.birthDay}\nSex: {self.sexType}\n"

    def get_age(self):
        birth = datetime.strptime(self.birthDay, "%d.%m.%Y")
        now = datetime.now()
        age = (now - birth).days/365
        return age
