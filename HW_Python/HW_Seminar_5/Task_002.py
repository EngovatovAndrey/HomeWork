'''Задача 28: Напишите рекурсивную функцию sum(a, b), возвращающую сумму двух целых неотрицательных чисел.
 Из всех арифметических операций допускаются только +1 и -1. Также нельзя использовать циклы.
*Пример:*
2 2
    4 '''
user_digit = [int(input("Введите число: ")) for _ in range(2)]
def sum (a: int, b: int):
        if a < 0 or b < 0:
            return 'Ошибка ввода!'    
        if(a==0):
            return b
        if(b==0):
            return a
        result =sum(a - 1, b) + 1
        return result           
print(f'Сумма чисел {user_digit[0]} и {user_digit[1]} равна {sum(user_digit[0], user_digit[1])}')
