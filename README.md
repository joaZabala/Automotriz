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
	- [x] Api
	- [x] DB Helper
	- [x] clases
		- [x] clientes
		- [x] contactos
		- [x] productos
		- [x] facturas
		- [x] detalles facturas
		- [x] ordenes
		- [x] detalle ordenes
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
------------------------------------- Consultas simples -------------------------------------
create procedure SP_CONSULTAR_PRODUCTOS
AS
BEGIN
	SELECT*FROM PRODUCTOS
	where fecha_baja is null
END
go
create procedure SP_CONSULTAR_CLIENTES
AS
BEGIN
	SELECT*FROM clientes
	where Fecha_Baja is null
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

------------------------------------- CLIENTES -------------------------------------
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
------------------------------------- PRODUCTOS -------------------------------------
CREATE PROCEDURE SP_INSERTAR_PRODUCTOS
@producto varchar(100),
@id_tipo_producto int, @num_serie int,
@precio decimal(10,2), @fecha_fabricacion date,
@vida_util int, @peso decimal(10,2),
@id_unidad_peso int, @largo decimal(10,2),
@ancho decimal(10,2),@alto decimal(10,2),
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
    update PRODUCTOS
	set fecha_baja=GETDATE()
	where id_producto=@ProductoID
 
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
		 p.id_tipo_producto,
		 
		 p.num_serie,
		 p.precio,
		 p.fecha_fabricacion,
		 p.vida_util,
		 p.peso,
		 P.id_unidad_peso,
		 
		 p.largo,
		 p.ancho,
		 p.alto,
		 P.id_unidad_medida,
		 
		 P.id_tipo_material,
		 
		 P.id_pais,
		 
		 P.id_marca
		
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
-------------------------------------   FACTURAS   -------------------------------------
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
@precio decimal(10,2),
@cantidad int
as
begin
	insert into DETALLE_FACTURAS (nro_factura,cod_producto,pre_unitario,cantidad)
	values (@factura,@producto,@precio,@cantidad);
end
go
------------------------------------- ORDENES -------------------------------------
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
@precio decimal(10,2)
as
begin
	insert into DETALLE_PEDIDOS(fecha_entrega,id_orden_pedido,id_producto,cantidad,precio)
	values(@fecha,@orden,@producto,@cantidad,@precio); 
end
go
------------------------------------- TRIGGER   -------------------------------------
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
----------------------------------------------------------------------------------------------------------------------------------------------------

-------------------------------------Consultas espesificas de reporte-------------------------------------
/*Crear un procedimiento almacenado para usuarios finales que muestre detalladamente los productos que estén en un
rango de precios que se ellos especifiquen como parámetros al ejecutar el SP, en caso de que no exista productos entre
esos precios se deberá mostrar un mensaje que avise de ello:*/
CREATE PROCEDURE SP_MOSTRAR_PRODUCTOS
@precio1 decimal(10,2),
@precio2 decimal(10,2)
AS
BEGIN
IF EXISTS (SELECT id_producto FROM PRODUCTOS WHERE precio between @precio1 and @precio2)
	BEGIN

		SELECT p.id_producto 'ID Producto',
		p.producto 'Producto',
		tp.descripcion 'Tipo Producto',
		p.num_serie 'Número de Serie',
		CONCAT('$', p.precio) 'Precio U$D',
		p.fecha_fabricacion 'Fecha Fabricación',
		p.vida_util 'Vida Útil en Años',
		CONCAT(p.peso, ' en ',tup.descripcion) 'Peso',
		p.largo 'Largo',
		p.ancho 'Ancho',
		p.alto 'Alto',
		tum.descripcion 'Unidad de Medida',
		tm.descripcion 'Tipo de Material',
		pp.pais 'País Origen',
		m.marca 'Marca'

		FROM PRODUCTOS p
		JOIN TIPO_PRODUCTOS tp on tp.id = p.id_tipo_producto
		JOIN TIPO_UNIDADES_PESO tup on tup.id = p.id_unidad_peso
		JOIN TIPO_UNIDADES_MEDIDA tum on tum.id = p.id_unidad_medida
		JOIN TIPO_MATERIALES tm on tm.id = p.id_tipo_material
		JOIN PAISES pp on pp.id_pais = p.id_pais
		JOIN MARCAS m on m.id = p.id_marca
		WHERE p.precio between @precio1 and @precio2

	END
ELSE
	BEGIN
		PRINT 'No se encontraron productos en ese rango de precio'
	END
END;

go
/*Crear una consulta que permita hallar el autoplan más elegido por los clientes y que su ejecución sea sostenible en el
tiempo. Esto para que la empresa pueda identificar siempre en cualquier momento cuales son los planes más
solicitados y de allí poder tomar decisiones:*/

