Algoritmo "Imprimir_multiplos_de_qq_numero"

Var
   n, divisor, limite: inteiro

Inicio
   escreval("Bom dia!!!")
   escreval("Qual o n�mero que deseja verificar os m�ltiplos?")
   leia(divisor)
   escreval("Qual o limite do intervalo a ser verificado?")
   leia(limite)
   para n de 0 ate limite faca
      se (n%divisor = 0) entao
         escreval(n)
      fimse
   fimpara

Fimalgoritmo