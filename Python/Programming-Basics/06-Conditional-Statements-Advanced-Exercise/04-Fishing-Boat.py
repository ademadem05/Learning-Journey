budget = int(input())
season = input()
fishermen = int(input())
rent = 0
if season == "Spring":
    rent = 3000
elif season in ("Summer", "Autumn"):
    rent = 4200
elif season == "Winter":
    rent = 2600
if fishermen <= 6:
    rent *= 0.90
elif fishermen <= 11:
    rent *= 0.85
else:
    rent *= 0.75
if fishermen % 2 == 0 and season != "Autumn":
    rent *= 0.95
if budget >= rent:
    print(f"Yes! You have {budget - rent:.2f} leva left.")
else:
    print(f"Not enough money! You need {rent - budget:.2f} leva.")
