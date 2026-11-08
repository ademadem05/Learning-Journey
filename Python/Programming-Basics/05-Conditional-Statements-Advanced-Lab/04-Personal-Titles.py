age = float(input())
gender = input()
if gender == "m":
    print("Mr." if age >= 16 else "Master")
elif gender == "f":
    print("Ms." if age >= 16 else "Miss")
