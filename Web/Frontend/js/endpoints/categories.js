/*
      "categories": {
        "route": "GET /api/categories/",
        "header": {
          "authorization": "Bearer: (token)"
        },
        "response": "list of categories"
      }
*/

function registration() {
    const xhr = new XMLHttpRequest();
    xhr.open("POST", "http://localhost:5000/api/auth/registration");

    xhr.onload = () => {
        if (xhr.status < 200 || xhr.status >= 300) {
            console.error(`Request failed. Status: ${xhr.status}`);
            return;
        }

        let response = JSON.parse(xhr.responseText);
        console.log(response);
    };

    xhr.onerror = () => {
        console.error("Network error.");
    };

    xhr.setRequestHeader("Content-Type", "application/json");
    //xhr.setRequestHeader("Authorization", "Bearer ...");

/*
    const body = {
        "username": "TestUser01",
        "email": "testuser01@email.com",
        "password": "Password01!"
    };
*/

    const body = {
        "username": e_reg_userName.value,
        "email": e_reg_email.value,
        "password": e_reg_password.value
    };

    xhr.send(JSON.stringify(body));
}

/******************************/
/******************************/
/******************************/

/*
      "add": {
        "route": "POST /api/categories/add",
        "header": {
          "authorization": "Bearer: (token)"
        },
        "body": {
          "name": "Valami",
          "type": "expense/income",
          "in_use": 0
        }
      }
*/

/******************************/
/******************************/
/******************************/

/*
      "update": {
        "route": "PATCH /api/categories/update/:id",
        "header": {
          "authorization": "Bearer: (token)"
        },
        "body": {
          "name": "something",
          "type": "expense/income",
          "in_use": 0
        }
      }
*/

/******************************/
/******************************/
/******************************/

/*
      "status": {
        "route": "PATCH /api/categories/status/:id",
        "header": {
          "authorization": "Bearer: (token)"
        }
      }
*/





