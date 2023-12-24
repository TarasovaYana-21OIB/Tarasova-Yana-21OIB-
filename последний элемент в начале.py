
N = int(input("Введите число N: "))

numbers = list(map(int, input("Введите числа через пробел: ").split()))

reversed_numbers = numbers[::-1]

for number in reversed_numbers:
    print(number)
