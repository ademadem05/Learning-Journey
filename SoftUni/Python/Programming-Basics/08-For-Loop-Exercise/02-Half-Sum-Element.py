n = int(input())
numbers = [int(input()) for _ in range(n)]
max_number = max(numbers)
rest = sum(numbers) - max_number
if max_number == rest:
    print("Yes")
    print(f"Sum = {max_number}")
else:
    print("No")
    print(f"Diff = {abs(max_number - rest)}")
