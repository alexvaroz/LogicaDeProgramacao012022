Algoritmo "Somar_idade_homens_mulheres"

Var
   idade_primeiro_homem, idade_segundo_homem:inteiro
   idade_primeira_mulher, idade_segunda_mulher:inteiro
   idade_homem_mais_velho, idade_homem_mais_novo: inteiro
   idade_mulher_mais_velha, idade_mulher_mais_nova: inteiro

Inicio
   escreval("Informe a idade do primeiro homem:")
   leia(idade_primeiro_homem)
   escreval("Informe a idade do segundo homem:")
   leia(idade_segundo_homem)
   escreval("Informe a idade da primeira mulher:")
   leia(idade_primeira_mulher)
   escreval("Informe a idade da segunda mulher:")
   leia(idade_segunda_mulher)
   se (idade_primeiro_homem > idade_segundo_homem) entao
      idade_homem_mais_velho <- idade_primeiro_homem
      idade_homem_mais_novo <- idade_segundo_homem
   senao
      idade_homem_mais_novo <- idade_primeiro_homem
      idade_homem_mais_velho <- idade_segundo_homem
   fimse
   se (idade_primeira_mulher > idade_segunda_mulher) entao
      idade_mulher_mais_velha <- idade_primeira_mulher
      idade_mulher_mais_nova <- idade_segunda_mulher
   senao
      idade_mulher_mais_nova <- idade_primeira_mulher
      idade_mulher_mais_velha <- idade_segunda_mulher
   fimse
   escreval("A soma das idades do homem mais velho com a mulher mais nova é ", idade_homem_mais_velho + idade_mulher_mais_nova)
   escreval("O produto das idades do homem mais novo com a mulher mais velha é ", idade_homem_mais_novo * idade_mulher_mais_velha)
Fimalgoritmo