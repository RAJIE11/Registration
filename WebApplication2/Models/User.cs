﻿namespace WebApplication2.Models
{
    public class User
    {
        public int Id { get; set; }  //Primary KEY
        public string Username { get; set; } = "";
        public string Password { get; set; } = "";
    }
}
