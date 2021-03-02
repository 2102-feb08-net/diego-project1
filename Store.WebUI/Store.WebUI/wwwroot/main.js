'use strict';

function loadProducts() {
    return fetch('product/all').then(response => {
        if (!response.ok) {
            throw new Error(`Network response not ok (${response.status})`);
        }
        return response.json();
    });
}