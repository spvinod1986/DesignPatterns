using System;

namespace ChainOfResponsibility
{
    public class UserRequest
    {
        public string UserName { get; set; }
        public decimal Balance { get; set; }
        public decimal CreditScore { get; set; }
        public DateTime AccountActivatedAt { get; set; }
    }
}