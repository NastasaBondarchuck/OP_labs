
def create_input_file(file_name):
    choice = input("Enter 'w' to create new file || "
                   "Enter 'a' to add information to the file: ")
    while choice != "w" and choice != 'W' and choice != 'a' and choice != 'A':
        choice = input("You've entered wrong symbol. Try again, please. ")
    if choice == 'a' or choice == 'A':
        if check_file(file_name, 'a+'):
            print("Enter your text: "
                  "Enter Ctrl+C to stop entering.")
            entering(file_name, 'a+')
    else:
        if check_file(file_name, 'w+'):
            print("Enter your text: "
                  "Enter Ctrl+C to stop entering.")
            entering(file_name, 'w+')


def check_file(file_name, mode):
    try:
        file = open(file_name, mode)
        file.close()
    except IOError:
        return False
    return True


def entering(file_name, mode):
    with open(file_name, mode) as file:
        while True:
            try:
                file.write(input())
                file.write('\n')
            except KeyboardInterrupt:
                break


def read_file(file_name):
    with open(file_name, 'r') as file:
        return file.read()


def delete_one_symb_words(text):
    count = 0
    lines = text.split('\n')
    new_text = ''
    for line in lines:
        words = line.split()
        new_line = ''
        for i, word in enumerate(words):
            if len(word) != 1 or not word.isalpha():
                new_line += word + ' '
            else:
                count += 1
        new_text += new_line + '\n'
    return new_text, count


def delete_dupl_delims(text, delim):
    count = 0
    for char in text:
        while char == delim and char*2 in text:
            text = text.replace(char*2, char, 1)
            count += 1
    return text, count


def create_output_file(file_name, content, count_words, count_spaces, count_commas, count_dots):
    if check_file(file_name, 'w+'):
        with open(file_name, 'w+') as file:
            file.write(content +
                       "\nNumber of deleted one-symbol words - " + str(count_words) +
                       "\nNumber of deleted spaces - " + str(count_spaces) +
                       "\nNumber of deleted commas - " + str(count_commas) +
                       "\nNumber of deleted dots - " + str(count_dots))
