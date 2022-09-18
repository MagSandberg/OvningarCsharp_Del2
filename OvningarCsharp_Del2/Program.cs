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

Console.CursorVisible = false;

Console.Write("Ange bredd: ");
int width = int.Parse(Console.ReadLine());
Console.Write("Ange höjd: ");
int height = int.Parse(Console.ReadLine());

int cursorLeft = 0;
int cursorTop = 0;

DrawBox(width, height);

void DrawBox(int width, int height)
{
    Console.Clear();
    int xValue = width / 2;
    int yValue = height / 2;

    //Deklarerar fönsterstorleken på konsolen
    Console.WindowHeight = height;
    Console.WindowWidth = width;

    //Tar bort scrollbars
    Console.SetBufferSize(width, height);

    for (int i = 1; i < height + 1; i++)
    {
        if (i == 1 || i == height)
        {
            for (int k = 1; k < width + 1; k++)
            {
                Console.Write("#");
            }
            if (i < height)
            {
                Console.WriteLine();
            }
        }
        if (i > 1 && i < height)
        {
            for (int j = 1; j < width + 1; j++)
            {
                if (j == 1 || j == width)
                {
                    Console.Write("#");
                }
                else if (j > 1 || j < width + 1)
                {
                    if (j == xValue && i == yValue)
                    {
                        cursorLeft = Console.CursorLeft;
                        cursorTop = Console.CursorTop;
                        Console.Write("@");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
            }
            Console.WriteLine();
        }
    }
    bool quit = false;

    do
    {
        Console.CursorLeft = cursorLeft;
        Console.CursorTop = cursorTop;
        var keyPressed = Console.ReadKey();
        switch (keyPressed.Key)
        {
            case ConsoleKey.LeftArrow:
                if (cursorLeft > 1)
                {
                    cursorLeft--;
                    Console.SetCursorPosition(cursorLeft, cursorTop);
                    Console.Write("@");
                    Console.Write("-");
                }
                break;
            case ConsoleKey.RightArrow:
                if (cursorLeft < width-2)
                {
                    cursorLeft++;
                    Console.Write("-");
                    Console.Write("@");
                }
                break;
            case ConsoleKey.UpArrow:
                if (cursorTop > 1)
                {
                    Console.Write("-");
                    cursorTop--;
                    Console.SetCursorPosition(cursorLeft, cursorTop);
                    Console.Write("@");
                }
                break;
            case ConsoleKey.DownArrow:
                if (cursorTop < height - 2)
                {
                    Console.Write("-");
                    cursorTop++;
                    Console.SetCursorPosition(cursorLeft, cursorTop);                    
                    Console.Write("@");
                }
                break;
            case ConsoleKey.Q:
                quit = true;
                Console.Clear();
                break;
        }
    } while (!quit);
}

//.21
//Skriv om DrawBox så den istället returnerar en 2D-array av char med tecknen som den
//tidigare skrev ut på displayen. Man ska också kunna mata in en tredje parameter
//för antal slumpade ‘#’. Om man anger t.ex 5 så ska 5 stycken extra ‘#’ slumpas ut på
//random ställen inne i boxen.