prices = {"Roses": 5.00, "Dahlias": 3.80, "Tulips": 2.80, "Narcissus": 3.00, "Gladiolus": 2.50}
flower = input()
count = int(input())
budget = int(input())
total = prices[flower] * count
if flower == "Roses" and count > 80:
    total *= 0.90
elif flower == "Dahlias" and count > 90:
    total *= 0.85
elif flower == "Tulips" and count > 80:
    total *= 0.85
elif flower == "Narcissus" and count < 120:
    total *= 1.15
elif flower == "Gladiolus" and count < 80:
    total *= 1.20
if budget >= total:
    print(f"Hey, you have a great garden with {count} {flower} and {budget - total:.2f} leva left.")
else:
    print(f"Not enough money, you need {total - budget:.2f} leva more.")
