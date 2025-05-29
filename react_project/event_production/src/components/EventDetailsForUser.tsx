import { useEffect, useState } from "react";
import { NavLink } from "react-router-dom";
import {getEventsById} from "../api/ServerFunctions";
import { Event } from "../types/Event";
import { useParams } from "react-router-dom";


export const EventDetailsForUser=()=>{
    const { eventId } = useParams<{ eventId: string }>();
    const [event, setEvent] = useState<Event | null>(null);
    const [loading, setLoading] = useState<boolean>(true);
    const getEventsFromServer = async () => {
        try {
          if(eventId){
          const eventFromServer = await getEventsById(eventId);
          console.log("eventFromServer:", eventFromServer);
          setEvent(eventFromServer);
          }
        } catch (error) {
          console.error("error fetching events: " + error);
        } finally {
            setLoading(false);
          }
      };
    
     
      useEffect(() => {
        getEventsFromServer();
      }, [eventId]);
    

    return(
    <div>
        {event ? (
            <div>
                <h2>{event.name}</h2>
                <p> {event.eventId} :מזהה האירוע</p>
                <p> {event.prodEmail} :כתובת מייל מפיק האירוע</p>
                <p>תיאור האירוע: {event.description}</p>
                <button>
                    <NavLink to={`/ProducerDetailsForUser/${event.prodEmail}`}>לפרטי מפיק האירוע</NavLink>
                </button>
            </div>
          ) : (
            <p>טוען פרטי אירוע...</p>
          )}
          
    </div>  
    
    )
}