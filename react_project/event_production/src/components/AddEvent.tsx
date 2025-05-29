import { useState } from "react";
import { postEvents } from "../api/ServerFunctions"; // קריאה לפונקציית הוספה מהשרת
import { useNavigate } from "react-router-dom";
import { Event } from "../types/Event";

export const AddEvent = () => {
  const navigate = useNavigate();

  const [newEvent, setNewEvent] = useState<Partial<Event>>({
    eventId:"",
    name: "",
    description: "",
    prodEmail: ""
  });

  const handleChange = (e: React.ChangeEvent<HTMLInputElement | HTMLTextAreaElement>) => {
    const { name, value } = e.target;
    setNewEvent((prev) => ({
      ...prev,
      [name]: value,
    }));
  };

  const handleSubmit = async (e: React.FormEvent) => {
    e.preventDefault();
    try {
      // כאן תצטרכי להתאים את postEvents לפונקציה שמקבלת newEvent ולא ריק
      await postEvents(newEvent as Event);
      alert("אירוע נוסף בהצלחה!");
      navigate("/AddEvent"); // חזרה לרשימת האירועים (תעדכני לפי הצורך)
    } catch (error) {
      console.error("שגיאה בהוספת האירוע:", error);
      alert("אירעה שגיאה בהוספת האירוע.");
    }
  };

  return (
    <div>
      <h2>הוספת אירוע חדש</h2>
      <form onSubmit={handleSubmit}>
        <div>
          <label>שם האירוע:</label>
          <input
            type="text"
            name="name"
            value={newEvent.name}
            onChange={handleChange}
            required
          />
        </div>
        <div>
          <label>תיאור האירוע:</label>
          <textarea
            name="description"
            value={newEvent.description}
            onChange={handleChange}
            required
          />
        </div>
        <div>
          <label>אימייל מפיק:</label>
          <input
            type="email"
            name="prodEmail"
            value={newEvent.prodEmail}
            onChange={handleChange}
            required
          />
        </div>
        <button type="submit">הוסף אירוע</button>
      </form>
    </div>
  );
};
