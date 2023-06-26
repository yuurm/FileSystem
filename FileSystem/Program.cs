// See https://aka.ms/new-console-template for more information

string directoryPath = "C:/Bazis/Desktop/NewPath"; 

            
            Directory.CreateDirectory(directoryPath);

            
            string filePath1 = Path.Combine(directoryPath, "file1.txt");
            string filePath2 = Path.Combine(directoryPath, "file2.txt");
            string filePath3 = Path.Combine(directoryPath, "file3.txt");

            
            File.WriteAllText(filePath1, string.Join(" ", Enumerable.Range(1, 100)));
            File.WriteAllText(filePath2, DateTime.Now.ToString());
            File.WriteAllText(filePath3, string.Join(Environment.NewLine, Directory.GetDirectories("C:/Program Files")));

           
            string content1 = File.ReadAllText(filePath1);
            string content2 = File.ReadAllText(filePath2);
            string content3 = File.ReadAllText(filePath3);

            Console.WriteLine("Содержимое файлов:");
            Console.WriteLine($"file1.txt: {content1}");
            Console.WriteLine($"file2.txt: {content2}");
            Console.WriteLine($"file3.txt: {content3}");

            
            string newDirectoryPath = "C:/Bazis/Desktop/New/Directory/Path";
            Directory.CreateDirectory(newDirectoryPath);

            
            string newFilePath2 = Path.Combine(newDirectoryPath, "file2.txt");
            File.Move(filePath2, newFilePath2);

            
            string newCategoryPath = Path.Combine(newDirectoryPath, "Category1");
            Directory.Move(directoryPath, newCategoryPath);

            
            string file1Content = File.ReadAllText(filePath1);

            
            string[] numbers = file1Content.Split(' ');
            for (int i = 9; i < 20; i++)
            {
                numbers[i] = (200 + (i + 1 - 10)).ToString();
            }

            
            using (FileStream fileStream = new FileStream(filePath1, FileMode.Truncate, FileAccess.Write))
            using (StreamWriter writer = new StreamWriter(fileStream))
            {
                writer.Write(string.Join(" ", numbers));
            }

            Console.WriteLine("Информация в файле №1 после перезаписи чисел от 10 до 20:");
            string updatedContent1 = File.ReadAllText(filePath1);
            Console.WriteLine(updatedContent1);

            Console.ReadLine();