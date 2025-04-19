# Traductor Multilingüe con GPT-4

Aplicación de escritorio para traducir texto entre múltiples idiomas mediante la API de OpenAI (GPT-4). Ofrece una interfaz gráfica ligera, traducción contextual precisa, historial local y soporte para más de 10 idiomas.

## Índice

- [Características](#características)
- [Requisitos](#requisitos)
- [Instalación](#instalación)
  - [Uso de appsettings.json](#uso-de-appsettingsjson)

## Características

- Traducción contextual usando GPT-4.
- Soporte para más de 50 idiomas.
- Selección de idioma de origen y destino.
- Copia rápida del resultado al portapapeles.
- Historial de las últimas 10 traducciones.
- Configuración flexible mediante archivos, entorno o entrada manual.

## Requisitos

- [.NET 6.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
- Cuenta en [OpenAI](https://platform.openai.com/signup) con clave API.
- IDE compatible (Visual Studio, Rider, VS Code).
- Conexión a Internet.

## Instalación

```bash
# Clonar el repositorio
git clone https://github.com/DevM4riano/Traductor-GPT4.git
cd Traductor-GPT4

# Restaurar dependencias
dotnet restore

# Crear archivo de entorno (opcional si no usas appsettings)
echo "OPENAI_API_KEY=tu_clave_aquí" > .env

# Ejecutar la aplicación
dotnet run
```

### _Uso de appsettings.json_

- Puedes definir la clave de API en el archivo de configuración estándar de .NET `appsettings.json`, que suele ser adecuado para entornos de desarrollo.

> [!TIP]  
> **Recomendación:** Para mantener tus credenciales seguras y evitar comprometerlas en un repositorio público, es recomendable usar un archivo `.env` para almacenar las claves API en vez de `appsettings.json`. El archivo `.env` se puede excluir de control de versiones (añadiéndolo a `.gitignore`) para proteger la clave de accesos no autorizados. Este método también es más flexible para trabajar en diferentes entornos (local, testing, producción).

```json
{
  "OpenAI": {
    "ApiKey": "tu_clave_aquí"
  }
}
```
