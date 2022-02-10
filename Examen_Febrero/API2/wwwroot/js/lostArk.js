window.onload = inicializaEventos;
function inicializaEventos() {
    rellenarTabla();
    document.getElementById("btnGuardar").addEventListener("click", insertarPlanta, false);
    document.getElementById("btnEliminar").addEventListener("click", eliminarPlanta, false);
}
function insertarPlanta() {
    var oPlanta = new clsPlanta();
    oPlanta.nombre = document.getElementById("txtBName").value
    oPlanta.descripcion = document.getElementById("txtBDesc").value
    var miLlamada = new XMLHttpRequest();
    var json = JSON.stringify(oPlanta);
    miLlamada.open("POST", "http://localhost:63921/api/planta");
    miLlamada.setRequestHeader('Content-type', 'application/json; charset=utf-8');
    miLlamada.onreadystatechange = function () {
        if (miLlamada.readyState == 4 && miLlamada.status == 200) {
            alert(miLlamada.value)
        }
    }
    miLlamada.send(json)
}
function rellenarTabla() {
    document.getElementById("charge").style.display = "block";
    var miLlamada = new XMLHttpRequest();
    miLlamada.open("GET", "http://localhost:63921/api/planta");
    miLlamada.onreadystatechange = function () {
        if (miLlamada.readyState == 4 && miLlamada.status == 200) {
            var arrayPlantas = JSON.parse(miLlamada.responseText);
            crearTabla(arrayPlantas);
            crearSelect(arrayPlantas);
        }
        else {
            controlarErrores(miLlamada.status);
        }
    }
    miLlamada.send();
}

function crearTabla(arrayPlantas) {
    for (var i = 0; i < arrayPlantas.length; i++) {
        var fila = document.createElement("tr");
        var columnaId = document.createElement("td");
        var columnaName = document.createElement("td");
        var columnaApellidos = document.createElement("td");
        columnaId.innerHTML = arrayPlantas[i].idPlanta
        columnaName.innerHTML = arrayPlantas[i].nombre
        columnaApellidos.innerHTML = arrayPlantas[i].descripcion
        fila.appendChild(columnaId)
        fila.appendChild(columnaName)
        fila.appendChild(columnaApellidos)
        document.getElementById("tablaPlantas").appendChild(fila)
    }
    document.getElementById("charge").style.display = "none";
    document.getElementById("tablaPlantas").style.display = "block";
}
function crearSelect(arrayPlantas) {
    for (var i = 0; i < arrayPlantas.length; i++) {
        var option = document.createElement("option");
        option.value = arrayPlantas[i].idPlanta;
        option.innerHTML = arrayPlantas[i].nombre;
        document.getElementById("selectBorrar").appendChild(option);
    }
}
function eliminarPlanta() {
    var id = document.getElementById("selectBorrar").value;
    var miLlamada = new XMLHttpRequest();
    miLlamada.open("DELETE", "http://localhost:63921/api/planta/" + id);
    miLlamada.onreadystatechange = function () {
        if (miLlamada.readyState == 4 && miLlamada.status == 200) {
                alert("Creo que se ha borrado")
        }
    }
    miLlamada.send();
    location.reload();
}
function controlarErrores(int) {
    switch (int) {
        case 404: document.getElementById("error").innerHTML = "SEXOOOOO"
            break;
        case 500: alert("Hey500")
            break;
    }
}
class clsPlanta{
    constructor(nombre, descripcion) {
        this.nombre = nombre;
        this.descripcion = descripcion;
    }
}
