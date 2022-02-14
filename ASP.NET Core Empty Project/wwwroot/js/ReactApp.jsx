import ReactDetails from "./ReactDetails.jsx";

function App() {

    const [people, setPeople] = React.useState([]);
    const [city, setCitys] = React.useState([]);
    
  
    const getPeople = () => {
        fetch('React/GetPeopleList'
            , {
                headers: {
                    'Content-Type': 'application/json',
                    'Accept': 'application/json'
                }
            }
        )
            .then(function (response) {
                console.log(response)
                return response.json();
            })
            .then(function (myJson) {
                console.log(myJson);
                setPeople(myJson.reactPeople)
                setCitys(myJson.reactCity)
            });
    }
    React.useEffect(() => {
        getPeople()
    }, [])


   
    return (
        <div className="container">
            <ReactDetails />
            <h3 className="p-3 text-center">React - Display a list of People</h3>
            <table className="table table-striped table-bordered">
                <thead>
                    <tr>
                        <th>Name</th>
                    </tr>
                </thead>
                <tbody>
                    {people && people.map(people =>
                        <tr key={people.ssn}>
                            <td>{people.name}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        </div>

    )
}

ReactDOM.render(
    <App />,
    document.getElementById('root')
);