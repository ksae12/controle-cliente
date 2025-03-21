
# Sistema de Cálculo de Imposto - Bacl-End com C#

Este é um sistema simples desenvolvido como atividade do curso de Back-End do [SENAI](https://www.fiepb.com.br/senai), usando a linguagem de programação [C#](https://learn.microsoft.com/pt-br/dotnet/csharp/). O sistema implementa conceitos da POO, como abstração, herança e polimorfismo.

## Funcionalidades
- Classes abstratas e herança:
    - A classe abstrata `Cliente` serve como base para as classes `PessoaFisica` e `PessoaJuridica`

- Cálculo de Imposto:
    - Ambas as classes `PessoaFisica` e `PessoaJuridica` calculam impostos com base no valor da compra.
    - A classe `PessoaJuridica` utiliza do polimorfismo para sobreescrever o método de cálculo de imposto da classe `Cliente`.

## Exemplo de execução
 1. O sistema solicita informações básicas do cliente (nome, cpf, endereço e tipo do cliente)..
 2. O usuário fornece o valor da compra.
 3. O sistema calcula o imposto com base no tipo de cliente.
    - Pessoa Física: Aplica uma taxa de 10% de imposto.
    - Pessoa Jurídica: Aplica uma taxa de 20% de imposto.

## Tecnologias
- Linguagem C#
- POO como paradigma de programação
- IDE: Visual Studio Code

### Como executar
    1. Clone o repositório
    2. Abra o projeto na IDE
    3. Compile o código e execute o projeto
    4. Inserir os dados e veja os cálculos realizados


Este projeto foi desenvolvido como parte de uma atividade didática, apenas para entender alguns conceitos na prática, portanto é bem simples. 
