def Repeat_strings():
    array = input().split()
    text_long = ""
    for i in range(len(array)):
        text = array[i] * len(array[i])
        text_long += text
    print(text_long)

Repeat_strings()