"use strict";

// const arrayProfessores = ["Sobrino", "Rangel"];
const arrayVariado = [5, true, "ADS"];
const arrayProfessores = [];
arrayProfessores[0] = "Sobrino";
arrayProfessores[1] = "Rangel";

// Métodos javascript
// Adiciona elementos no inicio do array
arrayProfessores.unshift("Guerra");

// Remove elementos a partir do começo do array
arrayProfessores.shift();

// Mostra na tela o elemento que foi deletado
let elementoRemovido = arrayProfessores.shift();
console.log(elementoRemovido);

// Adiciona elementos no final do array
arrayProfessores.push("Maua");

// Remove elementos a partir do final do array
arrayProfessores.pop();

arrayProfessores.splice(0, 1);
arrayProfessores.splice(1, 0, "Rangel");

// Ordena o array
arrayProfessores.sort();


// Chamadas

console.log(arrayProfessores);
console.log("Tipo do elemento 1", typeof arrayVariado[1]);
console.table(arrayProfessores);
console.log("Tipo", typeof arrayProfessores);
console.log("Quantidade de elementos", arrayProfessores.length);



// Atividade Prática
const arrayNotas = [2, 10, 3.7, 7.8, 5.5, 6.2, 10, 8, 9, 9];

// for (let i = 0; i < arrayNotas.length; i++){
//     console.log("Média", (i + 1), "é:", arrayNotas[i]);
// }

// Função de callback
arrayNotas.forEach((element, index) => {
    console.log("Média", (index + 1), "é:", element)
});


