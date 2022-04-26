// Construa um algoritmo que leia 500 valores inteiros e positivos aleatórios
// e imprima os seguintes valores:
// ** Maior número ** Menor número ** Média dos 500 números

Algoritmo "Exercicio5"

Var
   numero, maior_numero, menor_numero: inteiro
   media_numeros: real
   soma_numeros: inteiro
   qtde_numeros: inteiro

Inicio
   qtde_numeros <- 1
   numero <- RandI(500)
   maior_numero <- numero
   menor_numero <- numero
   soma_numeros <- numero
   enquanto qtde_numeros <= 500 faca
      se (numero > maior_numero) entao
         maior_numero <- numero
      fimse
      se (numero < menor_numero) entao
         menor_numero <- numero
      fimse
      escreval(qtde_numeros)
      escreval(numero)
      soma_numeros <- soma_numeros + numero
      qtde_numeros <- qtde_numeros + 1
      numero <- RandI(500)
   fimenquanto
   escreval("Maior número:",maior_numero)
   escreval("Menor número:",menor_numero)
   escreval("Média dos 500 números:",soma_numeros/500)

Fimalgoritmo