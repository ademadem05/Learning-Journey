groups = int(input())
peaks = [0, 0, 0, 0, 0]
total = 0
for _ in range(groups):
    people = int(input())
    total += people
    if people <= 5:
        peaks[0] += people
    elif people <= 12:
        peaks[1] += people
    elif people <= 25:
        peaks[2] += people
    elif people <= 40:
        peaks[3] += people
    else:
        peaks[4] += people
for count in peaks:
    print(f"{count / total * 100:.2f}%")
