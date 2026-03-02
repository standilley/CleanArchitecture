Clean Architecture – ASP.NET Core (.NET 8)
Este projeto é uma implementação prática do padrão Clean Architecture utilizando ASP.NET Core (.NET 8).
O objetivo é demonstrar uma arquitetura desacoplada, organizada e de fácil manutenção, separando claramente:
Regras de negócio
Casos de uso
Infraestrutura
Interfaces de entrada
🏗️ Estrutura da Solução
A solução está organizada em múltiplos projetos, cada um com uma responsabilidade específica:
text
Copiar código
CleanArchitecture
│
├── CleanArchitecture.API
├── CleanArchitecture.Application
├── CleanArchitecture.Domain
├── CleanArchitecture.Persistence
└── CleanArchitecture.Tests
📦 CleanArchitecture.API
Camada responsável por expor a aplicação via API REST.
Responsabilidades
Controllers
Configuração da aplicação
Injeção de dependências
Middlewares
Estrutura
text
Copiar código
CleanArchitecture.API
├── Controllers
├── Extensions
├── Program.cs
├── appsettings.json
└── appsettings.Development.json
📦 CleanArchitecture.Application
Camada de casos de uso da aplicação.
Responsabilidades
Orquestrar regras de negócio
Implementar casos de uso
Conter serviços de aplicação
Aplicar comportamentos compartilhados
Estrutura
text
Copiar código
CleanArchitecture.Application
├── Services
├── UseCases
├── Shared
└── Behavior
📦 CleanArchitecture.Domain
Camada central do sistema, contendo apenas regras de negócio puras.
✅ Não depende de nenhuma outra camada.
Responsabilidades
Entidades
Interfaces (contratos)
Estrutura
text
Copiar código
CleanArchitecture.Domain
├── Entities
└── Interfaces
📦 CleanArchitecture.Persistence
Camada responsável pela infraestrutura e persistência de dados.
Responsabilidades
Implementação de repositórios
Configuração do banco de dados
Integração com Entity Framework (ou outro ORM)
Estrutura
text
Copiar código
CleanArchitecture.Persistence
├── Context
├── Repositories
└── ServiceExtensions.cs
📦 CleanArchitecture.Tests
Projeto destinado aos testes automatizados.
Responsabilidades
Testes unitários
Testes de casos de uso
Garantia da integridade das regras de negócio
text
Copiar código
CleanArchitecture.Tests
🔄 Fluxo de Dependências
O fluxo de dependência segue rigorosamente o padrão da Clean Architecture:
text
Copiar código
API
 ↓
Application
 ↓
Domain
 ↑
Persistence
Regras
Domain não depende de ninguém
Application depende apenas do Domain
Persistence depende do Domain
API depende de Application e Persistence
🚀 Como Executar o Projeto
Pré-requisitos
.NET SDK 8.0 ou superior
Passos
Clone o repositório:
bash
Copiar código
git clone https://github.com/standilley/CleanArchitecture.git
Acesse o diretório do projeto:
bash
Copiar código
cd CleanArchitecture
Restaure as dependências:
bash
Copiar código
dotnet restore
Execute a aplicação:
bash
Copiar código
dotnet run --project CleanArchitecture.API
A API estará disponível em:

Copiar código
https://localhost:5001
(ou conforme configuração local)
✅ Benefícios da Arquitetura
Baixo acoplamento
Código organizado e legível
Alta testabilidade
Facilidade de manutenção
Escalabilidade
📚 Referências
Robert C. Martin — Clean Architecture
https://cleanarchitecture.io/
https://learn.microsoft.com/aspnet/core/
👤 Autor
Standilley Oliveira Santos
GitHub: https://github.com/standilley
