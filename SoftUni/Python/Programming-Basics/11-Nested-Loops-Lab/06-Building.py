floors = int(input())
rooms = int(input())
for floor in range(floors, 0, -1):
    if floor == floors:
        kind = "L"
    elif floor % 2 == 0:
        kind = "O"
    else:
        kind = "A"
    print(" ".join(f"{kind}{floor}{room}" for room in range(rooms)))
