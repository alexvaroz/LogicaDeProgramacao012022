// Elabore um algoritmo no qual leia duas notas bimestrais e informe se
// o aluno foi aprovado ou não.
// Nota: Considere aprovado se a média aritmética entre as notas for maior
// que 5.0.

Algoritmo "Exercicio1"

Var
   nota1, nota2, media: real
Inicio
   escreval("Informe a nota 1:")
   leia(nota1)
   escreval("Informe a nota 2:")
   leia(nota2)
   media <- (nota1 + nota2)/2
   se (media >= 5) entao
      escreval("Você foi aprovado!!!")
   senao
      escreval("Você foi reprovado...")
   fimse
fimalgoritmo




Fimalgoritmo