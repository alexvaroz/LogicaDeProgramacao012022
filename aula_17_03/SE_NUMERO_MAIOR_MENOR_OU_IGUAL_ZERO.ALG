Algoritmo "Se_Numero_maior_menor_ou_igual_zero"

Var
   numero: inteiro

Inicio
   escreval("Bom dia!!!!")
   escreval("Informe um n�mero inteiro:")
   leia(numero)
   se (numero > 0) entao
      escreval("O n�mero informado � POSITIVO!!!")
   senao
      se (numero = 0) entao
         escreval("O n�mero informado � 0!!!")
      senao
         escreval("O n�mero informado � NEGATIVO!!!")
      fimse
   fimse
Fimalgoritmo