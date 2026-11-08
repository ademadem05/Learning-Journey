n = int(input())
left = sum(int(input()) for _ in range(n))
right = sum(int(input()) for _ in range(n))
if left == right:
    print(f"Yes, sum = {left}")
else:
    print(f"No, diff = {abs(left - right)}")
