def reversedWord(text):
    reversed_text = text[::-1]
    return reversed_text

text_input = input()
result = reversedWord(text_input)
print(result)