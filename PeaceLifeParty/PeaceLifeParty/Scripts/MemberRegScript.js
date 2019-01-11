/// <reference path="jquery-1.10.2.js" />

//memberReg

$(document).ready(function () {

    $('#sumbit').click(function () {
        console.log('@Model');
        $.ajax({
            type: "POST",
            url: '@Url.Action("MemberRegistration", "Home")',
            // dataType: 'json',              
            data: { model: '@Model' },
            success: function (datam) {
                alert('ddd');
            }
        });
    });
});