import sys

min_number = sys.maxsize
command = input()
while command != "Stop":
    min_number = min(min_number, int(command))
    command = input()
print(min_number)
