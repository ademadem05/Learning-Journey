budget = float(input())
extras = int(input())
clothing_price = float(input())
decor = budget * 0.1
clothing = extras * clothing_price
if extras >= 150:
    clothing -= clothing * 0.1
total = decor + clothing
if total > budget:
    print("Not enough money!")
    print(f"Wingard needs {total - budget:.2f} leva more.")
else:
    print("Action!")
    print(f"Wingard starts filming with {budget - total:.2f} leva left.")
