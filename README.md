# 🚀 Estudo Prático de CI/CD com GitHub Actions

Este repositório foi criado com o objetivo de documentar meu processo de aprendizado em CI/CD. Ao longo dos estudos, segui um cronograma prático com foco na criação de uma pipeline funcional utilizando **GitHub Actions**.

---

## 📌 Cronograma de estudos criado pelo ChatGPT 

### 🎯 Objetivo:

Criar um pipeline CI/CD funcional para um projeto backend usando **GitHub Actions**.

---

### ✅ Passo 1: Introdução a CI/CD

- O que é CI/CD?
  - **CI (Integração Contínua):** Testes automatizados em cada commit.
  - **CD (Entrega Contínua):** Deploy automático após os testes.
- Ferramentas populares: GitHub Actions, GitLab CI, Jenkins.

---

### ✅ Passo 2: GitHub Actions Básico

- Entendendo a sintaxe YAML dos arquivos de workflow.
- Criar o primeiro pipeline:
  - Arquivo: `.github/workflows/test.yml`
  - Exemplo: `echo "Hello CI/CD"`
- Subir um repositório no GitHub com o workflow básico.

---

### ✅ Passo 3: CI com Testes Automatizados

- Adicionar testes ao projeto (ex: Jest, pytest, JUnit).
- Criar workflow que execute os testes a cada `push`.
- Configurar o job para falhar caso algum teste falhe.

---

### ✅ Passo 4: Build e Deploy Simples

- Adicionar uma etapa de build (ex: `npm run build`, `docker build`).
- Deploy automático em algum serviço gratuito:
  - Railway, Vercel, Heroku, GitHub Pages, etc.
- Deploy de uma API simples.

---

### ✅ Passo 5: Variáveis de Ambiente e Secrets

- Gerenciar secrets no GitHub:
  - `Settings > Secrets and variables > Actions`
- Usar variáveis nos workflows:
  - Ex: `${{ secrets.API_KEY }}`
- Esconder uma credencial e utilizá-la no pipeline.

---

### ✅ Passo 6: Pipeline Multi-Estágio

- Dividir o pipeline em múltiplas fases:
  - `test → build → deploy`
- Adicionar aprovação manual antes do deploy em produção:
  - `environment: production`
- Criar deploy condicional.

---

### ✅ Passo 7: Projeto Final

- Aplicar CI/CD completo em um projeto pessoal.
- Documentar o processo.

---

## 🧠 Aprendizados

Durante esse estudo, aprendi como montar uma pipeline desde o zero com GitHub Actions, configurando testes, builds, deploys automáticos e gerenciamento seguro de credenciais.

---