create procedure sp_Autoplan_popular
as
begin
	SELECT a.descripcion 'AutoPlan más Elegido'
	FROM AUTOPLANES a
	WHERE year(a.fecha_inicio)=year(GETDATE()) 
	and a.id_autoplan IN (SELECT TOP 5 ac.id_autoplan
							FROM AUTOPLANES_CLIENTES ac
							GROUP BY ac.id_autoplan
							ORDER BY COUNT(ac.id_autoplan) DESC
							)
end
go 
/*Crear una consulta que permita traer todas las autopartes que fueron vendidas entre septiembre y noviembre del año
pasado y dar: el promedio de cantidades vendidas y cantidad de facturas en las que aparecen. Esto es esencial para
llevar a cabo un análisis detallado de las ventas durante este intervalo de tiempo específico. Este análisis nos permitirá
identificar patrones de venta, preferencias de los clientes y posibles oportunidades de mejora en nuestra estrategia de
comercialización y stock. De esta manera, estaremos mejor preparados para tomar decisiones y diseñar estrategias más
efectivas para este periodo*/

create procedure sp_autopart_vendida
as
begin
	Select p.id_producto, p.producto, p.id_marca, m.marca, p.precio, p.id_tipo_producto, tp.descripcion, f.fecha, f.nro_factura, 
			COUNT(f.nro_factura) 'cantidad de facturas en donde aparece', 
			AVG(cantidad)'promedio de la cantidad vendida'
	from TIPO_PRODUCTOS tp, PRODUCTOS p, MARCAS m, facturas f, DETALLE_FACTURAS df
	WHERE tp.id = p.id_tipo_producto 
		and m.id = p.id_marca 
		and p.id_producto = df.cod_producto 
		and f.nro_factura = df.nro_factura 
		and MONTH (f.fecha) between 9 and 11 
		and DATEDIFF(year, fecha, GETDATE()) = 1 
		and tp.descripcion NOT IN (SELECT descripcion
									FROM TIPO_PRODUCTOS
									WHERE descripcion like '%automovil%')
	group by p.id_producto, p.producto, p.id_marca, m.marca, p.precio, p.id_tipo_producto, tp.descripcion, f.fecha, f.nro_factura
	order by p.producto
end
go
/*Se requiere obtener información sobre las marcas más populares y ampliamente adquiridas en nuestro catálogo de
productos, con el fin de llevar a cabo un análisis exhaustivo de las preferencias de los clientes con respecto a las
diversas marcas que ofrecemos:*/
create procedure sp_marcas_populares
@tipo_cliente int
as
begin
	SELECT m.marca, SUM(df.cantidad) AS total_vendido, tc.tipo 'tipo de cliente'
	FROM MARCAS m
	JOIN PRODUCTOS p ON m.id = p.id_marca
	JOIN DETALLE_FACTURAS df ON p.id_producto = df.cod_producto
	Join FACTURAS f on f.nro_factura = df.nro_factura
	join CLIENTES c on c.cod_cliente = f.cod_cliente
	join TIPO_CLIENTES tc on tc.id_tipo = c.id_tipo_cliente 
	where p.id_producto in (SELECT p.id_producto
							from PRODUCTOS p, DETALLE_FACTURAS df
							where df.cod_producto = p.id_producto )
							and @tipo_cliente = c.id_tipo_cliente
	GROUP BY m.marca, tc.tipo
	ORDER BY total_vendido DESC;
end
go
/*Crear un procedimiento que permita a los empleados de la compañía ver la cantidad de productos en la ubicación que
colocan como parámetro junto con la cantidad mínima que consideren relevante y la fecha de fabricación de dicho
producto.
(Esto ayuda en caso de ver los productos más viejos, en dicha zona).
Por defecto el parámetro de ubicación es "Zona de Carga y Descarga" ya que es la ubicación que menos producto le
conviene a la empresa tener. La cantidad es 0 para mostrar todas las cantidades:*/
create procedure sp_productos_en
@ubica varchar(200) = 'Zona De Carga y Descarga',
@cantidad int = 0
as
begin
	if ((select count(*) 
		from TIPO_UBICACION tu, UBICACIONES u, STOCK s, PRODUCTOS p 
		where tu.id = u.id_tipo_ubicacion
		and s.id= u.id_stock
		and p.id_producto=s.id_producto
		and tu.ubicacion like '%'+@ubica+'%'
		and u.cantidad >= @cantidad)=0)
		print 'No Hay Productos En La Zona Buscada'
	else
		select FORMAT(p.fecha_fabricacion,'yyyy-MM') 'Fecha de fabricacion', p.producto, u.cantidad, tu.ubicacion
		from TIPO_UBICACION tu, UBICACIONES u, STOCK s, PRODUCTOS p
		where tu.id = u.id_tipo_ubicacion
			and s.id= u.id_stock
			and p.id_producto=s.id_producto
			and tu.ubicacion like '%'+@ubica+'%'
			and u.cantidad >= @cantidad
		order by 2
