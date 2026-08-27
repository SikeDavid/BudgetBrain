/*
"update": {
    "route": "PATCH /api/entries/:id",
    "header": {
        "authorization": "Bearer: (token)"
    },
    "body": {
        "category_id": "id",
        "name": "Fizetés",
        "description": "Fizetés",
        "amount": 999,
        "date": "2026-04-01",
        "completed": 1
    }
},
*/

function entriesUpdate(id) {
    const body = {
        "category_id": e_in_entUp_catId.value,
        "name": e_in_entUp_name.value,
        "amount": e_in_entUp_amt.value,
        "description": e_in_entUp_desc.value,
        "date": e_in_entUp_date.value,
        "completed": e_cbx_entUp_comp.checked ? 1 : 0
    };

    ajax({
        caller: entriesUpdate,
        method: "PATCH",
        url: `${API_PATH}/entries/${id}`,
        body: body,
        auth: true,
        callbackSuccess: entriesUpdateSuccess,
        callbackError: entriesUpdateError
    });
}

/******************************/
/******************************/
/******************************/

function entriesUpdateSuccess(response) {
    console.log(response);
}

/******************************/
/******************************/
/******************************/

function entriesUpdateError(response) {
    console.error(response);
}
