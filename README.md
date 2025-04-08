# GUIA DE CONFIGURAÇÃO DO AMBIENTE DE DESENVOLVIMENTO DO PROJETO AMBEV

### **Correções iniciais**

Seguem as configuracoes inicais caso do projeto contenha definicoes diferentes das citadas abaixo.


```sh

No arquivo: template\backend\docker-compose.yml

Corrija as portas definidas de "8080" para "8080:8080".


No arquivo: template\backend\src\Ambev.DeveloperEvaluation.WebApi\appsettings.json

Substitua o usuario e senha na conexao para refletir o que está no docker-compose.yml

"DefaultConnection": "Server=localhost;Database=developer_evaluation;User Id=developer;Password=ev@luAt10n;TrustServerCertificate=True"

```


## **1. Clonar o Repositório**

```sh

git clone https://github.com/marceloandrade1986/Ambev.DeveloperEvaluation.git

cd Ambev.DeveloperEvaluation

```



---

```sh
No passo 2 o docker-compose.yml contem todas as configuracoes
Em ambiente de desenvolvimento voce pode utilizar o banco em localhost e aceessar por algum SGDB
como o dbeaver por exemplo para falicilitar o gerenciamento visual.


```






## **2. Configurar o Banco de Dados PostgreSQL**

### **2.1. Criar um Contêiner PostgreSQL com Docker**

```sh

docker run --name ambev-db -e POSTGRES_USER=ambev -e POSTGRES_PASSWORD=ambev -e POSTGRES_DB=developer_db -p 5432:5432 -d postgres

```



### **2.2. Verificar se o contêiner está rodando**

```sh

docker ps

```



### **2.3. Acessar o banco de dados**

```sh

docker exec -it ambev-db psql -U ambev -d developer_db

```



---



## **3. Configurar o Backend (.NET 8.0)**

### **3.1. Navegar até o diretório backend**

```sh

cd template/backend

```

## ** Configure o arquivo global.json caso queira especificar uma versao do SDK.



### **3.2. Restaurar dependências do .NET**

```sh

dotnet restore

```



### **3.3. Compilar o projeto**

```sh

dotnet build

```



### **3.4. Rodar o projeto**

```sh

dotnet run

```



## ** Caso ja tenha expertise com o Visual Studio ele ja contem todas as ferramenteas de auxilio na limpeza, construcao e execucao do projeto.

---



## **4. Configurar o Frontend (Angular)**

### **4.1. Navegar até o diretório frontend**

```sh

cd ../frontend

```



### **4.2. Instalar dependências**

```sh

npm install

```



### **4.3. Iniciar o servidor de desenvolvimento**

```sh

ng serve --open

```



---



## **5. Configurar as Migrações do Entity Framework Core**



### **5.1. Abrir o Package Manager Console no Visual Studio**

Se estiver usando o Visual Studio:

```powershell

Tools -> NuGet Package Manager -> Package Manager Console

```

Se estiver usando .NET CLI, os comandos podem ser executados diretamente no terminal.



### **5.2. Navegar até o diretório do ORM**

```sh

cd template/backend/src/Ambev.DeveloperEvaluation.ORM

```



### **5.3. Criar a primeira migração**

```powershell

Add-Migration InitialCreate

```



### **5.4. Aplicar as migrações no banco de dados**

```powershell

Update-Database

```



### **5.5. Verificar todas as migrações aplicadas**

```powershell

Get-Migrations

```



---



## **6. Popular o Banco de Dados com Dados Iniciais (Seeding)**

### **6.1. Adicionar Dados no `OnModelCreating` (DefaultContext.cs)**

```csharp

protected override void OnModelCreating(ModelBuilder modelBuilder)

{

    base.OnModelCreating(modelBuilder);



    modelBuilder.Entity<User>().HasData(

        new User { Id = Guid.NewGuid(), Name = "Admin", Email = "admin@ambev.com", Role = "Administrator" },

        new User { Id = Guid.NewGuid(), Name = "User1", Email = "user1@ambev.com", Role = "User" }

    );



    modelBuilder.Entity<Product>().HasData(

        new Product { ProductId = Guid.NewGuid(), Name = "Beer", Price = 10.0m },

        new Product { ProductId = Guid.NewGuid(), Name = "Soda", Price = 5.0m }

    );

}

```



### **6.2. Atualizar o banco para incluir os dados iniciais**

```powershell

Update-Database

```



---



## **7. Comandos Úteis para Gerenciar Migrações**

### **7.1. Verificar o estado do contexto do banco de dados**

```powershell

Get-DbContext

```



### **7.2. Remover a última migração (se necessário)**

```powershell

Remove-Migration

```



### **7.3. Recriar as migrações do zero**

```powershell

Remove-Migration

Add-Migration InitialCreate

Update-Database

```



---



## **8. Rodar a Aplicação Completa**

### **8.1. Iniciar o Backend**

```sh

cd template/backend

dotnet run

```



### **8.2. Iniciar o Frontend**

```sh

cd ../frontend

ng serve --open

```

Agora o projeto está configurado e rodando em ambiente de desenvolvimento local! 🚀











