'use strict';

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
            row.addEventListener('click', () => {
                sessionStorage.setItem('messageId', message.id);
                location = 'index.html';
            });
        }

        inboxTable.hidden = false;

    })
    .catch(error => {
        errorMessage.textContent = error.toString();
        errorMessage.hidden = false;
    });