values = {"a": 1, "e": 2, "i": 3, "o": 4, "u": 5}
text = input()
total = 0
for char in text:
    total += values.get(char, 0)
print(total)
