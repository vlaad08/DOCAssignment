import React from "react";
import UploadForm from "../components/UploadForm";
import Navbar from "../components/Navbar";
import "./StoryUploadPage.css";




const StoryUploadPage = () => {
    return (
        <>
            <Navbar></Navbar>
            <div className="story-upload-page-container">
                <h1 className="story-upload-page-title">Upload a Story</h1>
                <UploadForm></UploadForm>
            </div>
        </>
    );
}


export default StoryUploadPage;