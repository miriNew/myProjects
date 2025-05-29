import axios from "axios" // מייבא את axios לביצוע קריאות HTTP.
import { Event } from "../types/Event"; // מייבא את סוג האירוע.
import { Producer } from "../types/Producer";

const server = 'http://localhost:3000'; // כתובת השרת.
const EventProductionServer = axios.create({
    baseURL: server // יוצר מופע של axios עם כתובת בסיסית.
});

// פונקציה לקבלת כל האירועים.
export const getEvents = async (): Promise<Event[]> => {
    const response = await EventProductionServer.get<Event[]>('/eventController'); // מבצע קריאה ל-API.
    return response.data; // מחזיר את הנתונים.
};
//פונקציה לקבלת כל האירועים ע"פ ID
export const getEventsById = async (id:string): Promise<Event> => {
    const response = await EventProductionServer.get<Event>(`/eventController/${id}`); // מבצע קריאה ל-API.
    return response.data; 
};
//פונקציה להוספת אירוע
export const postEvents = async (newEvent: Event): Promise<Event[]> => {
    const response = await EventProductionServer.post<Event[]>('/eventController',newEvent); // מבצע קריאה ל-API.
    return response.data; 
};
//פונקציה לעדכון אירוע ע"פ ID
export const putEventsById = async (eventId:string, updatedEvent: Event): Promise<Event[]> => {
    const response = await EventProductionServer.put<Event[]>(`/eventController/${eventId}`,updatedEvent); // מבצע קריאה ל-API.
    return response.data; 
};
//פונקציה למחיקת אירוע ע"פ ID
export const deleteEventsById = async (eventId:string): Promise<Event[]> => {
    const response = await EventProductionServer.delete<Event[]>(`/eventController/${eventId}`); // מבצע קריאה ל-API.
    return response.data; 
};
//פונקציה לקבלת מפיק ע"פ EMAIL
export const getProducersByEmail = async (email:string): Promise<Producer> => {
    const response = await EventProductionServer.get<Producer>(`/eventProducerController/${email}`); // מבצע קריאה ל-API.
    return response.data; 
};
//פונקציה להוספת מפיק
export const postProducers = async (newProducer: Producer): Promise<Producer> => {
    const response = await EventProductionServer.post<Producer>('/eventProducerController',newProducer); // מבצע קריאה ל-API.
    return response.data; 
};
//פונקציה למחיקת מפיק ע"פ EMAIL
export const deleteProducersByEmail = async (email:string): Promise<Producer> => {
    const response = await EventProductionServer.delete<Producer>(`/eventProducerController/${email}`); // מבצע קריאה ל-API.
    return response.data; 
};


