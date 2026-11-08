degrees = int(input())
time_of_day = input()
outfit = ""
shoes = ""
if time_of_day == "Morning":
    if 10 <= degrees <= 18:
        outfit, shoes = "Sweatshirt", "Sneakers"
    elif 18 < degrees <= 24:
        outfit, shoes = "Shirt", "Moccasins"
    elif degrees >= 25:
        outfit, shoes = "T-Shirt", "Sandals"
elif time_of_day == "Afternoon":
    if 10 <= degrees <= 18:
        outfit, shoes = "Shirt", "Moccasins"
    elif 18 < degrees <= 24:
        outfit, shoes = "T-Shirt", "Sandals"
    elif degrees >= 25:
        outfit, shoes = "Swim Suit", "Barefoot"
elif time_of_day == "Evening":
    outfit, shoes = "Shirt", "Moccasins"
print(f"It's {degrees} degrees, get your {outfit} and {shoes}.")
