# Sistema De Multas
Sistema Crud De Multas utilizando .Net 8 e JWT Token para Backend e Angular 17 para Frontend
<h4>BackEnd</h4>
Sistema Back-end desenvolvido com .Net 8 , utilizando ddd, arquitetura limpa e padrão repository, organizando o codigo em 4 camadas, sendo a camada Core responsavel pelas entidades, exceções e interfaces das funcionalidades que agem na camada Infrastructure, a camada API, onde possui os controladores que fazem a comunicação e interação entre as camadas Application e Infrastructure , a camada Application esta responsavel pelas lógicas de negocio do sistema e faz interação direta com a camada API e recebe dados da camada Core para enviar para a Infrastructure, a camada Infrastructure pelas movimentações feitas diretamente no banco de dados, pela configuração da encriptação de senha e configuração do JWT Token , seguindo os principios SOLID deixando o codigo mais limpo, diminuindo os acoplamentos, separando as responsabilidades e facilitando na hora de manutenção e testes.

<h4>FrontEnd</h4>
Sistema Front-end desenvolvido com Angular 17, utilizando separação de pastas para organização, tendo pasta Pages para paginas, pasta Components para os componentes Navbar e Sidebar, pasta Service para os serviços que irão se conectar diretamente com a API backend, pasta de Guard para aumentar segurança com movimentação do token e login, pasta de Models para os modelos de entrada de dados e pasta de Interceptor que possui um arquivo para interceptar as chamadas HTTP com o Jwt Token.

<h4>Banco de Dados</h4>
Banco de dados utilizando SQL Server , utilizando o Entity Framework para criação e acesso as tabelas.

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

# Regras de Negocio Utilizadas
# Verificação do Número do AIT
- Verifique se o campo NÚMERO DO AIT que foi digitado já existe na tabela MULTAS.
- Se existir, abrir a tela 'DETALHES DO AIT' somente para visualização dos dados do primeiro registro encontrado
neste AIT.
- Se não existir, vá para a Regra 2.
 
# Pesquisa do AIT
- Pesquise o AIT na string, eliminando dígitos da esquerda até encontrar dados dentro da tabela MULTAS
- Se encontrado, vá para a Regra 3
- Se não encontrado, crie um novo registro com as informações digitadas. Após registrar, abra a tela 'DETALHES
DO AIT' para edição dos demais dados

# Verificação da Data, Hora e Minuto da Infração
- Verifique se a DATA, HORA, MINUTO DA INFRAÇÃO que foi digitada já existe nos registros já encontrados
- Se existir, vá para a Regra 4
- Se não existir, crie um novo registro com as informações digitadas. Após registrar, abra a tela 'DETALHES DO
AIT' para edição dos demais dados

# Verificação do Código da Infração
- Verifique se o CÓDIGO DA INFRAÇÃO que foi digitado já existe nos registros já encontrados
- Se existir, vá para a Regra 5
- Se não existir, crie um novo registro com as informações digitadas. Após registrar, abra a tela 'DETALHES DO
AIT' para edição dos demais dados

# Verificação da Placa do Veículo
- Verifique se a PLACA DO VEÍCULO que foi digitada já existe nos registros já encontrados
- Se existir, termina com 'PENDÊNCIA AIT'
- Se não existir, crie um novo registro com as informações digitadas. Após registrar, abra a tela 'DETALHES DO
AIT' para edição dos demais dados
