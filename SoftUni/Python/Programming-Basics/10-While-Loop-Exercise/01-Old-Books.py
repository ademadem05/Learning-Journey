wanted = input()
checked = 0
book = input()
while book != "No More Books":
    if book == wanted:
        print(f"You checked {checked} books and found it.")
        break
    checked += 1
    book = input()
else:
    print("The book you search is not here!")
    print(f"You checked {checked} books.")
