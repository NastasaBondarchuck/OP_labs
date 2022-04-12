import pickle
from Abit import Abit


def create_file(file_name):
    check_file = input("Enter 'a' to add information to file "
                       "or enter 'n' to create new file: ")
    file = open(file_name, "ab" if check_file == "a" or check_file == "A" else 'wb')
    file.close()


def write_to_file(file_name: str, full_name: str, birthday: str, sex: str):
    with open(file_name, "ab") as file:
        pickle.dump(full_name, file)
        pickle.dump(birthday, file)
        pickle.dump(sex, file)


def read_from_file(file_name: str):
    abits_list = []
    with open(file_name, "rb") as file:
        while True:
            try:
                full_name = pickle.load(file)
                birthday = pickle.load(file)
                sex = pickle.load(file)
                abit = Abit(full_name, birthday, sex)
                abits_list.append(abit)
            except EOFError:
                break
    return abits_list


def create_recruits_file(file_name: str):
    file = open(file_name, "wb")
    file.close()
