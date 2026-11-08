needed = float(input())
money = float(input())
days = 0
spend_streak = 0
while money < needed and spend_streak < 5:
    action = input()
    amount = float(input())
    days += 1
    if action == "save":
        money += amount
        spend_streak = 0
    else:
        money = max(money - amount, 0)
        spend_streak += 1
if money >= needed:
    print(f"You saved the money for {days} days.")
else:
    print("You can't save the money.")
    print(days)
