## TOPIC 2:  PERSONAL INFORMATION SYSTEM

### Scenario:
You are tasked with developing a simple personal information system. The system should store and display information about individuals, including their age, height, and personal details. Additionally, the system should perform basic operations such as type conversion, conditional checks, and constant usage.

### Requirements:

**Variable Initialization:**

Declare and initialize variables to store the following information for a person:
```
Name (string)
Age (int)
Height in meters (double)
```

User Input:
```
Prompt the user to enter their name, age, and height.
Ensure that the entered age and height are valid (age should be a positive integer, height should be a positive number).
```
Type Conversion:
```
Convert the age to a double and store it in a new variable named doubleAge.
```
**Conditional Statements:**
```
Check if the entered age is greater than or equal to 18.
If true, display a message like "Welcome to the adult section."
If false, display a message like "You are still a minor."
```
**Constant Declaration:**
```
Declare a constant named LEGAL_DRINKING_AGE with a value of 21.
Check if the entered age is greater than or equal to LEGAL_DRINKING_AGE.
If true, display a message like "You are legally allowed to drink."
If false, display a message like "Sorry, you are underage for drinking."
```
**String Manipulation:**
```
Create a new string variable named personalInfo that includes the person's name, age, and height.
Display the personalInfo string.
```
**Additional Considerations:**
```
Ensure that the program gracefully handles incorrect input.
Include comments to explain each section of the code.
Use clear and informative messages for user interactions.
You may assume that the height is entered in meters.
```
### Example Output:
```
Welcome to Your Personal Information System!

Please enter your name: Alice
Please enter your age: 28
Please enter your height in meters: 1.65

------------------------
Your Personal Details:
Name: Alice
Age: 28
Height: 1.65 meters

Age Check:
Welcome, Alice! You're eligible for additional features.

Legal Drinking Age Verification:
Cheers, Alice! You're legally allowed to enjoy alcoholic beverages.

Personal Details Presentation:
Your Personal Information: Alice, 28 years old, 1.65 meters tall.

------------------------

```
Thank you for using Your Personal Information System!
