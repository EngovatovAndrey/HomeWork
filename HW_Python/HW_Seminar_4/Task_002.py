"""
Задача 24: В фермерском хозяйстве в Карелии выращивают чернику. Она растет на круглой грядке, причем кусты высажены 
только по окружности. Таким образом, у каждого куста есть ровно два соседних. Всего на грядке растет N кустов.
Эти кусты обладают разной урожайностью, поэтому ко времени сбора на них выросло различное число ягод – на i-ом кусте 
выросло ai ягод.
В этом фермерском хозяйстве внедрена система автоматического сбора черники. Эта система состоит из управляющего модуля и 
нескольких собирающих модулей. Собирающий модуль за один заход, находясь непосредственно перед некоторым кустом, собирает 
ягоды с этого куста и с двух соседних с ним.
Напишите программу для нахождения максимального числа ягод, которое может собрать за один заход собирающий модуль, находясь 
перед некоторым кустом заданной во входном файле грядки.
"""
from random import randint
size = int(input('Введите количество кустов - '))
clumb = [randint(1, 9) for _ in range(size)]
print(clumb)
if size < 3:
      print(sum(clumb))
      exit()
count1 = 0
count2 = 0
for i in range(1, len(clumb) - 1):
    count1 = clumb[i-1] + clumb[i] + clumb[i+1]
    if count1 > count2:
        count2 = count1
        count1 = 0
count1 = clumb[0] + clumb[-1] + clumb[-2]
if count1 > count2:
        count2 = count1
        count1 = 0
count1 = clumb[-1] + clumb[0] + clumb[1]
if count1 > count2:
        count2 = count1
        count1 = 0
print(f'Максимальное количество ягод для сбора {count2}')
