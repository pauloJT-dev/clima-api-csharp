Aplicación de consulta del clima mediante API REST

Aplicación de consola desarrollada en C# que obtiene información meteorológica actual mediante la API de Open-Meteo.

Descripción

El programa realiza una petición HTTP a una API REST y procesa la respuesta en formato JSON para mostrar información del clima.

Actualmente consulta información utilizando las coordenadas de Cabo San Lucas, Baja California Sur, aunque la URL puede modificarse para consultar otras ubicaciones.

Información que muestra

* Temperatura actual
* Velocidad del viento
* Hora del reporte

Tecnologías utilizadas

* C#
* .NET
* API REST
* HTTP
* JSON
* HttpClient
* Programación asíncrona (async/await)

Funcionamiento

1. El programa establece la URL de la API.
2. Realiza una petición HTTP GET mediante HttpClient.
3. Recibe la respuesta de la API en formato JSON.
4. Procesa los datos utilizando JsonDocument.
5. Extrae la temperatura, velocidad del viento y hora.
6. Muestra la información en la consola.

API utilizada

Open-Meteo proporciona datos meteorológicos mediante una API que permite realizar consultas utilizando coordenadas geográficas.

Objetivo

Practicar el consumo de APIs REST, solicitudes HTTP, procesamiento de JSON y programación asíncrona utilizando C# y .NET.
