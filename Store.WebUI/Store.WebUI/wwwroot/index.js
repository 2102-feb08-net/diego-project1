'use strict';
// Load all products
const homeTable = document.getElementById('product-table');
const storeTable = document.getElementById('store-product-table');
const errorMessage = document.getElementById('error-message');

loadProducts()
    .then(products => {
        for (const item of products) {
            const row = homeTable.insertRow();
            row.innerHTML = `<td>${item.id}</td>
                             <td>${item.type}</td>
                             <td>${item.name}</td>
                             <td>${item.price}</td>`;
        }

        homeTable.hidden = false;

    })
    .catch(error => {
        errorMessage.textContent = error.toString();
        errorMessage.hidden = false;
    });

// Load store inventory
function loadInventory(store) {
    const locStore = document.getElementById(store);
    const storeId = locStore.value;

    var url = storeId !== undefined ? `api/store/products?storeid=${storeId}` : 'api/store/products';
    return fetch(url).then(response => {
        if (!response.ok) {
            throw new Error(`Network response not ok (${response.status})`);
        }
        return response.json();
    })
        .then(products => {
            homeTable.hidden = true;
            for (const item of products) {
            const row = storeTable.insertRow();
            row.innerHTML = `<td>${item.id}</td>
                             <td>${item.type}</td>
                             <td>${item.name}</td>
                             <td>${item.price}</td>`;
        }

            storeTable.hidden = false;

    })
        .catch(error => {
            errorMessage.textContent = error.toString();
            errorMessage.hidden = false;
        });
}