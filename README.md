# Importação de Planilhas em Excel 🚀

## Descrição 📜

**Importação de Planilhas em Excel** é um projeto desenvolvido utilizando **C#** e **.NET MVC**, com o objetivo de estudar e praticar a importação e manipulação de dados em planilhas Excel. O sistema permite aos usuários fazer upload de arquivos Excel e importar seus dados para um banco de dados.

Este projeto foi criado como parte do processo de aprendizado de tecnologias de backend, utilizando **.NET MVC** para a construção da aplicação web.

---

## Tecnologias Utilizadas ⚙️

O sistema foi desenvolvido utilizando as seguintes tecnologias:

- **Backend:** 
  - C#
  - ASP.NET MVC
  - Entity Framework
  - FileHelpers (para leitura de arquivos Excel)
  
- **Frontend:**
  - HTML
  - CSS
  - JavaScript
  
- **Banco de Dados:** SQL Server.

---

## Funcionalidades Principais 🎯

O sistema **Importação de Planilhas em Excel** oferece as seguintes funcionalidades:

- **Upload de Planilha Excel:** Permite que o usuário faça o upload de um arquivo Excel (.xlsx ou .xls).
- **Importação para Banco de Dados:** Converte os dados da planilha em registros e os armazena no banco de dados.
- **Visualização de Dados Importados:** Exibe os dados que foram importados diretamente da planilha para a interface.

---

## Imagens do Projeto 📸

Abaixo, estão algumas imagens que demonstram o funcionamento do projeto:

### 1. **Página de Upload de Arquivo**

Na página inicial, os usuários podem fazer upload de planilhas Excel:

![importar-planilha-vazio](https://github.com/user-attachments/assets/c2f84c0a-740a-4f7d-a1f4-8a93d9671c0c)

---

### 2. **Tabela de Dados em Excel**

Aqui, o usuário seleciona a tabela com os dados no excel:

![Excel](https://github.com/user-attachments/assets/75ce68f2-6759-42ab-b07d-46f15929b22e)

---

### 3. **Tabela de Dados Importados**

Após a importação, os dados aparecem na interface em formato tabular:

![importar-planilha-dados](https://github.com/user-attachments/assets/4ea2a21a-30d4-4e83-b644-0dc672caa0de)

---

### 4. **Dados Gravados no Banco de Dados**

Os dados são gravados diretamente no banco de dados:

![dados-banco-dados](https://github.com/user-attachments/assets/4d46d072-aab6-4959-ac1f-fe36658fdfc7)

---

## Como Começar 🚀

Siga os passos abaixo para começar a usar o **Importação de Planilhas em Excel** em sua máquina:

### 1. **Clone o Repositório**

Clone o repositório para o seu ambiente local utilizando o comando abaixo:

```sh
git clone https://github.com/seu-usuario/Importacao-Planilhas-Excel.git
```
---

### 2. **Configuração do Banco de Dados**

Crie seu banco de dados e configure a aplicação com os dados correspondentes:

```javascript
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost; Database=ImportacaoDB; User Id=sa;Password=senha"
}

```

### 3. **Configuração do Projeto**

**No diretório do projeto instale as dependências do projeto, execute **
```sh
dotnet restore
```

**Crie e Migre o Banco de Dados**
```sh
dotnet ef database update
```

**Para rodar o projeto bastar executar o comando abaixo ou clicar na setinha verde vo vscode 2022**
```sh
dotnet run
```
