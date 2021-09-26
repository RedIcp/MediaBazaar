﻿using System;
using System.Collections.Generic;
using System.Text;


namespace MediaBazaar
{
	abstract class Pesron
    {
		private static int nextID = 1;
		private int iD;
		private string firststName;
		private string lasttName;
		private int phoneNumber;
		private string email;
		private string city;
		private string dateOfBirth;
		private int bsn;
		private string username;
		private string password;


		// properties
		public string FirstName { get; set; }
		public string LastName { get; set; }

		public int PhoneNumber { get; set; }
		public string City { get; set; }
		public string DateOfBirth { get; set; }
		public int BSN { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public string Email { get; set; }
		public int ID { get; private set; }

		//constructor

		public Pesron(string firstname, string lastname, int phonenumber, string email, string city, string dateofbirth, int bsn, string username, string password)
		{
			
			this.ID = nextID;
			nextID++;

			this.LastName = firstname;
			this.FirstName = lastname;
			this.PhoneNumber = phonenumber;
			this.Email = email;
			this.City = city;
			this.DateOfBirth = dateofbirth;
			this.BSN = bsn;
			this.Username = username;
			this.Password = password;
		
		}
		// methodes
		public override string ToString()
		{
			return $"ID: {ID} - Name: {FirstName} {LastName} - Email: {Email} - PhoneNumber: {PhoneNumber.ToString()}";
		}


	}
}
 

	