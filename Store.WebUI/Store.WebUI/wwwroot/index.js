﻿'use strict';
// Load all products
const inboxTable = document.getElementById('product-table');
const errorMessage = document.getElementById('error-message');

loadProducts()
    .then(products => {
        for (const message of products) {
            const row = inboxTable.insertRow();
            row.innerHTML = `<td>${message.id}</td>
                             <td>${message.type}</td>
                             <td>${message.name}</td>
                             <td>${message.price}</td>`;
        }

        inboxTable.hidden = false;

    })
    .catch(error => {
        errorMessage.textContent = error.toString();
        errorMessage.hidden = false;
    });

// Load store inventory
const userStore = document.getElementById('store-item1').value;
console.log(userStore);