'use strict';

// Load all Store products
function loadProducts() {
    return fetch('api/product/all').then(response => {
        if (!response.ok) {
            throw new Error(`Network response not ok (${response.status})`);
        }
        return response.json();
    });
}

// Send new customer registration form
function sendSignInForm(signinForm) {
    return fetch('api/customer/registration', {
        method: 'POST',
        headers: {
            'Content-type': 'application/json'
        },
        body: JSON.stringify(signinForm)
    }).then(response => {
        if (!reposnse.ok) {
            throw new Error(`Network response not ok (${response.status})`);
        }
    });
}
