import React from "react";
import "./Story.css"
import axios from "axios";

interface StoryProps {
    title: string;
    body: string;
    id: string;
    onStoryDeleted: () => void;
}

var address = "http://localhost:5171";
// on click load story, get data from the db and then display it
const Story : React.FC<StoryProps> = ({title, body, id, onStoryDeleted }) => {

    const deleteStory = async (storyId: string) => {
        try {
            await axios.delete(`${address}/stories/${storyId}`);
            onStoryDeleted();
        } catch (error) {
            console.error("Failed to delete story:", error);
        }
    }
    return (
        <div className="story-container">
            <h3 className="story-title">{title}</h3>
            <p className="story-body">{body}</p>
            <button className="story-deleteButton" onClick={() => deleteStory(id)}>Delete Story</button>
        </div>
    );
}

export default Story;