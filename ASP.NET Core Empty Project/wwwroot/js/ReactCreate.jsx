﻿const ReactCreate = (props) => {
    const [Name, setName] = React.useState("");
    const [PhoneNr, setPhoneNr] = React.useState("");
    const [Id, setId] = React.useState("");
    const [CityId, setCity] = React.useState("1");

    function handleSubmit(e) {
        e.preventDefault();
        var vali = Validation();
        
        if (vali) {
            fetch('React/CreatePerson',
                {
                    method: 'POST',
                    headers: { 'Content-Type': 'application/json' },
                    body: JSON.stringify({
                        Name: Name, SSN: Id, PhoneNr: PhoneNr, cityId: CityId
                    })
                })
                .then(response => {
                    console.log('Response:', response);
                    window.location.reload(false);
                    console.log(data);
                });
        }
    }

    function Validation() {
        let text;
        if (isNaN(Id) || Id.length < 1 || Id.length > 13) {
            text = "Input not valid (Must be a number and lenght less than 13)";
            document.getElementById("validation").innerHTML = text;
            return false;
        /*if (!isNaN(Name)) {
            text = "Name can not contain numbers";
            document.getElementById("validation").innerHTML = text;
            return false;
            }*/
        } else {
            text = "Input Ok";
            document.getElementById("validation").innerHTML = text;
            return true;
        }
    }


    return (

        <form className="table table-striped table-bordered" onSubmit={handleSubmit}>
            <p id="validation"></p>
            <div className="form-row">
                <div className="form-group col-md-3">
                    <input value={Name} onChange={(e) => setName(e.target.value)} type="text" className="form-control"
                        id="name" placeholder="Enter Name" required/>
                </div>
            </div>

            <div className="form-row">
                <div className="form-group col-md-3">
                    <input value={PhoneNr} onChange={(e) => setPhoneNr(e.target.value)} type="text" className="form-control"
                        id="phoneNr" placeholder="Enter PhoneNr" required/>
                </div>
            </div>

            <div className="form-row">
                <div className="form-group col-md-3">
                    <input value={Id} onChange={(e) => setId(e.target.value)} type="text" className="form-control"
                        id="id" placeholder="Enter SSN" required/>
                </div>
            </div>
            
            <div className="form-row">
                <label>Choose city</label>
                <select onChange={(e) => setCity(e.target.value)} 
                    className="form-select">
                    {props.cities.map(city => (
                        <option key={city.id} value={city.id}>{city.name}</option>
                ))}
                </select>
                <button type="submit" className="btn">Add Person</button>
            </div >
        </form>
    );

}

export default ReactCreate