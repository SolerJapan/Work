// See https://aka.ms/new-console-template for more information


Functions SenseOne = new Functions();

SenseOne.input = "NihonKitsune1";
//SenseOne.input = "Palleo";
//SenseOne.input = "mikim";

//int length = Word.Length;
String OddOrEven = SenseOne.oddOrEven(SenseOne.input);
String Palidrome = SenseOne.Palind(SenseOne.input); ;
//String Reverse = "";


//if(length % 2 == 0 )
//{
//    OddOrEven = "even";
//}
//else
//{
//    OddOrEven = "odd";
//}

//for (int i = length -1; i>=0; i--)
//{
//    Reverse += Word[i].ToString(); 
//}
//if(Reverse == Word)
//{
//    Palidrome = "Is a Palindrome";
//}
//else
//{
//    Palidrome = "Not a Palindrome";
//}




Console.WriteLine("Comparing String");

Console.WriteLine("String" + SenseOne.input + " is " + SenseOne.input.Length + " long " );
Console.WriteLine("the length " + SenseOne.input.Length + " is " + SenseOne.primeNum(SenseOne.input.Length));
Console.WriteLine("String" + SenseOne.input + " is " + OddOrEven);
Console.WriteLine("String" + SenseOne.input + " " + Palidrome);

Console.WriteLine("Program Complete");
