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

void DrawBox(int width, int height)
{
    Console.Clear();

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
                    Console.Write("-");
                }
            }
            Console.WriteLine();
        }
    }
}

int width = int.Parse(Console.ReadLine());
int heigth = int.Parse(Console.ReadLine());

DrawBox(width, heigth);