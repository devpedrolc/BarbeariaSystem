<img width="1024" height="1024" alt="photo" src="https://github.com/user-attachments/assets/77dc9fee-7749-41e4-ac8a-475c9ffaf048" />
💈 Barbearia System - Gestão Financeira
Um sistema de console simples e eficiente para gestão de fluxo de caixa de barbearias, desenvolvido em .NET 10. O sistema permite o registro de serviços e a visualização de relatórios financeiros básicos.

🚀 Funcionalidades
Registro de Serviços: Entrada de valores financeiros de forma rápida.

Relatório Financeiro: Soma total de entradas e saídas registradas.

Persistência de Dados: Integração com repositório para salvar e carregar transações.

🏗️ Estrutura do Projeto
O projeto segue uma estrutura organizada em camadas para facilitar a manutenção:

Barbearia.Domain: Modelos de dados (Transacao) e enums (TipoTransacao).

Barbearia.Infrastructure: Implementação da persistência de dados no RepositorioFinanceiro.

Barbearia.UI: Interface de linha de comando (CLI) para interação com o usuário.

🛠️ Tecnologias Utilizadas
C# / .NET 10

LINQ (para processamento de relatórios)

📋 Como executar
Pré-requisitos: Certifique-se de ter o .NET SDK instalado.

Clonar o repositório: https://github.com/devpedrolc/BarbeariaSystem.git

Navegar até a pasta do projeto: cd BarbeariaSystem/Barbearia.UI

Executar a aplicação: dotnet run

📝 Exemplo de Uso
Ao iniciar o programa, você verá o menu principal:

Novo Serviço: Digite o valor do corte ou procedimento.

Relatório: Veja o saldo total acumulado.

Sair: Encerra a aplicação e garante que os dados foram salvos.

