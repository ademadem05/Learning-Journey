nylon = int(input())
paint = int(input())
thinner = int(input())
hours = int(input())
nylon_price = (nylon + 2) * 1.50
paint_price = (paint * 0.1 + paint) * 14.50
thinner_price = thinner * 5.00
materials = nylon_price + paint_price + thinner_price + 0.40
workers = materials * 0.3 * hours
print(materials + workers)
