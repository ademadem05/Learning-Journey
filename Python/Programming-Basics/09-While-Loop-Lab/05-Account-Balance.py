total = 0
command = input()
while command != "NoMoreMoney":
    amount = float(command)
    if amount < 0:
        print("Invalid operation!")
        break
    total += amount
    print(f"Increase: {amount:.2f}")
    command = input()
print(f"Total: {total:.2f}")
