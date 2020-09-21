# C# Language Basics

1. (15pt) Write a password generator that prompts the user for the length of a password, then generates and prints a random password of the given length. The generated password should consists of characters randomly selected from lower case letters, upper case letters, and digits. For example:

Please enter the length of the password: 6
Generated password: wFD43r
HINT: put a-z, A-Z, and 0-9 in an array, then use Random to pick characters from the array.

2. (15pt) Write a program that prompts the user to enter three words and display them in alphabetical order. For example:

Please enter three words: Welcome to C#
Sorted: C# to Welcome
Note that the words should be sorted in a case-insensitive manner.

HINT: Use String.Split() to split the input line into an array of strings, then use Array.Sort() to sort it.

[Project Structure]

You may put the code for both exercises inside one Main() method. Alternatively, you can create two projects (e.g. Exercise1 and Exercise2) inside the same solution (e.g. Lab1).

[Submission]

You may submit individual .cs files, or package the whole solution into a zip file and upload it to CSNS. If you choose to upload a zip file, please exclude the /bin and /obj folders -- you can create the zip file using the git archive command we discussed in class.
