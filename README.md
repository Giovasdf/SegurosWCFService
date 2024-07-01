Este proyecto implementa un servicio WCF (Windows Communication Foundation) para una aseguradora, proporcionando funcionalidades clave para la gestión de seguros. WCF es una tecnología de Microsoft ideal para desarrollar servicios interoperables que utilizan varios protocolos de comunicación.

Estructura del Proyecto:
AseguradoraWCF.sln: Solución de Visual Studio que contiene el proyecto del servicio WCF.
AseguradoraWCF/: Carpeta raíz del proyecto.
Servicio.svc: Archivo que define el servicio WCF para la gestión de seguros.
IServicioSeguros.cs: Interfaz que define las operaciones del servicio, como consultar pólizas y registrar siniestros.
ServicioSeguros.cs: Implementación de la interfaz del servicio que contiene la lógica de negocio para las operaciones de seguros.
Configuracion/: Carpeta que contiene archivos de configuración del servicio WCF.
Web.config: Configuración principal del servicio WCF, incluyendo la configuración de endpoints y comportamientos.

Configuración y Uso:
Abre la solución AseguradoraWCF.sln en Visual Studio.
Compila y ejecuta el proyecto para iniciar el servicio WCF.
El servicio estará disponible en la URL especificada en el archivo de configuración Web.config.
Puedes consumir el servicio WCF desde aplicaciones cliente, como aplicaciones .NET, utilizando las operaciones definidas en IServicioSeguros.cs.
