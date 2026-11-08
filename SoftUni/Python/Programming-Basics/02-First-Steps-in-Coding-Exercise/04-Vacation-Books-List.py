pages = int(input())
pages_per_hour = int(input())
days = int(input())
total_hours = pages // pages_per_hour
print(total_hours // days)
