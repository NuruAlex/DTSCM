﻿namespace SqlDataBase.Tables.Staffs
{
    public class Director : IStaff
    {
        public int Id { get; set; }
        public string StaffLogin { get; set; }
        public string Initials { get; set; }
        public string StaffPassword { get; set; }
        public string Post { get; set; }
    }
}
