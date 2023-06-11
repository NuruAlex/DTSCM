using SqlDataBase;
using SqlDataBase.Tables.Staffs;

namespace DTSCM.Verification
{
    public static class StaffManager
    {
        public static IStaff CurrentStaff { get; set; }
        private static IStaff TemproraryStaff { get; set; }

        public static bool Enter()
        {
            if (TemproraryStaff == null)
                return false;
            CurrentStaff = TemproraryStaff;
            GoNext(CurrentStaff.Post);
            return true;
        }
        private static void GoNext(string post)
        {
            switch (post)
            {
                case "Охранник": new Security.SecurityForm().Show(); break;
                case "Директор": new Director.DirectorForm().Show(); break;
                case "Администратор": new Administrator.AdministratorForm().Show(); break;
            }
        }
        public static bool StaffIsExist(string login, string password)
        {
            TemproraryStaff = GetStaff(login, password);
            return TemproraryStaff != null && TemproraryStaff.StaffLogin == login && TemproraryStaff.StaffPassword == password;
        }
        public static IStaff GetStaff(string login, string password)
        {
            string post = DataBase.Get.StaffPostByLogin(login);
            switch (post)
            {
                case "Охранник": return DataBase.Get.Staff<SqlDataBase.Tables.Staffs.Security>(login, password);
                case "Директор": return DataBase.Get.Staff<SqlDataBase.Tables.Staffs.Director>(login, password);
                case "Администратор": return DataBase.Get.Staff<SqlDataBase.Tables.Staffs.Administrator>(login, password);
                default: return null;
            }
        }

    }
}
