start = int(input())
end = int(input())
magic = int(input())
counter = 0
found = False
for i in range(start, end + 1):
    for j in range(start, end + 1):
        counter += 1
        if i + j == magic:
            print(f"Combination N:{counter} ({i} + {j} = {magic})")
            found = True
            break
    if found:
        break
if not found:
    print(f"{counter} combinations - neither equals {magic}")
