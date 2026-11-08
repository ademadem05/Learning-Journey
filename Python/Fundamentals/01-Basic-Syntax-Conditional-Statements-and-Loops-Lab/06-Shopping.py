def shopping(budget: int ):
    money = budget
    while True:
        userinput = input()

        if userinput == "End":
            print("You bought everything needed.")
            break

        product_price = int(userinput)
        if money < product_price:
            print("You went in overdraft!")
            break
        else:
            money -= product_price


budget = int(input())
shopping(budget)