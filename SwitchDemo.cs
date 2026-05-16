using System;
class SwitchDemo{
static void Main(){
Console.Write("Enter a Student No (1-5): ");
int Sno = int.Parse(Console.ReadLine());
switch(Sno){
case 1:
Console.WriteLine("Student 1");
break;
case 2:
Console.WriteLine("Student 2");
break;
case 3:
Console.WriteLine("Student 3");
break;
case 4:
Console.WriteLine("Student 4");
break;
case 5:
Console.WriteLine("Student 5");
break;
default:
Console.WriteLine("No Student exists with the given id");
break; 
}

}
}
