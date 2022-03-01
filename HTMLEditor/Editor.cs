using System;
using System.Text;

namespace HTMLEditor
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("-------------");
            Start();
        }

        public static void Start()
        {
            var file = new StringBuilder();

            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("-------------");
            Console.Write(" ");
            Console.WriteLine("Deseja salvar o arquivo? (s/n)");
            char saveOption = char.Parse(Console.ReadLine());
            Save(saveOption, file);

            Viewer.Show(file.ToString());
        }

        public static void Save(char option, StringBuilder text)
        {
            if (option == 's')
            {
                Console.WriteLine(" Qual o caminho para salvar o arquivo?");
                var path = Console.ReadLine();

                using(var file = new StreamWriter(path))
                {
                    file.Write(text.ToString());
                }

                Console.WriteLine($"Arquivo {path} salvo com sucesso!");
                Console.ReadLine();
            }

        }
    }
}
