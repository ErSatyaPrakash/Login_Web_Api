var GetLogin = Function()
{
    var username = $('#txtUsername').val();
    var password = $('#txtPassword').val();
    var LoginData = JSON.stringify({ "Username": username, "Passowrd": password });
    $.ajax({

            type: "POST",
            data: LoginData,
            url: "/api/values/GetLogin",
            contentType: "application/json;charset=utf-8",
            dataType: "json",
            success: function (result) {
                alert("ok"+result)
            },
            error: function (result) {
                alert("Error"+result)
            }

        });
};