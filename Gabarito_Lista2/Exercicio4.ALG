// Uma  rainha  requisitou os servi�os  de um monge e disse-lhe que pagaria
// qualquer  pre�o. O monge,  necessitando de alimentos  ,  indagou �  rainha
// sobre o pagamento,  se poderia  ser feito  com  gr�os  de  trigo dispostos
// em  um  tabuleiro de  xadrez,  de  tal  forma que o primeiro quadro deveria
// conter  apenas  um  gr�o e os  quadros subsequentes ,  o dobro do quadro
// anterior.  A  rainha achou o  trabalho barato e pediu que o  servi�o  fosse
// executado,  sem  se dar  conta de que  seria  imposs�vel  efetuar  o
// pagamento.  Elabore um  algoritmo para  calcular  o n�mero de gr�os  que o
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
   escreval("O monge deve receber", soma_graos, " gr�os")

Fimalgoritmo