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
		- [x] contactos
		- [x] productos
		- [x] facturas
		- [x] detalles facturas
		- [ ] ordenes
		- [ ] detalle ordenes
- Front end
	- [x] form clientes
	- [x] form productos
	- [x] form facturas
	- [x] form ordenes
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
---- Consultas simples ----
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
CREATE PROCEDURE SP_TIPOS_CONTACTOS
AS 
	SELECT*FROM TIPO_CONTACTOS
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
CREATE PROCEDURE SP_CONSULTAR_TIPO_FACTURAS
AS
BEGIN
	SELECT * FROM TIPO_FACTURA
END
go

-------------- CLIENTES -----------------
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
    WHERE nombre LIKE '%'+ @NOMBRE+'%' AND 
        id_tipo_cliente = @ID_TIPO_CLIENTE
		and c.fecha_baja is null
    
END
go
	CREATE PROCEDURE SP_ELIMINAR_CLIENTE
	@COD INT
AS
BEGIN
  DELETE CLIENTES WHERE cod_cliente = @COD
END
go
CREATE PROCEDURE SP_BAJA_CLIENTES
@COD INT
AS
BEGIN
  UPDATE CLIENTES
  SET FECHA_BAJA = GETDATE()
  WHERE COD_CLIENTE = @COD
END
go


create PROCEDURE SP_MODIFICAR_CLIENTES
@COD INT,
@nombre varchar(75) = null,
@razonSocial varchar(75)= null,
@cuil_cuit varchar(75)= null,
@id_barrio int = null,
@direccion varchar(100) = null,
@id_tipo_cliente int = null
AS
BEGIN 
   UPDATE CLIENTES
   SET NOMBRE = @NOMBRE,
        RAZON_SOCIAL=@RAZONSOCIAL,
		cuil_cuit= @CUIL_CUIT,
		id_barrio = @ID_BARRIO,
		direccion=@DIRECCION, 
		id_tipo_cliente=@ID_TIPO_CLIENTE
   WHERE COD_CLIENTE = @COD
END

go

CREATE PROCEDURE SP_INSERTAR_CONTACTOS
@COD INT output,
@DESCRIPCION VARCHAR(50),
@ID_TIPO_CONTACTO INT,
@COD_CLIENTE INT
AS
BEGIN
	INSERT INTO CONTACTOS(descripcion,id_tipo_contacto,cod_cliente)
	VALUES(@DESCRIPCION,@ID_TIPO_CONTACTO,@COD_CLIENTE)
	SET @COD = SCOPE_IDENTITY()
END
go
create procedure sp_consultar_contacto_By_Id
@id int
as 
select*
 from CONTACTOS 
 where cod_cliente = @id
go
CREATE PROCEDURE sp_modificar_contacto
 @descripcion varchar(100),
 @id_tipo_contacto int,
 @cod_cliente int
 AS
 BEGIN
	UPDATE CONTACTOS
	SET descripcion = @descripcion,
		id_tipo_contacto = @id_tipo_contacto
	WHERE cod_cliente = @cod_cliente
end
go
create procedure SP_CONSULTAR_CLIENTES_BY_ID
@id int
as 
select*
 from CLIENTES 
 where cod_cliente = @id
go
------------- PRODUCTOS ---------------
CREATE PROCEDURE SP_INSERTAR_PRODUCTOS
@producto varchar(100),
@id_tipo_producto int, @num_serie int,
@precio double precision, @fecha_fabricacion date,
@vida_util int, @peso double precision,
@id_unidad_peso int, @largo double precision,
@ancho double precision,@alto double precision,
@id_unidad_medida int, @id_tipo_material int,
@id_pais int, @id_marca int

AS 
BEGIN 
	INSERT INTO PRODUCTOS(producto,
	id_tipo_producto, num_serie,precio,
	fecha_fabricacion,vida_util,peso,
	id_unidad_peso,largo,ancho,alto,
	id_unidad_medida,id_tipo_material,
	id_pais, id_marca)
	VALUES(@producto,
	@id_tipo_producto,@num_serie,@precio,
	@fecha_fabricacion,@vida_util,
	@peso,@id_unidad_peso,@largo,
	@ancho,@alto,@id_unidad_medida,
	@id_tipo_material,@id_pais,@id_marca)
