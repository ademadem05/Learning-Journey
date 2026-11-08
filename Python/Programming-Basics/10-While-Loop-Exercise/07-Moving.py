space = int(input()) * int(input()) * int(input())
command = input()
while command != "Done":
    space -= int(command)
    if space < 0:
        break
    command = input()
if space < 0:
    print(f"No more free space! You need {abs(space)} Cubic meters more.")
else:
    print(f"{space} Cubic meters left.")
