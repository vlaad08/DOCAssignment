

interface DepartmentPageProps {
    departmentName: string
}

const DepartmentPage : DepartmentPageProps = () => {
    return (
        <div>
            <h1>{departmentName}</h1>
        </div>
    )
}