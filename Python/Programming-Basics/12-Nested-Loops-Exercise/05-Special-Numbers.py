n = int(input())
special = []
for number in range(1111, 10000):
    digits = str(number)
    if all(d != "0" and n % int(d) == 0 for d in digits):
        special.append(digits)
print(" ".join(special))
