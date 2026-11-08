change = round(float(input()) * 100)
coins = 0
for coin in (200, 100, 50, 20, 10, 5, 2, 1):
    coins += change // coin
    change %= coin
print(coins)
