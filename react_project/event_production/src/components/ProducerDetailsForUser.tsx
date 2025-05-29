import { useEffect, useState } from "react";
import {getProducersByEmail} from "../api/ServerFunctions";
import { Producer } from "../types/Producer";
import { useParams } from "react-router-dom";

export const ProducerDetailsForUser=()=>{

    const { email } = useParams<{ email: string }>();
    const [producer, setProducer] = useState<Producer | null>(null);
    const [loading, setLoading] = useState<boolean>(true);
    const getEventsFromServer = async () => {
        try {
          if(email){
          const producerFromServer = await getProducersByEmail(email);
          console.log("email from params:", email);
          setProducer(producerFromServer);
          }
        } catch (error) {
          console.error("error fetching events: " + error);
        } finally {
            setLoading(false);
          }
      };
    
     
      useEffect(() => {
        getEventsFromServer();
      }, [email]);
    
    return(
    <div>
         {producer ? (
            <div>
                <h2>{producer.name}</h2>
                <p> {producer.email} :כתובת מייל המפיק</p>
                <p>מזהה מפיק האירוע: {producer.productId}</p>
                <p>תיאור המפיק: {producer.description}</p>
                <p>מס' טלפון המפיק: {producer.phoneNum}</p>
            </div>
          ) : (
            <p>טוען פרטי המפיק...</p>
          )}
    </div>
    )
}