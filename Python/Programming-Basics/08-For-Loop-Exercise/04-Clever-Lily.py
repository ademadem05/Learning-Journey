age = int(input())
washing_machine = float(input())
toy_price = int(input())
savings = 0
gift = 10
toys = 0
for year in range(1, age + 1):
    if year % 2 == 0:
        savings += gift - 1
        gift += 10
    else:
        toys += 1
savings += toys * toy_price
if savings >= washing_machine:
    print(f"Yes! {savings - washing_machine:.2f}")
else:
    print(f"No! {washing_machine - savings:.2f}")
