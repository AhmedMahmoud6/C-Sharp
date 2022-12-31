//multi dimensional array
            string[,] array2DString = new string[3, 2]
            {
                {"one", "two" },
                {"three","four" },
                {"five","six" }
            };
            array2DString[1, 1] = "chicken";
            Console.WriteLine($"{array2DString[1,1]}");
