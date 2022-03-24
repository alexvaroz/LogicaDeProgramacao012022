Algoritmo "exemplo_escolha_caso"

Var
   nivel_escolhido: caracter

Inicio
   escreval("Selecione o nível, de acordo com as opções:")
   escreval("T - Treinamento")
   escreval("I - Iniciante")
   escreval("M - Mediano")
   escreval("E - Experiente")
   escreval("N - Ninja")
   leia(nivel_escolhido)
   escolha nivel_escolhido
   caso "T"
      escreval("Você selecionou o nível TREINAMENTO")
   caso "I"
      escreval("Você selecionou o nível Iniciante")
   caso "M"
      escreval("Você selecionou o nível Mediano")
   caso "E"
      escreval("Você selecionou o nível Experiente")
   caso "N"
      escreval("Você selecionou o nível Ninja")
   outrocaso
      escreval("A opção não foi identificada. Tente novamente.")
   fimescolha
Fimalgoritmo