rates = {
    "Sofia": (0.05, 0.07, 0.08, 0.12),
    "Varna": (0.045, 0.075, 0.10, 0.13),
    "Plovdiv": (0.055, 0.08, 0.12, 0.145),
}
city = input()
sales = float(input())
commission = 0
if city in rates and sales >= 0:
    if sales <= 500:
        commission = sales * rates[city][0]
    elif sales <= 1000:
        commission = sales * rates[city][1]
    elif sales <= 10000:
        commission = sales * rates[city][2]
    else:
        commission = sales * rates[city][3]
if commission == 0:
    print("error")
else:
    print(f"{commission:.2f}")
