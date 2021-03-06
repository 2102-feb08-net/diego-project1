'use strict';

const loginForm = document.getElementById('login-form');
const successMessage = document.getElementById('error-msg');
const errorMessage = document.getElementById('success-msg');

loginForm.addEventListener('submit', event => {
    event.preventDefault();
    successMessage.hidden = true;
    errorMessage.hidden = true;

    const email = loginForm.elements['LogInEMail'].value;
    const password = loginForm.elements['LogInPassword'].value;

    // Login validation
});