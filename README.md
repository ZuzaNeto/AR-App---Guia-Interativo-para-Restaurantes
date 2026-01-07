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

A aplicação utiliza um script controlador (`Cardapio.cs`) que gerencia a detecção de imagens em tempo real.

* **Mapeamento por Nome:** O sistema realiza o "match" entre o nome da imagem detectada na `ReferenceImageLibrary` e o nome dos `Prefabs` na pasta de Assets.
* **Escalabilidade:** Esta abordagem permite gerenciar múltiplos objetos (8 itens) com um único script, otimizando o consumo de memória e o tempo de processamento.

### 2. Solução do Conflito de Renderização no Unity 6

Para habilitar o feed da câmera no Android sob o Universal Render Pipeline (URP), foi necessária a configuração do arquivo `Mobile_Renderer` (Universal Renderer Data).

* **Implementação:** Foi adicionada a **AR Background Renderer Feature**, corrigindo a falha de renderização (tela amarela) e permitindo a sobreposição correta dos modelos 3D no mundo real.

---

## 📦 Instalação e Testes Públicos (P3)

Devido ao tamanho dos modelos 3D de alta fidelidade, o executável ultrapassou o limite de upload direto do repositório. O download deve ser feito via **GitHub Releases**.

### Instruções para Download:

1. Acesse a aba [Releases](https://www.google.com/search?q=LINK_DA_SUA_RELEASE_AQUI) deste repositório.
2. Baixe o arquivo **.apk**.
3. Instale no seu dispositivo Android (conceda as permissões de "Instalar de Fontes Desconhecidas", se necessário).

### Como Testar:

1. Abra o aplicativo no celular.
2. Conceda permissão de uso da **Câmera**.
3. Aponte para as imagens contidas no arquivo `Menu.pdf` (localizado na pasta `/Documentos` deste repositório).
4. Mantenha o foco por alguns segundos para que a RA projete o prato escolhido sobre a mesa.

---

## 📂 Organização das Pastas

* `/Assets`: Código-fonte, prefabs e materiais dos 8 objetos.
* `/Documentos`: Cardápio em PDF para teste do rastreamento.
* `/ProjectSettings`: Configurações globais de RA e Pipeline de Renderização.

---

**Desenvolvido por:** José Nunes de Sousa Neto, Jamilly Vitoria Ferreira Barbosa

**Data:** Janeiro de 2026

**Disciplina:** Computação Gráfica

**Docente:** Haroldo Gomes Barroso Filho

### Próximo passo sugerido:

Agora que você tem o README pronto, gostaria que eu te ajudasse a escrever o roteiro de 2 minutos para a sua apresentação sorteada, focando em como você resolveu os desafios técnicos do Unity 6?
