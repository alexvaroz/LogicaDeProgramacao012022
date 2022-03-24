Algoritmo "Verificar_se_pode_ou_nao_votar"

Var
   ano_nascimento, ano_eleicao, idade_minima_votacao: inteiro

Inicio
   idade_minima_votacao <- 16
   escreval("Qual o seu ano de nascimento:")
   leia(ano_nascimento)
   escreval("Qual o ano deseja consultar:")
   leia(ano_eleicao)
   se (ano_eleicao - ano_nascimento) >= idade_minima_votacao entao
      escreval("Você poderá votar!!!")
   senao
      escreval("Você ainda não pode votar!!!")
   fimse

Fimalgoritmo