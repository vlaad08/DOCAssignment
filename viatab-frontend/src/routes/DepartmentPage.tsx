import React from "react"
import { useParams } from "react-router-dom"
import axios from "axios"
import Story from "../components/Story";
import Navbar from "../components/Navbar";
import "./DepartmentPage.css"

var address = "http://localhost:5171";


const DepartmentPage = () => {
    const [department, setDepartment] = React.useState<{
        name: string;
        description: string;
    } | null>(null);
    const [stories, setStories] = React.useState<{
        id: string;
        title: string;
        body: string;
    }[]>([]);
    const [loading, setLoading] = React.useState(true);

    const { departmentId } = useParams<{ departmentId: string }>()

    const fetchDepartmentInfo = React.useCallback(async () => {
        try {
            const response = await axios.get(`${address}/departments/${departmentId}`);
            setDepartment(response.data);
        } catch (error) {
            console.error("Failed to fetch departments:", error);
        }
    }, [departmentId]); 

    const fetchStories = React.useCallback(async () => {
        try {
            const response = await axios.get(`${address}/stories/departments/${departmentId}`);
            setStories(response.data)
        } catch (error) {
            console.error("Failed to fetch stories:", error);
        }
    }, [departmentId]);


    React.useEffect(() => {
        fetchDepartmentInfo();
        if(departmentId){
            fetchStories();
        }
        setLoading(false);
    }, [departmentId, fetchDepartmentInfo, fetchStories]);

    

    
    if(loading) {
        return <p>Loading...</p>
    }

    return (
        <>
            <Navbar></Navbar>
            <div className="department-container">
                <h1 className="department-name">{department?.name}</h1>
                <p className="department-description" >{department?.description}</p>
                <h2>Stories</h2>
                <ul className="stories-list">
                    {stories.map((story, key) => (
                        <li key={key} className="story-item">
                            <Story title={story.title} body={story.body} id={story.id} onStoryDeleted={fetchStories}></Story>
                        </li>
                    ))}
                </ul>
            </div>
        </>
    )
}

export default DepartmentPage;