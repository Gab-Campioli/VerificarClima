# 🌡️ Termômetro Visual em C# - Windows Forms

Este projeto é uma aplicação simples feita em **C# com Windows Forms**, com o objetivo de praticar o uso de componentes como `PictureBox`, `TextBox`, `Label`, entre outros.

A aplicação simula um **termômetro**: ao digitar uma temperatura no campo de texto, uma **imagem representando o clima atual** é exibida automaticamente.

---

## 🔧 Funcionalidades

- ✅ Entrada de temperatura através de um `TextBox`
- ✅ Exibição de **imagem** relacionada ao clima (frio, ameno, quente) em um `PictureBox`
- ✅ **Validação da entrada**, impedindo que letras ou caracteres especiais sejam inseridos no campo de temperatura
- ✅ Um `Label` exibe a **data atual** ao iniciar o programa
- ✅ Interface simples e intuitiva para fins didáticos

---

## 🖼️ Prévia da Interface

Veja abaixo uma prévia da interface da aplicação em execução:

![Prévia do Programa](print1.jpg)

---

## 🧠 Lógica de Funcionamento

- **Temperatura ≤ 10°C** → Imagem de **clima frio**
- **Temperatura entre 11°C e 25°C** → Imagem de **clima ameno**
- **Temperatura > 25°C** → Imagem de **clima quente**

A imagem exibida é atualizada automaticamente com base na temperatura digitada.

---

## 🔒 Validação de Entrada

A aplicação possui uma verificação que **impede a entrada de letras ou símbolos** no campo de temperatura. Somente números são aceitos, o que evita erros no funcionamento do programa.

---

## 📅 Exibição da Data Atual

Ao executar o programa, a data do dia atual é exibida automaticamente em um `Label`, utilizando o formato padrão do sistema:

## 💻 Tecnologias Utilizadas

- **C#**
- **.NET Framework**
- **Windows Forms (WinForms)**
- Componentes usados: `PictureBox`, `TextBox`, `Label`, `Button`

---

## 📁 Arquivos Incluídos

- `Form1.cs` – Lógica principal da aplicação
- `Program.cs` – Ponto de entrada
- `print1.jpg` – Imagem de prévia do programa (inserida neste repositório)
- Imagens adicionais de clima (devem ser adicionadas ao projeto)

---

## 📌 Observações

- As imagens devem ser adicionadas ao diretório do projeto e configuradas com a propriedade `Copy to Output Directory` como **Copy if newer**
- Este projeto tem fins **educacionais** para aprendizado de interfaces gráficas em C#

---

## 👨‍💻 Autor

Desenvolvido como parte de um exercício de prática em C# e Windows Forms.