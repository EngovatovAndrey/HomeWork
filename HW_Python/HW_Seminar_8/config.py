import string 
path = '/Users/engomac/Documents/Programming/GeekBrains/Практика/Home_Work/HW_Python/HW_Seminar_8/PhoneBook.txt'

def add_contact(contact):
    file = open(path, 'a', encoding='UTF-8')
    file.write(contact)
    file.close()

def dele_contact(name):
    if name == '' or name == ' ':
        print('Ты забыл имя ввести')
    else:
        with open(path, "r") as f: 
            data = f.readlines()
        with open(path, "w") as f:
            for line in data :
                if name.capitalize() not in line.strip("\n") : 
                    f.write(line)  

def print_phone_book():
    with open(path, "r") as f: 
        data = f.readlines()
    with open(path, "w") as f:
        for line in data :
            if line.strip(): 
                f.write(line) 
    with open(path, "r") as f: 
        data = f.readlines() 
        for line in data :
            print(line.translate(line.maketrans('', '', string.punctuation)), end='')


def find_name(name):
    flag = False
    with open(path, "r") as f: 
        data = f.readlines()
        for line in data:
            if name in line.strip("\n"): 
                flag = True
                line1 = line         
        if flag:
            print('Есть такой контакт!')     
            print(line1.strip("\n"))    
        else:
            print('Такого контакта пока нет')  
            
def count_contact():
    file = open(path, 'r', encoding='UTF-8')
    data = file.readlines()
    count = len(data)
    print(f'В вашей телефонной книге {count} контактов')


# def make_dict():
#     file = open('PhoneBook.txt', 'r', encoding='UTF-8')
#     data = file.readlines()
#     my_dict = {}
#     for i in range(len(data)):
#         item = data[i].translate(data[i].maketrans('', '', string.punctuation))
#         my_dict[data[i].split(' ')[0]] = my_dict.get(data[i].split(' ')[0].translate(data[i].maketrans('', '', string.punctuation)))
#         my_dict[data[i].split(' ')[0]] = item.split()[1:]
#     file.close()
#     return my_dict 





    
 
