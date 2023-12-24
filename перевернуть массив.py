N = int(input("Введите число N: ")

num = []

for i in range(N):
    number = int(input("Введите число: "))
    num.append(number)

reversed_num = num[::-1]

print(reversed_num)
