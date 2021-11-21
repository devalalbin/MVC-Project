function GetPeople() {
    $.get("/Ajax/GetPeople", null, function (data) {
        $("#PeopleList").html(data);
    });
}

