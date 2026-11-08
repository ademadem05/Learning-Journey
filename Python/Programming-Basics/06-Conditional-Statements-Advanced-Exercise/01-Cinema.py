prices = {"Premiere": 12.00, "Normal": 7.50, "Discount": 5.00}
projection = input()
rows = int(input())
columns = int(input())
print(f"{rows * columns * prices[projection]:.2f} leva")
