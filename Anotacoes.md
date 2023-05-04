* Criar o projeto console
```console
    dotnet new console
```

* Criar pasta
```console
    mkdir <nome da pasta>
```

* Criar uma classe
```console
    # dotnet new --install Vio.Dotnet.Templates
    dotnet new class -n <MinhaClasse>
```

* Iniciando o repositorio git
```console

    git init -b main
    git remote add <nomerepositorio> <url>
    git push -u origin main
    git config credential.username hesauhugo
    git pull --allow-unrelated-histories origin main

```

* Desabilidar aviso de nulos alterar essa tag no .csproj `<Nullable>disable</Nullable>`

* Encapsulamento: Proteger propriedades de metodos de modificações externas, a não ser que os mesmos passem por uma validação

* Rodar o projeto
```console

    dotnet run

```
* Body expressions `get => _nome.ToUpper();`

* Modificadores de acesso
    * Public: O membro é acessível de qualquer lugar, dentro ou fora da classe.
    * Private: O membro é acessível somente dentro da classe em que é declarado.
    * Protected: O membro é acessível dentro da classe em que é declarado e também em classes derivadas da classe base.
    * Internal: O membro é acessível dentro do mesmo assembly (um assembly é um arquivo .dll ou .exe que contém um ou mais módulos de código) em que é declarado.