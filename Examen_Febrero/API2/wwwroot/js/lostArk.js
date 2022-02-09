window.onload = inicializaEventos;
function inicializaEventos() {
    rellenarTabla();
}
function rellenarTabla() {
    var miLlamada = new XMLHttpRequest();
    miLlamada.open("GET", "http://localhost:63921/api/planta");
    miLlamada.onreadystatechange = function () {
        if (miLlamada.readyState == 4 && miLlamada.status == 200) {
            var arrayPlantas = JSON.parse(miLlamada.responseText);
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
        }
        else {
            controlarErrores(miLlamada.status);
        }
    }
    miLlamada.send();
}
function controlarErrores(int) {
    switch (int) {
        case 404: document.getElementById("error").innerHTML = "SEXOOOOO"
            break;
        case 500: alert("Hey500")
            break;
    }
}
