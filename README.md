# cp_cs
Checkpoint C# FIAP

João Víctor Flaitt RM553888

Este programa em C# compara a idade de dois alunos e mostra quem é o mais velho, quem é o mais novo ou se eles têm a mesma idade.

  1. Entrada de dados
    O programa pede ao usuário que digite a idade do 1º aluno e do 2º aluno.
    As idades são armazenadas em duas variáveis inteiras: age1 e age2.
  
 2.  Comparação das idades
    São utilizadas estruturas condicionais para comparar as idadades seguindo essa formatação:
      if (age1 > age2) → o 1º aluno é mais velho.
      else if (age2 > age1) → o 2º aluno é mais velho.
      else → significa que age1 == age2, ou seja, idades iguais.
     
  3. Resumo com operador condicional
     É mostrado um resumo usando o operador ternário (?:), que é uma forma curta de escrever if/else:

  4. Saída no console
    O resultado é mostrado usando Console.WriteLine.
    No final, o programa espera que o usuário pressione uma tecla antes de fechar
