import string
from config import *
s = '''Наташа 1212313 Кто
Рембо  121212 Без комментариев
Серега 121231 Петушара
Кащей 666 Бессмертный
Андрей 1231 Мегабосс
Ира 554433 красивая 123123, Пустой
Тамара 434535 Без комментариев
'''


def command_3():
    name = input(
        'Введите имя контакта в котором необходимо произвести изменения - ').capitalize()
    new_phone = input('Введите новый телефон контакта - ')
    with open(path, "r") as f:
        data = f.readlines()
        for line in data:
            if name in line.strip("\n"):
                print('Произвожу замену...')
                line11 = line
                s = f'{line11.split()[0]} {new_phone} {line11.split()[-1]}'
                print(s)
    with open(path, "a") as f:
        file = open(path, 'a', encoding='UTF-8')
        file.write(s+'\n')
        dele_contact(name)

command_3()
# with open("PhoneBook.txt", "a") as f:
#     file = open('PhoneBook.txt', 'a', encoding='UTF-8')
#     file.write(s1 + '\n')
# dele_contact(new_phone)
# command_3()

