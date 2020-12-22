using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Diary_Version_2
{
    class EventDataAccess
    {
        DataAccess dataAccess;
        public EventDataAccess()
        {
            this.dataAccess = new DataAccess();
        }

        public List<EventEn> GetAllEvents()
        {
            string sql = "SELECT * FROM EventDiary";
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<EventEn> events = new List<EventEn>();
            while (reader.Read())
            {
                EventEn event1 = new EventEn();
                event1.UserId = (int)reader["User Id"];
                event1.EventId = (int)reader["Event Id"];
                event1.EventName = reader["EventName"].ToString();
                event1.Story = reader["Story"].ToString();

                events.Add(event1);
            }
            return events;
        }

        public EventEn GetEvent(int id)
        {
            string sql = "SELECT * FROM EventDiary WHERE [Event Id]=" + id;
            SqlDataReader reader = this.dataAccess.GetData(sql);
            reader.Read();
            EventEn event1 = new EventEn();
            event1.EventId = (int)reader["Event Id"];
            event1.EventName = reader["EventName"].ToString();
            event1.Story = reader["Story"].ToString();
            return event1;
        }


        public int InsertEventName(EventEn name)
        {
            string sql = "INSERT INTO EventDiary(EventName) VALUES('" + name.EventName + "')";
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }

        public int InsertStory(EventEn story)
        {
            string sql = "INSERT INTO EventDiary(Story) VALUES('" + story.Story + "')";
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }

        public int UpdateEvent(EventEn event1)
       {
           string sql = "UPDATE EventDiary SET EventName='" + event1.EventName + "',Story='" +event1.Story + "' WHERE EventId=" + event1.EventId;
           int result = this.dataAccess.ExecuteQuery(sql);
           return result;
        }
        public int DeleteEvent(int id)
        {
            string sql = "DELETE FROM EventDiary WHERE [Event Id]=" + id;
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }

        public List<string> GetAllEventNames()
        {
            string sql = "SELECT * FROM EventDiary";
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<string> events = new List<string>();
            while (reader.Read())
            {
                events.Add(reader["EventName"].ToString());
            }
            return events;
        }
    }
}
