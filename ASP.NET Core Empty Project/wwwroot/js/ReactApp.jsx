import ReactDetails from "./ReactDetails.jsx";
import ReactTable from './ReactTable.jsx';

function App() {

    const [people, setPeople] = React.useState([]);
    const [details, setDetails] = React.useState([]);
    const [city, setCitys] = React.useState([]);

    const showPersonDetails = (person) => {
        setDetails({ ssn: person.ssn, name: person.name, phoneNr: person.phoneNr, cityName: person.cityName });
    }
    
  
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
            <h3 className="p-3 text-center">React</h3>
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