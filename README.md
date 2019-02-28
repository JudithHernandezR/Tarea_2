# 2.1
##  2.1 Declaración de clases: atributos, métodos, encapsulamiento.
### Lee y escribe un resumen con tus palabras del siguiente documento: http://msdn.microsoft.com/es-es/library/ms173109.aspx
Clases  y estructuras son dos de las construcciones básicas. Cuando se crea un objeto de la clase, la variable a la que se asigna el objeto contiene solo una referencia a esa memoria. 
Una estructura es un tipo de valor. Cuando se crea una estructura, la variable a la que se asigna la estructura contiene los datos reales de ella, cuando se asigna a una nueva variable, se copia.
Métodos, campos, constantes, propiedades y eventos deben llevarse  dentro de un tipo; el cual se le nombra miembros, los diversos tipos de miembros que se pueden encontrar en una clase o estructura son,Campos, Constantes, Propiedades, Métodos, Constructores, Eventos, Finalizadores, Indizadores, Operadores y Tipos anidados.
Algunos de estos  métodos y propiedades están hechas para ser invocables y accesibles desde un código fuera de la clase o la estructura, lo que se denomina código de cliente
El termino  herencia es una clase que deriva de otra clase (la clase base) que contiene por defecto  todos los miembros públicos, protegidos e internos de la clase base, salvo sus constructores y finalizadores.
Una interfaz significa que el tipo implementa todos los métodos definidos en la interfaz.
Las clases y estructuras pueden definirse con algunos parámetros de tipos los cuales son :

**Tipos genéricos**: se define con un parámetro de código de cliente que  crea instancias de List <string> o List <int> para especificar que contendrá la lista.

**Tipo estático**: esta clase puede contener miembros estáticos y no se puede crear una instancia de ellos,  miembros son accesibles a través del nombre de clase.

**Tipos anidados** : esta clase como su nombre lo dice Una clase o estructura se puede anidar dentro de otra clase o estructura.

**Tipos parciales**: definen parte de una clase, estructura en un archivo de código y otra parte en un archivo de código independiente. 
**Iniciadores de objetos:** pueden iniciar fácilmente instancias de objetos de clase o estructura y de colecciones de objetos.

**Tipos Anonimos**: no es necesario crear una clase con nombre, se puede simplemente rellenar una lista con estructuras de datos que no tiene que conservar o pasar a otro método. 
**Métodos de extracción:** "extender" una clase sin crear una clase derivada mediante la creación y mantener la estructura original.
##   2.2 Instanciación de una clase.
###  Investiga sobre el operador new visto en clase. Describe algunos de sus usos.
Operador new básicamente se utiliza para crear objetos es útil para las instancias de tipo anónimo con este operador también podemos invocar el constructor predeterminado para tipos de valor lo cual nos puede brindar muchas facilidades al momento de utilizarlo, también hay que recordar que l operador new no se puede sobrecargar, si el operador new no puede asignar memoria, se produce la excepción .
## 2.3 Referencia al objeto actual.
### La palabra clave this hace referencia a la instancia actual de la clase. 
* Escribe un programa donde utilices this para obtener acceso a miembros con el fin de evitar ambigüedades con nombres similares.
* Escribe un programa donde se utilice this como parámetro.  
 ***programa this  c#***
 ## 2.4 Métodos: declaración, mensajes, paso de parámetros, retorno de valores.
 ### Lee y escribe un resumen con tus palabras de los siguientes documentos: 
Son métodos de clase y se ejecutan cuando es creado un objeto de un tipo determinado; tienen el mismo nombre de la clase e inician los miembros de datos del nuevo objeto. El constructor que no toma parámetros es llamados constructores predeterminados se invocan cuando se crea una instancia de un objeto mediante el operador new y no proporciona argumentos a new.
Las clases sin constructores se les asigna un constructor publico predeterminado, para habilitar la creación de instancias de clases.
Los constructores tipo struct no pueden contener un constructor predeterminado explicito ya que el compilador proporciona uno automáticamente; solo se invoca si se crea una instancia del tipo struct con new.
Las clases como las structs pueden definir constructor que acepten parámetros, se debe llamar a constructores que toman parámetros a través de una instrucción new o base. La palabra clave base puede utilizarse con o sin parámetros.
Un constructor puede invocar a otro constructor en el mismo objeto mediante la palabra this; this se puede utilizar con o sin parámetros.
Los constructores pueden ser marcados como public, private, protected, internal o protectedinternal. Estos modifican el acceso.
Un constructor se puede declarar como estático mediante la palabra clave static

## 2.5 Constructores y destructores: declaración, uso y aplicaciones.
### Los parámetros declarados en un método sin in, ref o out se van a otro método llamado por valor, el valor se puede cambiar en el método pero el cambio se pierde cuando es devuelto al control de procedimiento. Si usa palabras claves de PM en la declaración del parámetro se puede modificar el comportamiento
Palabras clave que se pueden utilizar para declarar PM
•	Params Dede ser una matriz unimensional, este puede especificar un parámetro de métodos que toma un numero variable de argumentos
Puede enviar una lista separada por comas de argumentos del tipo específico, también puede no enviar argumentos, pero su longitud cero
*	***In*** Se pasa por referencia, pero solo es leído por el método llamado
*	***Ref** La palabra clave ref indica un valor que se ha pasado mediante referencia. Se usa en cuatro contextos         diferentes:
       * En una firma del método y en una llamada al método, para pasar un argumento a un método mediante referencia
       * En una firma del método, para devolver un valor al autor de la llamada mediante referencia.
       * En un cuerpo de miembro, para indicar que un valor devuelto de referencia se almacena localmente como una referencia que el autor de la llamada pretende modificar o, en general, que una variable local accede a otro valor por referencia
       * En una declaración struct para declarar ref struct o ref readonly struct

    Cuando se usa en una lista de parámetros del método, la palabra clave ref indica que un argumento se ha pasado mediante referencia, no por valor.
*	***Out*** Se puede utilizar en dos contextos
    1.	Modificador de parámetros permite pasar un argumentó a un método mediante una referencia en vez de un valor
    2.	Declaraciones de parámetros de tipo genérico que especifica que un parámetro de tipo es covariante
    
    ## 2.7 Sobrecarga de operadores: Concepto y utilidad, operadores unarios y binarios.

    Implementa una clase llamada Dado, la cual es una abstracción de los dados de algún juego.
    Debe de tener por lo menos las siguientes propiedades:
    * valor
    * color
    La clase debe contar por lo menos con:
      * Dos constructores sobrecargados.
      * Los operadores ==, <, > sobrecargados.
      * El uso de la palabra clave this.
Realiza tu clase dentro del método Main de tu programa, creando tres dados, arrojándolos e imprimiendo el mejor de ellos o si alguno es igual.
