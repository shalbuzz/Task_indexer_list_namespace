namespace Task_indexer_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            
            library.AddBook(new Book("Programming", "John Doe", 300, 10));
            library.AddBook(new Book("AI", "Jane Smith", 250, 20));
            library.AddBook(new Book("CProg", "Alice Brown", 350, 30));
            library.AddBook(new Book("Machine Learning", "Bob White", 400, 40));

            
            var booksByName = library.FindAllBooksByName("Programming");
            Console.WriteLine("Programming ile elaqeli kitablar:");
            foreach (var book in booksByName)
            {
                Console.WriteLine($"Adi: {book.Name}, Kod: {book.Code}, Muellif: {book.AuthorName}");
            }

            
            var bookByCode = library.FindBookByCode("PR10");
            if (bookByCode != null)
            {
                Console.WriteLine($"\nKodla tapilan kitab: {bookByCode.Name}, Kod: {bookByCode.Code}");
            }

            
            var booksByPageCount = library.FindAllBooksByPageCountRange(250, 350);
            Console.WriteLine("\nSehife sayi 250-350 araliginda olan kitablar:");
            foreach (var book in booksByPageCount)
            {
                Console.WriteLine($"Adi: {book.Name}, Kod: {book.Code}, Sehife Sayi: {book.PageCount}");
            }

            
            library.RemoveBookByCode("AI20");
            Console.WriteLine("\nAI20 kodu olan kitab silindi!");

            
           
            Console.WriteLine("\nTapilan Kitablar");
            var searchBooks = library.SearchBooks("Programming");
            foreach(var book in searchBooks)
            {
                Console.WriteLine($"Adi: {book.Name}, Kod: {book.Code}, Sehife Sayi: {book.PageCount}");
            }

            library.RemoveAllBooksByName("Programming");
            Console.WriteLine("\nProgramming olan adi silinler kitablar");

            Console.WriteLine("\nKitablar:");
            for (int i = 0; i < library.BooksCount; i++)
            {
                var book = library[i];
                Console.WriteLine($"Adi: {book.Name}, Kod: {book.Code}, Muellif: {book.AuthorName}");
            }


        }
    }
}
