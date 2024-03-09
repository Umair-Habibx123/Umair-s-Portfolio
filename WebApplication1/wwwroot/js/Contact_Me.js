function sendEmail() {
    var recipient = document.getElementById('recipientEmail').value;
    var subject = document.getElementById('SenderName').value;
    var body = document.getElementById('message').value;

    // AJAX request to send email
    var xhr = new XMLHttpRequest();
    xhr.open("POST", "/sendEmail", true);
    xhr.setRequestHeader("Content-Type", "application/json");

    xhr.onreadystatechange = function () {
        if (xhr.readyState === 4 && xhr.status === 200) {
            alert("Email sent successfully.");
        } else if (xhr.readyState === 4 && xhr.status !== 200) {
            alert("Error sending email: " + xhr.responseText);
        }
    };

    var data = JSON.stringify({ recipient: recipient, subject: subject, body: body });
    xhr.send(data);
}