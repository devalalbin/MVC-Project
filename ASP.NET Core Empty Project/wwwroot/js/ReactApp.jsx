import ReactDetails from "./ReactDetails.jsx";
import ReactTable from './ReactTable.jsx';
import ReactCreate from './ReactCreate.jsx';

function App() {

    const [people, setPeople] = React.useState([]);
    const [details, setDetails] = React.useState([]);
    const [cities, setCities] = React.useState([]);
    const showPersonDetails = (person) => {
        setDetails({
            ssn: person.ssn,
            name: person.name,
            phoneNr: person.phoneNr,
            cityName: person.cityName
        });
    }

    React.useEffect(() => {
        getPeople()
    }, [])

    const getPeople = () => {
        fetch('React/GetPeopleList'
            , {
                headers: {
                    'Content-Type': 'application/json',
                }
            }
        )
            .then(function (response) {
                return response.json();
            })
            .then(function (myJson) {
                //console.log(myJson);
                setPeople(myJson.reactPeople)
                setCities(myJson.reactCities)
            });
    }
    //console.log(cities);
    //console.log(people);
    return (
        <div className="container">
            <h3 className="p-3 text-center">React</h3>
            <h4 className="p-3 text-center">Add Person</h4>
            <ReactCreate cities={cities} />
            <h4 className="p-3 text-center">Person List</h4>
            <ReactTable people={people} showPersonDetails={showPersonDetails} />
            <div>
                <p>Person details</p>
                <ReactDetails details={details}  />
            </div>
        </div>

    )
}

ReactDOM.render(
    <App />,
    document.getElementById('root')
);