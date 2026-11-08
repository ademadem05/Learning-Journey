total = int(input()) + int(input()) + int(input())
minutes = total // 60
seconds = total % 60
print(f"{minutes}:{seconds:02d}")
