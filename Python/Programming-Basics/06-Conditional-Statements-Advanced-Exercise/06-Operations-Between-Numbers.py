n1 = int(input())
n2 = int(input())
operator = input()
if operator in ("+", "-", "*"):
    if operator == "+":
        result = n1 + n2
    elif operator == "-":
        result = n1 - n2
    else:
        result = n1 * n2
    parity = "even" if result % 2 == 0 else "odd"
    print(f"{n1} {operator} {n2} = {result} - {parity}")
elif n2 == 0:
    print(f"Cannot divide {n1} by zero")
elif operator == "/":
    print(f"{n1} / {n2} = {n1 / n2:.2f}")
elif operator == "%":
    print(f"{n1} % {n2} = {n1 % n2}")
