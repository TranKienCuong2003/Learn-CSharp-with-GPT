using System;
using StringAdvanced;
using NumberHandling;
using ArrayAndListHandling;
using OOP;
using AdvancedTopics;

public class Program
{
    public static void Run()
    {
        // Bài tập chủ đề 1: Xử lý chuỗi nâng cao
        Console.WriteLine("Chủ đề 1: Xử lý chuỗi nâng cao");
        ReverseString.Run();
        Console.WriteLine();

        CheckPalindrome.Run();
        Console.WriteLine();

        CountWords.Run();
        Console.WriteLine();

        LongestWord.Run();
        Console.WriteLine();

        CountCharacter.Run();
        Console.WriteLine();

        ConvertToUpper.Run();
        Console.WriteLine();

        ConvertToLower.Run();
        Console.WriteLine();

        TrimSpaces.Run();
        Console.WriteLine();

        ConcatenateStrings.Run();
        Console.WriteLine();

        ToTitleCase.Run();
        Console.WriteLine();

        // Bài tập chủ đề 2: Xử lý số và các phép toán
        Console.WriteLine("Chủ đề 2: Xử lý số và các phép toán");
        SumOfTwoNumbers.Run();
        Console.WriteLine();

        DifferenceOfTwoNumbers.Run();
        Console.WriteLine();

        ProductOfTwoNumbers.Run();
        Console.WriteLine();

        DivisionOfTwoNumbers.Run();
        Console.WriteLine();

        SquareRoot.Run();
        Console.WriteLine();

        PrimeNumberCheck.Run();
        Console.WriteLine();

        AbsoluteValue.Run();
        Console.WriteLine();

        CelsiusToFahrenheit.Run();
        Console.WriteLine();

        FahrenheitToCelsius.Run();
        Console.WriteLine();

        SumFrom1ToN.Run();
        Console.WriteLine();

        // Bài tập chủ đề 3: Xử lý mảng và danh sách
        Console.WriteLine("Chủ đề 3: Xử lý mảng và danh sách");
        SumArray.Run();
        Console.WriteLine();

        MaxInArray.Run();
        Console.WriteLine();

        MinInArray.Run();
        Console.WriteLine();

        ReverseArray.Run();
        Console.WriteLine();

        FindElementIndex.Run();
        Console.WriteLine();

        SortArray.Run();
        Console.WriteLine();

        AddToList.Run();
        Console.WriteLine();

        RemoveFromList.Run();
        Console.WriteLine();

        ConcatenateLists.Run();
        Console.WriteLine();

        ContainsInList.Run();
        Console.WriteLine();

        // Bài tập chủ đề 4: Hướng đối tượng
        Console.WriteLine("Chủ đề 4: Hướng đối tượng");

        OOP.Person person = new OOP.Person("John", 30);
        person.DisplayInfo();
        Console.WriteLine();

        Dog dog = new Dog("Buddy");
        dog.Speak();
        dog.Bark();
        Console.WriteLine();

        BankAccount account = new BankAccount();
        account.Deposit(100);
        Console.WriteLine($"Account balance: {account.GetBalance()}");
        Console.WriteLine();

        new Counter();
        new Counter();
        Console.WriteLine($"Count: {Counter.Count}");

        Counter.ResetCount();
        Console.WriteLine($"Count after reset: {Counter.Count}");

        // Bai tap chu de 5: Các chủ đề nâng cao
        Console.WriteLine("Chu de 5: Cac chu de nang cao");

        FileOperations.Run();
        Console.WriteLine();

        ExceptionHandling.Run();
        Console.WriteLine();

        LinqExample.Run();
        Console.WriteLine();

        AsyncProgramming.Run().Wait();
        Console.WriteLine();

        DelegatesAndEvents.Run();
        Console.WriteLine();

        ReflectionExample.Run();
        Console.WriteLine();

        GenericExample.Run();
        Console.WriteLine();

        CustomAttributeExample.Run();
        Console.WriteLine();

        DependencyInjectionExample.Run();
        Console.WriteLine();

        CustomCollectionExample.Run();
        Console.WriteLine();
    }
}
