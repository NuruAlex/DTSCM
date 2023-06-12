﻿using System;

namespace SqlDataBase.Tables.Staffs
{
    public class Administrator : IStaff
    {
        public int Id { get; set; }
        public string StaffLogin { get; set; }
        public string Initials { get; set; }
        public string StaffPassword { get; set; }
        public string Post { get; set; }
        public string AccessLevel { get; set; }
        public DateTime LastDateEntered { get; set; }
    }
}
