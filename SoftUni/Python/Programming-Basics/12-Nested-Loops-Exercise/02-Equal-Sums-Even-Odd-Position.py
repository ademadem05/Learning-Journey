start = int(input())
end = int(input())
result = []
for number in range(start, end + 1):
    digits = str(number)
    odd_sum = sum(int(d) for d in digits[0::2])
    even_sum = sum(int(d) for d in digits[1::2])
    if odd_sum == even_sum:
        result.append(digits)
print(" ".join(result))
