<h1 align="center">📝 Task Manager API</h1>

<p align="center">
  API RESTful para la gestión de tareas construida con <b>.NET 8</b> y <b>Entity Framework Core</b> utilizando una <b>InMemory Database</b>. 
  Ideal para gestionar tareas con un CRUD completo.
</p>

<p align="center">
  <img src="https://img.shields.io/badge/.NET-8.0-blueviolet?style=for-the-badge&logo=dotnet">
  <img src="https://img.shields.io/badge/Entity%20Framework-InMemory-blue?style=for-the-badge&logo=microsoft">
  <img src="https://img.shields.io/badge/RESTful-API-green?style=for-the-badge&logo=api">
</p>

---

## 📌 **Características**

✅ **CRUD Completo** para crear, leer, actualizar y eliminar tareas.  
✅ Implementación de **Entity Framework Core** con **InMemory Database**.  
✅ **Swagger UI** para explorar y probar la API de manera interactiva.  
✅ **CORS** configurado para interactuar con aplicaciones externas (Angular, React, etc.).  
✅ **Sembrado de datos** por defecto al iniciar la aplicación.  

---
## 🚀 **Requisitos Previos**

Antes de comenzar, asegúrate de tener instalados los siguientes elementos:

- **.NET 8 SDK** → [Descargar](https://dotnet.microsoft.com/download)  
- **Visual Studio** o **VS Code** (opcional)  
- **Git** (para clonar el repositorio)  

---

## 📥 **Instalación**

1️⃣ **Clonar el repositorio**:

```bash
git clone https://github.com/EmersonUrielVargas/tm-task-manager-mngr.git
cd tm-task-manager-web-ui
```
2️⃣ **Restaurar los paquetes:**:

```bash
dotnet restore
```

3️⃣ **Ejecutar la aplicación:**:

```bash
dotnet run
```

4️⃣ **La API estara disponible en **:

```bash
➡️ http://localhost:7167
➡️ https://localhost:7167
```
---
## 📊 Explorar la API con Swagger
La documentación interactiva está habilitada mediante Swagger.
Puedes acceder a la UI de Swagger una vez estes corriendo el proyecto en:

```bash
➡️ http://localhost:7167
➡️ https://localhost:7167/swagger/index.html
```
---

## 📦 Despliegue en Azure App Service y Github Actions

  El Api contiene el workflow para su despliegue en azure web apps mediante github actions

---

## 📧 **Contacto**

- Autor: Emerson Vargas
- GitHub: [@emersonurielvargas](https://github.com/EmersonUrielVargas)
- Email: emrvargaitaz@gmail.com

---
