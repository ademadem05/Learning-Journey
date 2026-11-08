import sys

max_number = -sys.maxsize
command = input()
while command != "Stop":
    max_number = max(max_number, int(command))
    command = input()
print(max_number)