END
go
create PROCEDURE sp_eliminarProducto
    @ProductoID INT
AS
BEGIN
    
    IF EXISTS (SELECT 1 FROM PRODUCTOS WHERE id_producto = @ProductoID)
    BEGIN
        
        DELETE FROM PRODUCTOS WHERE id_producto = @ProductoID;
    END
END
go
create PROCEDURE sp_ConsultarProductos_param
@NombreProducto VARCHAR(100),
    @Marca INT,
    @TipoProductoID INT,
    @TipoMaterialID INT
AS
BEGIN
    SELECT
         p.id_producto,
		 p.producto,
		 TP.descripcion,
		 p.num_serie,
		 p.precio,
		 p.fecha_fabricacion,
		 p.vida_util,
		 p.peso,
		 TUP.descripcion 'unidadPeso',
		 p.largo,
		 p.ancho,
		 p.alto,
		 TUM.descripcion 'unidadMedida',
		 TM.descripcion 'TipoMaterial',
		 PP.pais,
		 M.marca
    FROM
        PRODUCTOS P
        INNER JOIN MARCAS M ON P.id_marca = M.id
        INNER JOIN TIPO_PRODUCTOS TP ON P.id_tipo_producto = TP.id
        INNER JOIN TIPO_MATERIALES TM ON P.id_tipo_material = TM.id
		INNER JOIN TIPO_UNIDADES_PESO TUP ON TUP.id = P.id_unidad_peso
		INNER JOIN TIPO_UNIDADES_MEDIDA TUM ON TUM.id = P.id_unidad_medida
		INNER JOIN PAISES PP ON PP.id_pais = P.id_pais
    WHERE
        P.producto LIKE '%' + @NombreProducto + '%' 
        AND P.id_marca = @Marca
        AND P.id_tipo_producto = @TipoProductoID
        AND P.id_tipo_material = @TipoMaterialID 
END
GO
create procedure SP_MODIFICAR_PRODUCTO
@id_producto int,
@producto varchar(100),
@id_tipo_producto int,
@num_serie int,
@precio double precision,
@fecha_fabricacion date,
@vida_util int, 
@peso double precision,
@id_unidad_peso int,
@largo double precision,
@ancho double precision,
@alto double precision,
@id_unidad_medida int,
@id_tipo_material int,
@id_pais int,
@id_marca int
AS 
BEGIN
Update PRODUCTOS
SET 
producto = @producto,
id_tipo_producto = @id_tipo_producto,
num_serie = @num_serie,
precio = @precio,
fecha_fabricacion = @fecha_fabricacion,
vida_util = @vida_util,
peso = @peso,
id_unidad_peso = @id_unidad_peso,
largo = @largo,
ancho = @ancho,
alto = @alto,
id_unidad_medida =  @id_unidad_medida,
id_tipo_material =@id_tipo_material,
id_pais = @id_pais,
id_marca =@id_marca
WHERE id_producto = @id_producto
end
go
create procedure SP_CONSULTAR_PRODUCTOS_ID
@id  int
as
begin
Select  P.*, TP.descripcion, TM.descripcion, M.marca
    FROM
        PRODUCTOS P
        INNER JOIN MARCAS M ON P.id_marca = M.id
        INNER JOIN TIPO_PRODUCTOS TP ON P.id_tipo_producto = TP.id
        INNER JOIN TIPO_MATERIALES TM ON P.id_tipo_material = TM.id
    WHERE @id = id_producto
end
go
----------   FACTURAS   ------------------
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
@cantidad int
as
begin
	insert into DETALLE_FACTURAS (nro_factura,cod_producto,pre_unitario,cantidad)
	values (@factura,@producto,@precio,@cantidad);
end
go

--------- ORDENES ------------
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
----------- TRIGGER   --------------------
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
