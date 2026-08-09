/*
      "entry": {
        "route": "GET /api/entries/:id",
        "header": {
          "authorization": "Bearer: (token)"
        },
        "response": {
          "entry_id": 1,
          "name": "Élelmiszer",
          "description": "Bolt",
          "amount": -12000,
          "date": "2026-04-03",
          "completed": 1
        }
      }
*/

/******************************/
/******************************/
/******************************/

/*
      "entries": {
        "route": "GET /api/entries?year=2026&month=4",
        "header": {
          "authorization": "Bearer: (token)"
        },
        "response": "list of entries"
      }
*/

/******************************/
/******************************/
/******************************/

/*
      "add": {
        "route": "POST /api/entries/",
        "header": {
          "authorization": "Bearer: (token)"
        },
        "body": {
          "categoryid": "id",
          "amount": "number",
          "description": "text",
          "date": "date"
        },
        "response": {
          "message": "Entry created",
          "entryid": "id"
        }
      }
*/

/******************************/
/******************************/
/******************************/

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
      }
*/

/******************************/
/******************************/
/******************************/

/*
      "complete": {
        "route": "PATCH /api/entries/:id/complete",
        "header": {
          "authorization": "Bearer: (token)"
        },
        "response": {
          "message": "Entry status changed"
        }
      }
*/

/******************************/
/******************************/
/******************************/

/*
      "delete": {
        "route": "DELETE /api/entries/:id",
        "header": {
          "authorization": "Bearer: (token)"
        },
        "response": {
          "message": "Entry deleted"
        }
      }
*/









