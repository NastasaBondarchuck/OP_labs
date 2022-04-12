from FileFunctions import *


def entering_to_file(file_name: str):
    cont = True
    print("Enter abit's list: ")
    while cont:
        full_name = input("Fullname: ")
        birthday = input("Birthday [dd.mm.yyyy]: ")
        sex_letter = input("Sex: ")
        sex = "Male" if sex_letter == "m" or sex_letter == "M" else "Female"
        write_to_file(file_name, full_name, birthday, sex)
        check_entering = input("Continue entering? [y/n]\n")
        cont = True if check_entering == "y" or check_entering == "Y" else False


def delete_older_abits(abits_list: list):
    for abit in abits_list:
        if abit.get_age() > 35:
            abits_list.remove(abit)


def print_list(abits_list: list):
    for abit in abits_list:
        print(abit.get_info())


def recruits(abits_list: list, file_name: str):
    for abit in abits_list:
        if 18 <= abit.get_age() <= 27 and abit.sexType == "Male":
            write_to_file(file_name, abit.fullName, abit.birthDay, abit.sexType)
