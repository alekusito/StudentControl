//#region Declaración de Variables
//#endregion Declaración de Variables

//#region Acciones

LoadPersons();

//#endregion Acciones

//#region Funciones

function PersonModel(){
    this.IndividualId;
    this.DocumentNumber;
    this.FirstName; 
    this.MiddleName;
    this.LastName;
    this.SecondLastName;
    this.BirthDate;
    this.Address;
    this.PhoneNumber;
    this.CellphoneNumber;
    this.MailAddress
}

function LoadPersons(){
    $.ajax({
        url: SITE_ROOT + "Person/GetPersons",
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        type: "POST",        
        success: function success(tableData) {
            $('#personTable').bootstrapTable('load', tableData);
        }
    });
}

// function SavePersonDummy(){
// debugger;
//     var person = new PersonModel();
//     person.DocumentNumber = '1714233655';
//     person.FirstName = 'Alejandro';
//     person.MiddleName = 'Patricio';
//     person.LastName = 'Villagran';
//     person.SecondLastName = 'Palacio';
//     person.BirthDate = '07/08/1982';
//     person.Address = 'Carcelén';
//     person.PhoneNumber = '2471466';
//     person.CellphoneNumber = '0992779709';
//     person.MailAddress = 'alekusito@yahoo.com';

//     $.ajax({
//         url: SITE_ROOT + "Person/SavePerson",
//         data: {person: person},
//         type: "POST",        
//         success: function success(data) {
//             debugger;
//             LoadPersons()
//         }
//     });
// }


//#endregion Funciones