### Criar o projeto console
```ps
    dotnet new console
```

### Criar pasta
```ps
    mkdir [NomeDaPasta]
```

### Criar uma classe
```ps
    # dotnet new --install Vio.Dotnet.Templates
    dotnet new class -n [MinhaClasse]
```

### Iniciando o repositorio git
```ps

    git init -b main
    git remote add [NomerDORepositorio] [url]
    git push -u origin main
    git config credential.username hesauhugo
    git pull --allow-unrelated-histories origin main

```

### Desabilidar aviso de nulos alterar essa tag no .csproj 
```html
    <Nullable>disable</Nullable>
```
### Encapsulamento
* Proteger propriedades de metodos de modificações externas, a não ser que os mesmos passem por uma validação

### Rodar o projeto
```ps

    dotnet run

```
### Body expressions
```C#
    get => _nome.ToUpper();
```
### Modificadores de acesso
* Public: O membro é acessível de qualquer lugar, dentro ou fora da classe.
* Private: O membro é acessível somente dentro da classe em que é declarado.
* Protected: O membro é acessível dentro da classe em que é declarado e também em classes derivadas da classe base.
* Internal: O membro é acessível dentro do mesmo assembly (um assembly é um arquivo .dll ou .exe que contém um ou mais módulos de código) em que é declarado.

### Propriedade Readonly 
```C#
    public string NomeCompleto { get => Nome + " " + Sobrenome; }
```

### Método
* Bloco de código que contém uma série de instruções

### Construtores 
* Permitem que o programador defina valores padrão, limite a instanciação e grave códgios flexíveis e fáceis de ler

### Interpolação de strings
* .[https://learn.microsoft.com/pt-br/dotnet/csharp/tutorials/string-interpolation]
* O recurso interpolação de cadeia de caracteres baseia-se no recurso formatação composta e fornece uma sintaxe mais legível e conveniente para incluir resultados de expressão formatada em uma cadeia de caracteres de resultado.
* Para concatenação é possível usar o sinal de `+`
* A interpolação deixa o código mais legivel
