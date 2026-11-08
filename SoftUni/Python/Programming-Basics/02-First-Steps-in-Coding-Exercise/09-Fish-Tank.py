length = int(input())
width = int(input())
height = int(input())
percent = float(input())
liters = length * width * height / 1000
print(liters * (1 - percent / 100))
