# Fashion-World

# FASHION WORLD

**Fashion World** es un proyecto grupal del primer cuatrimestre de la carrera de la Tecnicatura Universitaria en Programación, en el cual se buscó exponer los conocimientos adquiridos a lo largo de los meses, mediante una aplicación de escritorio (WinForms) desarrollada con .NET y C#.

> Esta aplicación esta orientada a la gestión de inventario de una empresa de ropa. A través de esta aplicación, se pueden manipular los productos y gestionar atributos clave como las tablas auxiliares, que influyen en el sistema. Además, se busca proporcionar a los usuarios la capacidad de consultar y obtener estadísticas basadas en los datos almacenados, permitiéndoles así obtener un control detallado de sus productos y estadísticas relevantes sobre su empresa.
> 

## El proyecto se dividió en tres etapas fundamentales:

### 1ª Etapa

El primer paso fue desarrollar el diagrama de la base de datos, definiendo las tablas maestras y auxiliares, claves, restricciones y las relaciones entre ellas.

### 2ª Etapa

En esta etapa se implementó el diseño de la base de datos en SQL Server, creando las tablas mediante scripts del sistema. Se utilizaron las sentencias de definición de datos (DDL) para crear la estructura de la base de datos y luego se insertaron datos en las tablas, realizando consultas complejas a las mismas utilizando sentencias de manipulación de datos (DML).

### 3ª Etapa

Finalmente, se diseñó la interfaz gráfica utilizando WinForms de .NET, con C# como lenguaje de programación. El proyecto se estructuró en tres capas principales:

- **Capa de Datos**: Utilizando ADO.NET, se realizaron las consultas hacia la base de datos y se gestionó el acceso a la misma. En esta capa se implementó el patrón **DAO (Data Access Object)**.
- **Capa de Negocio**: Aquí se definieron las entidades de la base de datos en el código, permitiendo la lógica de negocio de la aplicación.
- **Capa de Presentación**: En esta capa se gestionaron las distintas interfaces que conformaban la aplicación, facilitando la interacción del usuario con el sistema.

En esta última etapa, se aplicaron los conocimientos adquiridos sobre **ADO.NET**, conexión manual a bases de datos (sin el uso de ORMs), manipulación de componentes en una interfaz gráfica y el concepto de ABMC (Alta, Baja, Modificación y Consulta), lo que permitió interactuar con la base de datos desde una aplicación externa.

---

Las funcionalidades desarrolladas en la aplicación fueron las siguientes:

- ABMC de la tabla principal (prendas de ropa/productos).
- Sistema de filtrado de productos por marca, precio, tipo de prenda, rubro, entre otros.
- Agregar nuevos registros a tablas auxiliares como Rubros, Tipos de prendas y Marcas, con el fin de que estos afecten el manejo de la tabla principal (Productos).
- Desarrollo de una sección para mostrar los resultados de las consultas realizadas en la segunda etapa del proyecto.

---
