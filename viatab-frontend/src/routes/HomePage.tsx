import React from "react";
import Navbar from "../components/Navbar";
import "./HomePage.css";

const HomePage: React.FC = () => {
    return (
        <>
            <Navbar></Navbar>
            <div className="homePageContainer">
                <div className="homePageContent">
                    <h1 className="homePageHeader">Welcome to the VIA Tabloid!</h1>
                    <p className="homePageText">Over here you can find stories and ideas related to our different departments. Do you have something to share? 
                        No problem, you can create your own story and share it with the world.
                    </p>
                </div>
            </div>
        </>
    );
};

export default HomePage;


