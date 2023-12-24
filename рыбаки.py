m = int(input("Введите максимальную массу, которую может выдержать лодка: "))
n = int(input("Введите количество рыбаков: "))

weights = []
for i in range(n):
    weight = int(input("Введите вес рыбака: "))
    weights.append(weight)

weights.sort()

boats = 0
left = 0
right = n - 1

while left <= right:
    if weights[left] + weights[right] <= m:
       left += 1
       right -= 1
    else:
        right -= 1
    boats += 1

print("Минимальное количество лодок:", boats)
