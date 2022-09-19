//.19
//Skriv en metod DrawBox(int width, int height)
//När man anropar metoden ska den tömma konsolen och skriva ut en rektangel
//där de yttre tecknen består av ‘#’ och de inre av ‘-’ Exempel:
/*
DrawBox(7, 4);
#######
#-----#
#-----#
#######
*/

//void DrawBox(int width, int height)
//{
//    Console.Clear();

//    for (int i = 1; i < height + 1; i++)
//    {
//        if (i == 1 || i == height)
//        {
//            for (int k = 1; k < width + 1; k++)
//            {
//                Console.Write("#");
//            }
//            if (i < height)
//            {
//                Console.WriteLine();
//            }
//        }
//        if (i > 1 && i < height)
//        {
//            for (int j = 1; j < width + 1; j++)
//            {
//                if (j == 1 || j == width)
//                {
//                    Console.Write("#");
//                }
//                else if (j > 1 || j < width + 1)
//                {
//                    Console.Write("-");
//                }
//            }
//            Console.WriteLine();
//        }
//    }
//}

//int width = int.Parse(Console.ReadLine());
//int heigth = int.Parse(Console.ReadLine());

//DrawBox(width, heigth);


//.20
//Använd DrawBox-metoden i föregående uppgift för att rita en box.
//Placera sedan ett @ i mitten av boxen. Om man använder piltangenterna ska man kunna flytta runt @.
//När den kommer till kanten av boxen så ska den inte kunna gå längre åt det hållet.
//Hint: För att flytta @ behöver du skriva ‘-’ på dess tidigare position och ‘@’ på den nya positionen.
//Spara bredd och höjd på boxen så du vet när den ska stanna.

//Console.CursorVisible = false;

//Console.Write("Ange bredd: ");
//int width = int.Parse(Console.ReadLine());
//Console.Write("Ange höjd: ");
//int height = int.Parse(Console.ReadLine());

//int cursorLeft = 0;
//int cursorTop = 0;

//DrawBox(width, height);

//void DrawBox(int width, int height)
//{
//    Console.Clear();
//    int xValue = width / 2;
//    int yValue = height / 2;

//    //Deklarerar fönsterstorleken på konsolen
//    Console.WindowHeight = height;
//    Console.WindowWidth = width;

//    //Tar bort scrollbars
//    Console.SetBufferSize(width, height);

//    for (int i = 1; i < height + 1; i++)
//    {
//        if (i == 1 || i == height)
//        {
//            for (int k = 1; k < width + 1; k++)
//            {
//                Console.Write("#");
//            }
//            if (i < height)
//            {
//                Console.WriteLine();
//            }
//        }
//        if (i > 1 && i < height)
//        {
//            for (int j = 1; j < width + 1; j++)
//            {
//                if (j == 1 || j == width)
//                {
//                    Console.Write("#");
//                }
//                else if (j > 1 || j < width + 1)
//                {
//                    if (j == xValue && i == yValue)
//                    {
//                        cursorLeft = Console.CursorLeft;
//                        cursorTop = Console.CursorTop;
//                        Console.Write("@");
//                    }
//                    else
//                    {
//                        Console.Write("-");
//                    }
//                }
//            }
//            Console.WriteLine();
//        }
//    }
//    bool quit = false;

//    do
//    {
//        Console.CursorLeft = cursorLeft;
//        Console.CursorTop = cursorTop;
//        var keyPressed = Console.ReadKey();
//        switch (keyPressed.Key)
//        {
//            case ConsoleKey.LeftArrow:
//                if (cursorLeft > 1)
//                {
//                    cursorLeft--;
//                    Console.SetCursorPosition(cursorLeft, cursorTop);
//                    Console.Write("@");
//                    Console.Write("-");
//                }
//                break;
//            case ConsoleKey.RightArrow:
//                if (cursorLeft < width-2)
//                {
//                    cursorLeft++;
//                    Console.Write("-");
//                    Console.Write("@");
//                }
//                break;
//            case ConsoleKey.UpArrow:
//                if (cursorTop > 1)
//                {
//                    Console.Write("-");
//                    cursorTop--;
//                    Console.SetCursorPosition(cursorLeft, cursorTop);
//                    Console.Write("@");
//                }
//                break;
//            case ConsoleKey.DownArrow:
//                if (cursorTop < height - 2)
//                {
//                    Console.Write("-");
//                    cursorTop++;
//                    Console.SetCursorPosition(cursorLeft, cursorTop);                    
//                    Console.Write("@");
//                }
//                break;
//            case ConsoleKey.Q:
//                quit = true;
//                Console.Clear();
//                break;
//        }
//    } while (!quit);
//}

//.21
//Skriv om DrawBox så den istället returnerar en 2D-array av char med tecknen som den
//tidigare skrev ut på displayen. Man ska också kunna mata in en tredje parameter
//för antal slumpade ‘#’. Om man anger t.ex 5 så ska 5 stycken extra ‘#’ slumpas ut på
//random ställen inne i boxen.

//Console.CursorVisible = false;

//Random random = new Random();

//Console.Write("Choose width: ");
//int width = int.Parse(Console.ReadLine());
//Console.Write("Choose height: ");
//int height = int.Parse(Console.ReadLine());
//Console.Write("Amount of random #: ");
//int randomNum = (int.Parse(Console.ReadLine()));

////2D-array med 1 rad och 3 kolumner
//int[,] multiArray = new int[1, 3];
//multiArray[0, 0] = width;
//multiArray[0, 1] = height;
//multiArray[0, 2] = randomNum;

//int cursorLeft = 0;
//int cursorTop = 0;

//DrawBox(multiArray);

