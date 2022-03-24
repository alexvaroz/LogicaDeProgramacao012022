Algoritmo "Se_Numero_maior_menor_ou_igual_zero"

Var
   numero: inteiro

Inicio
   escreval("Bom dia!!!!")
   escreval("Informe um número inteiro:")
   leia(numero)
   se (numero > 0) entao
      escreval("O número informado é POSITIVO!!!")
   senao
      se (numero = 0) entao
         escreval("O número informado é 0!!!")
      senao
         escreval("O número informado é NEGATIVO!!!")
      fimse
   fimse
Fimalgoritmo