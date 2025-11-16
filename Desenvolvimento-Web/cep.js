"use strict";

const cep = document.getElementById("cep");
const btnPesquisar = document.getElementById("btnPesquisar");
const saida = document.getElementById("saida");


function btnClick(){

}

function obterCep(){
    return cep.value;
}

async function buscarDadosCep(){
    const urlViaCep = "https://viacep.com.br/ws/" + obterCep() + "/json/";
    // const trazerCep = fetch(urlViaCep);
    // const resposta = await trazerCep;
    
    try{
        const resposta = await fetch(urlViaCep);

        if(!resposta.ok){
            throw new Error ("Erro na requisição");
        }

        const dadosJSON = await resposta.json();


        console.log(typeof(dadosJSON));
        console.log(dadosJSON);

        // console.log(typeof(dadosJSON.logradouro));
        // console.log(dadosJSON.estado);
        if(!dadosJSON.erro){
            saida.innerHTML = gerarStringEndereço(dadosJSON);
        }
        else{
            saida.innerHTML = "CEP inexistente";
        }
        
    } catch(e){
        saida.innerHTML = `Erro ao buscar CEP`;
    }
}

 function gerarStringEndereço(infoCep){
    const logra = infoCep.logradouro;
    const localidade = infoCep.localidade;
    const bairro = infoCep.bairro;
    const uf = infoCep.uf;

    return logra + "<br>" + bairro + "<br>" +  localidade + "/" + uf;
 }



// EVENT LISTENER
btnPesquisar.addEventListener("click", buscarDadosCep);

