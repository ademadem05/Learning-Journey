trip_price = float(input())
puzzles = int(input())
dolls = int(input())
bears = int(input())
minions = int(input())
trucks = int(input())
count = puzzles + dolls + bears + minions + trucks
total = puzzles * 2.60 + dolls * 3 + bears * 4.10 + minions * 8.20 + trucks * 2
if count >= 50:
    total -= total * 0.25
total -= total * 0.1
if total >= trip_price:
    print(f"Yes! {total - trip_price:.2f} lv left.")
else:
    print(f"Not enough money! {trip_price - total:.2f} lv needed.")
