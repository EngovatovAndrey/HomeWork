from config import *
from commands import *
menu = '''
Функционал телефонной книги
1 - Добавить новый контакт
2 - Удалить контакт
3 - Редактировать запись
4 - Поиск контакта
5 - Показать всю телефонную книгу
6 - Показать меню снова
0 - Вывести количество контактов 
'''

print(menu)

while True:
    print()
    command = int(input('Введите цифру для выполнения команды - '))
    
    if command == 1:
        print()
        command_1()
    
    if command == 2:
        print()
        command_2()

    if command == 3:
        print()
        command_3()
        
    if command == 4:
        print()
        command_4()

    if command == 5:
        print()
        command_5()
    
    if command == 6:
        print(menu)

    if command == 0:
        command_0()