end
go
/*Se quiere conocer el porcentaje de compras por tipo de clientes que tiene la empresa, tanto por la cantidad de factura y
por la cantidad de artículos vendidos:*/
create procedure sp_porcentaje_x_t_clientes
as
begin
		select tc.tipo 'Tipo de Cliente',
		concat(count(f.nro_factura)* 100/ (select count(*) from FACTURAS),'%') 'Porcentaje de Compras', 
		'Por Facturas' 'Tipo de Porcentaje'
		from CLIENTES c, FACTURAS f, TIPO_CLIENTES tc
		where c.id_tipo_cliente = tc.id_tipo
		and f.cod_cliente = c.cod_cliente
		group by tc.tipo
	union
		select tc.tipo,
		concat(count(f.cod_cliente)* 100/ (select count(*) from DETALLE_FACTURAS),'%'), 
		'Por Articulos Vendidos'
		from CLIENTES c, FACTURAS f, TIPO_CLIENTES tc, DETALLE_FACTURAS df
		where c.id_tipo_cliente = tc.id_tipo
			and f.cod_cliente = c.cod_cliente
			and df.nro_factura= f.nro_factura
		group by tc.tipo
		order by 3 desc
end
go
/*Crear un procedimiento almacenado el cual obtenga:
Todos los clientes que tengan una razón social conocida, si ese cliente compró algún producto (la fecha de compra va
desde un año ingresado por el usuario por parámetro hasta la fecha actual). Además, se quiere mostrar todos los datos
del cliente y el producto que compró (si lo hizo). Ordenar por cliente y rotule.
Esto cumpliría el objetivo de saber que clientes no han comprado desde un año ingresado por parámetro hasta la fecha
actual, para poder darlos de baja y se quiere saber que productos frecuenta comprar para así poder brindarle posibles
descuentos.*/
CREATE PROCEDURE SP_CLIENTES
@ANIO INT
AS
BEGIN
	SELECT C.nombre 'CLIENTE',C.razon_social 'RAZON SOCIAL',C.cuil_cuit 'CUIL/CUIT',
	B.barrio 'BARRIO',C.direccion 'DIRECCIÓN',TC.tipo 'TIPO CLIENTE',
	P.producto 'PRODUCTO'
	FROM CLIENTES C
	LEFT JOIN TIPO_CLIENTES TC ON TC.id_tipo = C.id_tipo_cliente
	LEFT JOIN BARRIOS B ON B.id_barrio = C.id_barrio
	LEFT JOIN FACTURAS F ON F.cod_cliente = C.cod_cliente
	LEFT JOIN DETALLE_FACTURAS DF ON DF.nro_factura = F.nro_factura
	LEFT JOIN PRODUCTOS P ON P.id_producto = DF.cod_producto
	WHERE C.razon_social IS NOT NULL
		AND YEAR(F.fecha) BETWEEN @ANIO AND YEAR(GETDATE())
	ORDER BY 1
END
go


------------------------------------- Vistas -------------------------------------
/*Crear una vista que permita ver el total recaudado, el promedio recaudado por factura y la cantidad de facturas
registradas para los siguientes periodos de tiempo: en el primer semestre del año, el año actual, el año pasado y desde
los inicios de la empresa hasta la actualidad.*/
CREATE VIEW VW_TOTALES_RECAUDADO
AS
	SELECT SUM(DF.cantidad * DF.pre_unitario)'TOTAL RECAUDADO' ,
		SUM(DF.cantidad * DF.pre_unitario)/COUNT(DISTINCT F.NRO_FACTURA)'PROMEDIO POR FACTURA',
		COUNT(DISTINCT F.NRO_FACTURA)'CANTIDAD DE FACTURAS',
		'DESDE EL INICIO' TIEMPO
	from DETALLE_FACTURAS df
	JOIN FACTURAS F ON F.nro_factura = DF.nro_factura
UNION
	SELECT SUM(DF.cantidad * DF.pre_unitario) ,
		SUM(DF.cantidad * DF.pre_unitario)/COUNT(DISTINCT F.NRO_FACTURA),
		COUNT(DISTINCT F.NRO_FACTURA),
		'EN EL AÑO CORRIENTE' TIEMPO
	from DETALLE_FACTURAS df
	JOIN FACTURAS F ON F.nro_factura = DF.nro_factura
	where DATEDIFF(YEAR, f.fecha ,getdate())=0
UNION
	SELECT SUM(DF.cantidad * DF.pre_unitario) ,
		SUM(DF.cantidad * DF.pre_unitario)/COUNT(DISTINCT F.NRO_FACTURA),
		COUNT(DISTINCT F.NRO_FACTURA),
		'PRIMER SEMESTRE DEL AÑO' TIEMPO
	from DETALLE_FACTURAS df
	JOIN FACTURAS F ON F.nro_factura = DF.nro_factura
	where YEAR(FECHA)=YEAR(GETDATE())
		AND MONTH(FECHA) BETWEEN 1 AND 6
