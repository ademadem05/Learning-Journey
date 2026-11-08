import math

series = input()
episode = int(input())
break_time = int(input())
time_left = break_time - break_time / 8 - break_time / 4
if time_left >= episode:
    print(f"You have enough time to watch {series} and left with {math.ceil(time_left - episode)} minutes free time.")
else:
    print(f"You don't have enough time to watch {series}, you need {math.ceil(episode - time_left)} more minutes.")
