const ReactDetails = (props) => {

    const [person, setPerson] = React.useState(props.details);

    React.useEffect(
        () => {
            setPerson(props.details)
        },
        [props]
    )

    function handleSubmit(e) {
        //e.preventDefault();
        var pers = person.ssn;
        //console.log(person);

        fetch('React/DeletePerson',
            {
                method: 'POST',
                headers: { 'Content-Type': 'application/json' },
                body: JSON.stringify({ sSN: pers })
            })
            .then(response => {
                console.log('Response:', response);
                //console.log('Response:', pers);
            });
    }

    return (
        <div>
            
            < table className="table table-striped table-bordered" >
                <thead>
                    <tr>
                        <th>Name</th>
                        <th>SSN</th>
                        <th>PhoneNr</th>
                        <th>City</th>
                    </tr>
                </thead>
                <tbody>
                    <tr key={person.ssn}>
                        <td >{person.name}</td>
                        <td >{person.ssn}</td>
                        <td >{person.phoneNr}</td>
                        <td >{person.cityName}</td>
                    </tr>
                </tbody>
            </table >
            <form onSubmit={handleSubmit}>
                <button type="submit">Delete Person</button>
            </form>
        </div>

    )
}

export default ReactDetails