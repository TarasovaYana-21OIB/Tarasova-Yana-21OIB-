A = int(input("Введите целое число A: "))
B = int(input("Введите целое число B: "))

print("Четные на отрезке от", A, "до", B, ":")

num = A
while num <= B:
  if num % 2 == 0:
    print(num, end=" ")
  num += 1
