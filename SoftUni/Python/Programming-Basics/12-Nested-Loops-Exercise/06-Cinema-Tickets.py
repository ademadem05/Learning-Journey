tickets = {"student": 0, "standard": 0, "kid": 0}
total = 0
movie = input()
while movie != "Finish":
    seats = int(input())
    sold = 0
    while sold < seats:
        ticket = input()
        if ticket == "End":
            break
        tickets[ticket] += 1
        sold += 1
    total += sold
    print(f"{movie} - {sold / seats * 100:.2f}% full.")
    movie = input()
print(f"Total tickets: {total}")
print(f"{tickets['student'] / total * 100:.2f}% student tickets.")
print(f"{tickets['standard'] / total * 100:.2f}% standard tickets.")
print(f"{tickets['kid'] / total * 100:.2f}% kids tickets.")
