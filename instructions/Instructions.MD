# Menu Permissions: Chillisoft Assessment

Below are provided two different input files and an output file. _Only_ an example of the input and output is given to you, without any requirements other than to reverse engineer the logic that produces the output.

Your goal is to produce working code that produces the same output as provided given these input files. The input and expected output files are all provided in this folder.

You should be able to execute your final result from the command line. If you were to name the program `menupermissions` then you should be able to execute it from the command line (using cmd or bash, or other shell) as follows:
```
menupermissions users.txt menus.txt > output1.json
```

__Note__: it doesn't have to be a compiled executable, but must be runnable from the command line using a command similar to the above. For example, if you write a python program it could be:
```
python menupermissions.py users.txt menus.txt > output1.json
```

If you were to run the above command, `output1.json` should be exactly the same in content as the `output.json` provided. (Note: the exact whitespace does not need to be the same, but the json structure and data should be).

The program should be written as if it were to be deployed into production. However, it does not need to have logging, and only needs very basic error handling that will reject invalid files.

## Assessment Guidelines

You can use any language/platform to write the solution with.

The submission will be assessed on the basis of:
 - Does it work?  This will be checked by running the same program with a different set of input and verifying that it produces the output. Note: the real dataset has about 200 menu items and 10000 users.
 - Is the code good quality?  Quality is subjective, but consider that you will be putting this into production, so the code should be indicative of your values as a developer.  

## Submission Instructions

To submit the final solution to Chillisoft, send a zip file of:
 - your code 
 - _an executable or interpretable script_ 
 - instructions to run it - that is: 
   - which OS and which shell to use to execute it. (e.g. Windows+cmd, or Linux+bash, or other)
   - If your program needs a JVM, or a .NET runtime, please indicate which. 
   - If your program needs an interpreter to execute, please tell us which interpreter and which version to use (e.g. Python 3, Nodejs 16, Ruby 2.8 etc)

## The files

### Input file 1 (users.txt):

```
User1 NYNYN NNNNY
UserBob NNYNN NNNYY
User3 YNNYN YNNYY
User4 YYYYY YYYYY
```

### Input file 2 (menus.txt):

```
1, Applications Menu
2, Security Permissions Menu
3, Customers Menu
4, Accounts Menu
6, Settings Menu
5, Pricing Menu
7, Orders Menu
8, Jobs Menu
9, Profile Menu
10, Help Menu
```

### Resulting output file (output.json):

```json
{
  "users": [
    {
      "userName": "User1",
      "menuItems": [
        "Security Permissions Menu",
        "Accounts Menu",
        "Help Menu"
      ]
    },
    {
      "userName": "UserBob",
      "menuItems": [
        "Customers Menu",
        "Profile Menu",
        "Help Menu"
      ]
    },
    {
      "userName": "User3",
      "menuItems": [
        "Applications Menu",
        "Accounts Menu",
        "Settings Menu",
        "Profile Menu",
        "Help Menu"        
      ]
    },
    {
      "userName": "User4",
      "menuItems": [
        "Applications Menu",
        "Security Permissions Menu",
        "Customers Menu",
        "Accounts Menu",
        "Pricing Menu",
        "Settings Menu",
        "Orders Menu",
        "Jobs Menu",
        "Profile Menu",
        "Help Menu"
      ]
    }
  ]
}

```