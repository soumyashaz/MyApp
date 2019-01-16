namespace MyApp.Pages
{
    public interface IPage
    {
        string Title { get; }
        string Url { get; }
        void WaitLoading();

        void AcceptDialog();

        void CancelDialog();

        void BrowserRefresh();

        void Quit();
    }
}
