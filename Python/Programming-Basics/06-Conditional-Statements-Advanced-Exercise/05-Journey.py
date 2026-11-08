budget = float(input())
season = input()
if budget <= 100:
    destination = "Bulgaria"
    if season == "summer":
        place, spent = "Camp", budget * 0.30
    else:
        place, spent = "Hotel", budget * 0.70
elif budget <= 1000:
    destination = "Balkans"
    if season == "summer":
        place, spent = "Camp", budget * 0.40
    else:
        place, spent = "Hotel", budget * 0.80
else:
    destination = "Europe"
    place, spent = "Hotel", budget * 0.90
print(f"Somewhere in {destination}")
print(f"{place} - {spent:.2f}")
