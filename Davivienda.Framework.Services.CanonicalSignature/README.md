# Davivienda.Framework.Services.CanonicalSignature

## Estado de construcción

## Acerca de
CanonicalSignature, es una librería que simplifica la complejidad de implementar una firma canónica al encapsular los campos de Request, Response y Headers de Servicio tipo API Rest en una sola solución.

## Instalación
Esta libreria se encuentra en el repositorio de artefactos de Azure DevOps Server, puede user el siguiente comando de Nuget para instalar la libreria y sus dependencias:  
````
Install-Package Davivienda.Framework.Services.CanonicalSignature -version 1.1.0
````

| Puede especificar la versión deseada utilizando el modificador `-version`.

## Versiones
### Versión 1.1.0
[![Paquete Davivienda.Framework.Services.CanonicalSignature en la fuente Davivienda.Framework@Release de Azure Artifacts](https://crsjce010223vm/tfs/TI_SourceCode/_apis/public/Packaging/Feeds/5d423925-fde5-4b79-997d-a37c6bc8e93a@9991c2e4-9410-48d1-b2a7-e737efdda19a/Packages/a8028101-7fdb-4eb2-b2ce-7cc622ff7cd0/Badge)](https://crsjce010223vm/tfs/TI_SourceCode/Sinpe.PMB/_packaging?_a=package&feed=5d423925-fde5-4b79-997d-a37c6bc8e93a%409991c2e4-9410-48d1-b2a7-e737efdda19a&package=a8028101-7fdb-4eb2-b2ce-7cc622ff7cd0&preferRelease=true)

#### Aspectos destacados
Firma canónica de servicios versión 0.0.1.  
**StandardHeader**: Representa las cabeceras HTTP personalizadas requeridas por el estandar Davivienda.

| Header Description| Property Name    | Header Name      |
|:----------------: |:----------------:| :---------------:|
| Transaction Id    | **TransactionId**| x-TransactionId  |
| Session Id        | **SessionId**    | x-SessionId      |
| Channel Id        | **ChannelId**    | x-ChannelId      |
| I18n              | **I18n**         | x-I18n           |  

**ServiceRequest**: Esta clase representa el cuerpo de una solicitud(request). Es una clase genérica de tipo `T`, su única propiedad es del mismo tipo. El diseño altamente generalizado de esta clase permite que se adapte y transforme según las necesidades específicas, haciendo de `Body` un objeto extensible y versátil para cualquier escenario requerido.  

| Property Name |
|:-------------|
| Body|

**ServiceResponse**: Esta clase representa el cuerpo de una respuesta(response). Es una clase genérica de tipo `T`, la propiedad `Data` es del mismo tipo. El diseño altamente generalizado de esta clase permite que se adapte y transforme según las necesidades específicas, haciendo de `Data` un objeto extensible y versátil para cualquier escenario requerido.  

| Property Name |
|:-------------|
| Body|
| Succeeded|
| TransactionId|
| SessionId|
| Errors|

---

**NOTA**: `Errors`, es una colección del tipo `ErrorDetail`, que contiene estas propiedades:  

| Property Name |
|:-------------|
| Message|
| code|

Con estas propiedades, se le comunica al llamante el detalle del error o errores que se presenten durante la ejecución de un transacción.  La colección puede ser Nula, en caso que toda la operación se ejecute sin problemas. 


### Versión 1.1.1
#### Aspectos destacados
Se actualizan los tipos de datos de GUID a string de los campos `TransactionId` y `SessionId`, en las clases **`StandardHeader`** y **`ServiceResponse`**.


#### Problemas conocidos