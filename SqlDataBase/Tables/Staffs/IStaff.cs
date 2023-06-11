namespace SqlDataBase.Tables.Staffs
{
    public interface IStaff
    {
        int Id { get; set; }
        string StaffLogin { get; set; }
        string Initials { get; set; }//в данном случае ФИО полностью
        string StaffPassword { get; set; }
        string Post { get; set; }//Дожность сотрудника
    }
}
