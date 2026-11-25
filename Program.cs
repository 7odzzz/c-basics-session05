namespace C__Basics_Assigment_lec_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.
            //Console.WriteLine(password);  // Compile error because name is private field high protection
            //Book b1 = new Book(); //Now the main see the class
            //Console.WriteLine(b1.password01); //secret01
            #endregion


            #region 2.
            //Book b2 = new Book();
            //Console.WriteLine(b2.copiesInStock); // Works and print 5 if no static in the field
            //Console.WriteLine(copiesInStock); // doesnt compile because there's no obj handled it 
            #endregion


            #region 3.
            //Book b1 = new Book();
            //b1.Title = "Setted up!";
            //Console.WriteLine(b1.Title); // setted up

            #endregion


            #region 4,5
            //4.
            //Book b3 = new Book();
            //Console.WriteLine(b3.genre); // science
            //Console.WriteLine("================");

            //5.

            // int to enum  = explicit cast

            //int value01 =  (int)Genre.Fiction;
            //int value02= (int)Genre.NonFiction;
            //int value03= (int)Genre.Science;

            //Console.WriteLine($"FICTION AS INT: {value01}"); //0
            //Console.WriteLine($"NONFICTION AS INT: {value02}");//1
            //Console.WriteLine($"Science AS INT: {value03}");//2

            #endregion



            #region 6.
            // enum to int = explicit cast
            //int genreNumber = 1;
            //Genre genre = (Genre)genreNumber; //  dangerous bec silent failure 
            //Console.WriteLine(genre) ; // NonFiction
            #endregion



            #region 7.
            //Genre genre01 = Genre.Fiction;
            //string genre02 = genre01.ToString();
            //Console.WriteLine($"Genre As String: {genre02}"); // fiction

            #endregion


            #region 8.

            //string genreText = "Science"; //index 2

            //Genre genre = (Genre)Enum.Parse(typeof(Genre), genreText);
            //Console.WriteLine(genre); //science

            #endregion


            #region 9.

            string genreText = "Mystery";
            Genre genre;
            bool isParsed = Enum.TryParse<Genre>(genreText, out genre);

            if (!isParsed) Console.WriteLine("Unknown genre");

            #endregion


        }
    }
}
