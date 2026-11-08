n = int(input())
current = 1
row = 1
while current <= n:
    numbers = []
    for _ in range(row):
        if current > n:
            break
        numbers.append(str(current))
        current += 1
    print(" ".join(numbers))
    row += 1
