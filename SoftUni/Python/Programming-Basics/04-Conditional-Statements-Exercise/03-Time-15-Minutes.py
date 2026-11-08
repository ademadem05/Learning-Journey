hours = int(input())
minutes = int(input())
total = hours * 60 + minutes + 15
hours = total // 60
minutes = total % 60
if hours > 23:
    hours = 0
print(f"{hours}:{minutes:02d}")
