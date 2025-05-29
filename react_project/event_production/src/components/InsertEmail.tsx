import { useState } from "react";
import { useNavigate } from "react-router-dom";

export const InsertEmail = () => {
  const [email, setEmail] = useState<string>("");
  const navigate = useNavigate();

  const handleSubmit = () => {
    if (email.trim()) {
      navigate(`/EventDetailsForProducer/${email}`);
    }
  };

  return (
    <div>
      <input
        type="email"
        placeholder="הכנס כתובת אימייל"
        value={email}
        onChange={(e) => setEmail(e.target.value)}
      />
      <button onClick={handleSubmit}>שלח</button>
    </div>
  );
};
