from config import *


def command_1():
    print('Введите данные контакта')
    new_name = input('Введите имя контакта ').capitalize()
    new_phone = input(f'Введите номер для контакта {new_name} ')
    if new_phone.isdigit() == False:
        new_phone = input(
            f'Введите номер состоящий только из цифр для контакта {new_name} ')
    new_comment = input(f'Введите комментарии для {new_name} ')
    if new_comment == '' or new_comment == ' ':
        new_comment = 'Без комментариев'
    new_contact = f'{new_name} {new_phone}, {new_comment}'+'\n'
    add_contact(new_contact)
    print('Контакт добавлен')


def command_2():
    del_name = input('Введите имя контакта для удаления - ').capitalize()
    dele_contact(del_name)
    print('Контакт удален')


def command_3():
    name = input(
        'Введите имя контакта в котором необходимо произвести изменения - ').capitalize()
    with open(path, "r") as f:
        data = f.readlines()
        flag = False
        for line in data:
            if name in line.strip("\n"):
                flag = True
                break
        if flag:
            next = int(input('''Введите 1, чтобы поменять Имя
Введите 2, чтобы поменять номер телефона
Введите 3, чтобы обновить комментарии - '''))
            if next == 1:
                new_name = input(
                    'Введите новое имя контакта - ').capitalize()
                with open(path, "r") as f:
                    data = f.readlines()
                    for line in data:
                        if name in line.strip("\n"):
                            print('Имя контакта обновлено')
                            line1 = line
                            line2 = []
                            line2.append(new_name)
                            line2.append(line1.split()[1:])
                            s = ' '.join(str(x) for x in line2)
                            s = s.translate(s.maketrans(
                                '', '', string.punctuation))
                with open(path, "a") as f:
                    file = open(path, 'a', encoding='UTF-8')
                    file.write(s+'\n')
                dele_contact(name)

            if next == 2:
                new_phone = input('Введите новый телефон контакта - ')
                with open(path, "r") as f:
                    data = f.readlines()
                    for line in data:
                        if name in line.strip("\n"):
                            print('Номер телефона обновлен')
                            line11 = line
                            s = f'{line11.split()[0]} {new_phone} {line11.split()[-1]}'
                with open(path, "a") as f:
                    file = open(path, 'a', encoding='UTF-8')
                    file.write(s+'\n')
                    dele_contact(name)
            if next == 3:
                new_comment = input('Введите новое описание контакта - ')
                with open(path, "r") as f:
                    data = f.readlines()
                    for line in data:
                        if name in line.strip("\n"):
                            print('Описание контакта обновлено')
                            line11 = line
                            s = f'{name} {line11.split()[1]} {new_comment}'
                with open(path, "a") as f:
                    file = open(path, 'a', encoding='UTF-8')
                    file.write(s+'\n')
                    dele_contact(name)
        else:
            print('Такого контакта нет')


def command_4():
    name = input('Введите имя для поиска - ').capitalize()
    find_name(name)


def command_5():
    print_phone_book()


def command_0():
    count_contact()
