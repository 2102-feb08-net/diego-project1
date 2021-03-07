'use strict';

const loginForm = document.getElementById('login-form');
const successMessage = document.getElementById('error-msg');
const errorMessage = document.getElementById('success-msg');

loginForm.addEventListener('submit', event => {
    event.preventDefault();
    successMessage.hidden = true;
    errorMessage.hidden = true;

    const email = loginForm.elements['LogInEmail'].value;
    const password = loginForm.elements['LogInPassword'].value;

    console.log(email + " " + password);

    loadCustomer(email, password)
        .then(customer => {
            console.log("email: " + customer.Email + " pass: " + customer.Password);

            if (email == customer.Email) {
                if (password == customer.Password) {
                    sessionStorage.setItem('accountMail', customer.Email);
                    sessionStorage.setItem('accountFirstName', customer.FirstName);
                    sessionStorage.setItem('accountLastName', customer.LastName);
                    window.location = "customerhome.html";
                }
                else {
                    alert("Incorrect password. Try again.");
                }
            }
            else {
                alert("Error404: Email not found");
            }
        })
        .catch(error => {
            errorMessage.textContent = error.toString();
            errorMessage.hidden = false;
        });
});