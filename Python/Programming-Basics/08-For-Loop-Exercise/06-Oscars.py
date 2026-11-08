actor = input()
points = float(input())
judges = int(input())
for _ in range(judges):
    judge = input()
    points += len(judge) * float(input()) / 2
    if points > 1250.5:
        break
if points > 1250.5:
    print(f"Congratulations, {actor} got a nominee for leading role with {points:.1f}!")
else:
    print(f"Sorry, {actor} you need {1250.5 - points:.1f} more!")
