name = input()
grade_level = 1
total = 0
fails = 0
while grade_level <= 12:
    grade = float(input())
    if grade < 4:
        fails += 1
        if fails > 1:
            break
        continue
    total += grade
    grade_level += 1
if fails > 1:
    print(f"{name} has been excluded at {grade_level} grade")
else:
    print(f"{name} graduated. Average grade: {total / 12:.2f}")
