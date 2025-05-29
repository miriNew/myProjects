import { NavLink } from "react-router-dom";

export const Producers=()=>{


    return(
    <div>
         <button>
            <NavLink to="/InsertEmail">מפיקה קיימת</NavLink>
          </button>
          <button>
            <NavLink to="/AddProducer">מפיקה חדשה</NavLink>
          </button>
    </div>
    )
}