def between1And100(num: float):
    if 1 <= num and num <= 100:
        return True


while True:
    userInput = float(input())
    if between1And100(userInput) == True:
        print(f"The number {userInput} is between 1 and 100")
        break

