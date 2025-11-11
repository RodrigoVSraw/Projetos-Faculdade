
// Parte 1
"use strict";

let p1, p2;

// Funções

function caucularMedia (p1, p2){
    const media = (p1 + 2 * p2)/3;
    return media.toFixed(2);
}

function somarNum(n1, n2){
    const soma = n1 + n2;
    return soma;
}

// Colocando a função em uma váriavel. Usando os valores padrão '0' para receber argumentos não definidos.
const somarNumero = function(n1=0, n2=0){
    return n1 + n2;
}

const mediaAluno2 = caucularMedia(6, 8);

// Operador ternário no return
const parOuImparV2 = function(num){
    return (num%2 == 0) ? "Par" : "Ímpar";
}
// Função seta
const somarNumV2 = (n1=0, n2=0) => n1 + n2;



// Chamadas

console.log(caucularMedia(4, 6));

console.log(`A média do aluno 2 é: ${mediaAluno2}`);

console.log("A soma é ", somarNumero(25, 17));

console.log(parOuImparV2(3));

console.log(somarNumV2(4, 3));






// Atividade Prática 

// Usando loops
for (let i = 1; i <=10; i++){
    console.log(i);
}

let j = 10;
while (j >= 0){
    console.log(j);
    j--;
}

let i = 2;
do {
    console.log(i);
    i += 2;

} while (i <= 20)

// Função
function parOuImpar (num){
    if(num % 2 == 0){
        return "Par";
    }
    else {
        return "Ímpar";
    }
}

console.log("O número é ", parOuImpar(2));

