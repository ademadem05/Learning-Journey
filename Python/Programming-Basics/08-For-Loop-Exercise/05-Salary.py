fines = {"Facebook": 150, "Instagram": 100, "Reddit": 50}
tabs = int(input())
salary = int(input())
for _ in range(tabs):
    salary -= fines.get(input(), 0)
    if salary <= 0:
        print("You have lost your salary.")
        break
else:
    print(salary)
