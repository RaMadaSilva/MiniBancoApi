# MiniBancoApi

Escopo:

O sistema deve permitir o gerenciamento de contas bancárias para dois tipos de usuários: Cliente e Funcionário.

## Funcionalidades para Funcionários:

1. Criar contas de usuários: Os funcionários devem ter a capacidade de criar contas para os clientes. Durante a criação da conta, um montante inicial deve ser depositado.
2. Realizar depósitos e Levantamentos: Os funcionários devem ter a capacidade de realizar depósitos e Levantamento nas contas dos clientes. Para isso, o funcionário deve informar o ID do cliente e o tipo de operação a ser realizada.

## Funcionalidades para Clientes:

1. Dados do cliente: O sistema deve armazenar os seguintes dados dos clientes: primeiro nome, último nome, número do BI, telefone e email. É importante garantir que não haja clientes cadastrados com o mesmo email ou número de telefone.
2. Operações bancárias: Os clientes devem poder realizar as seguintes operações bancárias:
   a) Levantamento: Permitir que os clientes façam levantamentos de dinheiro de suas contas.
   b) Transferência: Permitir que os clientes transfiram dinheiro de sua conta para outra conta bancária.
   c) Pagamentos: Permitir que os clientes realizem pagamentos a partir de suas contas.

É importante considerar os seguintes pontos adicionais:

- Segurança: O sistema deve ter recursos adequados de segurança para proteger as informações dos clientes e garantir transações seguras.
- Integridade dos dados: O sistema deve validar os dados fornecidos durante a criação de contas e operações bancárias para garantir a integridade dos dados e evitar erros.
- Usabilidade: O sistema deve ser intuitivo e fácil de usar tanto para funcionários quanto para clientes. A interface do usuário deve ser clara e amigável.
- Relatórios: O sistema pode fornecer recursos de geração de relatórios para que os funcionários possam obter informações sobre as transações realizadas, saldos de contas, entre outros dados relevantes.

Alguns Diagramas:

## 1. Diagrama de caso de Uso:

![image](https://github.com/RaMadaSilva/MiniBancoApi/assets/91338367/c29dd54c-e93c-419d-ac83-c77a3611e634)

## 2. Diagrama de Classe

![image](https://github.com/RaMadaSilva/MiniBancoApi/assets/91338367/6ce624e8-d530-49b7-a6af-46606ceddf84)
