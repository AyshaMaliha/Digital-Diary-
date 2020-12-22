using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Diary_Version_2
{
    class EventServices
    {
        EventDataAccess eventDataAccess;
        public EventServices()
        {
            this.eventDataAccess = new EventDataAccess();
        }

        public List<EventEn> GetEventList()
        {
            return this.eventDataAccess.GetAllEvents();
        }

        public int AddNewEvent(string eventName)
        {
            EventEn event1 = new EventEn() { EventName = eventName };
            return this.eventDataAccess.InsertEventName(event1);
        }

        public int AddNewStory(string story)
        {
            EventEn event1 = new EventEn() { Story = story };
            return this.eventDataAccess.InsertEventName(event1);
        }
        public int UpdateEvent(int id, string eventName, string story)
        {
            EventEn event1 = new EventEn() { EventId = id, EventName = eventName, Story = story };
            return this.eventDataAccess.UpdateEvent(event1);
        }
        public int DeleteEvent(int id)
        {
            return this.eventDataAccess.DeleteEvent(id);
        }

        public List<string> GetEventNameList()
        {
            return this.eventDataAccess.GetAllEventNames();
        }

       
    }
}

