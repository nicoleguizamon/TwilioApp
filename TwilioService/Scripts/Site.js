$(document).ready(function () {
    var uri = '/api/Twilio';

    $("#btnSendMessage").click(function () {
        var phone = $('#PhoneNumber').val();
        var message = $('#TextMessage').val();
        var formData = { PhoneNumber: phone, TextMessage: message };
        $.ajax({
            url: uri,
            type: "POST",
            data: formData,
            success: function (data, textStatus, jqXHR) {
                $('#resultMessage').text(data);
            },
            error: function (jqXHR, textStatus, errorThrown) {
                $('#resultMessage').text('Error: ' + errorThrown);
            }
        });

    });
});

