﻿namespace DinnerPlanner.Domain.Model
{
    public class User : AggregateRoot
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}