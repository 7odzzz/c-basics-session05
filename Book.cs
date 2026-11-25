using System;
using System.Collections.Generic;
using System.Text;

namespace C__Basics_Assigment_lec_5
{
    internal class Book // fields is private by default in class
    {
        private string password = "secret"; // All class can see it 
        public string password01 = "secret01"; // anyone sees the class can see it

        internal  int copiesInStock = 5;

        public string? Title; // just to erase the warning

        public Genre genre = Genre.Science; // Public could be accessed by obj






    }
}
