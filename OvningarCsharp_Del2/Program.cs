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

int width = int.Parse(Console.ReadLine());
int heigth = int.Parse(Console.ReadLine());

DrawBox(width, heigth);

void DrawBox(int width, int height)
{
    Console.Clear();
    int x = width / 2;
    int y = height / 2;
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
                    //Todo! Lista ut hur man placerar @ på plats x och y...
                    //if ()
                    //{
                    //    Console.Write("@");
                    //}
                    else
                    {
                        Console.Write("-");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}