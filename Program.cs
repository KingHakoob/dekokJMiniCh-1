// Jacob Dekok
// 10/17/2022
// Git Hub Transfer - Mini Challenge #1 "What is your name?"
// This is a console project that will ask the user their name
// and report it back to the console


Console.Clear();

string again = "YES";

while(again == "YES"){

    Console.WriteLine("What is your name?");
    string yourName = Console.ReadLine();
    Console.WriteLine("Hello, good aftertnoon " + yourName);

    Console.WriteLine("Would you like to tell me your name again? 'YES' 'NO'");
    again = Console.ReadLine().ToUpper();

    if(again == "NO"){
        Console.WriteLine("Good Bye!");
    }else if (again != "YES" && again != "NO"){
        Console.WriteLine("I'll take that as a no... ");
    }

}