n = int(input())

def even_Number(n):
    status = True
    for i in range(n):
        num = int(input())
        if num % 2 != 0:
            status = False
            break
    if status:
        print("All numbers are even.")
    else:
        print(f"{num} is odd!") 

even_Number(n)