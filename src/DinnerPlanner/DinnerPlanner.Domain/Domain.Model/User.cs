namespace DinnerPlanner.Domain.Domain.Model
{
    public class User : AggregateRoot
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public IRole Role { get; set; }
    }
}