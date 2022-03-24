Algoritmo "Calcular_Bonus"

Var
   tempo_trabalho: inteiro
   salario: real

Inicio
   escreval("Informe o seu tempo de trabalho:")
   leia(tempo_trabalho)
   escreval("Informe seu salário atual:")
   leia(salario)
   se (tempo_trabalho >= 5) entao
      escreval("O bônus a ser recebido é de ",salario*0.20, " reais")
   senao
      escreval("O bônus a ser recebido é de ",salario*0.10, " reais")
   fimse
Fimalgoritmo