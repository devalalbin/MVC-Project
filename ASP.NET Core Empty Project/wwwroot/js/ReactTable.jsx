const ReactTable = (props) => {
    const [people, setPeople] = React.useState(props.people)

    React.useEffect(() => {
        setPeople(props.people)
    }, [props])

    return (
        <table className="table table-striped table-bordered">
            <thead>
                <tr>
                    <th className="btn" onClick={() => { props.sort() }}>Name</th>
                    <th>See details</th>
                </tr>
            </thead>
            <tbody>
                {(people.map((item) => (
                        <tr key={item.ssn}>
                            <td >{item.name}</td>
                            <td>
                                <button onClick={() => { props.showPersonDetails(item) }} className="btn">Details</button>
                            </td>
                        </tr>
                    ))
                ) }
            </tbody>
        </table>
    )
}

export default ReactTable