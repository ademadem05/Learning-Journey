jury = int(input())
total = 0
count = 0
presentation = input()
while presentation != "Finish":
    grades = [float(input()) for _ in range(jury)]
    total += sum(grades)
    count += jury
    print(f"{presentation} - {sum(grades) / jury:.2f}.")
    presentation = input()
print(f"Student's final assessment is {total / count:.2f}.")
