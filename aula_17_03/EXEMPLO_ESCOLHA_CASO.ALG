Algoritmo "exemplo_escolha_caso"

Var
   nivel_escolhido: caracter

Inicio
   escreval("Selecione o n�vel, de acordo com as op��es:")
   escreval("T - Treinamento")
   escreval("I - Iniciante")
   escreval("M - Mediano")
   escreval("E - Experiente")
   escreval("N - Ninja")
   leia(nivel_escolhido)
   escolha nivel_escolhido
   caso "T"
      escreval("Voc� selecionou o n�vel TREINAMENTO")
   caso "I"
      escreval("Voc� selecionou o n�vel Iniciante")
   caso "M"
      escreval("Voc� selecionou o n�vel Mediano")
   caso "E"
      escreval("Voc� selecionou o n�vel Experiente")
   caso "N"
      escreval("Voc� selecionou o n�vel Ninja")
   outrocaso
      escreval("A op��o n�o foi identificada. Tente novamente.")
   fimescolha
Fimalgoritmo