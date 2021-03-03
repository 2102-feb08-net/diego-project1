'use strict';
// Get data from form in signup.html 
var firstName = document.getElementById('FirstName');
var lastName = document.getElementById('LastName');
var email = document.getElementById('Email');
var password = document.getElementById('Password');
var passwordRepeat = document.getElementById('PasswordRepeat');

// Validate Data
if (firstName == '' || lastName == '' || email == '') {
    console.log("Filed must not be empty.");
}

if (password != passwordRepeat) {
    console.log("Passwords must match.");
}

// Serialize Data and send to CustomerController