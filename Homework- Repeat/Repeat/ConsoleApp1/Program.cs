
#region Homework
// 1

//int n = 21;

//if (n%3==0 && n%7==0)
//{
//    Console.WriteLine("bolunur");
//}
//else
//{
//    Console.WriteLine("bolunmur");
//}

// 2

//int n = 10;
//int m = 22;

//int sum = 0; 
//if (n%2 == 0 && m%2 == 0)
//{
//    sum = n + m;
//}
//Console.WriteLine(sum);

// 3 

//int n = 10;
//int m = 20;

//int sum = 0;

//for (int i = n; i < m; i++)
//{
//    if (i % 2 == 1)
//    {
//        sum+= i; 
//    }
//}

//Console.WriteLine(sum);

// 4

//int[] nums = { 1, 2, 11, 55, 23, 4, 6 };

//int sum = 0;

//foreach (var num in nums)
//{
//    if (num % 2 != 0) 
//    {
//        sum += num;
//    }
//}
//Console.WriteLine(sum);

// 5 

//int[] nums = { 1, 3, 5, 6, 9 };

//int count = 0;

//foreach (var num in nums)
//{
//    if (num % 2 == 0)
//        count++;

//}
//Console.WriteLine(count);
#endregion


//static void sum ()
//{  
//    Console.WriteLine(100+400);
//}
//sum();

//static void Sum ()
//{
//    int a = 100;
//    int b = 200;
//    int sum = a + b;
//    Console.WriteLine(sum);
//}
//Sum();


//ShowDatas();
//static void ShowDatas()
//{
//    string fullName = "Kubra Memmedova";
//    string email = "kubra@code.edu.az";
//    string fullData = $"{fullName} - {email}";

//    SowAge();

//    Console.WriteLine(fullData);
//}

//static void SowAge()
//{
//    Welcome();
//    int age = 25;
//    Console.WriteLine(age);
//}

//static void Welcome()
//{
//    Console.WriteLine("Welcome Kubra");
//}



//static void SumItemsOfArray()
//{
//    int[] arr = { 1, 2, 3, 4, 5 };
//    int sum = 0;
//    foreach (var item in arr)
//    {
//        sum+= item; 
//    }

//    Console.WriteLine(sum); ;
//}
//SumItemsOfArray();


//static void SearchByName()
//{
//    string[] people = { "Sheref" , "Pervin" , "Cahangir" , "Huseyn" };
//    string searchText = "Pervinvvv";

//    foreach (var person in people)
//    {
//        if (person == searchText) 
//        {
//            Console.WriteLine(person);
//            break;
//        }

//        if (person == "Cahangir")
//        {
//            Console.WriteLine(person);
//            return;
//        }

//    }

//    Console.WriteLine("Our search method is working");

//}
//SearchByName();


//static void Sum(int number1, int number2)
//{
//    int sum = number1 + number2;
//    Console.WriteLine(sum);
//}
//Sum(5,9);



//bool isMarried = false;
//static void ShowText(string text, int num)
//{
//    Console.WriteLine(text+ "-" +num);
//}

//if (isMarried)
//{
//    Console.WriteLine("Evlidir");
//}

//string str = "Hello P139";
//int number = 55;


//ShowText(str, number);



//static void Login(string username, string password)
//{
//    if (username == "samir555" && password == "Samir123_")
//    {
//        Console.WriteLine("Login successed");
//    }
//    else
//    {
//        Console.WriteLine("Username or password is wrong");
//    }
//}



//Console.WriteLine("Add your username:");
//string username = Console.ReadLine();


//Console.WriteLine("Add your password:");
//string password = Console.ReadLine();

//Login(username, password);


//Console.WriteLine("Add your name");

//string name = Console.ReadLine();

//Console.WriteLine(name);



//Console.WriteLine("Add first number:");
//int number1 = Convert.ToInt32(Console.ReadLine());


//Console.WriteLine("Add second number:");
//int number2 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("----------");

//SumNumbers(number1, number2);

//static void SumNumbers(int a, int b)
//{
//    int sum = a + b;
//    Console.WriteLine(sum);
//}




//static string ShowName()
//{
//    return "samir";
//}

//string result = ShowName();
//Console.WriteLine(result);


//static void Sum (int a, int b)
//{
//    Console.WriteLine(a+b);
//}
//Sum(5, 6);


//using System.Data;

//static int Sum(int a, int b)
//{
//    return a + b;
//}

//int sum = Sum(5, 10);

//sum++;

//Console.WriteLine(sum);


//static int GetSumOfNumbersFromArray(int[] numbers)
//{
//    int sum = 0;
//    foreach (var item in numbers)
//    {
//        sum += item;
//    }

//    return sum;
//}


//int[] arr = { 1, 2, 3, 4, 5, 6 };

//int result = GetSumOfNumbersFromArray(arr);

//Console.WriteLine(result);


//string weekday = "Monday";

//switch (weekday)
//{
//    case "Saturday":
//        Console.WriteLine("This day is Saturday");
//        break;
//    case "Monday":
//        Console.WriteLine("This day is Monday");
//        break;
//    case "Tuesday":
//        Console.WriteLine("This day is Tuesday");
//        break;
//    case "Sunday":
//        Console.WriteLine("This day is Sunday");
//        break;
//    default:
//        Console.WriteLine("Not found week day");
//        break;
//}


//static bool CheckWeekDayIfSunday(string weekDay)
//{
//    bool isSunday = false;

//    switch (weekDay)
//    {
//        case "Saturday":
//            isSunday = false;
//            break;
//        case "Monday":
//            isSunday = false;
//            break;
//        case "Tuesday":
//            isSunday = false;
//            break;
//        case "Sunday":
//            isSunday = true;
//            break;
//        case "Thrusday":
//            isSunday = false;
//            break;
//        case "Friday":
//            isSunday = false;
//            break;
//        case "Wednesday":
//            isSunday = false;
//            break;

//    }
//    return isSunday;
//}



//bool result = CheckWeekDayIfSunday("Wednesday");

//ShowWeekDay(result);


//static void ShowWeekDay(bool isSunday)
//{
//    if (isSunday)
//    {
//        Console.WriteLine("yes, Today is Sunday");
//    }
//    else
//    {
//        Console.WriteLine("no, Today is Sunday");
//    }

//}



