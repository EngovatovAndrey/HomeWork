# Задача 14: Требуется вывести все целые степени двойки (т.е. числа вида 2k), 
# не превосходящие числа N
from random import randint
digit_N = randint(2, 64)
print(f"Число для проверки {digit_N}")
i = 0
while 2**i < digit_N:
    print(2**i)
    i+=1