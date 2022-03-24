Algoritmo "Exemplo_estrutura_repeticao"
// Devo receber 5 notas e calcular a média
Var
   nota, soma, media: real
   n: inteiro

Inicio
   soma <-0
   para n de 1 ate 5 faca
        escreval("Digite a nota:")
        leia(nota)
        soma <- soma + nota
   fimpara
   media <- soma/5
   escreval("A sua média foi ", media)

Fimalgoritmo