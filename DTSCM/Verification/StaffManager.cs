using SqlDataBase;
using SqlDataBase.Tables.Staffs;
using System.Collections.Generic;

namespace DTSCM.Verification
{
    public static class StaffManager
    {
        public static IStaff CurrentStaff { get; set; }
        private static IStaff TemproraryStaff { get; set; }

        public static bool Enter()
        {
            if(TemproraryStaff == null)
                return false;
            CurrentStaff = TemproraryStaff;
            GoNext(CurrentStaff.Post);
            return true;
        }
        public static void GoNext(string post)
        {
            switch (post)
            {
                case "Охранник": new Security.SecurityForm().Show();break;
                case "Директор": new Director.DirectorForm().Show(); break;
                case "Администратор": new Administrator.AdministratorForm().Show(); break;
            }
        }
        public static bool StaffIsExist(string post, string password)
        {
            TemproraryStaff = GetStaff(post, password);
            return TemproraryStaff != null && TemproraryStaff.Post == post && TemproraryStaff.StaffPassword == password;
        }
        public static IStaff GetStaff(string post,string password)
        {
            switch(post)
            {
                case "Охранник": return GetStaff<SqlDataBase.Tables.Staffs.Security>(post, password);
                case "Директор": return GetStaff<SqlDataBase.Tables.Staffs.Director>(post, password); 
                case "Администратор": return GetStaff<SqlDataBase.Tables.Staffs.Administrator>(post, password);
                default: return null;
            }
        }
        private static IStaff GetStaff<T>(string post, string password)
        {
            List<T> Staffs = DataBase.ConvertToList<T>
                   (DataBase.SelectRequestExecute($"select * from Staffs where Post ='{post}' and StaffPassword ='{password}'"));
            if (Staffs.Count == 1)
                return (IStaff)Staffs[0];
            return null;
        }
    }
}
