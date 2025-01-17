import axios from "axios";
import Employee from "./Employee";
const employeeAPI = (url = "http://localhost:8000/api/Employee") => {
    return {
      fetchAll: () => axios.get(url),
      create: (newRecord) => axios.post(url, newRecord),
      update: (id, updatedRecord) => axios.put(url + id, updatedRecord),
      delete: (id) => axios.delete(url + id),
    };
  };
  
  const addOrEdit = (formData, onSuccess) => {
    employeeAPI()
      .create(formData)
      .then((res) => {
        onSuccess();
      })
      .catch((err) => console.log(err));
  };
  
const EmployeeList = () => {
  return (
    <div className="row">
      <div className="col-md-12">
        <div className="jumbotron jumbotron-fluid py-4">
          <div className="container text-center">
            <h1 className="display-4">Employee Register</h1>
          </div>
        </div>
      </div>
      <div className="col-md-4">
        <Employee addOrEdit={addOrEdit} />
      </div>
      <div className="col-md-8">
        <div>list of employee records</div>
      </div>
    </div>
  )
}

export default EmployeeList