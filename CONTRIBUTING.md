# 🤝 Guía de Contribución

Tu participación es fundamental para el éxito y crecimiento de este proyecto. A continuación, se detallan las mejores prácticas para contribuir de manera efectiva y profesional.

## Índice

1. [Flujo de Trabajo para Contribuir](#flujo-de-trabajo-para-contribuir)
2. [Convenciones para Mensajes de Commit](#convenciones-para-mensajes-de-commit)
3. [Estructura de Nombres para Ramas](#estructura-de-nombres-para-ramas)
4. [Buenas Prácticas en el Uso de `.env`](#buenas-prácticas-en-el-uso-de-env)
5. [Código de Conducta](#código-de-conducta)


## Flujo de Trabajo para Contribuir

1. **Haz un fork del repositorio**:  
   Dirígete a la esquina superior derecha del repositorio y haz clic en "Fork" para crear una copia en tu cuenta de GitHub.

2. **Clona tu repositorio forkeado**:  
   ```bash
   git clone https://github.com/tu_usuario/Traductor-GPT4.git
   cd Traductor-GPT4
   ```

3. **Crea una rama para tu contribución**:  
   Utiliza nombres descriptivos que sigan el formato `tipo/descripción-breve`. Por ejemplo:
   ```bash
   git checkout -b feat/soporte-japones
   ```

4. **Realiza tus cambios**:  
   Asegúrate de seguir las convenciones de código y las buenas prácticas establecidas.

5. **Realiza commits descriptivos**:  
   Usa mensajes claros que describan los cambios realizados. Ejemplo:
   ```bash
   git commit -m "feat: añadido soporte para japonés"
   ```

6. **Envía un Pull Request (PR)**:  
   Sube tus cambios a tu repositorio:
   ```bash
   git push origin feat/soporte-japones
   ```
   Luego, en el repositorio original, haz clic en "New Pull Request" y proporciona una descripción detallada de los cambios.

## Convenciones para Mensajes de Commit

Adopta el estándar [Conventional Commits](https://www.conventionalcommits.org/en/v1.0.0/) para mantener un historial de commits claro y estructurado. Las convenciones incluyen:

- **Uso del modo imperativo**:  
  Escribe los mensajes como si estuvieras dando una orden. Ejemplo:
  ```bash
  git commit -m "fix: corregir error en la traducción de caracteres especiales"
  ```

- **Estructura del mensaje**:  
  ```bash
  <tipo>(<alcance>): <descripción>
  ```
  Ejemplos de tipos comunes:
  - `feat`: Nueva funcionalidad
  - `fix`: Corrección de errores
  - `docs`: Cambios en la documentación
  - `refactor`: Mejoras en el código sin cambios funcionales
  - `test`: Añadir o corregir pruebas
  - `chore`: Tareas de mantenimiento

- **Uso de pies de página**:  
  Para cambios que rompen la compatibilidad, utiliza:
  ```bash
  BREAKING CHANGE: <descripción del cambio>
  ```

## Estructura de Nombres para Ramas

Utiliza convenciones claras para nombrar las ramas:

- `feat/`: Nuevas funcionalidades
- `fix/`: Corrección de errores
- `docs/`: Cambios en la documentación
- `refactor/`: Mejoras en el código
- `test/`: Añadir o corregir pruebas

Ejemplos:
- `feat/soporte-japones`
- `fix/correccion-traduccion`
- `docs/actualizacion-readme`

## Buenas Prácticas en el Uso de `.env`

Para gestionar de manera segura las claves API y otras configuraciones sensibles, se recomienda el uso de archivos `.env`. Estos archivos permiten almacenar variables de entorno que pueden ser cargadas en la aplicación sin comprometer la seguridad.

- **Creación del archivo `.env`**:  
  En la raíz del proyecto, crea un archivo `.env` con el siguiente contenido:
  ```env
  OPENAI_API_KEY=tu_clave_aquí
  ```

- **Uso del archivo `.env` en el proyecto**:  
  Asegúrate de que tu aplicación cargue las variables de entorno desde el archivo `.env` al iniciar. Esto puede hacerse utilizando bibliotecas como `dotenv` en entornos Node.js o configuraciones específicas en otros lenguajes.

- **Exclusión del archivo `.env` del control de versiones**:  
  Para evitar que las claves sensibles sean compartidas, agrega el archivo `.env` al archivo `.gitignore`:
  ```
  .env
  ```

- **Alternativa con `appsettings.json`**:  
  Si prefieres no usar un archivo `.env`, puedes almacenar la clave API en el archivo `appsettings.json`:
  ```json
  {
    "OpenAI": {
      "ApiKey": "tu_clave_aquí"
    }
  }
  ```
  Sin embargo, ten en cuenta que este archivo puede ser incluido en el control de versiones, por lo que es crucial asegurarse de que no contenga información sensible antes de compartirlo.

## Código de Conducta

Para promover un ambiente inclusivo y respetuoso, este proyecto adopta el [Contributor Covenant](https://www.contributor-covenant.org/), un código de conducta para proyectos de código abierto. Este código establece expectativas claras sobre el comportamiento de los contribuyentes y busca crear una comunidad acogedora para todos.
