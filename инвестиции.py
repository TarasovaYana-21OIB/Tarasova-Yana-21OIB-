X = int(input("Введите минимальную сумму инвестиций: "))
a = int(input("Сумма денег у Майкла: "))
b = int(input("Сумма денег у Ивана: "))

if a >= X and b >= X:
  print(2)
elif a >= X:
  print("Mike")
elif b >= X:
  print("Ivan")
elif a + b >= X:
  print(1)
else:
  print(0)
