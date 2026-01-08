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

### 1. Gerenciamento de Ativos (Script `Cardapio.cs`)

A lógica principal reside na classe `MultiImageTrackingManager`, que coordena a detecção de imagens e o ciclo de vida dos objetos 3D.

* **Estrutura de Dados do Prefab:**
A aplicação utiliza um dicionário interno para rastrear instâncias ativas, garantindo que cada prato seja instanciado apenas uma vez.
```json
{
  "dados_objeto_ra": {
    "identificador": "nome_da_imagem_library",
    "transform_vinculado": "trackedImage.transform",
    "status_rastreio": "TrackingState.Tracking",
    "objetos_disponiveis": 8
  }
}

```


* **Método Principal `OnTrackedImagesChanged`:** Este método é o "coração" da aplicação. Ele monitora a biblioteca de imagens e executa as seguintes funções:
1. **Detecção (`eventArgs.added`):** Compara o nome da imagem detectada com a lista de prefabs disponíveis.
2. **Instanciação:** Cria o objeto 3D como filho da imagem rastreada se ele ainda não existir na cena.
3. **Atualização (`eventArgs.updated`):** Ativa ou desativa a visibilidade do modelo 3D conforme a câmera mantém ou perde o foco no papel.

---

## 📦 Instalação e Testes Públicos (P3)

Devido ao tamanho dos modelos 3D de alta fidelidade, o executável ultrapassou o limite de upload direto do repositório. O download deve ser feito via **GitHub Releases**.

### Instruções para Download:

1. Acesse a aba [Releases](https://github.com/ZuzaNeto/AR-App---Guia-Interativo-para-Restaurantes/releases/tag/v1.0) deste repositório.
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

## 👥 Créditos

*Alunos:* José Nunes de Sousa Neto e Jamilly Vitoria Ferreira Barbosa
*Disciplina:* EECP0014 - Computação Gráfica
*Professor:* Haroldo Gomes Barroso Filho
*Instituição:* UFMA — Universidade Federal do Maranhão  
*Semestre:* 2025.2

---

<div align="center">

*Desenvolvido para fins acadêmicos*

</div>

---
**Desenvolvido por:** José Nunes de Sousa Neto, Jamilly Vitoria Ferreira Barbosa

**Data:** Janeiro de 2026

**Disciplina:** Computação Gráfica

**Docente:** Haroldo Gomes Barroso Filho
