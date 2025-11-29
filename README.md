# CaminaDog 🐕

**CaminaDog** es una aplicación web ASP.NET Core diseñada para ayudar a los dueños de perros a diagnosticar problemas de comportamiento y generar planes de paseo personalizados basados en las características y necesidades específicas de sus mascotas.

## 📋 Descripción

CaminaDog proporciona una plataforma interactiva donde los usuarios pueden:

- Ingresar información detallada sobre su perro (edad, raza, peso, nivel de energía, etc.)
- Identificar problemas de comportamiento específicos
- Recibir un diagnóstico personalizado con técnicas de corrección
- Obtener rutinas diarias y planes de paseo adaptados a las necesidades de su mascota

## 🚀 Características

- **Diagnóstico de Comportamiento**: Análisis de problemas comunes como hiperactividad, desobediencia, ansiedad por separación, y más
- **Planes Personalizados**: Generación de rutinas diarias y estrategias de corrección basadas en el perfil del perro
- **Interfaz Intuitiva**: Diseño moderno con tema oscuro para una mejor experiencia de usuario
- **Responsive Design**: Funciona perfectamente en dispositivos móviles y de escritorio

## 🛠️ Tecnologías

- **Framework**: ASP.NET Core 8.0
- **Patrón**: Razor Pages
- **Frontend**: HTML5, CSS3, Bootstrap 5
- **Lenguaje**: C# (.NET 8.0)
- **Arquitectura**: MVC con servicios inyectados

## 📁 Estructura del Proyecto

```
CaminaDog/
├── Models/              # Modelos de datos
│   ├── Diagnosis.cs     # Modelo de diagnóstico
│   └── StrategyPlan.cs  # Modelo de plan estratégico
├── Services/            # Lógica de negocio
│   └── DiagnosisService.cs
├── Pages/               # Razor Pages
│   ├── Index.cshtml     # Página principal
│   ├── Diagnosis.cshtml # Formulario de diagnóstico
│   ├── Plan.cshtml      # Visualización del plan
│   └── Shared/          # Componentes compartidos
├── wwwroot/             # Archivos estáticos
│   ├── css/             # Estilos
│   ├── js/              # Scripts
│   └── lib/             # Librerías
├── Program.cs           # Punto de entrada
└── appsettings.json     # Configuración
```

## 🔧 Requisitos Previos

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) o superior
- Un editor de código (Visual Studio, VS Code, Rider, etc.)
- Navegador web moderno

## 📦 Instalación

1. **Clonar el repositorio** (o navegar al directorio del proyecto):

   ```bash
   cd c:\Dev\appsNet\caminaDog\CaminaDog
   ```

2. **Restaurar dependencias**:

   ```bash
   dotnet restore
   ```

3. **Compilar el proyecto**:
   ```bash
   dotnet build
   ```

## ▶️ Ejecución

### Modo Desarrollo

```bash
dotnet run
```

La aplicación estará disponible en:

- HTTPS: `https://localhost:5195`
- HTTP: `http://localhost:5194`

### Modo Producción

```bash
dotnet run --configuration Release
```

## 🎯 Uso

1. **Accede a la página principal** en tu navegador
2. **Completa el formulario de diagnóstico** con la información de tu perro:
   - Nombre
   - Edad (acepta decimales, ej: 2.5 años)
   - Raza
   - Peso
   - Nivel de energía
   - Problemas de comportamiento observados
3. **Haz clic en "Generar Plan de Paseo"**
4. **Revisa el diagnóstico y plan personalizado** que incluye:
   - Análisis de problemas identificados
   - Técnicas de corrección específicas
   - Rutina diaria recomendada
   - Plan de paseo adaptado

## 🎨 Características de Diseño

- **Tema Oscuro**: Interfaz moderna con paleta de colores oscuros para reducir la fatiga visual
- **Diseño Responsivo**: Adaptable a diferentes tamaños de pantalla
- **Animaciones Suaves**: Transiciones y efectos visuales para mejorar la experiencia del usuario
- **Accesibilidad**: Diseño pensado para ser accesible y fácil de usar

## 🧪 Desarrollo

### Agregar Nuevos Problemas de Comportamiento

Edita el archivo `Services/DiagnosisService.cs` y agrega nuevos casos en el método de diagnóstico.

### Modificar Estilos

Los estilos personalizados se encuentran en `wwwroot/css/site.css`. El tema oscuro está implementado mediante variables CSS.

## 📝 Licencia

Este proyecto es de uso privado y educativo.

## 👥 Contribuciones

Este es un proyecto personal. Si deseas contribuir o tienes sugerencias, por favor contacta al desarrollador.

## 📧 Contacto

Para preguntas o soporte, contacta al equipo de desarrollo.

---

**Desarrollado con ❤️ para mejorar la vida de los perros y sus dueños**
