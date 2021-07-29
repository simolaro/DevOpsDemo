class NewClass: 
    """This is our first class. What it does is display a string text and a value of  variable name""" 
    name = str(input("Enter your name: ")) 
    def greeting (name): 
        print ("Hello", name) 

    MyObject = NewClass()
    print (NewClass.name) 
    print (NewClass.greeting(NewClass.name)) 
    print (NewClass.__doc__)
    MyObject.greeting()
