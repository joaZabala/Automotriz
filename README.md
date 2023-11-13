# UTN grupo 4: Automotriz
---
Trabajo Grupal de la asignatura Programacion II
## Tabla de Contenidos
***
- [Caracteristicas](#Características)
- [Estructura del Projecto](#estructura-del-proyecto)
- [Dependencias](#Dependencias)
- [Instalar](#Instalación)
- [Area de Control](#Area-de-Control)
- [Integración de Api](#Integración-de-Api)
- [Base de Datos](#Base-de-datos)
- [Integrantes](#Integrantes)
- [Licencia](#License)
***
## Características
---
el proyecto permite 
- dar de alta baja y consulta de clientes y productos
- dar de alta, baja, consulta y modification de Facturas y ordenes de productos
- Generar reportes  de...
## estructura del proyecto
---
- celeste - Programación en C#
- violeta - API como HTTP
- amarillo - BD en SQL
- naranja - Objetos usados-SQL usados
![estructura del projecto imagen](https://files.catbox.moe/0ojbcu.png)
## Dependencias
---
librerías, frameworks y herramientas usadas:

- C# librerías:
	- librería
- .Net Framework (version)
- SQL Server (version)
- alguna otra que me este olvidando
## Instalación
---
```bash
# Clone the repository
git clone https://github.com/your-username/your-repository.git
```
## Area de Control
---
cosas que faltan y cosas completas
- BD
	- [x] Tablas e Inserts basicos
	-  sp
		- [x] consulta paises
		- [x] consulta localidades
		- [x] insertar clientes
		- [x] consultar clientes param (?)
		- [x] eliminar cliente
		- [x] consultar productos
		- [x] insertar productos
		- [x] consultar tipo de clientes
		- [x] insertar facturas y detalles
		- [x] insertar ordenes de pedidos y detalles
	- Trigger
		- [x] stock reduce cuando se inserta factura
- BackEnd
	- [ ] Api
	- [x] DB Helper
	- [ ] clases
		- [x] clientes
		- [ ] contactos
		- [x] productos
		- [x] facturas
		- [x] detalles facturas
		- [ ] ordenes
		- [ ] detalle ordenes
- Front end
	- [x] form clientes
	- [x] form productos
	- [ ] form facturas
	- [ ] form ordenes
	- [ ] reportes
## Integración de Api
---
explicacion de como la APi funciona y como esta integrada
## Base de datos
---
la base de datos que usamos es la siguiete: https://drive.google.com/file/d/1xUxFIivYS9ZqBCspCpBKAKstCrIGlTbT/view?usp=sharing
- 
la parte de la base de datos que usamos es la siguiente:
![parte de la base util](https://files.catbox.moe/rib3cc.png)
### SP usados

```
create procedure SP_CONSULTAR_PRODUCTOS
AS
BEGIN
SELECT*FROM PRODUCTOS
END
go
create procedure SP_CONSULTAR_CLIENTES
AS
BEGIN
SELECT*FROM clientes
END
go
create procedure SP_CONSULTAR_TIPO_CLIENTES
AS
BEGIN
SELECT*FROM TIPO_CLIENTES
order by id_tipo ;
END
go
create procedure SP_CONSULTAR_barrios
AS
BEGIN
SELECT*FROM BARRIOS
END
go
create procedure SP_CONSULTAR_paises
AS
BEGIN
SELECT*FROM PAISES
END
go
create procedure SP_CONSULTAR_localidades
AS
BEGIN
SELECT*FROM LOCALIDADES
END
go
 CREATE PROCEDURE sp_insertar_clientes 
@nombre varchar(75),
@razonSocial varchar(75),
@cuil_cuit varchar(75),
@id_barrio int,
@direccion varchar(100),
@id_tipo_cliente int,
@id int output
as
begin
    INSERT INTO CLIENTES ( nombre, razon_social, cuil_cuit, id_barrio, direccion, id_tipo_cliente)
    VALUES ( @nombre, @razonSocial, @cuil_cuit, @id_barrio, @direccion, @id_tipo_cliente);
	 -- Obtener el último cod_cliente insertado
    SET @id= SCOPE_IDENTITY()
end
go
 create PROCEDURE SP_CONSULTAR_CLIENTES_PARAM
@NOMBRE VARCHAR(50) ,
@ID_TIPO_CLIENTE INT 
AS 
BEGIN
    SELECT *
	FROM CLIENTES c
	join BARRIOS b on b.id_barrio =c.id_barrio
    WHERE nombre LIKE '%'+ @NOMBRE+'%' AND 
        id_tipo_cliente = @ID_TIPO_CLIENTE
    
END
go
CREATE PROCEDURE SP_ELIMINAR_CLIENTE
@COD INT
AS
BEGIN
  DELETE CLIENTES WHERE cod_cliente = @COD
END
go
CREATE PROCEDURE SP_INSERTAR_PRODUCTOS
@id_producto int, @producto varchar(100),
@id_tipo_producto int, @num_serie int,
@precio double precision, @fecha_fabricacion date,
@vida_util int, @peso double precision,
@id_unidad_peso int, @largo double precision,
@ancho double precision,@alto double precision,
@id_unidad_medida int, @id_tipo_material int,
@id_pais int, @id_marca int

AS 
BEGIN 
INSERT INTO PRODUCTOS(id_producto,producto,
id_tipo_producto, num_serie,precio,
fecha_fabricacion,vida_util,peso,
id_unidad_peso,largo,ancho,alto,
id_unidad_medida,id_tipo_material,
id_pais, id_marca)
VALUES(@id_producto,@producto,
@id_tipo_producto,@num_serie,@precio,
@fecha_fabricacion,@vida_util,
@peso,@id_unidad_peso,@largo,
@ancho,@alto,@id_unidad_medida,
@id_tipo_material,@id_pais,@id_marca)

END
go
create procedure sp_insertar_factura
@cliente int,
@tipo_facturas int,
@factura int output,--variable para la id de facturas
@orden int = null-- es null en caso de que no este asociada una orden de pedido
as
begin
	insert into FACTURAS(fecha,cod_cliente,id_tipo_factura,id_orden_pedido)
	values(GETDATE(), @cliente,@tipo_facturas,@orden);-- getdate es para ingresar la fecha como el momento en que se inserta

	set @factura = SCOPE_IDENTITY();--para detalle de factura el id es necesario, se saca con el scopeidentity
end
go
create procedure sp_insertar_detalle_f
@factura int,
@producto int,
@precio float,
@cantidad int,
@p_cod int output
as
begin
	if (@cantidad> (select cantidad_total from STOCK s where s.id_producto = @producto)) -- si cantidad es mayor que el stock, salta error
		begin
			raiserror('la cantidad es mayor que el stock actual en la empresa, haga una orden de pedido',-1,-1)
			set @p_cod = @producto
		end
	else --si no hay error se procede con la insersion
		begin
			insert into DETALLE_FACTURAS (nro_factura,cod_producto,pre_unitario,cantidad)
			values (@factura,@producto,@precio,@cantidad);
		end
end
go
create procedure sp_insert_orden
@detalles varchar(150),
@orden int output --para sacar el id de orden de pedidos
as
begin
	insert into ORDEN_PEDIDOS(fecha_creacion,especificaciones)
	values (GETDATE(),@detalles); -- se carga la fecha con el getdate

	set @orden = SCOPE_IDENTITY();-- se consigue el id que carga en orden de pedidos
end
go
create procedure sp_insert_detalle_o
@orden int,
@fecha date,-- fecha pactada a la entrega
@producto int,
@cantidad int,
@precio float
as
begin
	insert into DETALLE_PEDIDOS(fecha_entrega,id_orden_pedido,id_producto,cantidad,precio)
	values(@fecha,@orden,@producto,@cantidad,@precio); 
end
go
create trigger t_reduccion_de_stock
on detalle_facturas
for insert
as
begin
	declare @cantidad int;
	declare @producto int;

	select @cantidad = i.cantidad from inserted i;
	select @producto = i.cod_producto from inserted i;

	update STOCK
	set cantidad_total = cantidad_total - @cantidad
	where id_producto = @producto
end
go
create procedure Sp_consultar_tipoPeso
as
begin
select *
from TIPO_UNIDADES_PESO
END
go
create procedure Sp_consultar_tipoMedida
as
begin
select *
from TIPO_UNIDADES_MEDIDA
END
go
create procedure Sp_consultar_tipoProducto
as
begin
select *
from TIPO_PRODUCTOS
END
go
CREATE PROCEDURE SP_CONSULTAR_MARCAS
AS 
BEGIN
SELECT *
FROM MARCAS
END
go
CREATE PROCEDURE SP_CONSULTAR_TIPOMATERIAL
AS
BEGIN
SELECT *
FROM TIPO_MATERIALES
END
```
## Integrantes
---
- 405486 Dorado Arias Sofía Belén
- 404931 Sagripanti Valentino
- 405037 Toloza Lautaro Tomas
- 404975 Zabala Joaquín Ariel
- 405141 Ziade Manuel Alejandro

---
1W3
Grupo número 4
Fecha de Entrega: 14/10/2023
Profesor: Martin Poliotto
## License

This project is licensed under the MIT License :
```markdown
MIT License

Copyright (c) [2023] [Dorado Arias Sofía Belén - Sagripanti Valentino - Toloza Lautaro Tomas - Zabala Joaquín Ariel - Ziade Manuel Alejandro]

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```
