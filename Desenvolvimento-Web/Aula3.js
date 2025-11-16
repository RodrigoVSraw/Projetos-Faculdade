const arrayNums = [25, 21, 8, "26", 26 , 48, 2, 26];

// Ex1
function excluirElemento(array, num){
    const indiceElemento = array.idexof(num);
    if (indiceElemento != -1){
        return array.splice(indiceElemento, 1);
    }
    else{
        return false;
    }
}

const elementoExcluido = excluirElemento(arrayNums, 21);
console.log("Tentativa de excluir Num:", (elementoExcluido));
// Maneira curta
return (indiceElemento != -1) ? array.splice(indiceElemento, 1) : false;



function excluirElemento(array, num){
    const copiaArrayNums = array.slice();
    const indiceElemento = copiaArrayNums.indexof(num);
    while (indiceElemento != -1){
        copiaArrayNums.splice(indiceElemento, 1);
        indiceElemento = copiaArrayNums.indexof(num);
    }
    return copiaArrayNums;
}

console.log(excluirElemento(arrayNums, 3));


function existeNoArray(array, num){
    return (array.includes(num)) ? 1 : 0
}

let procurandoElementos = existeNoArray(arrayNums, "26")
console.log(procurandoElementos);