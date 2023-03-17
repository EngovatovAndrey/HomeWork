"""
Задача 16: Требуется вычислить, сколько раз встречается некоторое число X в массиве A[1..N]. 
Пользователь в первой строке вводит натуральное число N – количество элементов в массиве. В последующих  
строках записаны N целых чисел Ai. Последняя строка содержит число X
*Пример:*
5
    1 2 3 4 5
    3
    -> 1
"""
import random
user_number = int(input("Введите число - "))
array = [random.randint(1, user_number) for _ in range(1, user_number+1)]
print(array)
digit_x = random.randint(1, user_number)
print(digit_x)
count = 0
for i in range(len(array)):
    if array[i] == digit_x:
        count +=1
print(f'Запрашиваемое число, встречается {count} раз')