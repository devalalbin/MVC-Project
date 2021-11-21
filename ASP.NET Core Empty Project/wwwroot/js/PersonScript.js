function getPeople() {
    //console.log("Kom vi in hit?");
    $.get("/Ajax/GetPeople", null, function (data) {
        $("#PeopleList").html(data);
    });
    
}

function getPersonById() {
    var personIdValue = document.getElementById('PersonId').value;
    console.log(personIdValue+" this is our value");
    $.post("/Ajax/Search", { personId: personIdValue }, function (data) {
        $("#PeopleList").html(data);
    });
}