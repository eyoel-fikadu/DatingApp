namespace DatingApp.Dtos
{
    public class UserForLoginDto
    {
        public UserForLoginDto(string userName, string password)
        {
            this.UserName = userName;
            this.Password = password;

        }
        public string UserName { get; set; }
        
        public string Password { get; set; }
    }
}