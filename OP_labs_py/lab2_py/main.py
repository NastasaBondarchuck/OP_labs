from ContentFunctions import *


first_file_name = "first.bin"
second_file_name = "second.bin"
create_file(first_file_name)
entering_to_file(first_file_name)
abits_list = read_from_file(first_file_name)
print("\n==============================\n"
      "List of abits: \n")
print_list(abits_list)
print("\n==============================\n"
      "List of abits that younger than 35: \n")
delete_older_abits(abits_list)
print_list(abits_list)
create_recruits_file(second_file_name)
recruits(abits_list, second_file_name)
recruits_list = read_from_file(second_file_name)
print("\n==============================\n"
      "List of recruits: \n")
print_list(recruits_list)
