'''Задача 26:  Напишите программу, которая на вход принимает два числа A и B, 
и возводит число А в целую степень B с помощью рекурсии.
*Пример:*
A = 3; B = 5 -> 243 (3⁵)
    A = 2; B = 3 -> 8 '''
user_digit = [int(input("Введите число: ")) for _ in range(2)]
def pov_recursion (a: int, b: int):
    if b == 0 or b == 1:
        return a
    return a*pov_recursion(a, b-1)
print(pov_recursion (user_digit[0], user_digit[1]))
