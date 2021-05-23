# tp5---2021-emybar
tp5---2021-emybar created by GitHub Classroom

##¿String es una tipo por valor o un tipo por referencia?
El Sring es un tipo de referencia, almacena una referencia a sus datos.

##¿Qué secuencias de escape tiene el tipo string?
secuencia de escape 	Nombre de carácter 	
          \' 	          Comilla simple 
          \" 	          Comilla doble 	
          \\ 	          Barra diagonal inversa 	
          \0 	          Null 	
          \a 	          Alerta 	
          \b 	          Retroceso 	
          \f 	          Avance de página 	
          \n 	          Nueva línea 	
          \r 	          Retorno de carro 	
          \t 	          Tabulación horizontal 	
          \v 	          Tabulación vertical 
          \u 	          Secuencia de escape Unicode (UTF-16) 	
          \U 	          Secuencia de escape Unicode (UTF-32) 	
          \x 	          Secuencia de escape Unicode similar a "\u" excepto con longitud variable 	


##¿Qué sucede cuando utiliza el carácter @ antes de una cadena de texto?
El carácter especial @ actúa como un identificador textual. Se puede usar de estas formas:
1- Para habilitar el uso de palabras clave de C# como identificadores. El carácter @ actúa como prefijo de un elemento de código que el compilador debe interpretar como un identificador en lugar de como una palabra clave de C#.
2-Para indicar que un literal de cadena se debe interpretar literalmente. El carácter @ de esta instancia define un literal de cadena textual. Las secuencias de escape sencillas (como "\\", que es una barra diagonal inversa), las secuencias de escape hexadecimales (como "\x0041", que es una A mayúscula) y las secuencias de escape Unicode (como "\u0041" que es una A mayúscula) se interpretan literalmente. Solo las secuencias de escape de comillas ("") no se interpretan literalmente, sino que generan comillas dobles. De igual modo, en el caso de una cadena interpolada literal, las secuencias de escape de llave ({{ y }}) no se interpretan literalmente, sino que generan caracteres de llave simple. En el siguiente ejemplo se definen dos rutas de archivo idénticas, una mediante un literal de cadena normal y otra mediante el uso de un literal de cadena textual. Este es uno de los usos más comunes de los literales de cadena textual.
