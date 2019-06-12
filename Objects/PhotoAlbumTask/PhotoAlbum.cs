namespace PhotoAlbumTask
{
    public class PhotoAlbum
    {
        private int NumberOfPages;

        public PhotoAlbum()
        {
            NumberOfPages = 16;
        }

        public PhotoAlbum(int pages)
        {
            NumberOfPages = pages;
        }
        
        public int GetNumberOfPages()
        {
            return NumberOfPages;
        }
    }
}