# Guia Interativo para Restaurantes em Realidade Aumentada (RA)

## 📌 Descrição do Projeto

Este projeto é uma aplicação móvel desenvolvida para a disciplina de **Computação Gráfica**. O objetivo é transformar a experiência de escolha em um restaurante, permitindo que o usuário visualize modelos 3D realistas dos pratos ao apontar a câmera do celular para as imagens do cardápio físico.

A aplicação utiliza o rastreamento de imagem (Image Tracking) para instanciar dinamicamente 8 objetos diferentes: **Pão de Forma, Croissant, Focaccia, Donut Tradicional, Donut de Chocolate, Donut Specialty, Café Espresso e Pizza Rústica**.

---

## 🛠️ Especificações Técnicas

* **Engine:** Unity 6 (6000.0.64f1).
* **Framework de RA:** AR Foundation com suporte ao Google ARCore.
* **Pipeline de Renderização:** Universal Render Pipeline (URP).
* **Linguagem:** C# para lógica de instanciamento dinâmico.

---

## 🏗️ Arquitetura e Implementação (Registro de Software - P2)

### 1. Gerenciamento Dinâmico de Ativos

Em vez de sobrecarregar a hierarquia da cena, o projeto utiliza um script de gerenciamento (`Cardapio.cs`) que monitora as mudanças no estado de rastreamento da câmera.

* **Mapeamento por Nome:** O sistema compara o nome da `ReferenceImage` detectada na biblioteca com o nome dos `Prefabs` armazenados nos Assets.
* **Eficiência:** Isso permite que a aplicação suporte múltiplos objetos (neste caso, 8 itens) utilizando um único controlador lógico, facilitando a escalabilidade do software.

### 2. Solução do Conflito de Renderização no Unity 6

Um desafio técnico significativo foi a integração do feed da câmera com o URP. A solução consistiu na configuração manual do arquivo `Mobile_Renderer` (Universal Renderer Data), onde foi adicionada a **AR Background Renderer Feature**. Esta etapa é crucial em versões recentes da Unity para garantir que a imagem do mundo real seja renderizada como plano de fundo antes dos objetos virtuais.

---

## 📦 Instalação e Uso (P3)

### Requisitos

* Dispositivo Android compatível com ARCore.
* Permissão de acesso à câmera habilitada.

### Instruções

1. Baixe o arquivo **.apk** disponível na seção [Releases] deste repositório.
2. Instale no seu dispositivo móvel.
3. Abra o arquivo `Menu.pdf` (disponível na pasta `/Assets/Documentos`) em uma tela ou imprima-o.
4. Inicie o aplicativo e aponte para as fotos dos pratos. Aguarde alguns segundos para que o rastreador identifique os pontos de contraste e projete o modelo 3D.



---

## 📂 Organização do Repositório

* `/Assets`: Contém todos os modelos 3D, materiais e scripts utilizados.
* `/Builds`: Local onde se encontra o arquivo pronto para instalação.
* `/Documentos`: Cardápio original utilizado como alvo para o rastreamento.

---

**Desenvolvido por:** José Nunes de Sousa Neto, Jamilly Vitoria Ferreira Barbosa

**Data de Entrega:** Janeiro de 2026
