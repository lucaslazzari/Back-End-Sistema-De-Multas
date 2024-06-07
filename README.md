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
- .Net Core 8.
- SqlServer.
- Angular 17.

# Packages para instalar no Back-end
<h4>Camada API</h4>
- Microsoft.EntityFrameworkCore.Design.
- Microsoft.AspNetCore.Authentication.JwtBearer.
- FluentValidation.AspNetCore.
- FluentValidation
<h4>Camada Application</h4>
- FluentValidation
<h4>Camada Insfrastructure</h4>
- Microsoft.EntityFrameworkCore.Tools.
- Microsoft.EntityFrameworkCore.SqlServer.

# Mudanças para rodar o codigo Back-end
- Alterar string de conexão no appsettings.json
- Utilizar o comando dotnet ef database update -s  ..\TicketSystemBackEnd.API\TicketSystemBackEnd.API.csproj na CLI do Visual Studio
