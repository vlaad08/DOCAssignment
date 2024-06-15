import React from "react";
import { Link } from "react-router-dom";
import axios from "axios";
import "./Navbar.css";

var address = "http://localhost:5171";

const Navbar = () => {
    const [departments, setDepartments] = React.useState<
    {
        id: string;
        name: string;
        description: string;
    }[]>([]);
    const [loading, setLoading] = React.useState(true);
    
    const [collapsed, setCollapsed] = React.useState(true);

    
    const toggleCollapse = () => {
        setCollapsed(!collapsed);
    };
    React.useEffect(() => {
        fetchDepartments();
        setLoading(false);
    }, []);

    const fetchDepartments = async () => {
        try {
            const response = await axios.get(`${address}/departments`);
            setDepartments(response.data);
        } catch (error) {
            console.error("Failed to fetch departments:", error);
        }
    };

    if (loading) {
        return <p>Loading...</p>;
    }



    return (
        <div className="navbar">
            <ul>
                <li>
                    <Link to="/">Home</Link>
                </li>
                <li>
                    <Link to="/upload/story">Upload a story</Link> 
                </li>
                <li>
                    <div>
                        <span className="departments-toggle" onClick={toggleCollapse}>Departments</span>
                        {!collapsed && (
                            <ul className="departments-list">
                                {departments.map((department, key) => (
                                    <li key={key} style={{ marginTop: "8px" }}>
                                        <Link to={`/department/${department.id}`}>{department.name}</Link>
                                    </li>
                                ))}
                            </ul>
                        )}
                    </div>
                </li>
            </ul>
        </div>
    );
}

export default Navbar;