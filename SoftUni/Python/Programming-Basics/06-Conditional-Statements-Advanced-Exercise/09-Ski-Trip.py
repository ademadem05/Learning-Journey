days = int(input())
room = input()
rating = input()
prices = {"room for one person": 18.00, "apartment": 25.00, "president apartment": 35.00}
total = prices[room] * (days - 1)
if room == "apartment":
    if days < 10:
        total *= 0.70
    elif days <= 15:
        total *= 0.65
    else:
        total *= 0.50
elif room == "president apartment":
    if days < 10:
        total *= 0.90
    elif days <= 15:
        total *= 0.85
    else:
        total *= 0.80
if rating == "positive":
    total *= 1.25
else:
    total *= 0.90
print(f"{total:.2f}")
