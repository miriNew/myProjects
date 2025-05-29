import { getEvents } from "../api/ServerFunctions";
import { Event } from "../types/Event";
import { useState, useEffect } from "react";
import { NavLink } from "react-router-dom";

export const AppMain = () => {
  const [events, setEvents] = useState<Event[]>([]);
  const [loading, setLoading] = useState<boolean>(false);
  const [searchEvent, setSearchEvent] = useState<string>("");

  const getEventsFromServer = async () => {
    try {
      setLoading(true);
      const eventFromServer: Event[] = await getEvents();
      setEvents(eventFromServer);
    } catch (error) {
      console.error("error fetching events: " + error);
    } finally {
      setLoading(false);
    }
  };

  useEffect(() => {
    getEventsFromServer();
  }, []);

  return (
    <div>
        <button>
            <NavLink to="/Producers">כניסת מפיקות</NavLink>
          </button>
      <h1>רשימת אירועים</h1>
      {loading ? (
        <p>טוען...</p>
      ) : (
        <>
        
          <input
            type="text"
            placeholder="search"
            value={searchEvent}
            onChange={(e) => setSearchEvent(e.target.value)}
          />
          {/* כאן אפשר להוסיף מיפוי להצגת האירועים */}
          {events
            .filter((event) =>
              event.name?.includes(searchEvent) // דוגמה לסינון לפי שם
            )
            .map((event) => (
              <div key={String(event.eventId)}>
                    <NavLink to={`/EventDetailsForUser/${event.eventId}`}>
                            {event.name} 
                    </NavLink>
              </div>
            ))}
            
        </>
      )}
    </div>
  );
};
