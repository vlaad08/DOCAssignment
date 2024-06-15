import React from "react";
import { Link } from "react-router-dom";



// call api -> generate department sublist and place under departments tab

const Sidebar = () => {
    return (
        <div>
            <ul>
                <li>
                    <Link to="/">Home</Link>
                </li>
                <li>
                    <Link to="">Departments</Link> {/* add dropdown */}
                </li>
            </ul>
        </div>
    );
}

export default Sidebar;