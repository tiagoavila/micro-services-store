namespace Identity.API.ViewModels
{
    public class SecurityTokenViewModel
    {
        public SecurityTokenViewModel(string token)
        {
            Token = token;
        }

        public string Token { get; set; }
    }
}
