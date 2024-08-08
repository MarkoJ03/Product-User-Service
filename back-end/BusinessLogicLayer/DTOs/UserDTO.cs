﻿using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BusinessLogicLayer.DTOs
{
    public class UserDTO
    {
        public UserDTO(int id, string username, string password, string role)
        {
            Id = id;
            Username = username;
            Password = password;
            Role = role;
        }

        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        [JsonIgnore]
        public string Role { get; set; } = string.Empty;

        [JsonIgnore]
        public ICollection<UserProduct> UserProducts { get; set; } = new List<UserProduct>();


        public UserDTO() { }
    }

}
