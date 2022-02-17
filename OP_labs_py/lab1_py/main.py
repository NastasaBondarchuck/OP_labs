from functions import *

input_file_name = "input.txt"
output_file_name = "output.txt"
create_input_file(input_file_name)
input_content = read_file(input_file_name)
print("\n==========================================\n",
      "The content of the input file: "
      "\n==========================================\n",
      input_content)
deleted_content, count_of_spaces = delete_dupl_delims(input_content, ' ')
deleted_content, count_of_commas = delete_dupl_delims(deleted_content, ',')
deleted_content, count_of_dots = delete_dupl_delims(deleted_content, '.')
deleted_content, count_of_words = delete_one_symb_words(deleted_content)
create_output_file(output_file_name, deleted_content, count_of_words, count_of_spaces, count_of_commas, count_of_dots)
print("\n==========================================\n",
      "The content of the output file: "
      "\n==========================================\n",
      read_file(output_file_name))

