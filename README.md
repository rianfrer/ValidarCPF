Validador de CPF em C#

Este projeto é um simples validador de CPF desenvolvido em C#. Ele verifica se um CPF informado pelo usuário é válido, seguindo as regras de cálculo dos dígitos verificadores.

Como funciona?
O CPF é composto por 11 dígitos, onde os dois últimos são dígitos verificadores. A validação é feita calculando esses dígitos com base nos primeiros 9.\
Regras para um CPF ser válido:
Não pode conter todos os números iguais (exemplo: 111.111.111-11).
Os dígitos verificadores devem ser calculados corretamente.

Cálculo dos dígitos verificadores
1º Dígito Verificador:
Multiplicar os 9 primeiros dígitos pelos pesos [10, 9, 8, 7, 6, 5, 4, 3, 2].
Somar os resultados.

Calcular o resto da soma dividido por 11.
Se o resto for menor que 2, o dígito é 0; caso contrário, é 11 - resto.

2º Dígito Verificador:
Multiplicar os 9 primeiros dígitos + o 1º dígito verificador pelos pesos [11, 10, 9, 8, 7, 6, 5, 4, 3, 2].
Somar os resultados.

Calcular o resto da soma dividido por 11.
Se o resto for menor que 2, o dígito é 0; caso contrário, é 11 - resto.


