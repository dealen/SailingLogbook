namespace SailingLogbook.Models
{
    public class LogEntry
    {
        public string Weather { get; set; }
        public string Wind { get; set; }
        public string Position { get; set; }
        public string Crew { get; set; }
        public string Skipper { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public string Notes { get; set; }
    }
}
