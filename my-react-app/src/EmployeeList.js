import React, { useEffect, useState } from 'react';

function EmployeeList() {
  const [employees, setEmployees] = useState([]);
const url='https://localhost:7203/Home/employee';

useEffect(() => {
        async function getData() {
            const response = await fetch(url)
            const data = await response.json()
            setEmployees(data)
        }
        getData();
    }, []);

  return (
    <div>
      <h1>Employee List</h1>
      {employees.map(employee => (
        <div key={employee.id}>
          <p>Id: {employee.id}</p>
          <p>First Name: {employee.first_name}</p>
          <p>Last Name: {employee.last_name}</p>
          <p>Address: {employee.address}</p>
        </div>
      ))}
    </div>
  );
}

export default EmployeeList;
