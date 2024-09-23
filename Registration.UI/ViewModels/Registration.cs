namespace Registration.UI.ViewModels
{
    public class Registration

    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string city { get; set; }
        public string phone { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string PostalCode { get; set; }

        public string? ReturnUrl { get; set; }

        public string? Title { get; set; }
    }
}
