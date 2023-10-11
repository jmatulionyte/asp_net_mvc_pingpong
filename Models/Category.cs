﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Twest2.Models
{
	public class Category
	{
		[Key]

		public int Id { get; set; }

		[Required]
        [DisplayName("Tournament Name")]
        public string TournamentName { get; set; }

		//[Range(1, 1000, ErrorMessage = "Display order must be between 1 and 1000")]

        [Required]
        [DisplayName("1st Attendee")]
        public string AttendeeFirst { get; set; }

        [Required]
        [DisplayName("2nd Attendee")]
        public string AttendeeSecond { get; set; }

		public string Result { get; set; } = "0";

        [Required]
        [DisplayName("Tournament Date/Time")]
        public DateTime TournamentDateTime { get; set; } = DateTime.Now;
    }
}

