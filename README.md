# 🖥️ Curso Windows Forms — C#

Projeto de estudos desenvolvido em **C# com Windows Forms e .NET 8**, reunindo exemplos práticos de interfaces gráficas para aplicações desktop no Windows.

O objetivo é praticar a criação de formulários, a interação com componentes visuais, o tratamento de eventos e a validação de dados informados pelo usuário.

## 🚀 Funcionalidades

### Menu principal
- Acesso aos exemplos por meio de botões.
- Abertura dos formulários em janelas modais com `ShowDialog()`.

### Hello World
- Alteração do texto de uma `Label` a partir do conteúdo de um campo de texto.
- Encerramento do formulário por um botão.

### Eventos de teclado
- Captura de teclas pelo evento `KeyDown`.
- Exibição do nome e do código numérico da tecla pressionada.
- Exibição do nome da tecla em letras maiúsculas e minúsculas.
- Limpeza dos campos e do histórico exibido.

### Máscaras de entrada
- Alternância de máscaras para hora, CEP, moeda, data e telefone.
- Campo de senha numérica com seis posições e caracteres ocultos.
- Exibição da máscara ativa e do conteúdo digitado.
- Limpeza dos campos.

### Validação de CPF
- Cálculo e conferência dos dígitos verificadores em uma classe utilitária.
- Exibição do resultado com texto e cores.
- Segundo formulário com verificação de preenchimento e quantidade de caracteres, confirmação antes da validação e mensagens em caixas de diálogo.

### Força da senha
- Classificação em **Inaceitavel**, **Fraca**, **Aceitavel**, **Forte** ou **Segura**, conforme a pontuação implementada no exemplo.
- Pontuação baseada em tamanho, letras maiúsculas e minúsculas, números, símbolos e repetição.
- Resultado visual com cores conforme a classificação.

## 🛠️ Tecnologias e ferramentas

| Tecnologia / ferramenta | Utilização |
| --- | --- |
| C# | Lógica da aplicação e tratamento de eventos |
| .NET 8 | Plataforma de execução do projeto |
| Windows Forms | Criação dos formulários e componentes visuais |
| Visual Studio | Desenvolvimento, designer visual e depuração |
| Expressões regulares (`Regex`) | Critérios de pontuação da senha |
| Git e GitHub | Versionamento e publicação do código |

## 📚 Conceitos praticados

- Programação orientada a eventos com `Click` e `KeyDown`.
- Componentes `Form`, `Button`, `Label`, `TextBox` e `MaskedTextBox`.
- Manipulação de propriedades como `Text`, `ForeColor`, `Mask` e `UseSystemPasswordChar`.
- Caixas de diálogo com `MessageBox` e tratamento de `DialogResult`.
- Manipulação de strings, estruturas condicionais e laços de repetição.
- Reutilização de código com métodos estáticos em uma classe utilitária.
- Organização de formulários em classes parciais e arquivos do designer.

## 📂 Principais arquivos

| Arquivo | Responsabilidade |
| --- | --- |
| `CursoWindowsForms.sln` | Solução para abertura no Visual Studio |
| `CursoWindowsForms/Program.cs` | Inicialização da aplicação |
| `CursoWindowsForms/Frm_Principal.cs` | Menu de acesso aos exemplos |
| `CursoWindowsForms/Frm_HelloWord.cs` | Interação inicial com campos e labels |
| `CursoWindowsForms/Frm_DemonstracaoKey.cs` | Demonstração dos eventos de teclado |
| `CursoWindowsForms/Frm_Mascara.cs` | Aplicação de máscaras de entrada |
| `CursoWindowsForms/Frm_ValidaCPF.cs` | Validação de CPF com resultado no formulário |
| `CursoWindowsForms/Frm_ValidaCPF2.cs` | Validação de CPF com mensagens e confirmação |
| `CursoWindowsForms/Frm_ValidaSenha.cs` | Classificação da força da senha |
| `CursoWindowsForms/Cls_Uteis.cs` | Método compartilhado para validação de CPF |

## ▶️ Como executar

### Pré-requisitos

- Windows.
- Visual Studio com suporte ao .NET 8 e a carga de trabalho **Desenvolvimento para desktop com .NET**.
- SDK do .NET 8 instalado.

### Pelo Visual Studio

1. Clone o repositório:

   ```bash
   git clone https://github.com/kauanfernandes05/CursoWindowsForms.git
   ```

2. Abra o arquivo `CursoWindowsForms.sln` no Visual Studio.
3. Defina `CursoWindowsForms` como projeto de inicialização, se necessário.
4. Execute com **F5** ou **Ctrl + F5**.
5. No menu principal, selecione o exemplo que deseja explorar.

### Pelo terminal no Windows

Na pasta raiz do repositório, execute:

```bash
dotnet run --project CursoWindowsForms/CursoWindowsForms.csproj
```

## 🎯 Objetivo do projeto

Registrar minha evolução no desenvolvimento de aplicações desktop com C#, aplicando os conteúdos estudados em exemplos práticos de Windows Forms.

Os validadores e a classificação de senha são exercícios didáticos. A validação de CPF confere os dígitos verificadores; a classificação de senha representa a pontuação definida no código.

## 👨‍💻 Autor

**Kauan Fernandes** — Estudante de Engenharia de Software e Estagiário de Desenvolvimento.

- [GitHub](https://github.com/kauanfernandes05)
- [LinkedIn](https://www.linkedin.com/in/kauan-fernandes05/)
