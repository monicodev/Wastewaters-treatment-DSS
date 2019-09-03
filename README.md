Wastewater-treatment-DSS :computer:
=============
Las plantas depuradoras de aguas residuales se encargan de reducir las cargas contaminantes presentes en este tipo de aguas, antes de que estas sean vertidas en el medio ambiente, y para ello es fundamental que a estas aguas se le realicen varios análisis especializados que proporcionen información sobre ciertas propiedades de ellas y así poder tomar decisiones sobre los métodos de tratamientos a emplear paraque los efluentes de las plantas cumplan con la normas ambientales establecidas. Para ello se aplican modelos matemáticos que permiten tomar los datos obtenidos de los análisis realizados en los laboratorios y procesarlos para convertirlos en información útil. Por lo que a continuación se presenta el desarrollo de un prototipo de un sistema para el soporte de decisiones sobre los procesos operacionales de las plantas depuradoras de aguas residuales de tipo lodo activado. Este software permite brindar apoyo en el almacenamiento y procesamiento de los resultados de los ensayos de laboratorio realizados a las aguas residuales para ofrecer información que favorezca la toma de decisiones oportunas y certeras sobre los métodos de tratamientos a emplear para reducir los contaminantes que se encuentra en ellas.

## Indice de Contenido :paperclip:
- [Introducción](#Introducción)
- [Objetivo](#Objetivo)
- [Requerimientos Funcionales](#Requerimientos)
- [Casos de uso](#Casos)
- [Diseño estructurado](#Diseño)
- [Author](#Author)

## Introducción :page_with_curl:
El agua es un recurso natural muy importante para los seres vivientes, por lo que es fundamental mantener su calidad para que esta no afecte negativamente en el ecosistema que le rodea. Por lo que las aguas portadoras de residuos, procedentes de las comunidades, a las que pueden agregarse eventualmente, aguas subterráneas, superficiales y pluviales; que vayan a ser vertidas en los cuerpos de agua deben pasar antes por una planta depuradora que se encargue de aplicar métodos de tratamientos para el saneamiento del agua con el fin de reducir las cargas contaminantes.

Para garantizar la calidad del agua, es necesario contar con cierto equipo que le dé el tratamiento correspondiente. Es por este motivo que las plantas depuradoras son tan importantes dentro de las comunidades, ya que estas se encargan de procesar parte de la materia orgánica, reduciendo la carga contaminante que se encuentra en el agua, a fin de que esta cumpla con las normas ambientales establecidas

Generalmente en las plantas de tratamiento se disponen de laboratorios donde se realizan análisis especializados para determinar variables, sobre las aguas residuales, que miden sus contaminantes, con la finalidad de tomar decisiones oportunas sobre los métodos de tratamientos a emplear para reducirlos, de tal forma que los efluentes de la planta cumplan con las normas ambientales establecidas. Para ello se aplican modelos matemáticos que se alimentan de los ensayos de laboratorio que generan la información que ayuda a reducir esta incertidumbre. 

## Objetivo :dart:
Desarrollar un prototipo de un sistema de soporte de decisiones para los procesos operacionales de las plantas depuradoras de aguas residuales de tipo lodo activado.

## Requerimientos Funcionales del Sistema :pushpin:

- Listar, almacenar y actualizar los datos del personal del laboratorio.
- Listar, almacenar y actualizar los datos de los clientes del laboratorio.
- Listar y actualizar los datos de los parámetros para el control de la planta de tratamiento.
- Listar, almacenar, actualizar y eliminar los datos y resultados de los ensayos realizados en el Laboratorio de Ingeniería Sanitaria en cualquier punto de muestra.
- Generar los reportes en Excel de los resultados de los análisis bajo el formato aprobado para el Laboratorio de Ingeniería Sanitaria. 
- Generar las gráficas para la determinación de la constante de desoxigenación y DBO último.
- Generar las gráficas para la determinación del coeficiente de decantamiento y productividad.
- Generar las gráficas independiente con respecto al tiempo en cada punto y variable.
- Generar correlaciones entre las variables DBO vs OD y OD vs SST * 0.8.
- Calcular la relación alimento-microorganismos (F/M).

## Casos de uso :speech_balloon:
Los diagramas de casos de uso permitieron capturar los servicios que el usuario adquiere al interactuar con el sistema, siendo importante que todos los requerimientos funcionales se encuentren reflejados en este.
- Gestionar Personal:

|**Caso de uso**|Gestionar Personal|
|-----------|--------------------|
|**Objetivo**|Listar, agregar y actualizar la información del personal del laboratorio.|
|**Pre-condiciones**|Para almacenar un personal se requiere cedula, nombre, apellido y cargo en el laboratorio de ingeniería sanitaria.|
|**Flujo de eventos**|Se lista en una tabla la información del personal registrado en el sistema. Adicionalmente se puede agregar personal nuevo o actualizar la información de los existente.|
|**Post_condiciones**|Los datos del personal se registran al sistema.|

- Gestionar cliente:

|**Caso de uso**|Gestionar cliente|
|-----------|--------------------|
|**Objetivo**|Listar, agregar y actualizar la información de los clientes del laboratorio de ingeniería sanitaria.|
|**Pre-condiciones**|Para almacenar un cliente se requiere Rif, razón social y dirección, adicionalmente se puede añadir un número de teléfono.|
|**Flujo de eventos**|Se lista en una tabla la información de los clientes registrado en el sistema. Adicionalmente se puede agregar clientes nuevos o actualizar la información de los existente.|
|**Post_condiciones**|Los datos de los clientes se registran al sistema.|

- Gestionar muestras:

|**Caso de uso**|Gestionar muestras|
|-----------|--------------------|
|**Objetivo**|Listar, agregar, actualizar y eliminar muestras al sistema.|
|**Pre-condiciones**|Para almacenar una muestra se requiere identificación de la muestra, identificar el cliente, fecha y hora de la toma de la muestra, captador de la muestra, analista de la muestra y el punto de estudio donde se tomo la muestra.|
|**Flujo de eventos**|Se lista en una tabla la información de las muestras registradas en el sistema, la cual se puede aplicar filtros de búsqueda. Adicionalmente se puede agregar muestras nuevas y actualizar o eliminar las muestras existente.|
|**Post_condiciones**|La información de las muestras se registra o eliminan del sistema.|

- Generar  reportes:

|**Caso de uso**|Generar  reportes|
|-----------|--------------------|
|**Objetivo**|Crear reportes para las muestras en Excel.|
|**Pre-condiciones**|Seleccionar una muestra registrada en el sistema.|
|**Flujo de eventos**|Se toma la información registrada de la muestra seleccionada y se genera un reporte en Excel.|
|**Post_condiciones**|Se genera un documento en Excel con los resultados de la muestra seleccionada.|

- Generar gráficos, correlaciones y cálculos:

|**Caso de uso**|Generar gráficos, correlaciones y cálculos|
|-----------|--------------------|
|**Objetivo**|Generar los gráficos, correlaciones y cálculos que brinden información al usuario.|
|**Pre-condiciones**|Tener datos de muestras suficientes para poder generar información útil.|
|**Flujo de eventos**|El usuario debe seleccionar el tipo de información que desea consultar aplicando filtros para realizar una consulta detallada sobre los datos a utilizar.|
|**Post_condiciones**|El sistema procederá a recopilar y procesar los datos para genera una tabla con los resultados de la consulta de la cual se puede generar una grafica que ofrece información para el usuario.|

- Gestionar Parámetros:

|**Caso de uso**|Gestionar parámetros|
|-----------|--------------------|
|**Objetivo**|Listar y actualizar los rangos y límites máximos  de los parámetros para el control de la   planta de tratamiento.|
|**Pre-condiciones**|Para actualizar los rangos y límites de los parámetros se requiere seleccionar   un parámetro e indicar sus límites.|
|**Flujo de eventos**|Actualizar los rangos y límites máximos de los parámetros.|
|**Post_condiciones**|Los rangos y límites máximos son actualizados.|

## Diseño estructurado :capital_abcd: :arrows_clockwise:
A partir de los casos de uso donde se identificaron los servicios a implementar en el sistema, se realizó la descomposición del sistema en módulos estructurados en jerarquías, lo que permitió identificar y organizar los módulos y sus relaciones:

- **Personal**: Módulo donde se realiza la gestión (listar, almacenar y actualizar) de los datos del personal del laboratorio en el sistema.
    - **Agregar/Actualizar personal**: Este módulo se encarga de recolectar los datos del personal para registrarlos en el sistema.
- **Clientes**: Módulo que permite la gestión (listar, almacenar y actualizar) de los datos de los clientes en el sistema.
    - **Agregar/Actualizar clientes**: Módulo que permite recolectar los datos de los clientes para registrarlos en el sistema.
- **Muestras**: Módulo donde se realiza la gestión (listar, almacenar, actualizar, eliminar y reportar) de los datos de las muestras en el sistema.
    - **Agregar/Actualizar muestras**: Módulo que permite recolectar los datos de las muestras para registrarlos en el sistema.
    - **Agregar/Actualizar resultados muestras**: Este módulo se encarga de recolectar los resultados de las muestras para registrarlos en el sistema.
- **Parámetros**: Módulo que permite la gestión (listar y actualizar) de los datos de los parámetros para el control de la planta de tratamiento en el sistema.
    - **Actualizar rangos y límites máximos**: Módulo donde se establecen los rangos y límites máximos de los parámetros para el control de la planta de tratamiento en el sistema.
- **Gráficas**: Este módulo se encarga de recopilar y procesar los resultados de las muestras registradas en el sistema para las gráficas, correlaciones y cálculos que proporcionan información al usuario a partir de ciertos parámetros de búsqueda.
    - **Imprimir Gráfica**: Este módulo se encarga de presentar la información al usuario a través de gráficos a partir de los datos obtenidos en el modulo Gráficas.


## Author :black_nib:
- **Monicodev**: [@monicodev](https://github.com/monicodev) :squirrel:

--------

:smiley: Have a nice day :smiley: