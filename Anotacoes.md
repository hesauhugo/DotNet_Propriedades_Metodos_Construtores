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
* Cuidado na interpolação quando o valor é numérico porém está formatado comtipo string 

### Formatando valores monetários
in:
```csharp
    decimal valorMonetario = 1582.40M;
    string valorMonetarioFormatado = $"{valorMonetario:C}"
```
out:
```console
    R$ 1.582,40
```
* Isso acontece porque o programa pega a cultura do sistema. Ex: Configuração do windows (Region).
* Atenção ao implementar em sistemas de nuvem pois vai pegar daquela região.


### Formatando a Cultura

in:
```csharp
    CultureInfo.DefaultThreadCUrrentCUlture = new CultureInfo("en-US")
    decimal valorMonetario = 1582.40M;
    string valorMonetarioFormatado = $"{valorMonetario:C}"
```
out:
```console
    $ 1,582.40
```

### Cultura Personalizada

in:
```csharp
    CultureInfo.DefaultThreadCUrrentCUlture = new CultureInfo("en-US")
    decimal valorMonetario = 1582.40M;
    valorMonetarioFormatado.ToString("C",CultureInfo.CreateSpecificCulture("pt-BR"))"
```
out:
```console
    R$ 1.582,40
```

### Números e Porcentagem
* Uma casa decimal

in:
```csharp
    
    decimal valorMonetario = 1582.40M;
    valorMonetarioFormatado.ToString("N1")

```
out:
```console
    R$ 1.582,4
```

* Porcentagem

in:
```csharp
    
    double porcentagem = .3421;
    valorMonetarioFormatado.ToString("P")

```
out:
```console
    34,21%
```

* Digitos

in:
```csharp
    
    double digitos = 123456;
    valorMonetarioFormatado.ToString("##-##-##")

```
out:
```console
    12-34-56
```
### Formatação Tipo DateTime
* Data Completa

in:
```csharp
    
    DataTime data = new DataTime.Now;
    valorMonetarioFormatado.ToString("dd/MM/yyyy HH:mm")

```
out:
```console
    17/04/2022 18:30
```

* Data Curta

in:
```csharp
    
    DataTime data = new DataTime.Now;
    valorMonetarioFormatado.ToShortDateString()

```
out:
```console
    17/04/2022 
```
* Hora Curta

in:
```csharp
    
    DataTime data = new DataTime.Now;
    valorMonetarioFormatado.ToShortTimeString()

```
out:
```console
    18:30
```

* Convertendo Datas

in:
```csharp
    var dataString = "2022-13-17 18:00";
    DataTime.TryParseExact(dataString,
                            "yyyy-MM-dd HH:mm",
                            CultureInfo.InvariantCulture,
                            DateTimeStyles.None,
                            out DataTime data
                            );
```
out:
```console
    01/01/0001 00:00:00
```

### Referências
1. .[https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/properties]
2. .[https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/methods]
3. .[https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/constructors]
5. .[https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/properties]
6. .[https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/methods]
7. .[https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/constructors]

