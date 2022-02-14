const ReactDetails = (props) => {

    const [person, setPerson] = React.useState(props.details);

    React.useEffect(
        () => {
            setPerson(props.details)
        },
        [props]
    )


    function DeletePerson(id) {
        fetch("/React/DeletePerson",
            {
                method: 'POST',
                headers: { 'Content-Type': 'application/json' },
                body: JSON.stringify({ id: id })
            })
            .then(response => {
                console.log('Response:', response);
                console.log('Response:', id);
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
                        <td><button className="btn btn-danger" onClick={DeletePerson(person.ssn)}>Delete user</button></td>
                    </tr>
                </tbody>
            </table >
            </div>

    )
}

export default ReactDetails

  