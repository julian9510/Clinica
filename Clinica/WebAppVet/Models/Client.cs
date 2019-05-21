﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebAppVet.Interfaces;
using WebAppVet.Models;

namespace WebAppVet.Models
{
    public partial class Client : IEntity
    {
        public Client()
        {
            Patients = new List<Patient>();
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }

        public IList<Patient> Patients { get; private set; }
    }

    [MetadataType(typeof(ClientMetadata))]
    public partial class Client
    {
        public class ClientMetadata
        {
            [Key]
            public int Id { get; set; }
            [StringLength(250)]
            [Required]
            public int FullName { get; set; }
            [StringLength(100)]
            public int Email { get; set; }
        }
    }
}