# Sistema Administrativo Peluqueria

Este proyecto es un sistema de gestión desarrollado en C#. A continuación, se describen los pasos para configurar y ejecutar el software correctamente.

## Requisitos Previos

- Tener instalado **SQL Server**.
- Tener un entorno de desarrollo configurado para **C#** (como Visual Studio).
- Contar con los privilegios necesarios para crear y gestionar bases de datos en SQL Server.

---

## Instrucciones de Configuración

### 1. Crear la Base de Datos

1. Navega a la carpeta donde se encuentra el script de la base de datos (`script.sql` o similar).
2. Abre SQL Server Management Studio (SSMS) o el cliente que prefieras para administrar SQL Server.
3. Ejecuta el script proporcionado para crear la base de datos y las tablas necesarias:
   ```sql
   -- Asegúrate de abrir el archivo del script e iniciar su ejecución completa.

## Configurar la Conexión a la Base de Datos

  1. Abre el proyecto en tu entorno de desarrollo.
  2. Ve a la clase Connection ubicada en la carpeta Models.
  3. Busca y edita la siguiente línea de código según los datos de tu SQL Server:
     ``
     return new SqlConnection(@"server=LAPTOP-989OF5PS\MSSQLSERVER02;database=SistemaGestionDB;integrated security=true;Encrypt=false");
     ``
     - server: Cambia el nombre del servidor por el de tu instancia de SQL Server.
       ``
       Por ejemplo: server=localhost; o server=MI-PC\SQLINSTANCE;.
       ``
     - database: Asegúrate de que el nombre sea SistemaGestionDB (o el que configuraste al ejecutar el script).
     - integrated security: Configura este valor en true o false dependiendo de si usas autenticación de Windows o SQL Server.
     - Encrypt=false: Mantén este valor si no necesitas cifrado.
    
## Ejecutar el Proyecto

  1. Una vez configurada la conexión, compila y ejecuta el proyecto desde tu entorno de desarrollo.
  2. El sistema debería estar listo para usar, interactuando con la base de datos creada previamente.

## Usuario Predeterminado
    
  El sistema incluye un usuario predeterminado para iniciar sesión:
  - Email: admin@gmail.com
  - Contraseña: Admin123*

Notas Adicionales
- Si encuentras problemas de conexión, verifica que:
  - El servidor SQL esté en ejecución.
  - La base de datos fue creada correctamente.
  - Las credenciales configuradas en la conexión son válidas.
- Puedes personalizar y extender el sistema según tus necesidades.
