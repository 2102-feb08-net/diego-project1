'use strict';
// Set up
const registrationForm = document.getElementById('registration-form');
const successMessage = document.getElementById('error-msg');
const errorMessage = document.getElementById('success-msg');

// Get data from form in signup.html
var firstName = document.getElementById('FirstName');
var lastName = document.getElementById('LastName');
var email = document.getElementById('Email');
var password = document.getElementById('Password');
var passwordRepeat = document.getElementById('PasswordRepeat');



// Event listener
registrationForm.addEventListener('submit', event => {
    event.preventDefault();
    successMessage.hidden = true;
    errorMessage.hidden = true;

    // Validate Data
    if (firstName == '' || lastName == '' || email == '') {
        console.log("Filed must not be empty.");
        // Refresh page
    }

    if (password != passwordRepeat) {
        console.log("Passwords must match.");
        // Refresh page
    }

    const signinForm = {
        FirstName: firstName,
        LastName: lastName,
        Email: email,
        Password: password
    };

    sendSignInForm(signinForm)
        .then(() => {
            successMessage.textContent = 'Signup successful';
            successMessage.hidden = false;
        })
        .catch(error => {
            errorMessage.textContent = error.toString();
            errorMessage.hidden = false;
        });
});
