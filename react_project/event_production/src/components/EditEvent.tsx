import { useEffect, useState } from "react";
import { useNavigate, useParams } from "react-router-dom";
import { getEventsById, putEventsById } from "../api/ServerFunctions";
import { Event } from "../types/Event";

export const EditEvent = () => {
  const { eventId } = useParams<{ eventId: string }>();
  const navigate = useNavigate();
  const [event, setEvent] = useState<Event | null>(null);
  const [loading, setLoading] = useState<boolean>(true);

  useEffect(() => {
    const fetchEvent = async () => {
      try {
        if (eventId) {
          const eventFromServer = await getEventsById(eventId);
          setEvent(eventFromServer);
        }
      } catch (error) {
        console.error("שגיאה בטעינת האירוע:", error);
        alert("אירעה שגיאה בטעינת האירוע.");
      } finally {
        setLoading(false);
      }
    };

    fetchEvent();
  }, [eventId]);

  const handleChange = (e: React.ChangeEvent<HTMLInputElement | HTMLTextAreaElement>) => {
    const { name, value } = e.target;
    if (event) {
      setEvent((prev) => prev ? { ...prev, [name]: value } : prev);
    }
  };

  const handleSave = async () => {
    try {
      console.log("נכנס ל-handleSave", event);

      if (event && event.eventId) {
        await putEventsById(event.eventId, event); // שימי לב שמעבירים גם ID וגם Event עצמו
        alert("האירוע עודכן בהצלחה!");
        navigate("/EventDetailsForProducer"); // חזרה לרשימת האירועים (תעדכני לפי הצורך)
      }
    } catch (error: any) {
      console.error("שגיאה בעדכון:", error.response?.data || error.message || error);
      alert("אירעה שגיאה בעדכון האירוע.");
    }
  };

  const handleCancel = () => {
    navigate(-1); // חזרה לעמוד הקודם
  };

  if (loading) {
    return <p>טוען פרטי אירוע...</p>;
  }

  if (!event) {
    return <p>אירוע לא נמצא</p>;
  }

  return (
    <div>
      <h2>עריכת אירוע</h2>
      <div>
        <label>שם האירוע:</label>
        <input
          type="text"
          name="name"
          value={event.name}
          onChange={handleChange}
        />
      </div>
      <div>
        <label>תיאור האירוע:</label>
        <textarea
          name="description"
          value={event.description}
          onChange={handleChange}
        />
      </div>
      <div>
        <label>אימייל מפיק:</label>
        <input
          type="email"
          name="prodEmail"
          value={event.prodEmail}
          onChange={handleChange}
        />
      </div>
      <button onClick={handleSave}>שמור שינויים</button>
      <button onClick={handleCancel}>בטל</button>
    </div>
  );
};
