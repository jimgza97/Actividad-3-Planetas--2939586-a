Descripción del Proyecto

Este proyecto es una simulación simple del movimiento orbital de cuerpos celestes en Unity. Se representa un sistema solar en el que:

El Sol gira sobre su propio eje.

La Tierra orbita alrededor del Sol.

La Luna orbita alrededor de la Tierra con una velocidad menor.

El objetivo de este proyecto es demostrar el concepto de movimiento orbital utilizando funciones trigonométricas en Unity y permitir una simulación visual fluida.

Cómo se Hizo

El proyecto fue desarrollado en Unity utilizando C# para manejar las órbitas y la rotación de los cuerpos celestes. Se implementó un script llamado Orbit.cs que se encarga de calcular la posición de cada objeto en su órbita y manejar la rotación sobre su propio eje.

Pasos de Implementación:

Creación de los GameObjects:

Se crearon tres GameObjects en Unity: Sol, Tierra y Luna.

Se les asignaron sprites representativos a cada uno mediante el Sprite Renderer.

Jerarquía de los Objetos:

Tierra fue establecida como hijo del Sol.

Luna fue establecida como hija de la Tierra.

Aplicación del Script Orbit.cs

La Tierra recibió el script y se configuró para orbitar alrededor del Sol.

La Luna recibió el script y se configuró para orbitar alrededor de la Tierra con una velocidad menor.

El Sol fue configurado para rotar sobre su propio eje.

Cálculos en el Script:

Se utiliza Mathf.Cos y Mathf.Sin para calcular la posición de cada objeto en su órbita.

Se usa Time.time para garantizar un movimiento constante sin aceleración.

Se permite la rotación individual de los objetos si se activa la opción selfRotate en el Inspector.

Cómo Funciona

Al iniciar el juego en Unity (Play), la Tierra comienza a orbitar alrededor del Sol y la Luna alrededor de la Tierra.

La velocidad y el radio de la órbita de cada cuerpo pueden ajustarse desde el Inspector de Unity.

El Sol rota sobre su propio eje para añadir realismo a la simulación.

Este sistema permite comprender de manera sencilla cómo funcionan las órbitas y la rotación en un entorno 2D dentro de Unity.
