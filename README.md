

# Simple Name Sorting Algorithm

This application contain 3 sub projects

## 1. name-sorter application

This is the main console application which take 1 input argument: the name/location of file to sort<br/>


## 2. Library application

This application contain all the helper function for the name-sorter function.<br />
some of the library function is: 

1. performSort function: perform sort on list of Objects(Object should be of primitive type or implement IComprable). <br />
this is an extension method so it can be call directly from list.

2. Swap function: generic function which perform swapping of 2 element of list of Objects <br />

3. printList function: generic function which print the content of list of object(the content of each object is the result of toString() function)

## 3. Testin Library function

Contain all the unit tests for Library function <br />
to run the tests use this command: dotnet test test-library/test-library.csproj 


### 4. Setting up command:

1. dotnet restore // restore all package 

2. dotnet run -p name-sorter/name-sorter.csproj ./unsorted-name-list.txt  // run the application

