# Задача 10: На столе лежат n монеток. Некоторые из них лежат вверх решкой, а некоторые – гербом. 
# Определите минимальное число монеток, которые нужно перевернуть, чтобы все монетки были повернуты вверх одной и 
# той же стороной. Выведите минимальное количество монет, которые нужно перевернуть
from random import randint
coins = int(input('Введите количество монет - '))
count_heads = 0
count_tails = 0 
for i in range(coins):
    i = randint(0,1)
    if i == 0:
        count_heads += 1
    if i == 1:
        count_tails += 1
print(f'Монет на стороне орел выпало - {count_heads}')
print(f'Монет на стороне решка выпало - {count_tails}')
if count_heads >= count_tails:
    print(f'Необходимо перевернуть {count_tails}')
else:
    print(f'Необходимо перевернуть {count_heads}')