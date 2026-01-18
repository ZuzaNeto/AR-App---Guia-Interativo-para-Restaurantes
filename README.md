# Menu Vision - Guia Interativo para Restaurantes em Realidade Aumentada (RA)

## 📌 Descrição do Projeto

Este projeto é uma aplicação móvel desenvolvida para a disciplina de **Computação Gráfica**. O objetivo é transformar a experiência de escolha em um restaurante, permitindo que o usuário visualize modelos 3D realistas dos pratos ao apontar a câmera do celular para as imagens do cardápio físico.

A aplicação utiliza o rastreamento de imagem (Image Tracking) para instanciar dinamicamente 8 objetos diferentes: **Pão de Forma, Croissant, Focaccia, Donut Tradicional, Donut de Chocolate, Donut Specialty, Café Espresso e Pizza Rústica**.

---

### 📦 Instalação e Demonstração

Para facilitar a avaliação e o teste público da plataforma, disponibilizamos materiais em vídeo detalhando todo o processo:

* **🎥 Desenvolvimento do App:** [Assista aqui como o app foi desenvolvido](https://www.google.com/search?q=LINK_DO_YOUTUBE_DESENVOLVIMENTO_AQUI) — *Explicação técnica sobre a integração do Unity 6 com AR Foundation.*
* **🎥 Instalação e Demonstração:** [Passo a passo de instalação e demonstração](https://youtu.be/MDLIjgQ5cGI?si=bXqDWH7MC4P9Rpbe) — *Guia visual de como instalar o APK e utilizar o cardápio interativo.*

#### **Requisitos de Sistema**

* **Compatibilidade:** O dispositivo Android deve ser obrigatoriamente compatível com o **ARCore**.
* **Lista de Dispositivos:** Você pode verificar se o seu aparelho suporta a tecnologia na lista oficial do Google: [Dispositivos compatíveis com ARCore](https://developers.google.com/ar/devices?hl=pt-br).
* **Software:** É necessário ter o *Google Play Services para RA* instalado e atualizado via Play Store.

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

## 🛠️ Especificações Técnicas

* **Engine:** Unity 6 (6000.0.64f1).
* **Framework de RA:** AR Foundation com suporte ao Google ARCore.
* **Pipeline de Renderização:** Universal Render Pipeline (URP).
* **Linguagem:** C# para lógica de instanciamento dinâmico.

---

## 🏗️ Arquitetura e Implementação (Registro de Software)

### 1. Gerenciamento de Ativos (Script `Cardapio.cs`)

*Estrutura de dados detalhada:*
A aplicação utiliza um dicionário interno para rastrear instâncias ativas, garantindo que cada prato seja instanciado apenas uma vez ao ser detectado pela primeira vez.

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

*Método de Instanciação Dinâmica:*
Este trecho do código é responsável por realizar o "match" entre o nome da imagem na biblioteca e o Prefab correspondente, ignorando diferenças entre maiúsculas e minúsculas.

```csharp
// Quando uma imagem nova é detectada
foreach (var trackedImage in eventArgs.added)
{
    var imageName = trackedImage.referenceImage.name;
    foreach (var prefab in arPrefabs)
    {
        if (string.Compare(prefab.name, imageName, System.StringComparison.OrdinalIgnoreCase) == 0 && !_instantiatedPrefabs.ContainsKey(imageName))
        {
            var newPrefab = Instantiate(prefab, trackedImage.transform);
            _instantiatedPrefabs.Add(imageName, newPrefab);
        }
    }
}

```

---

## 📂 Organização das Pastas

* `/Assets`: Código-fonte, prefabs e materiais dos 8 objetos.
* `/Documentos`: Cardápio em PDF para teste do rastreamento.
* `/ProjectSettings`: Configurações globais de RA e Pipeline de Renderização.

---

## 👥 Créditos

*Alunos:* José Nunes de Sousa Neto, Jamilly Vitoria Ferreira Barbosa

*Disciplina:* EECP0014 - Computação Gráfica

*Professor:* Haroldo Gomes Barroso Filho

*Instituição:* UFMA — Universidade Federal do Maranhão  

*Semestre:* 2025.2

---

<div align="center">

*Desenvolvido para fins acadêmicos*

</div>

---
