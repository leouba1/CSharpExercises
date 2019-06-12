# Objects

## Classes Student + Teacher
* Create a new project, and include in it the class Person that you just created.
* Create a class "Student" and another class "Teacher", both descendants of "Person".
* The class "Student" will have a public method "GoToClasses", which will write on screen "I’m going to class."
* The class "Teacher" will have a public method "Explain", which will show on screen "Explanation begins". Also, it will have a private attribute "subject", a string.
* The class Person must have a method "SetAge (int n)" which will indicate the value of their age (eg, 20 years old).
* The student will have a public method "ShowAge" which will write on the screen "My age is: 20 years old" (or the corresponding number).
* You must create another test class called "StudentAndTeacherTest" that will contain "Main" and:
    * Create a Person and make it say hello
    * Create a student, set his age to 21, tell him to Greet and display his age
    * Create a teacher, 30 years old, ask him to say hello and then explain.

## PhotoAlbumTarea
Create a class "PhotoAlbum" with a private attribute "numberOfPages."

It should also have a public method "GetNumberOfPages", which will return the number of pages.

The default constructor will create an album with 16 pages. There will be an additional constructor, with which we can specify the number of pages we want in the album.

Create a class "BigPhotoAlbum" whose constructor will create an album with 64 pages.

## House
* Create a class "House", with an attribute "area", a constructor that sets its value and a method "ShowData" to display "I am a house, my area is 200 m2" (instead of 200, it will show the real surface). Include getters an setters for the area, too.
* The "House" will contain a door. Each door will have an attribute "color" (a string), and a method "ShowData" wich will display "I am a door, my color is brown" (or whatever color it really is). Include a getter and a setter. Also, create a "GetDoor" in the house.
* A "SmallApartment" is a subclass of House, with a preset area of 50 m2.
* Also create a class Person, with a name (string). Each person will have a house. The method "ShowData" for a person will display his/her name, show the data of his/her house and the data of the door of that house.
* Write a Main to create a SmallApartment, a person to live in it, and to show the data of the person.

## Catalog
Create the classes diagram and then, using Visual Studio, a project and the corresponding classes for a catalog utility:
* It will be able to store information about music files, films and computer programs.
* For each item, it must store: name, code, category and size. For films it must also hold the director, the main actor and the main actress. For music files, the singer and the length (in seconds).
* For music and movies it must have a method "Play" (not implemented yet) and also a method "RetrieveInformation", which will (in a later version) connect to an internet server to get information about it.

Use inheritance if needed. In "Main", create arrays of each kind of object.

## ScreenText
Create a class ScreenText, to display a certain text in specified screen coordinates. It must have a constructor which will receive X, Y and the string to write. It must also have 3 setters and a "Display" method.

Create a class CenteredText, based on ScreenText, to display text centered (horizontally) in a certain row of the screen. Its constructor will receive only Y and the text. SetX should not change the horizontal position.

Create a class FramedText, to display text centered and inside a rectangle. It will receive the starting row and the text.

