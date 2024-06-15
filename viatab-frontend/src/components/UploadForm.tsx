import React from "react";
import axios from "axios";
import "./UploadForm.css";

var address = "http://localhost:5171";
const UploadForm = () => {
    const [title, setTitle] = React.useState("");
    const [body, setBody] = React.useState("");
    const [departmentId, setDepartmentId] = React.useState("");
    const [departments, setDepartments] = React.useState<
    {
        id: string;
        name: string;
        description: string;
    }[]>([]);
    const [loading, setLoading] = React.useState(true);

    const handleSubmit = (e: React.FormEvent) => {
        e.preventDefault();
        setTitle("");
        setBody("");
        postStory();
    };

    React.useEffect(() => {
        fetchDepartments();
        setLoading(false);
    }, []);

    const postStory = async () => {
        try {
            console.log(title, body, departmentId)
            await axios.post(`${address}/stories`, {
                title: title,
                body: body,
                departmentId: departmentId
            });
        } catch (error) {
            console.error("Failed to post story:", error);
        }
    }

    const fetchDepartments = async () => { 
        try {
            const response = await axios.get(`${address}/departments`);
            setDepartments(response.data);
            setDepartmentId(response.data[0].id);
        } catch (error) {
            console.error("Failed to fetch departments:", error);
        }
    }

    if(loading) {
        return <p>Loading...</p>
    }
    
    return (
        <div className="upload-form-container">  
            <div>
                <label htmlFor="department">Department:</label>
                <select id="department" onChange={(e) => setDepartmentId(e.target.value)}>
                    {departments.map((department) => (
                        <option key={department.id} value={department.id}>
                            {department.name}
                        </option>
                    ))}
                </select>
            </div>
            <form onSubmit={handleSubmit}>
                <div>
                    <label htmlFor="title">Title:</label>
                    <input
                        type="text"
                        id="title"
                        value={title}
                        onChange={(e) => setTitle(e.target.value)}
                    />
                </div>
                <div>
                    <label htmlFor="body">Body:</label>
                    <textarea
                        id="body"
                        value={body}
                        onChange={(e) => setBody(e.target.value)}
                    />
                </div>
                <button type="submit">Submit</button>
            </form>
        </div>
    );
};

export default UploadForm;