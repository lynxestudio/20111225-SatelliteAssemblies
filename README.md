# Entendiendo Satellite Assemblies usando MonoDevelop - (parte 1)

Una de las características más atractivas que .NET ofrece para el desarrollo de software es la capacidad de crear componentes en diferentes lenguajes de programación, esto es posible por que el objetivo de cada compilador existente para .NET es producir un assembly (ensamblado) el cual por definición es: La unidad funcional de distribución, versionamiento y de identidad de la plataforma .NET.
Además de clasificar los assemblies en Strong-Named o privados dependiendo de su instalación o en Single-File y Multi-File si contienen un archivo o varios, pueden también clasificarse en base a su contenido en donde tenemos a los ensamblados que contienen código MSIL y recursos (imágenes, traducciones o archivos de texto, etc) y a los Satellite assemblies (ensamblados satélite) que únicamente contienen recursos.
Para estos últimos ensamblados existen herramientas como Visual Studio o SharpDevelop que nos permiten hacerlo de forma automática, aunque también existe la opción de hacerlo de forma programática con las clases contenidas en el namespace System.Resources.

ResourceManager: Permite tener acceso a los archivos de recursos de forma programática.
ResourceReader: Lee los archivos binarios de recursos.
ResourceWriter: Escribe los archivos binarios de recursos.
ResXResourceReader: Lee los archivos XML de recursos.
ResXResourceWriter: Escribe los archivos XML de recursos.
En el siguiente programa mostramos el uso de la clase ResourceWriter para crear un satellite asembly. Abrimos MonoDevelop y creamos una solución GTK#, utilizando el diseñador de la interfaz gráfica, creamos una GUI similar a como se muestra en la siguiente imagen:

Construimos un manejador de evento para cada uno de los botones de manera que el código de la clase se vea como en el siguiente listado.


Al compilar y ejecutar el programa podemos ingresar uno a uno el nombre y el valor de la cadena o del archivo de imagen que contendrá nuestro archivo de recursos, en caso de las imágenes debemos habilitar el checkbox “Is image” además de que el archivo de imagen debe encontrarse físicamente en el mismo directorio que el programa, en las siguientes imágenes introduciremos un par de valores de prueba.


Después de ingresar el par de valores podemos generar físicamente el archivo de recursos con el botón “Build Resource”, como en la siguiente imagen:


La funcionalidad del botón “Build Resource” es crear una instancia de la clase ResourceWriter.
rw = new ResourceWriter("demo.resources")
Para después iterar en los valores de cada Hashtable,primero en el Hashtable de las cadenas en la cual utilizara el siguientel metodo:


rw.AddResource(entry.Key.ToString(),entry.Value.ToString());

A continuación itera en el Hastable de las imágenes en donde utiliza el método anterior salvo con la diferencia de convertir el valor en un objeto Bitmap.
rw.AddResource(entry.Key.ToString(),new Bitmap(entry.Value.ToString()));

Por último se utiliza el siguiente método:
rw.Generate();
Para crear físicamente el archivo “demo.resources” el cuál se creará en el mismo directorio donde se ejecuta el programa, como en la siguiente imagen:


Ahora solo falta crear el Satellite Assembly, esto puede lograrse con el compilador de .NET o bien con el Assembly Linker, para este tutorial utilizaremos el Assembly Linker, la instrucción para crear el ensamblado es la siguiente:

$ al /embed:demo.resources /out:demo.resources.dll
Utilizamos la opción /embed para incrustar el recurso en el ensamblado y la opción /out para nombrar al ensamblado resultado, este comando lo ejecutamos desde una terminal de consola como en la siguiente imagen:


Podemos observar que ahora el archivo mono.resources.dll es un ensamblado .NET válido mediante la herramienta MonoDis mediante el comando:

$ monodis mono.resources.dll
Veremos el contenido del ensamblado, como se muestra en la siguiente imagen:

Ahora ya tenemos listo el Satellite Assembly para que sea consumido por cualquier otra aplicación en .NET en la segunda parte mostraremos una aplicación para acceder al contenido del ensamblado.

