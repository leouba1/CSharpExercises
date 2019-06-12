using System;

namespace PhotoAlbumTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var album = new PhotoAlbum(30);
            Console.WriteLine($"Number of pages of album = {album.GetNumberOfPages()}");

            var defaultAlbum = new PhotoAlbum();
            Console.WriteLine($"Number of pages of defaultAlbum = {defaultAlbum.GetNumberOfPages()}");
        }
    }
}
