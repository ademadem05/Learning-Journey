def largerNums(num1, num2, num3):
      if num1 > num2 and num1 > num3 :
        return num1
      elif num2 > num1 and num2 > num3:
          return num2
      else:
          return num3

first_number =int(input())
second_number =int(input())
thir_number = int(input())
result = largerNums(first_number,second_number,thir_number)
print(result)