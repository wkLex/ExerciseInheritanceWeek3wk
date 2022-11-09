using System.Reflection;

Console.WriteLine("Excersice 1 Creating and Inheriting classes");
Console.WriteLine("Part 1 Creating Classes");

/*
Part-1:Creating classe Create the following three classes:
ClassA.
Class should have no object variables nor should you specify a constructor for it.
It only has the method public void a(), which prints a string "A".
ClassB. Class should have no object variables nor should you specify a constructor for it.
It only has the method public void b(), which prints a string "B".
ClassC. Class should have no object variables nor should you specify a constructor for it.
It only has the methodpublic void c(), which prints a string "C".
The output:
A
B
C
*/

/*//Solutiona 1
A a = new A();
B b = new B();
C c = new C();

a.a();
b.b();
c.c();
class A
{
    public void a()
    {
        Console.WriteLine("A");
    }

}

class B
{
    public void b()
    {
        Console.WriteLine("B");
    }
}

class C
{
    public void c()
    {
        Console.WriteLine("C");
    }
}
*/

/*PART TWO, 2. modify the classes so class B inherits class A, and class C inherits class B.
 * Class A will be a base class for class B. And class B will be a baseclass for class C.
 * 
 * C c = new C()
 * 
 * c.a();
 * c.b();
 * c.c();
 * 
 * Output:
 * A
 * B
 * C
 * */
//Ärva klasser 

A a = new A();
B b = new B();
C c = new C();

c.a();
c.b();
c.c();
class A
{
    public void a()
    {
        Console.WriteLine("A");
    }

}

class B : A // A is Base class - for B. Base class kallas även parent, super och anges med kolon :
            //B kallas child eller derived class
{
    public void b()
    {
        Console.WriteLine("B");
    }
}

class C : B // B is baseclass for C. C ärver Bs inställningar. 
{
    public void c()
    {
        Console.WriteLine("C");
    }
}
