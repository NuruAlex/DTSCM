using System;

namespace SqlDataBase.Tables.Staffs
{
    public interface IStaff
    {
        string StaffLogin { get; set; }
        string Initials { get; set; }//в данном случае ФИО полностью
        string StaffPassword { get; set; }
        string Post { get; set; }//Дожность сотрудника

        string AccessLevel { get; set; }
        DateTime LastDateEntered { get; set; }
    }
}
