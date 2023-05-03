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