//void DrawBox(int[,] multiArray)
//{
//    Console.Clear();
//    //Räknar ut vart mitten av "spelplanen" är
//    int xValue = multiArray[0, 0] / 2;
//    int yValue = multiArray[0, 1] / 2;

//    Console.WriteLine("Press Q to quit.");

//    //Deklarerar fönsterstorleken på konsolen
//    Console.WindowWidth = multiArray[0, 0];
//    Console.WindowHeight = multiArray[0, 1] + 1;

//    //Tar bort scrollbars
//    Console.SetBufferSize(multiArray[0, 0], multiArray[0, 1] + 1);

//    for (int i = 1; i < multiArray[0, 1] + 1; i++)
//    {
//        if (i == 1 || i == multiArray[0, 1])
//        {
//            for (int k = 1; k < multiArray[0 ,0] + 1; k++)
//            {
//                Console.Write("#");
//            }
//            if (i < multiArray[0, 1])
//            {
//                Console.WriteLine();
//            }
//        }
//        if (i > 1 && i < multiArray[0, 1])
//        {
//            for (int j = 1; j < multiArray[0, 0] + 1; j++)
//            {
//                if (j == 1 || j == multiArray[0, 0])
//                {
//                    Console.Write("#");
//                }
//                else if (j > 1 || j < multiArray[0, 0] + 1)
//                {
//                    if (j == xValue && i == yValue)
//                    {
//                        cursorLeft = Console.CursorLeft;
//                        cursorTop = Console.CursorTop;
//                        Console.ForegroundColor = ConsoleColor.Green;
//                        Console.Write("@");
//                        Console.ForegroundColor = ConsoleColor.Gray;
//                    }
//                    else
//                    {
//                        Console.Write("-");
//                    }
//                }
//            }
//            Console.WriteLine();
//        }
//    }

//    //Skriver ut antalet slumpade #
//    for (int r = 0; r < multiArray[0, 2]; r++)
//    {
//        int randomX = random.Next(2, multiArray[0, 0] - 2);
//        int randomY = random.Next(2, multiArray[0, 1] - 2);

//        Console.SetCursorPosition(randomX, randomY);
//        Console.ForegroundColor = ConsoleColor.Cyan;
//        Console.Write("#");
//        Console.ForegroundColor = ConsoleColor.Gray;
//    }

//    bool quit = false;

//    do
//    {
//        Console.CursorLeft = cursorLeft;
//        Console.CursorTop = cursorTop;
//        var keyPressed = Console.ReadKey();
//        switch (keyPressed.Key)
//        {
//            case ConsoleKey.LeftArrow:
//                if (cursorLeft > 1)
//                {
//                    cursorLeft--;
//                    Console.SetCursorPosition(cursorLeft, cursorTop);
//                    Console.ForegroundColor = ConsoleColor.Green;
//                    Console.Write("@");
//                    Console.ForegroundColor = ConsoleColor.Gray;
//                    Console.Write("-");
//                }
//                break;
//            case ConsoleKey.RightArrow:
//                if (cursorLeft < multiArray[0, 0] - 2)
//                {
//                    cursorLeft++;
//                    Console.Write("-");
//                    Console.ForegroundColor = ConsoleColor.Green;
//                    Console.Write("@");
//                    Console.ForegroundColor = ConsoleColor.Gray;
//                }
//                break;
//            case ConsoleKey.UpArrow:
//                if (cursorTop > 1)
//                {
//                    Console.Write("-");
//                    cursorTop--;
//                    Console.SetCursorPosition(cursorLeft, cursorTop);
//                    Console.ForegroundColor = ConsoleColor.Green;
//                    Console.Write("@");
//                    Console.ForegroundColor = ConsoleColor.Gray;
//                }
//                break;
//            case ConsoleKey.DownArrow:
//                if (cursorTop < multiArray[0, 1] - 2)
//                {
//                    Console.Write("-");
//                    cursorTop++;
//                    Console.SetCursorPosition(cursorLeft, cursorTop);
//                    Console.ForegroundColor = ConsoleColor.Green;
//                    Console.Write("@");
//                    Console.ForegroundColor = ConsoleColor.Gray;
//                }
//                break;
//            case ConsoleKey.Q:
//                quit = true;
//                Console.Clear();
//                break;
//        }
//    } while (!quit);
//}


//.22
//Skriv en funktion som kan ta ett godtyckligt antal strängar som parametrar
//och som returnerar den längsta av dem.

//ReturnLongestString(Console.ReadLine());

//void ReturnLongestString(string userInput)
//{
//    string[] strings = new string[3];
//    int result = 0;

//    for (int i = 0; i < 3; i++)
//    {
//        strings[i] = userInput;
//        for (int j = 1; j < 3; j++)
//        {
//            userInput = Console.ReadLine();
//            strings[j] = userInput;
//            if (strings[i].Length < strings[j].Length)
//            {
//                result = j;
//                strings[i] = strings[j];
//            }
//            else
//            {
//                result = i;
//            }
//            if (j == 2)
//            {
//                Console.WriteLine(strings[result]);
//                break;
//            }
//        }
//        break;
//    }
//}


//.23
//Skapa en metod int[] IndexOfAll(string text, char c) som söker igenom strängen text
//och returnerar en int[] med index till alla förekomster av c i text.

IndexOfAll(Console.ReadLine());

static int[] IndexOfAll(string text, char c = 'c')
{
    int[] ints = new int[text.Length];
    char[] textToChar = text.ToCharArray();

    for (int i = 0; i < text.Length; i++)
    {
        if (textToChar[i] == 'c')
        {
            ints[i] = i;
            Console.WriteLine($"Plats: {ints[i]} innehåller ett c");
        }
    }
    return ints;
}