using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ExAgenda10Databound
{
    public enum Priority { None, Normal, High };
    public enum Category { None, Business, Private, Education };

    public class AgendaItem
    {
        public string Text { get; set; }
        public DateTime StartTime { get; set; }
        public int Duration { get; set; }
        public string Time
        {
            get
            {
                return String.Format("{0} - {1}",
                    StartTime.ToString("HH:mm"),
                    StartTime.AddMinutes(Duration).ToString("HH:mm"));
            }
        }
        public Category Category { get; set; }
        public Priority Priority { get; set; }
        public bool IsImportant { get; set; }
        public bool HasAttachments { get; set; }
    }

    public class Week : ObservableCollection<AgendaItem>
    {
        public Week()
        {
            Add(new AgendaItem
            {
                Text = "Dept-Meeting",
                StartTime = new DateTime(2015, 4, 13, 8, 0, 0),
                Duration = 120,
                Category = Category.Business,
                Priority = Priority.Normal,
                IsImportant = false,
                HasAttachments = false
            });
            Add(new AgendaItem
            {
                Text = "Lunch with Donald",
                StartTime = new DateTime(2015, 4, 14, 12, 0, 0),
                Duration = 60,
                Category = Category.None,
                Priority = Priority.None,
                IsImportant = false,
                HasAttachments = false
            });
            Add(new AgendaItem
            {
                Text = "Tennis",
                StartTime = new DateTime(2015, 4, 14, 19, 0, 0),
                Duration = 120,
                Category = Category.Private,
                Priority = Priority.None,
                IsImportant = false,
                HasAttachments = false
            });
            Add(new AgendaItem
            {
                Text = "Prepare Financial Report",
                StartTime = new DateTime(2015, 4, 15, 9, 0, 0),
                Duration = 180,
                Category = Category.Business,
                Priority = Priority.High,
                IsImportant = true,
                HasAttachments = true
            });
            Add(new AgendaItem
            {
                Text = "Financial Meeting, N.216",
                StartTime = new DateTime(2015, 4, 15, 13, 0, 0),
                Duration = 120,
                Category = Category.Business,
                Priority = Priority.High,
                IsImportant = true,
                HasAttachments = false
            });
            Add(new AgendaItem
            {
                Text = "Workshop 'New Marketing Strategy', New York",
                StartTime = new DateTime(2015, 4, 16, 9, 0, 0),
                Duration = 600,
                Category = Category.Education,
                Priority = Priority.None,
                IsImportant = true,
                HasAttachments = true
            });
            Add(new AgendaItem
            {
                Text = "Lunch with Daisy",
                StartTime = new DateTime(2015, 4, 17, 12, 30, 0),
                Duration = 90,
                Category = Category.None,
                Priority = Priority.None,
                IsImportant = false,
                HasAttachments = false
            });
            Add(new AgendaItem
            {
                Text = "Check Time",
                StartTime = new DateTime(2015, 4, 18, 13, 0, 0),
                Duration = 30,
                Category = Category.Business,
                Priority = Priority.High,
                IsImportant = true,
                HasAttachments = false
            });
            Add(new AgendaItem
            {
                Text = "Tennis",
                StartTime = new DateTime(2015, 4, 17, 19, 30, 0),
                Duration = 120,
                Category = Category.Private,
                Priority = Priority.None,
                IsImportant = false,
                HasAttachments = false
            });
        }

    }
}
