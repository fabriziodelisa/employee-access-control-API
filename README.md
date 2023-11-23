# Desafío Técnico BeClever
## API para el control de acceso del personal de la empresa Clever Business en sus tres sucursales.
Proyecto desarrollado por Fabrizio De Lisa. Se utilizaron las tecnologias C# NET6, ENTITY FRAMEWORK, SQL SERVER.  
Se creó un microservicio API Rest consumible desde distintos clientes (mobile-web).  

### RUN:
Ya con el repositorio clonado y la Solución abierta en Visual Studio, dirigirse a la consola del administrador de paquetes y actualizar la base de datos con el comando: **Update-Database** . Luego de la actualización compilar. Se pueden utilizar los Endpoints desde el navegador con Swagger.
### DATOS:
accesType: 0(entry), 1(exit).  
CompanyBranchId: 1(Argentina), 2(Brasil), 3(España).  
employeeId: number (1-20).  
descriptionFilter: "string" (nombre o apellido)  
formato fecha: yyyy-mm-dd (Los registros de ingresos/egresos sedieron durante los meses del 2022)
  
### ENDPOINTS:   
  
#### La aplicacion esta corriendo en: https://localhost:7100/  
### **POST api/Access/AccessRegister**
Registra un nuevo acceso. Requiere enviar este formato:   

{  
    "accessDateTime": "yyyy-mm-dd",  
    "accessType": number,  
    "employeeId": number,  
    "companyBranchId": number  
}  
    
  
### **GET api/Access/Search**   
Busca la cantidad de ingresos y egresos dada una fecha, con posibilidad de filtrar por nombre o apellido y sucursal.  
Los Parametros son opcionales.
Requiere enviar una query con este formato:  
  
localhost:7100/api/Access/Search?dateFrom=2022-02-12&dateTo=2022-10-25&descriptionFilter=juan&companyBranchId=2  


### **GET api/Access/Average**
Lista el promedio mensual de hombre o mujeres que circulan por cada una de las sucursales.
Requiere enviar una query con este formato:  
  
localhost:7100/api/Access/Average?dateFrom=2022-06-18&dateTo=2022-12-14
