import { useState } from "react";
import { postProducers } from "../api/ServerFunctions";
import { Producer } from "../types/Producer";

export const AddProducer = () => {
  const [producer, setProducer] = useState<Producer>({
    name: "",
    email: "",
    phoneNum: "",
    description: "",
    productId: "",
  });

  const handleChange = (e: React.ChangeEvent<HTMLInputElement>) => {
    const { name, value } = e.target;
    setProducer((prev) => ({ ...prev, [name]: value }));
  };

  const handleSubmit = async () => {
    try {
      await postProducers(producer);
      alert("המפיק נוסף בהצלחה!");
      // אפשר לאפס את הטופס כאן אם רוצים
      setProducer({ name: "", email: "", phoneNum: "", description: "", productId: "" });
    } catch (error) {
      console.error("שגיאה בשליחת המפיק:", error);
    }
  };

  return (
    <div>
      <form onSubmit={handleSubmit}>
        <input type="text" name="productId" value={producer.productId} onChange={handleChange} placeholder="מזהה מפיק" required />
        <input type="text" name="name" value={producer.name} onChange={handleChange} placeholder="שם מפיק" required />
        <input type="email" name="email" value={producer.email} onChange={handleChange} placeholder="כתובת מייל" required />
        <input type="text" name="phoneNum" value={producer.phoneNum} onChange={handleChange} placeholder="מס' טלפון" required />
        <input type="text" name="description" value={producer.description} onChange={handleChange} placeholder="תיאור המפיק" required />
        <button type="submit">הוסף מפיק</button>
      </form>
    </div>
  );
};
