namespace SqlDataBase.Tables
{
    public class Channel
    {
        public int Id { get; set; }
        public string DetectorId { get; set; }
        public int Title { get; set; }
        public string CurrentLength { get; set; }
        public string MaxLength { get; set; }
        public bool IsActive { get; set; }
    }
}
