def is_positiveOrNot(number):
     if number == 0:
        return "zero"
     if number > 0:
        if number >= 1000000:
            return "large positive"
        elif number < 1:
            return "small positive"
        else:
            return "positive"
     elif number < 0:
        if number <= -1000000:
            return "large negative"
        elif number > -1:
            return "small negative"
        else:
            return "negative"




number = float(input())
result = is_positiveOrNot(number)
print(result)        