max_poor_grades = int(input())
poor_grades = 0
total = 0
solved = 0
last_problem = ""
failed = False
problem = input()
while problem != "Enough":
    grade = int(input())
    if grade <= 4:
        poor_grades += 1
        if poor_grades == max_poor_grades:
            failed = True
            break
    total += grade
    solved += 1
    last_problem = problem
    problem = input()
if failed:
    print(f"You need a break, {poor_grades} poor grades.")
else:
    print(f"Average score: {total / solved:.2f}")
    print(f"Number of problems: {solved}")
    print(f"Last problem: {last_problem}")
