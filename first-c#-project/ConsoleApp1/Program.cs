Console.WriteLine("Choose an option by number:");
Console.WriteLine("1 - Exercise (Getting and age)");
Console.WriteLine("0 - Exit");
Console.WriteLine("");
Console.Write("Input option: ");
string choose = Console.ReadLine();
Console.WriteLine("");
Console.WriteLine("");


switch(choose) {
    case "1": 
        exercise_1();
    break;

    case "0":
        Console.WriteLine("Saindo do programa...");
    return; // Sai do loop e finaliza o programa
    
    default:
        Console.WriteLine("Opção inválida. Tente novamente.");
    break;
}


void exercise_1(){
    Console.WriteLine("###################### RUNNING EXERCISE 1 - GETTING AND AGE ######################");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("How old are you?");

    string age =  Console.ReadLine();

    Console.WriteLine("You are " + age + " years old (Using concatnation)");
    Console.WriteLine("You are {0} years old (Using index)", age);
    Console.WriteLine($"You are {age} years old (Using var inside text)");
}



