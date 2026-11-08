tournaments = int(input())
starting_points = int(input())
points = 0
wins = 0
for _ in range(tournaments):
    stage = input()
    if stage == "W":
        points += 2000
        wins += 1
    elif stage == "F":
        points += 1200
    elif stage == "SF":
        points += 720
print(f"Final points: {starting_points + points}")
print(f"Average points: {points // tournaments}")
print(f"{wins / tournaments * 100:.2f}%")
