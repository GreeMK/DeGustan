# DeGustan
Programa de escritorio para DeGustan.
Hecho con Visual Basic .NET 8


# Errores
- Modulo Categorías
  - Cierre abrupto en el momento de hacer consultas seguidas, generado por cómo se gestiona la busqueda auto asistidas y la acción de buscar. La app realiza una consulta por cada letra ingresada, lo que genera muchas consultas y la BD se ve saturada y aborta.
    - Solución: Guardar los nombres de cada registro en memoria para luego mostrarlos en el desplegable
