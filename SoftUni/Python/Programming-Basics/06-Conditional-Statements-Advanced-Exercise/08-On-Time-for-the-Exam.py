exam_hour = int(input())
exam_minute = int(input())
arrival_hour = int(input())
arrival_minute = int(input())
difference = (exam_hour * 60 + exam_minute) - (arrival_hour * 60 + arrival_minute)
if difference < 0:
    print("Late")
    late = -difference
    if late < 60:
        print(f"{late} minutes after the start")
    else:
        print(f"{late // 60}:{late % 60:02d} hours after the start")
elif difference <= 30:
    print("On time")
    if difference > 0:
        print(f"{difference} minutes before the start")
else:
    print("Early")
    if difference < 60:
        print(f"{difference} minutes before the start")
    else:
        print(f"{difference // 60}:{difference % 60:02d} hours before the start")
