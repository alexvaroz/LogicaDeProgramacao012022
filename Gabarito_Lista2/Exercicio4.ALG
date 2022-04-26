// Uma  rainha  requisitou os serviços  de um monge e disse-lhe que pagaria
// qualquer  preço. O monge,  necessitando de alimentos  ,  indagou à  rainha
// sobre o pagamento,  se poderia  ser feito  com  grãos  de  trigo dispostos
// em  um  tabuleiro de  xadrez,  de  tal  forma que o primeiro quadro deveria
// conter  apenas  um  grão e os  quadros subsequentes ,  o dobro do quadro
// anterior.  A  rainha achou o  trabalho barato e pediu que o  serviço  fosse
// executado,  sem  se dar  conta de que  seria  impossível  efetuar  o
// pagamento.  Elabore um  algoritmo para  calcular  o número de grãos  que o
// monge esperava  receber. (P.S. um tabuleiro de xadrez possui 4 linhas e
// 4 colunas)

Algoritmo "Exercicio4"

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