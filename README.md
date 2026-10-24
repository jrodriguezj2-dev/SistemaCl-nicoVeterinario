# 🐾 Sistema de Control Clínico Veterinario

**Tecnología al servicio del cuidado animal.** 🩺🐶🐱

Sistema de gestión desarrollado en C# con SQLite, enfocado en organizar la información de una clínica veterinaria y facilitar el control de propietarios, mascotas, veterinarios y citas médicas.

---

## 🌟 Acerca del proyecto

El **Sistema de Control Clínico Veterinario** es un proyecto académico que busca integrar la programación, la gestión de datos y el diseño de sistemas para apoyar las actividades básicas de una clínica veterinaria.

A través de un menú interactivo de consola, permite administrar registros y mantener la información organizada mediante una base de datos SQLite.

## 🎯 Objetivo general

Desarrollar un sistema que permita gestionar de manera organizada la información de una clínica veterinaria, aplicando programación orientada a objetos, operaciones CRUD y persistencia de datos.

## 🩺 Funcionalidades del sistema

### 👥 Gestión de propietarios
- Registrar propietarios.
- Consultar propietarios registrados.
- Actualizar información.
- Eliminar registros cuando no existan dependencias que lo impidan.

### 🐕 Gestión de mascotas
- Registrar mascotas y asociarlas con sus propietarios.
- Consultar información de las mascotas.
- Actualizar datos.
- Eliminar registros respetando las relaciones de la base de datos.

### 🩺 Gestión de veterinarios
- Registrar veterinarios y sus especialidades.
- Consultar información.
- Actualizar datos.
- Eliminar registros cuando sea posible.

### 📅 Gestión de citas
- Programar citas veterinarias.
- Consultar citas registradas.
- Actualizar información de las citas.
- Eliminar citas.

### 💾 Persistencia de datos
- Almacenar información en SQLite.
- Utilizar claves primarias y relaciones entre tablas.
- Ejecutar operaciones CRUD mediante un repositorio.
- Mantener los datos guardados al cerrar el programa.

> **Nota:** El proyecto incluye tablas preparadas para futuras funciones clínicas, como expedientes, consultas, diagnósticos, tratamientos, vacunas y pagos. Su disponibilidad en la base de datos no implica que todas estas funciones estén implementadas en el menú actual.

## 🛠️ Tecnologías utilizadas

| Tecnología | Aplicación |
|---|---|
| C# | Lógica y funcionamiento del sistema |
| .NET 10 | Plataforma de ejecución |
| SQLite | Almacenamiento de datos |
| Visual Studio Code | Desarrollo y edición del código |
| Java y BlueJ | Trabajo de modelado de clases |
| Draw.io | Diseño de diagramas |
| Git y GitHub | Control de versiones y alojamiento del proyecto |

## 📂 Estructura del proyecto

```text
Sistema-Control-Clinico-Veterinario/
│
├── Codigo/
│   └── SistemaVeterinario/
│       ├── Program.cs
│       ├── SistemaVeterinario.csproj
│       │
│       ├── logica/
│       │   ├── Cita.cs
│       │   ├── ClinicaVeterinaria.cs
│       │   ├── Mascota.cs
│       │   ├── Persona.cs
│       │   ├── Propietario.cs
│       │   └── Veterinario.cs
│       │
│       └── Persistencia/
│           ├── InicializadorBaseDatos.cs
│           ├── RepositorioVeterinaria.cs
│           └── crear_tablas.sql
│
├── Diagramas/
│   ├── CasosDeUso/
│   └── Flujos/
│
├── BlueJ/
│   └── DiagramaDeClases/
│
└── README.md
```

## ⚙️ Requisitos para ejecutar el proyecto

- Tener instalado el SDK de .NET 10.
- Contar con un editor compatible, como Visual Studio Code.
- Restaurar los paquetes del proyecto antes de ejecutarlo.

### ▶️ Instalación y ejecución

1. Clonar el repositorio:

   ```bash
   git clone URL_DEL_REPOSITORIO
   ```

2. Entrar en la carpeta del proyecto:

   ```bash
   cd Codigo/SistemaVeterinario
   ```

3. Restaurar las dependencias:

   ```bash
   dotnet restore
   ```

4. Ejecutar el sistema:

   ```bash
   dotnet run
   ```

La base de datos SQLite se inicializa al iniciar la aplicación, según la configuración del proyecto.

## 🔄 Operaciones CRUD

El sistema implementa las operaciones CRUD para las principales entidades:

- **Create:** registrar información.
- **Read:** consultar registros.
- **Update:** actualizar información existente.
- **Delete:** eliminar registros respetando las relaciones de la base de datos.

Estas operaciones se encuentran organizadas en `RepositorioVeterinaria.cs` y se utilizan desde `Program.cs`.

## 📐 Modelado y documentación

El repositorio también contempla recursos de apoyo para el análisis y diseño del sistema:

- Diagramas de casos de uso.
- Diagramas de flujo.
- Diagrama de clases elaborado en BlueJ.

## 🎓 Propósito académico

Este proyecto permite aplicar conocimientos de programación, organización de clases, persistencia de datos, consultas SQL y diseño de sistemas, integrando diferentes herramientas utilizadas durante el aprendizaje.

---

**Desarrollado como proyecto académico de Ingeniería en Sistemas.**

🐾 *Cuidar su salud comienza con una buena organización.*

