<!-- Traductor Multilingüe con GPT-4

Aplicación de escritorio para traducir textos usando la inteligencia artificial de OpenAI (GPT-4). Soporta más de 50 idiomas y es fácil de usar.

¿Qué hace esta app?

Esta aplicación permite traducir textos de un idioma a otro utilizando la inteligencia de GPT-4. Puedes seleccionar el idioma de origen y el idioma al que deseas traducir. Escribes o pegas el texto, y la app muestra el resultado traducido. Puedes copiar la traducción con un clic. Tiene modo claro y oscuro, y guarda las últimas 10 traducciones.


Entendido, José. Aquí tienes todo en una sola estructura, sin líneas divisoras ni underscores, manteniendo los desplegables, la numeración clara y los bloques de código copiable:

<details>  
<summary><strong>Requisitos</strong></summary>


	•	.NET 6.0 SDK
	•	Cuenta de OpenAI con clave API
	•	Visual Studio o Rider (opcional)

</details>

<details>  
<summary><strong>Instalación</strong></summary>



```bash

# 1. Clonar el repositorio:

git clone https://github.com/DevM4riano/Traductor-GPT4.git
cd Traductor-GPT4

# 2. Restaurar las dependencias:

dotnet restore

# 3. Crear un archivo .env en la raíz del proyecto con tu clave:

OPENAI_API_KEY=tu_clave_aquí

# 4. Ejecutar la aplicación:

dotnet run
```
</details>


<details>  

<summary><strong>Detección de la clave API</strong></summary>


La app busca la clave en el siguiente orden: 

	1.	En el archivo .env
	2.	En las variables de entorno del sistema
	3.	Si no la encuentra, se solicita al iniciar la aplicación

</details>
