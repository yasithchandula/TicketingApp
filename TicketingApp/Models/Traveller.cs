﻿using MongoDbGenericRepository.Attributes;

namespace TicketingApp.Models
{
    [CollectionName("traveller")]
    public class Traveller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NIC { get; set; }
        public string Phone { get; set; }
        public DateTime DOB { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Status { get; set; }

    }
}
