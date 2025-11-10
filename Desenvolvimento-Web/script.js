"use strict";

// document.getElementById("saida").textContent = "Hello, world!!!";


// Variáveis 
// const notaP1 = document.getElementById("p1");
// const notaP2 = document.getElementById("p2");
const btnCalcular = document.getElementById("btnCalcular");
const saida = document.getElementById("saida");


// Funções 
function obterNota(nota){
    return +document.getElementById(nota).value;
}



function cauculaMedia(p1, p2){
    const media = (p1 + (p2 * 2)) / 3;
    return media;
}

function exibirSaida(s, content){
    const mensagem = s;
    return mensagem.textContent = content;
}

function validaNota(nota){
    return nota >= 0 && nota < 11;
}

function onClick(){
    const p1 = obterNota("p1");
    const p2 = obterNota("p2");

    if(validaNota(p1) && validaNota(p2)){
        const mediaCalculada = cauculaMedia(p1, p2);
        exibirSaida(saida, mediaCalculada.toFixed(2));
        console.log(mediaCalculada);
    }
    else{
        exibirSaida(saida, "As notas devem ser validas");
        console.log("As notas devem ser validas");
    }
    
    
}

// Event listeners

btnCalcular.addEventListener("click", onClick);
// saida.textContent = "Hello, world!!!";

