budget = float(input())
video_cards = int(input())
processors = int(input())
ram = int(input())
video_cards_price = video_cards * 250
processor_price = video_cards_price * 0.35
ram_price = video_cards_price * 0.1
total = video_cards_price + processors * processor_price + ram * ram_price
if video_cards > processors:
    total -= total * 0.15
if budget >= total:
    print(f"You have {budget - total:.2f} leva left!")
else:
    print(f"Not enough money! You need {total - budget:.2f} leva more!")
