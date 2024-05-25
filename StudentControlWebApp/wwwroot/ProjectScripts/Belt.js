//#region Declaración de Variables
//#endregion Declaración de Variables

//#region Acciones

LoadBelts();

//#endregion Acciones

//#region Funciones

function LoadBelts(){
    $.ajax({
        url: SITE_ROOT + "Belt/GetBelts",
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        type: "POST",        
        success: function success(tableData) {
            $('#beltTable').bootstrapTable('load', tableData);
        }
    });
}


//#endregion Funciones