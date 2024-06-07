# Sistema De Multas
Sistema Crud De Multas utilizando .Net 8 e JWT Token para Backend e Angular 17 para Frontend

- CRUD de multas.
- Autenticação de usuários.
- Permissão de usuário para edição e exclusão. 

# Pontos Obrigatórios
- CRUD de cadastro de Multas:
 - Os usuários podem criar e visualizar as multas.
 - A edição e exclusão só podem ser feitas pelo administrador do sistema.
- Autenticação de usuários:
 - Implemente autenticação dos usuários.
- Autorização para o CRUD de Multas:
 - Apenas usuários autorizados podem editar e excluir multas.
 - Somente o administrador do sistema poderá executar as ações de exclusão e alteração dos dados cadastrados
nas multas.

# Funcionalidades
- CRUD de cadastro de Multas:
 - Os usuários podem criar e visualizar as multas.
 - A edição e exclusão só podem ser feitas pelo administrador do sistema.
- Autenticação de usuários:
 - Implementar autenticação dos usuários utilizando JWT (JSON Web Tokens) fornecidos pela Microsoft.
- Autorização para o CRUD de Multas:
 - Apenas usuários autorizados podem visualizar, editar e excluir multas.
 - Somente o administrador do sistema poderá executar as ações de exclusão e alteração dos dados cadastrados
nas multas.

# Campos Necessários para Cadastro de Multas
1. Número do AIT: Campo obrigatório para identificar unicamente a infração.
2. Data, Hora, Minuto da Infração: Campo obrigatório para registrar quando a infração ocorreu.
3. Código da Infração: Campo obrigatório para categorizar o tipo de infração cometida.
4. Placa do Veículo: Campo obrigatório para identificar o veículo envolvido na infração.

# Tecnologias Utilizadas
1..Net Core 8
2. SqlServer
3. Angular 17

