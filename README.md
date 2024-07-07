# SignInApp

A console application for a simple sign in screen, where the user can input a username and password.
These inputs are tested against hardcoded values and if they match, the user is granted access.
If they don't, the user is prompted to try again.

Currently no encryption is implemented.

![image](https://github.com/khadir786/SimpleSignInApp/assets/52165828/de739b2f-c55e-437a-885a-d18945c3519e)



## Changelog

### **03/07/2024** 
- Completed initial logic for the program
### **07/07/2024**
- Added an internal attempt counter, where the user is locked out after five incorrect attempts
  - *<sub>It is by design that invalid inputs like null or empty spaces don't consume an attempt</sub>*

### Current Ideas for Additional Features
- ~~Add an internal attempt counter, where the user is locked out after specific number of incorrect attempts~~
- Registration?
  - Create a dictionary where the username is the key and the password is the value
    - If the user inputs a username that is already in the dictionary, it will be rejected

