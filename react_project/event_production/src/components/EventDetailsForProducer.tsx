import { useEffect, useState } from "react";
import { getEvents, deleteEventsById } from "../api/ServerFunctions";
import { Event } from "../types/Event";
import { useNavigate } from "react-router-dom";

export const EventDetailsForProducer = () => {
  const [events, setEvents] = useState<Event[]>([]);
  const [loading, setLoading] = useState<boolean>(true);
  const navigate = useNavigate();

  const fetchEvents = async () => {
    try {
      const allEvents = await getEvents();
      setEvents(allEvents);
    } catch (error) {
      console.error("Error fetching events:", error);
    } finally {
      setLoading(false);
    }
  };

  const handleDelete = async (id: string) => {
    try {
        console.log("מנסה למחוק אירוע עם id:", id);
      await deleteEventsById(id);
      console.log("האירוע נמחק מהשרת, מעדכן סטייט");
      setEvents(events.filter((event) => event.eventId !== id));
      alert("אירוע נמחק בהצלחה!");
    } catch (error) {
      console.error("Error deleting event:", error);
    }
  };

  const handleEdit = (id: string) => {
    navigate(`/EditEvent/${id}`);
  };

  const handleAddEvent = () => {
    navigate("/AddEvent");
  };

  useEffect(() => {
    fetchEvents();
  }, []);

  if (loading) {
    return <p>טוען אירועים...</p>;
  }

  return (
    <div>
      <h1>רשימת כל האירועים</h1>
      <button onClick={handleAddEvent}>להוספת אירוע חדש</button>
      {events.length === 0 ? (
        <p>אין אירועים להצגה.</p>
      ) : (
        <ul>
          {events.map((event:Event) => (
            <li key={event.eventId}>
              <h3>{event.name}</h3>
              <p>תיאור: {event.description}</p>
              <p>מייל מפיק: {event.prodEmail}</p>
              <button onClick={() => handleEdit(event.eventId)}>ערוך</button>
              <button onClick={() => handleDelete(event.eventId)}>מחק</button>
            </li>
          ))}
        </ul>
      )}
    </div>
  );
};
