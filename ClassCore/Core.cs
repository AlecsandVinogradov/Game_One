using System;
using System.IO;

namespace ClassCore
{
    public class Core
    {
        public static int[,] InitialMap()
        {
            int[,] temp = new int[50, 50];
            Random random = new Random();
            Random random1 = new Random();
            int direction = 1;
            int y = 6;
            for (int x = 0; x < temp.GetLength(0); x++)
            {
                y += direction;
                direction = random.Next(-1, 2);

                for (int _y = y; _y < temp.GetLength(1); _y++)
                {
                    if (_y > -1)
                        temp[x, _y] = random1.Next(1, 4);
                }
            }

            return temp;
        } //создаем карту 
        public static void SaveWord(int[,] _map)
        {
            File.Delete("first1.txt");
            for (int i = 0; i < _map.GetLength(0); i++)
            {
                for (int j = 0; j < _map.GetLength(1); j++)
                {
                    if (_map[i, j] != 0)
                    {
                        File.AppendAllText("first1.txt", $"Block: X = {i}; Y = {j}; Type = {_map[i, j]};\n");
                    }
                }
            }

        } //сохранить карту 

        public static int[,] LoadingWord(string path = "first1.txt")
        {
            int[,] tempArray = new int[50, 50];

            string[] lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] typeName = line.Split(':');
                if (typeName[0] == "Block")
                {
                    int x = 0, y = 0, typeBlock = 0;
                    string[] data = typeName[1].Split(';');

                    for (int k = 0; k < data.Length; k++)
                    {
                        string[] nameValye = data[k].Split('=');
                        switch (nameValye[0].Trim())
                        {
                            case "X":
                                x = Convert.ToInt32(nameValye[1]);
                                break;
                            case "Y":
                                y = Convert.ToInt32(nameValye[1]);
                                break;
                            case "Type":
                                typeBlock = Convert.ToInt32(nameValye[1]);
                                break;
                        }

                    }
                    tempArray[x, y] = typeBlock;
                }

            }
            return tempArray;
        }//загрузить мир по указанному пути , так же можно менять

    }
}
