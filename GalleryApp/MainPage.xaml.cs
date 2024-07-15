namespace GalleryApp
{
    public partial class MainPage : ContentPage
    {
        int count;
        List<string> list;
        

        public MainPage()
        {
            InitializeComponent();
            count = 0;
            list = new List<string>()
            {
                "a1","a2","a3","a4","a5","a6","a7","a8","a9", "a10","a11","a12","a13","a14","a15","a16",
            };
             
        }       

        private void upBtn_Clicked(object sender, EventArgs e)
        {
            count++;
            if (count == list.Count) 
                count = 0;
            img.Source = list[count];
           

        }

        private void downBtn_Clicked(object sender, EventArgs e)
        {
            count--;
            if (count < 0)
                count = 15;
            img.Source = list[count];
        }

        private void upBtn_Pressed(object sender, EventArgs e)
        {
            upBtn.TextColor = Color.FromArgb("#00FFFFFF");
        }

        private void upBtn_Released(object sender, EventArgs e)
        {
            upBtn.TextColor = Color.FromArgb("#000000");
        }

        private void downBtn_Pressed(object sender, EventArgs e)
        {
            downBtn.TextColor= Color.FromArgb("#00FFFFFF");
        }

        private void downBtn_Released(object sender, EventArgs e)
        {
            downBtn.TextColor = Color.FromArgb("#000000");
        }

        private void SwipeGestureRecognizer_Swiped_Left(object sender, SwipedEventArgs e)
        {

        }

        private void SwipeGestureRecognizer_Swiped_Right(object sender, SwipedEventArgs e)
        {
            count++;
            if (count == list.Count)
                count = 0;
            img.Source = list[count];
        }
    }

}
