﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace PumpManagement.Data
{
    public class Pumper
    {
        private ICollection<Address> _addresses;
        private ICollection<Local> _locals;
        private ICollection<Category> _categories;
        private ICollection<PumperSongMode> _pumperSongModes;
        private ICollection<PumperTournament> _pumperTournaments;

        public Pumper()
        {
            _addresses = new List<Address>();
            _locals = new List<Local>();
            _categories = new List<Category>();
            _pumperSongModes = new List<PumperSongMode>();
            _pumperTournaments = new List<PumperTournament>();
        }

        public int Id { get; set; }
        public  string Name { get; set; }
        public  string LastName { get; set; }
        public  string Email { get; set; }
        public  string Phone { get; set; }
        public  DateTime BirthDate { get; set; }
        public  int CaloriesBurned { get; set; }
        public  DateTime DebutDate { get; set; }
        public  string PhotoUrl { get; set; }

        public int ZoneId { get; set; }

        [ForeignKey("ZoneId")]
        public virtual Zone Zone { get; set; }

        public virtual ICollection<Address> Addresses
        {
            get { return _addresses; }
            set { _addresses = value; }
        }
        public virtual ICollection<Local> Locals
        {
            get { return _locals; }
            set { _locals = value; }
        }
        public virtual ICollection<Category> Categories
        {
            get { return _categories; }
            set { _categories = value; }
        }
        public virtual ICollection<PumperSongMode> PumperSongModes
        {
            get { return _pumperSongModes; }
            set { _pumperSongModes = value; }
        }
        public virtual ICollection<PumperTournament> PumpersTournaments
        {
            get { return _pumperTournaments; }
            set { _pumperTournaments = value; }
        }

       

        
    }
}
