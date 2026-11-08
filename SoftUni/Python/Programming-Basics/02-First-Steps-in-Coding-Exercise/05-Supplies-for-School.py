pens = int(input())
markers = int(input())
detergent = int(input())
discount = int(input())
total = pens * 5.80 + markers * 7.20 + detergent * 1.20
final_price = total - total * (discount / 100)
print(final_price)
