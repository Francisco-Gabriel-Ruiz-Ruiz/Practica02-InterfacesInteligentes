# Práctica #2 de Interfaces Inteligentes: Introducción C# - Scripts (Parte II)

Esta es la segunda práctica de la asignatura **Interfaces Inteligentes** (curso 2026-2027), perteneciente al [Grado en Ingeniería Informática](https://www.ull.es/grados/ingenieria-informatica/) de [La Universidad de La Laguna](https://www.ull.es/).

El objetivo principal de esta práctica es continuar familiarizándose con la herramienta Unity y C#, profundizando en el uso de los sistemas de Input, transformaciones espaciales (traslación y rotación), normalización de vectores y la independencia de fotogramas mediante `Time.deltaTime`. Este informe documenta la realización de los ejercicios del 5 al 13 de la hoja de problemas propuesta.

[Enlace a la hoja de problemas.](https://docs.google.com/document/d/1eL4NESQfyvbkEFGkTgvQwmgPjrnUmd03bNzlArNYYEs/edit?tab=t.0)

La metodología seguida para su realización es la siguiente:

* Sincronización del proyecto de Unity con este repositorio. Por lo general, un commit para cada ejercicio.
* Creación del directorio **Scripts** con todo el código C# desarrollado.
* Un script para cada ejercicio.
* Una misma escena base, adaptada según las necesidades de los ejercicios.

---

## Ejercicio 5

* Código desarrollado en [Assets/Scripts/Ej5Desplazamiento.cs](/Assets/Scripts/Ej5Desplazamiento.cs)
* Demostración en GIF:
![Demostración ejercicio 5](/GitImages/Ejercicio05-P02-II.gif)

Vemos en el GIF cómo los objetos se desplazan a unas posiciones determinadas relativas a su origen al pulsar la barra espaciadora.

En cuanto al script y configuración:
* Se configuró la escena con tres objetos y tres "marcadores invisibles" (GameObjects vacíos) para calcular el vector de desplazamiento inicial de forma visual.
* Se definió la variable pública `desplazamiento` de tipo `Vector3`.
* Se utiliza `Input.GetAxis("Jump") > 0` para detectar si el usuario ha pulsado la barra espaciadora.
* Al pulsar la tecla, la posición de los objetos se actualizan sumando el vector de desplazamiento a su `posicionOriginal` calculada en el `Start()`.

## Ejercicio 6

* Código desarrollado en [Assets/Scripts/Ej6CampoVelocidad.cs](/Assets/Scripts/Ej6CampoVelocidad.cs)
* Demostración en GIF:
![Demostración ejercicio 6](/GitImages/Ejercicio06-P02-II.gif)

Vemos en el GIF y en la consola cómo se muestran los resultados matemáticos calculados al presionar las teclas de flecha. 

En cuanto al script:
* Se ha añadido el campo público `speed` (velocidad).
* Se capturan los valores de los ejes mediante `Input.GetAxis("Horizontal")` e `Input.GetAxis("Vertical")`.
* Se detecta qué tecla exacta ha sido pulsada usando `Input.GetKey(KeyCode.X)`.
* Se calcula el producto de la velocidad por el eje correspondiente y se imprime en consola formateado a dos decimales con `CultureInfo.InvariantCulture` para usar el punto como separador. 

## Ejercicio 7

* Demostración con captura de pantalla:
![Demostración ejercicio 7](/GitImages/Ejercicio07-P02-II.png)

Para este ejercicio no se ha desarrollado un script, ya que la tarea consistía en configurar el Input Manager del proyecto.

Metodología:
* Se ha accedido a **Edit → Project Settings → Input Manager**.
* Dentro de los *Axes*, se ha modificado la entrada llamada `Fire1`.
* Se ha asignado la tecla `h` al campo *Alt Positive Button* sin sobrescribir la entrada principal (*Positive Button*). Esto permite que el eje reaccione tanto al control original como a esta nueva tecla de manera alternativa al llamar a `Input.GetAxis("disparo")` o `Input.GetButton("disparo")`.

## Ejercicio 8

* Código desarrollado en [Assets/Scripts/Ej8CuboMovimiento.cs](/Assets/Scripts/Ej8CuboMovimiento.cs)
* Demostración en GIF:
![Demostración ejercicio 8](/GitImages/Ejercicio08-P02-II.gif)

En este ejercicio el cubo se desplaza de forma constante en cada iteración basándose en un vector de dirección y una velocidad.

En cuanto al script y análisis:
* Se declaran `moveDirection` (Vector3) y `speed` (float) configurables desde el Inspector.
* En el método `Start()`, se fuerza a que `speed` sea mayor que 1 y que la posición inicial `y` sea exactamente 0, cumpliendo con las restricciones del enunciado.
* En `Update()`, se aplica el movimiento con `transform.Translate(moveDirection * speed)`.

**Análisis de situaciones propuestas:**
* **a. Duplicar coordenadas de dirección:** El cubo se mueve el doble de rápido, ya que la magnitud del vector dirección se multiplica por dos.
* **b. Duplicar la velocidad:** El efecto visual es idéntico al caso 'a'; el cubo avanza el doble de rápido en la misma dirección.
* **c. Velocidad menor que 1:** Al iniciar la escena, el script (por seguridad en el `Start`) fuerza la velocidad a un valor mayor que 1 (ej. 1.1f), por lo que si se intenta poner a 0.5 antes del Play, se auto-corrige. Si se cambia en tiempo de ejecución, el cubo irá más lento. Si en tiempo de ejecución lo cambiamos a valores negativos, se invierte su movimiento.
* **d. Posición Y > 0:** Al darle a Play, el script fuerza la posición Y del cubo a 0 inmediatamente.
* **e. Sistema de referencia local vs mundial:** Si el cubo está rotado, usar `Space.Self` (por defecto en Translate) lo moverá respecto a su propia orientación. Si usamos `Space.World`, se moverá respecto a los ejes globales de la escena sin importar hacia dónde mire el cubo.

## Ejercicio 9

* Código desarrollado en [Assets/Scripts/Ej9CuboPlayer.cs](/Assets/Scripts/Ej9CuboPlayer.cs) y [Assets/Scripts/Ej9EsferaPlayer.cs](/Assets/Scripts/Ej9EsferaPlayer.cs)
* Demostración en GIF:
![Demostración ejercicio 9](/GitImages/Ejercicio09-P02-II.gif)

Vemos cómo el cubo se controla mediante los ejes personalizados del Input Manager para las flechas (`HorizontalArrows` y `VerticalArrows`) y la esfera mediante los ejes de letras (`HorizontalAD` y `VerticalWS`).

He aquí capturas de los ejes personalizados:

![Captura de pantalla del Input Manager de ejes horizontales](/GitImages/InputManagerHorizontalCaptura.png)

![Captura de pantalla del Input Manager de ejes verticales](/GitImages/InputManagerVerticalCaptura.png)

En cuanto a los scripts:

* Se usan los valores devueltos por `Input.GetAxis(...)` utilizando los nombres de los ejes creados en el Input Manager (`HorizontalArrows`, `HorizontalAD`, `VerticalArrows`, `VerticalWS`).
* Se utiliza `transform.Translate` aplicando la variable de velocidad `speed` multiplicada por el valor del eje correspondiente en los ejes $X$ o $Y$, logrando un movimiento horizontal y vertical básico dependiente de los fotogramas (frames).

## Ejercicio 10

* Código desarrollado en [Assets/Scripts/Ej10CuboPlayer.cs](/Assets/Scripts/Ej10CuboPlayer.cs) y [Assets/Scripts/Ej10EsferaPlayer.cs](/Assets/Scripts/Ej10EsferaPlayer.cs)
* Demostración en GIF:
![Demostración ejercicio 10](/GitImages/Ejercicio10-P02-II.gif)

A simple vista el comportamiento es similar al Ejercicio 9, pero el movimiento ahora es independiente de la potencia del ordenador.

En cuanto a los scripts:
* Se ha introducido `Time.deltaTime`. Se calcula `float moveStep = speed * Time.deltaTime;`.
* Al multiplicar por este factor, la velocidad deja de medirse en unidades por frame y pasa a medirse en unidades por segundo, escalando el movimiento al tiempo real transcurrido entre fotogramas.

## Ejercicio 11

* Código desarrollado en [Assets/Scripts/Ej11CuboAcercandoseObjetivo.cs](/Assets/Scripts/Ej11CuboAcercandoseObjetivo.cs)
* Demostración en GIF:
![Demostración ejercicio 11](/GitImages/Ejercicio11-P02-II.gif)

Vemos en el GIF cómo el cubo persigue incansablemente a la esfera. Si alejamos la esfera, el cubo no acelera; mantiene su velocidad constante y nunca altera su altura (eje Y).

En cuanto al script:
* Se obtiene la dirección restando la posición actual a la del objetivo: `targetPosition - transform.position`.
* Para evitar que modifique su altura, se fuerza la componente Y del vector de dirección a cero antes de normalizar.
* Se usa `.normalized` sobre el vector resultante. Esto es crucial: convierte el vector a magnitud 1, logrando que el objeto avance solo en base a su variable `speed` y no a la distancia que lo separa del objetivo.

## Ejercicio 12

* Código desarrollado en [Assets/Scripts/Ej12CuboAcercandoseMirando.cs](/Assets/Scripts/Ej12CuboAcercandoseMirando.cs)
* Demostración en GIF:
![Demostración ejercicio 12](/GitImages/Ejercicio12-P02-II.gif)

A diferencia del ejercicio anterior, ahora el cubo rota físicamente para encarar (mirar de frente) a la esfera mientras se acerca a ella.

En cuanto al script:
* Se emplea la función `transform.LookAt(targetTransform)` para que el eje Z local del cubo apunte siempre en dirección a la esfera.
* Para el avance, se modificó el método `Translate` para que actúe sobre el espacio global usando `Space.World`.

## Ejercicio 13

* Código desarrollado en [Assets/Scripts/Ej13EsferaControlZ.cs](/Assets/Scripts/Ej13EsferaControlZ.cs)
* Demostración en GIF:
![Demostración ejercicio 13](/GitImages/Ejercicio13-P02-II.gif)

Vemos cómo la esfera se maneja con un estilo de control tipo "coche": el eje horizontal la hace girar sobre sí misma, y avanza constantemente hacia adelante en base a hacia dónde está mirando.

En cuanto al script:
* Se utilizan las propiedades físicas y geométricas locales. 
* Para el giro, se captura `Input.GetAxis("Horizontal")` y se aplica una rotación sobre su eje vertical mediante `transform.Rotate(Vector3.up * rotationValue)`.
* Para cumplir el requisito del enunciado, el avance hacia adelante se realiza extrayendo el vector frontal del objeto mediante la propiedad `transform.forward` y aplicándolo al movimiento en el espacio global: `transform.Translate(transform.forward * speed * Time.deltaTime, Space.World);`.
