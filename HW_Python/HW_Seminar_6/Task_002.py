'''Задача 32: Определить индексы элементов массива (списка), 
значения которых принадлежат заданному диапазону 
(т.е. не меньше заданного минимума и не больше заданного максимума)'''
from random import randint
user_num = [int(i) for i in input('Введите два числа через пробел(Минимум и Максимум диаппазона): ').split()]
my_list = [randint(1, 100) for _ in range(31)]
print(my_list)
result_list = [i for i in range(len(my_list)) if user_num[0] <= my_list[i] <= user_num[1]]
print(result_list)