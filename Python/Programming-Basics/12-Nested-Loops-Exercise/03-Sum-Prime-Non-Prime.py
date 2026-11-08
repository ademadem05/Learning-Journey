prime_sum = 0
non_prime_sum = 0
command = input()
while command != "stop":
    number = int(command)
    if number < 0:
        print("Number is negative.")
    else:
        is_prime = True
        for i in range(2, int(number ** 0.5) + 1):
            if number % i == 0:
                is_prime = False
                break
        if is_prime:
            prime_sum += number
        else:
            non_prime_sum += number
    command = input()
print(f"Sum of all prime numbers is: {prime_sum}")
print(f"Sum of all non prime numbers is: {non_prime_sum}")
