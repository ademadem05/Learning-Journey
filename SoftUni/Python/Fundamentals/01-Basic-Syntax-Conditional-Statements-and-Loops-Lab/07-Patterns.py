def triangle_pattern(n : int):
    for row in range(1, n + 1):
        for col in range(0, row):
            print("*", end= "")
        print()

    for row in range(n-1, 0, -1):
        for col in range(0, row):
            print("*", end="")
        print()


n = int(input())
triangle_pattern(n)