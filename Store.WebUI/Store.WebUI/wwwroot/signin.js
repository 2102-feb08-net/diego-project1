'use strict';
// Set up
const registrationForm = document.getElementById('registration-form');
const successMessage = document.getElementById('error-msg');
const errorMessage = document.getElementById('success-msg');

// Event listener
registrationForm.addEventListener('submit', event => {
    event.preventDefault();
    successMessage.hidden = true;
    errorMessage.hidden = true;

    const signinForm = {
        FirstName: registrationForm.elements['FirstName'].value,
        LastName: registrationForm.elements['LastName'].value,
        Email: registrationForm.elements['Email'].value,
        Password: registrationForm.elements['Password'].value,
        PassWordRepeat: registrationForm.elements['PasswordRepeat'].value,
        Admin: false
    };

    // Password validation
    if (signinForm.Password != signinForm.PassWordRepeat) {
        console.log("Passwords must match.");
        return false;
    }

    console.log(signinForm)

    sendSignInForm(signinForm)
        .then(() => {
            successMessage.textContent = 'Signup successful';
            successMessage.hidden = true;
            alert("Signup successful");
            setTimeout(() => { window.location = "index.html";}, 8000);
        })
        .catch(error => {
            errorMessage.textContent = error.toString();
            errorMessage.hidden = false;
        });
});

