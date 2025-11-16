"use strict";

class Professor {
    constructor (nome, idade, estaEmAula){
        this.nome = nome;
        this.idade = idade;
        this.estaEmAula = estaEmAula;
    }
}

const obj1 = {};

const obj2 = {
    nome: "Rodrigo",
    idade: 21,
    estaEmAula: true
};

const obj3 = new Professor("Guerra", 36, false);
const obj4 = new Professor("Léo", 28, true);

// const arrayObjetos = [obj2, obj3, obj4]

const arrayObjetos = [];
arrayObjetos.push(obj2);
arrayObjetos.push(obj3);
arrayObjetos.push(obj4);

console.table(arrayObjetos);
console.log(arrayObjetos[0].nome);
console.log(arrayObjetos[0].nome.length);

const strJSON = JSON.stringify(arrayObjetos);
console.log("Array de objetos --> string JSON:")
console.log(strJSON);

const arrayObJSON = JSON.parse(strJSON);
console.log("string JSON --> array de objetos:");
console.log(arrayObJSON);


console.log(obj2);
console.log(typeof obj2);
console.log(typeof obj2.nome)
console.log(obj2.nome.length);


obj2.nome = "Raw"
let nomeObj = obj2.nome;
console.log(nomeObj);

delete obj2.idade;
obj2.idade = 23; 



console.table(obj2);



