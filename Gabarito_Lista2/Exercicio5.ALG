// Construa um algoritmo que leia 500 valores inteiros e positivos aleatórios
// e imprima os seguintes valores:
// ** Maior número ** Menor número ** Média dos 500 números

Algoritmo "Exercicio5"

Var
   num_casas, casa: inteiro
   qtde_graos, soma_graos: inteiro
Inicio
   num_casas <- 3
   qtde_graos <- 1
   soma_graos <- 1
   casa <- 1

   para casa de 2 ate 16 faca
      qtde_graos <- 2 * qtde_graos
      soma_graos <- soma_graos + qtde_graos
   fimpara
   escreval("O monge deve receber", soma_graos, " grãos")

Fimalgoritmo