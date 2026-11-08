def double_char(txt):
    text = ""
    for i in range(len(txt)):
        letter = txt[i] * 2
        text += letter
    print(text)

while True:
    userInput = input()
    if userInput == "End":
        break
    elif userInput == "SoftUni":
        continue
    double_char(userInput)