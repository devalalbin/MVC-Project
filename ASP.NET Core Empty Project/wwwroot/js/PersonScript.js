function getPeople() {
    console.log("Did we make it in the function by clicking?");
    $.get("/Ajax/GetPeople", null, function (data) {
        $("#PeopleList").html(data);
    });
    
}

function getPersonById() {
    var personIdValue = document.getElementById('PersonId').value;
    console.log(personIdValue+" Test person id value");
    $.post("/Ajax/Search", { personId: personIdValue }, function (data) {
        $("#PeopleList").html(data);
    });
}



function deletePerson() {
    var personIdValue = document.getElementById('PersonId').value;
    $.post("/Ajax/DeletePerson", { personId: personIdValue }, function (data) {

    })
        .done(function () {
            console.log(personIdValue + " deleted this person with ID" );
            document.getElementById('errorMessages').innerHTML = "Deleted person.";
            getPeople();
        })
        .fail(function () {
            document.getElementById('errorMessages').innerHTML = "Something went wrong, could not delete the person";
        });

}