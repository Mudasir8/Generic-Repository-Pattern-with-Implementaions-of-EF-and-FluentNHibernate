
function btnSubmitClick() {

    var txtFirstName = $("#txtFirstName").val().trim();
    var txLastName = $("#txLastName").val().trim();
    if (!txtFirstName || !txLastName) {
        alert("First Name and Last Name cannot be empty");
        return;
    }

    $.ajax({
        url: "/Student/AddNewStudent",
        data: { firtName: txtFirstName, lastName: txLastName },
        success: function (response) {
            if (response) {
                alert("New student added successfully");
                window.location.href = "/Student";
            } else {
                alert("Something went wrong pleas try again");
            }
        }
    });

}