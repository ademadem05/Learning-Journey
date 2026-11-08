def muttate_strings(str1, str2):
    for i in range(len(str1)):
      new_string  = str2[:i + 1] + str1[i + 1:]
      if new_string != str1:
         print(new_string)
         str1 = new_string


string1 = input()
string2 = input()
muttate_strings(string1, string2)