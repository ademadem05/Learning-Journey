days = ["Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"]
day = int(input())
if 1 <= day <= 7:
    print(days[day - 1])
else:
    print("Error")