UNION
	SELECT SUM(DF.cantidad * DF.pre_unitario) ,
		SUM(DF.cantidad * DF.pre_unitario)/COUNT(DISTINCT F.NRO_FACTURA),
		COUNT(DISTINCT F.NRO_FACTURA),
		'EL AÑO PASADO' TIEMPO
	FROM FACTURAS F
	JOIN DETALLE_FACTURAS DF ON DF.nro_factura = F.nro_factura
	WHERE DATEDIFF(YEAR,FECHA,GETDATE())=1
go
/*Se necesita una lista de los clientes que más gastaron en los últimos dos años, de los clientes se quiere tener nombre
completo del cliente, contacto, tipo contacto, producto que compro, cantidad de productos que compro y el importe.
A los tipos de contactos, se necesita email y WhatsApp (si tuviese ambos), rotule. Utilizando la vista, muestre los 10
clientes que más gastaron, cantidad de productos comprados, nombre del cliente completo, su contacto y tipo de
contacto, para poder ofrecerles descuentos por ser los clientes que más invierten en la empresa.*/
CREATE VIEW VISTA_MAYORES_CLIENTES
AS
SELECT DISTINCT C.nombre 'CLIENTE',CO.descripcion 'CONTACTO', TP.descripcion'TIPO CONTACTO',P.producto 'PRODUCTO' ,
		SUM(DF.CANTIDAD)'CANTIDAD PRODUCTOS',
		SUM(DF.cantidad*DF.pre_unitario)'SUB TOTAL'
FROM CLIENTES C
JOIN CONTACTOS CO ON CO.cod_cliente = C.cod_cliente
JOIN TIPO_CONTACTOS TP ON TP.id = CO.id_tipo_contacto
JOIN FACTURAS F ON F.cod_cliente = C.cod_cliente
JOIN DETALLE_FACTURAS DF ON DF.nro_factura = F.nro_factura
JOIN PRODUCTOS P ON P.id_producto = DF.cod_producto
WHERE TP.descripcion IN ('EMAIL','WHATSAPP')
	AND DATEDIFF(YEAR,F.fecha,GETDATE()) IN (0,1)
GROUP BY C.NOMBRE,CO.descripcion,TP.descripcion,P.producto;
go

create procedure sp_zonas
as
begin
	select * 
	from TIPO_UBICACION
end
go
create PROCEDURE SP_MONTO_TOTAL_XFECHA
@FECHA_DESDE DATETIME,
@FECHA_HASTA DATETIME
AS
SELECT
SUM(DF.cantidad * DF.pre_unitario)'TOTAL RECAUDADO' ,
SUM(DF.cantidad * DF.pre_unitario)/COUNT(DISTINCT F.NRO_FACTURA)'PROMEDIO POR FACTURA',
COUNT(DISTINCT F.NRO_FACTURA)'CANTIDAD DE FACTURAS'
from DETALLE_FACTURAS df
JOIN FACTURAS F ON F.nro_factura = DF.nro_factura
WHERE fecha BETWEEN @FECHA_DESDE AND @FECHA_HASTA
go

CREATE PROCEDURE SP_MEJORES_CLIENTES
 @FECHA DATE
 AS BEGIN
 SELECT TOP 10
    C.nombre AS CLIENTE,
    SUM(DF.CANTIDAD) AS CANTIDAD_PRODUCTOS,
    SUM(DF.cantidad * DF.pre_unitario) AS SUB_TOTAL
FROM
    CLIENTES C
    JOIN CONTACTOS CO ON CO.cod_cliente = C.cod_cliente
    JOIN TIPO_CONTACTOS TP ON TP.id = CO.id_tipo_contacto
    JOIN FACTURAS F ON F.cod_cliente = C.cod_cliente
    JOIN DETALLE_FACTURAS DF ON DF.nro_factura = F.nro_factura
    JOIN PRODUCTOS P ON P.id_producto = DF.cod_producto
WHERE F.FECHA BETWEEN @FECHA AND GETDATE()
GROUP BY C.NOMBRE
ORDER BY 'SUB_TOTAL' DESC
END
go
CREATE PROCEDURE SP_BUSCAR_CLIENTE
 @NOMBRE varchar(75)
 AS
 BEGIN
 SELECT CT.descripcion 'CONTACTO',TC.descripcion 'TIPO_CONTACTO' FROM CONTACTOS CT
 JOIN CLIENTES C ON CT.cod_cliente = C.cod_cliente
 JOIN TIPO_CONTACTOS TC ON TC.id = CT.id_tipo_contacto
 WHERE C.nombre = @NOMBRE
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
