import { createHashRouter, RouterProvider } from 'react-router-dom' 
import HomePage from './routes/HomePage'
import DepartmentPage from './routes/DepartmentPage'
import StoryUploadPage from './routes/StoryUploadPage'

const router = createHashRouter([
    { path: "/", element: <HomePage /> },
    { path: "/upload/story", element: <StoryUploadPage/>},
    { path: "/department/:departmentId", element: <DepartmentPage /> }
]) 

function App() {
    return <RouterProvider router={router} /> 
}

export default App 