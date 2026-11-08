n = int(input())
groups = [0, 0, 0, 0, 0]
for _ in range(n):
    number = int(input())
    if number < 200:
        groups[0] += 1
    elif number < 400:
        groups[1] += 1
    elif number < 600:
        groups[2] += 1
    elif number < 800:
        groups[3] += 1
    else:
        groups[4] += 1
for count in groups:
    print(f"{count / n * 100:.2f}%")
