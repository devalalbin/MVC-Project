const ReactCreate = (props) => {

    const [Name, setName] = React.useState("");
    const [PhoneNr, setPhoneNr] = React.useState("");
    const [Id, setId] = React.useState("");
    const [CityId, setCity] = React.useState("1");

    function handleSubmit(e) {
        e.preventDefault();

        const data = {
            Name: Name,
            PhoneNr: PhoneNr,
            Id: Id,
            City: CityId 
        };
        //console.log(data.City);
        //console.log(data);
        //alert(data.City);

        fetch('React/CreatePerson',
            {
                method: 'POST',
                headers: { 'Content-Type': 'application/json' },
                body: JSON.stringify({
                    Name: data.Name, SSN: data.Id, PhoneNr: data.PhoneNr, cityId: data.City
                })
            })
            .then(response => {
                console.log('Response:', response);
                window.location.reload(false);
                console.log(data);
            });
    }

    return (
        <form className="table table-striped table-bordered" onSubmit={handleSubmit}>

            <div className="form-row">
                <div className="form-group col-md-3">
                    <input value={Name} onChange={(e) => setName(e.target.value)} type="text" className="form-control"
                        id="name" placeholder="Enter Name" />
                </div>
            </div>

            <div className="form-row">
                <div className="form-group col-md-3">
                    <input value={PhoneNr} onChange={(e) => setPhoneNr(e.target.value)} type="text" className="form-control"
                        id="phoneNr" placeholder="Enter PhoneNr" />
                </div>
            </div>

            <div className="form-row">
                <div className="form-group col-md-3">
                    <input value={Id} onChange={(e) => setId(e.target.value)} type="text" className="form-control"
                        id="id" placeholder="Enter SSN" />
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