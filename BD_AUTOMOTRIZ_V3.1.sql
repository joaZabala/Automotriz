CREATE DATABASE AUTOMOTRIZ_V3
GO
USE AUTOMOTRIZ_V3
GO
CREATE TABLE PAISES(
id_pais int,
pais varchar(75),
CONSTRAINT PK_PAISES PRIMARY KEY (id_pais)
)

CREATE TABLE PROVINCIAS(
id_provincia int,
provincia varchar(75),
id_pais int,
CONSTRAINT PK_PROVINCIAS PRIMARY KEY (id_provincia),
CONSTRAINT FK_PROVINCIAS_PAISES FOREIGN KEY (id_pais)
REFERENCES PAISES (id_pais)
)

CREATE TABLE LOCALIDADES(
id_localidad int,
localidad varchar(75),
id_provincia int,
CONSTRAINT PK_LOCALIDADES PRIMARY KEY (id_localidad),
CONSTRAINT FK_LOCALIDADES_PROVINCIAS FOREIGN KEY (id_provincia)
REFERENCES PROVINCIAS (id_provincia)
)

CREATE TABLE BARRIOS(
id_barrio int,
barrio varchar(75),
id_localidad int,
CONSTRAINT PK_BARRIOS PRIMARY KEY (id_barrio),
CONSTRAINT FK_BARRIOS_LOCALIDADES FOREIGN KEY (id_localidad)
REFERENCES LOCALIDADES (id_localidad)
)

CREATE TABLE TIPO_CLIENTES(
id_tipo int,
tipo varchar(50),
CONSTRAINT PK_TIPO_CLIENTES PRIMARY KEY(id_tipo)
)

CREATE TABLE CLIENTES(
cod_cliente int IDENTITY(1,1),
nombre varchar(75),
razon_social varchar(75),
cuil_cuit varchar(20), --tipo dato
id_barrio int,
direccion varchar(100),
id_tipo_cliente int,
CONSTRAINT PK_CLIENTES PRIMARY KEY (cod_cliente),
CONSTRAINT FK_CLIENTES_BARRIOS FOREIGN KEY (id_barrio)
REFERENCES BARRIOS (id_barrio),
CONSTRAINT FK_CLIENTES_TIPO_CLIENTES FOREIGN KEY (id_tipo_cliente)
REFERENCES TIPO_CLIENTES (id_tipo)
)
--
CREATE TABLE TIPO_PRODUCTOS(
id int,
descripcion varchar(75),
CONSTRAINT PK_TIPO_PRODUCTOS PRIMARY KEY (id)
)

CREATE TABLE TIPO_UNIDADES_PESO(
id int,
descripcion varchar(75),
CONSTRAINT PK_TIPO_UNIDADES_PESO PRIMARY KEY (id)
)
----
Create table TIPO_UBICACION
(
id int,
ubicacion varchar(200)
constraint pk_tipo_ubicacion primary key (id)
)

CREATE TABLE TIPO_UNIDADES_MEDIDA(
id int,
descripcion varchar(75),
CONSTRAINT PK_TIPO_UNIDADES_MEDIDA PRIMARY KEY (id)
)

CREATE TABLE TIPO_MATERIALES(
id int,
descripcion varchar(75),
CONSTRAINT PK_TIPO_MATERIALES PRIMARY KEY (id)
)

CREATE TABLE MARCAS(
id int,
marca varchar(75),
CONSTRAINT PK_MARCAS PRIMARY KEY (id)
)

CREATE TABLE PRODUCTOS(
id_producto int IDENTITY(1,1),
producto varchar(100),
id_tipo_producto int,
num_serie int,
precio double precision,
fecha_fabricacion date,
vida_util int,
peso double precision,
id_unidad_peso int,
largo double precision,
ancho double precision,
alto double precision,
id_unidad_medida int,
id_tipo_material int,
id_pais int,
id_marca int
CONSTRAINT PK_PRODUCTOS PRIMARY KEY (id_producto),
CONSTRAINT FK_PRODUCTOS_TIPO_PRODUCTOS FOREIGN KEY (id_tipo_producto)
REFERENCES TIPO_PRODUCTOS (id),
CONSTRAINT FK_PRODUCTOS_TIPO_PESO FOREIGN KEY (id_unidad_peso)
REFERENCES TIPO_UNIDADES_PESO (id),
CONSTRAINT FK_PRODUCTOS_TIPO_MEDIDA FOREIGN KEY (id_unidad_medida)
REFERENCES TIPO_UNIDADES_MEDIDA (id),
CONSTRAINT FK_PRODUCTOS_TIPO_MATERIALES FOREIGN KEY (id_tipo_material)
REFERENCES TIPO_MATERIALES (id),
CONSTRAINT FK_PRODUCTOS_PAISES FOREIGN KEY (id_pais)
REFERENCES PAISES (id_pais),
CONSTRAINT FK_PRODUCTOS_MARCAS FOREIGN KEY (id_marca)
REFERENCES MARCAS (id)
)

CREATE TABLE TIPO_MOVIMIENTOS(
id int,
descripcion varchar(75),
CONSTRAINT PK_TIPO_MOVIMIENTOS PRIMARY KEY (id)
)


CREATE TABLE STOCK(
id int,
id_producto int,
id_tipo_movimiento int,
cantidad_total int,
cantidad_minima int
CONSTRAINT PK_STOCK PRIMARY KEY (id),
CONSTRAINT FK_STOCK_PRODUCTOS FOREIGN KEY (id_producto)
REFERENCES PRODUCTOS (id_producto),
CONSTRAINT FK_STOCK_TIPO_MOVIMIENTOS FOREIGN KEY (id_tipo_movimiento)
REFERENCES TIPO_MOVIMIENTOS (id)
)

CREATE TABLE UBICACIONES(
id int,
cantidad int,
id_stock int,
id_tipo_ubicacion int,
CONSTRAINT PK_UBICACIONES PRIMARY KEY (id),
CONSTRAINT FK_UBICACIONES_STOCK FOREIGN KEY (ID_STOCK)
REFERENCES STOCK (ID),
CONSTRAINT FK_UBICACIONES_TIPO_UBICACION FOREIGN KEY (ID_TIPO_UBICACION)
REFERENCES TIPO_UBICACION (ID)
)
CREATE TABLE HISTORIAL_PRECIOS(
id int,
id_producto int,
precio double precision,
fechaDesde date,
fechaHasta date,
CONSTRAINT PK_HISTORIAL_PRECIOS PRIMARY KEY(id),
CONSTRAINT FK_HISTORIAL_PRECIOS_PRODUCTOS FOREIGN KEY (id_producto)
REFERENCES PRODUCTOS (id_producto)
)

CREATE TABLE TIPO_AUTOPLANES(
id int,
descripcion varchar(100),
CONSTRAINT PK_TIPO_AUTOPLANES PRIMARY KEY (id)
)

CREATE TABLE AUTOPLANES(
id_autoplan int,
descripcion varchar(75),
fecha_inicio date,
fecha_hasta date,
id_tipo_autoplan int,
CONSTRAINT PK_AUTOPLANES PRIMARY KEY (id_autoplan),
CONSTRAINT FK_AUTOPLANES_TIPO_AUTOPLANES FOREIGN KEY (id_tipo_autoplan)
REFERENCES TIPO_AUTOPLANES (id)
)

CREATE TABLE AUTOPLANES_CLIENTES(
id int,
cod_cliente int,
id_autoplan int,
CONSTRAINT PK_AUTOPLANES_CLIENTES PRIMARY KEY (id),
CONSTRAINT FK_AUTOPLANES_CLIENTES_CLIENTES FOREIGN KEY (cod_cliente)
REFERENCES CLIENTES (cod_cliente),
CONSTRAINT FK_AUTOPLANES_CLIENTES_AUTOPLANES FOREIGN KEY (id_autoplan)
REFERENCES AUTOPLANES (id_autoplan)
)

CREATE TABLE DETALLE_AUTOPLANES(
id_detalle int,
id_autoplan int,
cant_cuotas int,
intereses double precision,
id_producto int,
CONSTRAINT PK_DETALLE_AUTOPLANES PRIMARY KEY (id_detalle),
CONSTRAINT FK_DETALLE_AUTOPLANES_AUTOPLANES FOREIGN KEY (id_autoplan)
REFERENCES AUTOPLANES (id_autoplan),
CONSTRAINT FK_DETALLE_AUTOPLANES_PRODUCTOS FOREIGN KEY (id_producto)
REFERENCES PRODUCTOS (id_producto)
)

CREATE TABLE ORDEN_PEDIDOS(
id_orden int IDENTITY(1,1),
fecha_creacion date,
especificaciones varchar(150)
CONSTRAINT PK_ORDEN_PEDIDOS PRIMARY KEY (id_orden)
)

CREATE TABLE DETALLE_PEDIDOS(
id_detalle int IDENTITY(1,1),
fecha_entrega date,
id_orden_pedido int,
id_producto int,
cantidad int,
precio double precision,
CONSTRAINT PK_DETALLE_PEDIDOS PRIMARY KEY (id_detalle),
CONSTRAINT FK_DETALLES_PEDIDOS_PRDEN_PEDIDOS FOREIGN KEY (id_orden_pedido)
REFERENCES ORDEN_PEDIDOS (id_orden),
CONSTRAINT FK_DETALLE_PEDIDOS_PRODUCTOS FOREIGN KEY (id_producto)
REFERENCES PRODUCTOS (id_producto)
)

CREATE TABLE TIPO_FACTURA(
id int,
descripcion varchar(50),
CONSTRAINT PK_TIPO_FACTURAS PRIMARY KEY (id)
)

CREATE TABLE FACTURAS(
nro_factura int IDENTITY(1,1),
fecha date,
cod_cliente int,
id_tipo_factura int,
id_orden_pedido int,
CONSTRAINT PK_FACTURAS PRIMARY KEY (nro_factura),
CONSTRAINT FK_FACTURAS_CLIENTES FOREIGN KEY (cod_cliente)
REFERENCES CLIENTES (cod_cliente),
CONSTRAINT FK_FACTURAS_TIPO_FACTURAS FOREIGN KEY (id_tipo_factura)
REFERENCES TIPO_FACTURA (id),
CONSTRAINT FK_FACTURAS_ORDEN_PEDIDOS FOREIGN KEY (id_orden_pedido)
REFERENCES ORDEN_PEDIDOS (id_orden)
)
CREATE TABLE FORMA_PAGOS(
id_forma int,
descripcion varchar(50),
CONSTRAINT PK_FORMA_PAGOS PRIMARY KEY (id_forma)
)
CREATE TABLE FACTURAS_X_FORMA_PAGOS(
id int,
id_forma int,
nro_factura int,
descuento double precision,
CONSTRAINT PK_FACTURAS_X_FORMA_PAGOS PRIMARY KEY (id),
CONSTRAINT FK_FACTURAS_X_FORMA_PAGOS_FORMA_PAGOS FOREIGN KEY (id_forma)
REFERENCES FORMA_PAGOS (id_forma),
CONSTRAINT FK_FACTURAS_X_FORMA_PAGOS_FACTURAS FOREIGN KEY (nro_factura)
REFERENCES FACTURAS (nro_factura)
)
CREATE TABLE DETALLE_FACTURAS(
id_detalle int IDENTITY(1,1),
nro_factura int,
cod_producto int,
pre_unitario double precision,
cantidad int,
CONSTRAINT PK_DETALLE_FACTURAS PRIMARY KEY (id_detalle),
CONSTRAINT FK_DETALLE_FACTURAS_FACTURAS FOREIGN KEY (nro_factura)
REFERENCES FACTURAS (nro_factura),
CONSTRAINT FK_DETALLE_FACTURAS FOREIGN KEY (cod_producto)
REFERENCES PRODUCTOS (id_producto)
)
CREATE TABLE TIPO_CONTACTOS(
id int,
descripcion varchar(75),
CONSTRAINT PK_TIPO_CONTACTOS PRIMARY KEY (id)
)
CREATE TABLE CONTACTOS(
id_contacto int IDENTITY(1,1),
descripcion varchar(100),
id_tipo_contacto int,
cod_cliente int,
CONSTRAINT PK_CONTACTOS PRIMARY KEY (id_contacto),
CONSTRAINT FK_CONTACTOS_TIPOS_CONTACTOS FOREIGN KEY (id_tipo_contacto)
REFERENCES TIPO_CONTACTOS (id),
CONSTRAINT FK_CONTACTOS_CLIENTES FOREIGN KEY (cod_cliente)
REFERENCES CLIENTES (cod_cliente)
)
GO

----------------------------------------PAISES--------------------------------------------
insert into PAISES 
values (1,'Argentina'),
		(2,'Brasil'),
		(3,'Chile'),
		(4,'Italia'),
		(5,'China');

----------------------------------------PROVINCIAS--------------------------------------------
INSERT INTO PROVINCIAS (id_provincia, provincia, id_pais) values (1, 'Buenos Aires', 1);
INSERT INTO PROVINCIAS (id_provincia, provincia, id_pais) values (2, 'Catamarca', 1);
INSERT INTO PROVINCIAS (id_provincia, provincia, id_pais) values (3, 'Chaco', 1);
INSERT INTO PROVINCIAS (id_provincia, provincia, id_pais) values (4, 'Chubut', 1);
INSERT INTO PROVINCIAS (id_provincia, provincia, id_pais) values (5, 'C�rdoba', 1);
INSERT INTO PROVINCIAS (id_provincia, provincia, id_pais) values (6, 'Corrientes', 1);
INSERT INTO PROVINCIAS (id_provincia, provincia, id_pais) values (7, 'Entre R�os', 1);
INSERT INTO PROVINCIAS (id_provincia, provincia, id_pais) values (8, 'Formosa', 1);
INSERT INTO PROVINCIAS (id_provincia, provincia, id_pais) values (9, 'Jujuy', 1);
INSERT INTO PROVINCIAS (id_provincia, provincia, id_pais) values (10, 'La Pampa', 1);
INSERT INTO PROVINCIAS (id_provincia, provincia, id_pais) values (11, 'La Rioja', 1);
INSERT INTO PROVINCIAS (id_provincia, provincia, id_pais) values (12, 'Mendoza', 1);
INSERT INTO PROVINCIAS (id_provincia, provincia, id_pais) values (13, 'Misiones', 1);
INSERT INTO PROVINCIAS (id_provincia, provincia, id_pais) values (14, 'Neuqu�n', 1);
INSERT INTO PROVINCIAS (id_provincia, provincia, id_pais) values (15, 'R�o Negro', 1);
INSERT INTO PROVINCIAS (id_provincia, provincia, id_pais) values (16, 'Salta', 1);
INSERT INTO PROVINCIAS (id_provincia, provincia, id_pais) values (17, 'San Juan', 1);
INSERT INTO PROVINCIAS (id_provincia, provincia, id_pais) values (18, 'San Luis', 1);
INSERT INTO PROVINCIAS (id_provincia, provincia, id_pais) values (19, 'Santa Cruz', 1);
INSERT INTO PROVINCIAS (id_provincia, provincia, id_pais) values (20, 'Santa Fe', 1);
INSERT INTO PROVINCIAS (id_provincia, provincia, id_pais) values (21, 'Santiago del Estero', 1);
INSERT INTO PROVINCIAS (id_provincia, provincia, id_pais) values (22, 'Tierra del Fuego', 1);
INSERT INTO PROVINCIAS (id_provincia, provincia, id_pais) values (23, 'Tucum�n', 1);

--------------------------LOCALIDADES-----------------------------------------------------------
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Vicente L�pez', 1, 1);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Tigre', 1, 2);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('La Plata', 1, 3);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Capital Federal', 1, 4);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Antofagasta', 2, 5);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Andalgala', 2, 6);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Poman', 2, 7);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('San Fernando del Valle', 2, 8);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Machagai', 3, 9);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Puerto Tirol', 3, 10);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Resistencia', 3, 11);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Las Bre�as', 3, 12);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('El Hoyo', 4, 13);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Trelew', 4, 14);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Rada Tilly', 4, 15);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Comodoro Rivadavia', 4, 16);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('C�rdoba Capital', 5, 17);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Rio Cuarto', 5, 18);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('San Francisco', 5, 19);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Villa Mar�a', 5, 20);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Corrientes Capital', 6, 21);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Curuzu Cuatia', 6, 22);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Goya', 6, 23);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Virasoro', 6, 24);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Concordia', 7, 25);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Concepcion del Uruguay', 7, 26);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Gualeguaychu', 7, 27);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Piedras Blancas', 7, 28);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Formosa Capital', 8, 29);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Clorinda', 8, 30);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Las Lomitas', 8, 31);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Herradura', 8, 32);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('San Salvador de Jujuy', 9, 33);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Purmamarca', 9, 34);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Humahuaca', 9, 35);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Hornillos', 9, 36);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Santa Rosa', 10, 37);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Realico', 10, 38);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('General Acha', 10, 39);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Chacharramendi', 10, 40);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('La Rioja Capital', 11, 41);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Aminga', 11, 42);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Anillaco', 11, 43);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Guandacol', 11, 44);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Mendoza Capital', 12, 45);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Tunuyan', 12, 46);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Uspallata', 12, 47);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Tupungato', 12, 48);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Posadas', 13, 49);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Garupa', 13, 50);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Tobuna', 13, 51);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Puerto Piray', 13, 52);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('San Mart�n de los Andes', 14, 53);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Neuqu�n Capital', 14, 54);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Junin de los Andes', 14, 55);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Villa La Angostura', 14, 56);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Viedma', 15, 57);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Las Grutas', 15, 58);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('San Antonio Este', 15, 59);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('San Antonio Oeste', 15, 60);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Salta Capital', 16, 61);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Cafayate', 16, 62);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Tartagal', 16, 63);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Cachi', 16, 64);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('San Juan Capital', 17, 65);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Vallecito', 17, 66);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Calingasta', 17, 67);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Zonda', 17, 68);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('San Luis Capital', 18, 69);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Merlo', 18, 70);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Juana Koslay', 18, 71);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Villa Elena', 18, 72);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Rio Gallegos', 19, 73);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('El Calafate', 19, 74);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Caleta Olivia', 19, 75);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Puerto San Julian', 19, 76);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Rosario', 20, 77);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Santa Fe Capital', 20, 78);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Rufino', 20, 79);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Firmat', 20, 80);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Sgo. del Estero Capital', 21, 81);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('A�atuya', 21, 82);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Termas del Rio Hondo', 21, 83);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Pinto', 21, 84);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Ushuaia', 22, 85);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Tolhuin', 22, 86);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Rio Grande', 22, 87);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('San Miguel de Tucum�n', 23, 88);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Famailla', 23, 89);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('El Mollar', 23, 90);
INSERT INTO LOCALIDADES (localidad, id_provincia, id_localidad) VALUES ('Tafi del Valle', 23, 91);

------------------------------------BARRIOS-------------------------------------------------------
INSERT INTO BARRIOS (id_barrio, barrio, id_localidad) VALUES (1, 'Los Pinos', 1);
INSERT INTO BARRIOS (id_barrio, barrio, id_localidad) VALUES (2, 'San Mart�n', 1);
INSERT INTO BARRIOS (id_barrio, barrio, id_localidad) VALUES (3, 'La Cascada', 2);
INSERT INTO BARRIOS (id_barrio, barrio, id_localidad) VALUES (4, 'El Rosedal', 2);
INSERT INTO BARRIOS (id_barrio, barrio, id_localidad) VALUES (5, 'Las Acacias', 3);
INSERT INTO BARRIOS (id_barrio, barrio, id_localidad) VALUES (6, 'Villa del Lago', 3);
INSERT INTO BARRIOS (id_barrio, barrio, id_localidad) VALUES (7, 'Nueva Esperanza', 4);
INSERT INTO BARRIOS (id_barrio, barrio, id_localidad) VALUES (8, 'San Cayetano', 4);
INSERT INTO BARRIOS (id_barrio, barrio, id_localidad) VALUES (9, 'Los Alamos', 5);
INSERT INTO BARRIOS (id_barrio, barrio, id_localidad) VALUES (10, 'San Lorenzo', 5);
INSERT INTO BARRIOS (id_barrio, barrio, id_localidad) VALUES (11, 'Las Rosas', 6);
INSERT INTO BARRIOS (id_barrio, barrio, id_localidad) VALUES (12, 'Villa Primavera', 6);
INSERT INTO BARRIOS (id_barrio, barrio, id_localidad) VALUES (13, 'El Mirador', 7);
INSERT INTO BARRIOS (id_barrio, barrio, id_localidad) VALUES (14, 'San Vicente', 7);
INSERT INTO BARRIOS (id_barrio, barrio, id_localidad) VALUES (15, 'La Arboleda', 8);
INSERT INTO BARRIOS (id_barrio, barrio, id_localidad) VALUES (16, 'La Pradera', 8);
INSERT INTO BARRIOS (id_barrio, barrio, id_localidad) VALUES (17, 'Villa San Roque', 9);
INSERT INTO BARRIOS (id_barrio, barrio, id_localidad) VALUES (18, 'Santa Rosa', 9);
INSERT INTO BARRIOS (id_barrio, barrio, id_localidad) VALUES (19, 'Los Cerezos', 10);
INSERT INTO BARRIOS (id_barrio, barrio, id_localidad) VALUES (20, 'San Jos�', 10);
INSERT INTO BARRIOS (id_barrio, barrio, id_localidad) VALUES (21, 'Los Tilos', 11);
INSERT INTO BARRIOS (id_barrio, barrio, id_localidad) VALUES (22, 'Villa Hermosa', 11);
INSERT INTO BARRIOS (id_barrio, barrio, id_localidad) VALUES (23, 'La Florida', 12);
INSERT INTO BARRIOS (id_barrio, barrio, id_localidad) VALUES (24, 'San Isidro', 12);
INSERT INTO BARRIOS (id_barrio, barrio, id_localidad) VALUES (25, 'Villa del Sol', 13);
INSERT INTO BARRIOS (id_barrio, barrio, id_localidad) VALUES (26, 'Los Robles', 13);
INSERT INTO BARRIOS (id_barrio, barrio, id_localidad) VALUES (27, 'La Victoria', 14);
INSERT INTO BARRIOS (id_barrio, barrio, id_localidad) VALUES (28, 'San Marcos', 14);
INSERT INTO BARRIOS (id_barrio, barrio, id_localidad) VALUES (29, 'Los Laureles', 15);
INSERT INTO BARRIOS (id_barrio, barrio, id_localidad) VALUES (30, 'Villa Belgrano', 15);
INSERT INTO BARRIOS (id_barrio, barrio, id_localidad) VALUES (31, 'Los Fresnos', 16);
INSERT INTO BARRIOS (id_barrio, barrio, id_localidad) VALUES (32, 'San Juan', 16);
INSERT INTO BARRIOS (id_barrio, barrio, id_localidad) VALUES (33, 'Las Palmeras', 17);
INSERT INTO BARRIOS (id_barrio, barrio, id_localidad) VALUES (34, 'Villa Nueva', 17);
INSERT INTO BARRIOS (id_barrio, barrio, id_localidad) VALUES (35, 'El Bosque', 18);
INSERT INTO BARRIOS (id_barrio, barrio, id_localidad) VALUES (36, 'San Pedro', 18);
INSERT INTO BARRIOS (id_barrio, barrio, id_localidad) VALUES (37, 'Los P�jaros', 19);
INSERT INTO BARRIOS (id_barrio, barrio, id_localidad) VALUES (38, 'Villa Juana', 19);
INSERT INTO BARRIOS (id_barrio, barrio, id_localidad) VALUES (39, 'Las Lomas', 20);
INSERT INTO BARRIOS (id_barrio, barrio, id_localidad) VALUES (40, 'San Rafael', 20);
INSERT INTO BARRIOS (id_barrio, barrio, id_localidad) VALUES (41, 'Villa Mar�a', 21);
INSERT INTO BARRIOS (id_barrio, barrio, id_localidad) VALUES (42, 'Santa Clara', 21);
INSERT INTO BARRIOS (id_barrio, barrio, id_localidad) VALUES (43, 'Los Cipreses', 22);
INSERT INTO BARRIOS (id_barrio, barrio, id_localidad) VALUES (44, 'San Francisco', 22);
INSERT INTO BARRIOS (id_barrio, barrio, id_localidad) VALUES (45, 'La Paz', 23);
INSERT INTO BARRIOS (id_barrio, barrio, id_localidad) VALUES (46, 'Santa Rosa', 23);
INSERT INTO BARRIOS (id_barrio, barrio, id_localidad) VALUES (47, 'Los Sauces', 24);
INSERT INTO BARRIOS (id_barrio, barrio, id_localidad) VALUES (48, 'Villa Bella', 24);
INSERT INTO BARRIOS (id_barrio, barrio, id_localidad) VALUES (49, 'Las Violetas', 25);
INSERT INTO BARRIOS (id_barrio, barrio, id_localidad) VALUES (50, 'San Ignacio', 25);

-------------------TIPO_CLIENTES------------------------
INSERT INTO TIPO_CLIENTES (id_tipo, tipo) VALUES (1, 'Consumidor Final');
INSERT INTO TIPO_CLIENTES (id_tipo, tipo) VALUES (2, 'Empresa');
INSERT INTO TIPO_CLIENTES (id_tipo, tipo) VALUES (3, 'Concesionario');
INSERT INTO TIPO_CLIENTES (id_tipo, tipo) VALUES (4, 'Vendedora de Autopartes');

-----------------------------TIPO_PRODUCTOS---------------------------------------------------------------
INSERT INTO TIPO_PRODUCTOS (id, descripcion)
VALUES
    (1, 'automovil'),
    (2, 'Puertas'),
    (3, 'Ventanas'),
    (4, 'Asientos'),
    (5, 'Neum�ticos'),
    (6, 'Parachoques'),
    (7, 'Espejos'),
    (8, 'Radios'),
    (9, 'Airbags'),
    (10, 'faros');

-------------------TIPOS_UNIDADES_PESO-------------------
INSERT INTO TIPO_UNIDADES_PESO (id, descripcion) VALUES (1, 'Kilogramos');
INSERT INTO TIPO_UNIDADES_PESO (id, descripcion) VALUES (2, 'Libras');
INSERT INTO TIPO_UNIDADES_PESO (id, descripcion) VALUES (3, 'Gramos');
INSERT INTO TIPO_UNIDADES_PESO (id, descripcion) VALUES (4, 'Onzas');
INSERT INTO TIPO_UNIDADES_PESO (id, descripcion) VALUES (5, 'Toneladas');

---------------------TIPOS_UNIDADES_MEDIDAS-----------------
INSERT INTO TIPO_UNIDADES_MEDIDA (id, descripcion) VALUES (1, 'Cent�metros');
INSERT INTO TIPO_UNIDADES_MEDIDA (id, descripcion) VALUES (2, 'Metros');
INSERT INTO TIPO_UNIDADES_MEDIDA (id, descripcion) VALUES (3, 'Kil�metros');
INSERT INTO TIPO_UNIDADES_MEDIDA (id, descripcion) VALUES (4, 'Pulgadas');
INSERT INTO TIPO_UNIDADES_MEDIDA (id, descripcion) VALUES (5, 'Pies');
INSERT INTO TIPO_UNIDADES_MEDIDA (id, descripcion) VALUES (6, 'Yardas');

---------------------------------------TIPO_UBICACIONES--------------------------------
INSERT INTO TIPO_UBICACION (id, ubicacion) VALUES (1, 'Mostrador');
INSERT INTO TIPO_UBICACION (id, ubicacion) VALUES (2, 'Dep�sito Principal');
INSERT INTO TIPO_UBICACION (id, ubicacion) VALUES (3, 'Dep�sito Reserva');
INSERT INTO TIPO_UBICACION (id, ubicacion) VALUES (4, 'Sala de Exposici�n');
INSERT INTO TIPO_UBICACION (id, ubicacion) VALUES (5, 'Oficina de Ventas');
INSERT INTO TIPO_UBICACION (id, ubicacion) VALUES (6, '�rea de Almacenamiento');
INSERT INTO TIPO_UBICACION (id, ubicacion) VALUES (7, 'Zona de Carga y Descarga');
INSERT INTO TIPO_UBICACION (id, ubicacion) VALUES (8, '�rea de Producci�n');
INSERT INTO TIPO_UBICACION (id, ubicacion) VALUES (9, '�rea de Embalaje');
INSERT INTO TIPO_UBICACION (id, ubicacion) VALUES (10, '�rea de Env�o');

----------------------TIPOS_MATERIALES----------------------
INSERT INTO TIPO_MATERIALES (id, descripcion) VALUES (1, 'Acero');
INSERT INTO TIPO_MATERIALES (id, descripcion) VALUES (2, 'Aluminio');
INSERT INTO TIPO_MATERIALES (id, descripcion) VALUES (3, 'Pl�stico');
INSERT INTO TIPO_MATERIALES (id, descripcion) VALUES (4, 'Fibra de vidrio');
INSERT INTO TIPO_MATERIALES (id, descripcion) VALUES (5, 'Titanio');
INSERT INTO TIPO_MATERIALES (id, descripcion) VALUES (6, 'Caucho');

------------------------MARCAS-------------------------------------
INSERT INTO MARCAS (id, marca) VALUES (1, 'Toyota');
INSERT INTO MARCAS (id, marca) VALUES (2, 'Ford');
INSERT INTO MARCAS (id, marca) VALUES (3, 'Honda');
INSERT INTO MARCAS (id, marca) VALUES (4, 'Volkswagen');
INSERT INTO MARCAS (id, marca) VALUES (5, 'Chevrolet');
INSERT INTO MARCAS (id, marca) VALUES (6, 'BMW');
INSERT INTO MARCAS (id, marca) VALUES (7, 'Bosch');
INSERT INTO MARCAS (id, marca) VALUES (8, 'Delphi');
INSERT INTO MARCAS (id, marca) VALUES (9, 'Magnaflow');
INSERT INTO MARCAS (id, marca) VALUES (10, 'Denso');
INSERT INTO MARCAS (id, marca) VALUES (11, 'ACDelco');
INSERT INTO MARCAS (id, marca) VALUES (12, 'NGK');

----------------------TIPOS_MOVIMIENTOS------------------------------
INSERT INTO TIPO_MOVIMIENTOS (id, descripcion) VALUES (1, 'Ingreso de Stock');
INSERT INTO TIPO_MOVIMIENTOS (id, descripcion) VALUES (2, 'Salida de Stock');
INSERT INTO TIPO_MOVIMIENTOS (id, descripcion) VALUES (3, 'Venta');
INSERT INTO TIPO_MOVIMIENTOS (id, descripcion) VALUES (4, 'Devoluci�n');
INSERT INTO TIPO_MOVIMIENTOS (id, descripcion) VALUES (5, 'Transferencia entre Ubicaciones');

----------------------TIPO_AUTOPLANES------------------------------------
INSERT INTO TIPO_AUTOPLANES (id, descripcion) VALUES (1, 'AutoPlan Com�n');
INSERT INTO TIPO_AUTOPLANES (id, descripcion) VALUES (2, 'AutoPlan Deluxe');
INSERT INTO TIPO_AUTOPLANES (id, descripcion) VALUES (3, 'AutoPlan Bussines');
INSERT INTO TIPO_AUTOPLANES (id, descripcion) VALUES (4, 'AutoPlan Premium');
INSERT INTO TIPO_AUTOPLANES (id, descripcion) VALUES (5, 'AutoPlan Luxury');
INSERT INTO TIPO_AUTOPLANES (id, descripcion) VALUES (6, 'AutoPlan Personalizado');



-------------------------TIPOS_FACTURAS------------------------------------------------
INSERT INTO TIPO_FACTURA (id, descripcion) VALUES (1, 'Factura A');
INSERT INTO TIPO_FACTURA (id, descripcion) VALUES (2, 'Factura B');
INSERT INTO TIPO_FACTURA (id, descripcion) VALUES (3, 'Factura C');
INSERT INTO TIPO_FACTURA (id, descripcion) VALUES (4, 'Factura de Exportaci�n');

----------------------------FORMAS_PAGOS--------------------------------------------------------
INSERT INTO FORMA_PAGOS (id_forma, descripcion) VALUES (1, 'Efectivo');
INSERT INTO FORMA_PAGOS (id_forma, descripcion) VALUES (2, 'Tarjeta de Cr�dito');
INSERT INTO FORMA_PAGOS (id_forma, descripcion) VALUES (3, 'Tarjeta de D�bito');
INSERT INTO FORMA_PAGOS (id_forma, descripcion) VALUES (4, 'Transferencia Bancaria');
INSERT INTO FORMA_PAGOS (id_forma, descripcion) VALUES (5, 'Cheque');
INSERT INTO FORMA_PAGOS (id_forma, descripcion) VALUES (6, 'Financiamiento');

------------------------------------------CLIENTES-------------------------------------------------
INSERT INTO CLIENTES ( nombre, razon_social, cuil_cuit, id_barrio, direccion, id_tipo_cliente)
VALUES ( 'Juan P�rez', NULL, '20-12345678-9', 1, 'Calle 123', 1);
INSERT INTO CLIENTES ( nombre, razon_social, cuil_cuit, id_barrio, direccion, id_tipo_cliente)
VALUES ( 'Mar�a L�pez', NULL, '27-98765432-0', 2, 'Avenida Central', 2);
INSERT INTO CLIENTES ( nombre, razon_social, cuil_cuit, id_barrio, direccion, id_tipo_cliente)
VALUES ( 'Pedro G�mez', 'G�mez S.A.', '30-87654321-2', 3, 'Calle Principal', 2);
INSERT INTO CLIENTES ( nombre, razon_social, cuil_cuit, id_barrio, direccion, id_tipo_cliente)
VALUES ( 'Laura Rodr�guez', 'Rodr�guez Autos', '23-56789123-1', 4, 'Avenida Norte', 3);
INSERT INTO CLIENTES ( nombre, razon_social, cuil_cuit, id_barrio, direccion, id_tipo_cliente)
VALUES ( 'Carlos Mart�nez', 'Mart�nez Autom�viles', '24-12378945-6', 5, 'Calle Sur', 3);
INSERT INTO CLIENTES ( nombre, razon_social, cuil_cuit, id_barrio, direccion, id_tipo_cliente)
VALUES ( 'Ana S�nchez', NULL, '20-65431278-3', 6, 'Avenida Este', 1);
INSERT INTO CLIENTES ( nombre, razon_social, cuil_cuit, id_barrio, direccion, id_tipo_cliente)
VALUES ( 'Luis Gonz�lez', 'Gonz�lez Autopartes', '27-98765432-0', 7, 'Calle 456', 4);
INSERT INTO CLIENTES ( nombre, razon_social, cuil_cuit, id_barrio, direccion, id_tipo_cliente)
VALUES ( 'Marta Fern�ndez', NULL, '20-87654321-2', 8, 'Avenida Oeste', 1);
INSERT INTO CLIENTES ( nombre, razon_social, cuil_cuit, id_barrio, direccion, id_tipo_cliente)
VALUES ( 'Roberto P�rez', 'P�rez Empresas', '23-45678912-5', 9, 'Calle 789', 2);
INSERT INTO CLIENTES ( nombre, razon_social, cuil_cuit, id_barrio, direccion, id_tipo_cliente)
VALUES ( 'Luc�a Jim�nez', 'Jim�nez Autom�viles', '24-12378945-6', 10, 'Avenida Principal', 3);
INSERT INTO CLIENTES ( nombre, razon_social, cuil_cuit, id_barrio, direccion, id_tipo_cliente)
VALUES ( 'Diego L�pez', NULL, '20-65431278-3', 11, 'Calle 101', 1);
INSERT INTO CLIENTES ( nombre, razon_social, cuil_cuit, id_barrio, direccion, id_tipo_cliente)
VALUES ( 'Carmen Rodr�guez', NULL, '27-98765432-0', 12, 'Avenida Central', 1);
INSERT INTO CLIENTES ( nombre, razon_social, cuil_cuit, id_barrio, direccion, id_tipo_cliente)
VALUES ( 'Jorge P�rez', 'P�rez Autopartes', '30-87654321-2', 13, 'Calle 202', 4);
INSERT INTO CLIENTES ( nombre, razon_social, cuil_cuit, id_barrio, direccion, id_tipo_cliente)
VALUES ( 'Liliana G�mez', 'G�mez Empresas', '23-56789123-1', 14, 'Avenida Este', 2);
INSERT INTO CLIENTES ( nombre, razon_social, cuil_cuit, id_barrio, direccion, id_tipo_cliente)
VALUES ( 'Fernando S�nchez', 'S�nchez Autos', '24-12378945-6', 15, 'Calle 303', 2);
INSERT INTO CLIENTES ( nombre, razon_social, cuil_cuit, id_barrio, direccion, id_tipo_cliente)
VALUES ('Silvia Mart�nez', NULL, '20-65431278-3', 16, 'Avenida Norte', 1);
INSERT INTO CLIENTES ( nombre, razon_social, cuil_cuit, id_barrio, direccion, id_tipo_cliente)
VALUES ( 'Gustavo Gonz�lez', 'Gonz�lez Empresas', '27-98765432-0', 17, 'Calle 404', 2);
INSERT INTO CLIENTES ( nombre, razon_social, cuil_cuit, id_barrio, direccion, id_tipo_cliente)
VALUES ( 'Marcela L�pez', 'L�pez Autos', '30-87654321-2', 18, 'Avenida Sur', 2);
INSERT INTO CLIENTES ( nombre, razon_social, cuil_cuit, id_barrio, direccion, id_tipo_cliente)
VALUES ( 'Ricardo P�rez', NULL, '23-56789123-1', 19, 'Calle 505', 1);
INSERT INTO CLIENTES ( nombre, razon_social, cuil_cuit, id_barrio, direccion, id_tipo_cliente)
VALUES ( 'Natalia Jim�nez', 'Jim�nez Autopartes', '24-12378945-6', 20, 'Avenida 606', 4);

-----------------------------------PRODUCTOS---------------------------------------------------------------------------

INSERT INTO PRODUCTOS (producto, id_tipo_producto, num_serie, precio, fecha_fabricacion, vida_util, peso, id_unidad_peso, largo, ancho, alto, id_unidad_medida, id_tipo_material, id_pais, id_marca)
VALUES
( 'Autom�vil Sed�n', 1, 123456, 15000.50, '1995-04-15', 12, 1500.75, 1, 4.5, 1.8, 1.4, 2, 1, 1, 1),
( 'Puerta de Madera', 2, 987654, 45.75, '2020-10-20', 3, 10.25, 1, 1.2, 0.2, 2.0, 1, 3, 4, 4),
( 'Ventana de Aluminio', 3, 543210, 35.20, '2018-07-12', 4, 7.5, 1, 1.0, 0.8, 0.1, 1, 2, 3, 2),
( 'Puerta super buena', 4, 456789, 120.00, '2019-03-25', 2, 25.5, 1, 0.8, 0.6, 0.1, 1, 1, 1, 3),
( 'Neum�tico Deportivo', 5, 112233, 95.50, '2022-01-05', 1, 10.8, 1, 0.7, 0.7, 0.7, 1, 6, 5, 6),
( 'Parachoques Frontal', 6, 44555, 75.80, '2021-08-10', 2, 15.2, 1, 1.5, 0.3, 0.4, 1, 1, 2, 7),
( 'Espejo Retrovisor', 7, 67890, 20.25, '2020-12-30', 3, 5.0, 1, 0.8, 0.2, 0.2, 1, 2, 5, 3),
( 'Radio Multimedia', 8, 123123, 85.99, '2023-01-30', 0, 2.5, 1, 0.2, 0.2, 0.05, 1, 3, 4, 8),
( 'Airbag Frontal', 9, 789012, 49.50, '2019-11-20', 3, 2.0, 1, 0.5, 0.5, 0.1, 1, 4, 2, 9),
( 'Faros LED', 10, 555555, 120.75, '2021-04-02', 2, 1.8, 1, 0.3, 0.3, 0.1, 1, 1, 5, 12),
( 'Autom�vil Mercedes-Benz Clase C', 1, 1234590, 50000, '2023-01-01', 10, 1000, 1, 500, 200, 100, 2, 1, 1, 1),
( 'Puerta delantera izquierda de un autom�vil Ford Focus', 2, 234901, 2000, '2021-01-01', 5, 50, 1, 100, 50, 20, 2, 1, 2, 2),
( 'Ventana delantera derecha de un autom�vil Toyota Corolla', 3, 3459012, 1000, '2020-01-01', 3, 20, 1, 50, 25, 15, 2, 1, 3, 3),
( 'Asiento del conductor de un autom�vil Volkswagen Golf', 4, 45690123, 3000, '2019-01-01', 2, 50, 1, 100, 50, 20, 2, 1, 4, 4),
( 'Neum�tico delantero izquierdo de un autom�vil Chevrolet Silverado', 5, 56781234, 500, '2018-01-01', 1, 20, 1, 50, 25, 15, 2, 1, 5, 5),
( 'Parachoques trasero de un autom�vil Honda Civic', 6, 67892345, 1000, '2017-01-01', 5, 50, 1, 100, 50, 20, 2, 1, 3, 6),
( 'Espejo retrovisor lateral derecho de un autom�vil BMW Serie 3', 7, 7893456, 2000, '2016-01-01', 3, 20, 1, 50, 25, 15, 2, 1, 3, 7),
( 'Radio AM/FM de un autom�vil Ford Fiesta', 8, 8901567, 1500, '2015-01-01', 2, 50, 1, 100, 50, 20, 2, 1, 3, 8),
( 'Airbag del conductor de un autom�vil Toyota Yaris', 9, 9015678, 500, '2014-01-01', 1, 20, 1, 50, 25, 15, 2, 1, 2, 9),
( 'Faros delanteros de un autom�vil Volkswagen Tiguan', 10, 0126789, 1000, '2013-01-01', 5, 50, 1, 100, 50, 20, 2, 1, 1, 10),
( 'InventoCar A', 1, 1234589, 25000.00, '2000-05-15', 12, 1400.50, 1, 450.0, 180.0, 150.0, 2, 1, 4, 1),
( 'FuturoAuto B', 1, 9874321, 30000.00, '2015-08-22', 13, 1600.75, 1, 470.0, 185.0, 155.0, 2, 2, 3, 2),
( 'NextGenCar C', 1, 5891234, 35000.00, '2010-03-10', 11, 1550.25, 1, 460.0, 190.0, 160.0, 2, 3, 5, 3),
( 'EcoDrive D', 1, 2345891, 28000.00, '2005-12-05', 15, 1350.75, 1, 445.0, 175.0, 145.0, 2, 4, 4, 4),
( 'SuperCarro E', 1, 6789123, 45000.00, '2019-02-18', 14, 1700.00, 1, 480.0, 200.0, 165.0, 2, 5, 1, 5),
( 'AvanzAuto F', 1, 678912, 32000.00, '2012-11-30', 12, 1500.50, 1, 455.0, 180.0, 150.0, 2, 6, 2, 1),
( 'MegaMotor G', 1, 6789123, 42000.00, '2008-07-14', 13, 1650.25, 1, 465.0, 195.0, 162.0, 2, 1, 3, 2),
( 'FutureTech Auto H', 1, 7893456, 38000.00, '2016-04-25', 15, 1400.75, 1, 450.0, 175.0, 155.0, 2, 2, 5, 3),
( 'InnoCar I', 1, 891234, 29000.00, '2011-10-08', 14, 1550.25, 1, 470.0, 190.0, 160.0, 2, 3, 4, 4),
( 'GreenDrive J', 1, 123234, 36000.00, '2007-06-02', 11, 1450.50, 1, 440.0, 170.0, 140.0, 2, 4, 1, 5);

---------------------------------------------------STOCKS------------------------------------------------------------------------------------------
INSERT INTO STOCK (id, id_producto, id_tipo_movimiento, cantidad_total, cantidad_minima) VALUES
(1, 1, 1, 200, 25),
(2, 2, 2, 150, 40),
(3, 3, 3, 100, 15),
(4, 4, 4, 300, 55),
(5, 5, 5, 250, 30),
(6, 6, 1, 180, 20),
(7, 7, 2, 80, 10),
(8, 8, 3, 350, 50),
(9, 9, 4, 50, 5),
(10, 10, 5, 120, 35),
(11, 11, 1, 280, 45),
(12, 12, 2, 60, 8),
(13, 13, 3, 90, 12),
(14, 14, 4, 210, 28),
(15, 15, 5, 400, 60);

----------------------UBICACIONES------------------------------------
INSERT INTO UBICACIONES (id, cantidad, id_stock, id_tipo_ubicacion) VALUES
(1, 245, 1, 1),
(2, 132, 2, 2),
(3, 411, 3, 3),
(4, 88, 4, 4),
(5, 367, 5, 5),
(6, 203, 6, 6),
(7, 49, 7, 7),
(8, 288, 8, 8),
(9, 175, 9, 9),
(10, 413, 10, 10),
(11, 29, 11, 1),
(12, 176, 12, 2),
(13, 94, 13, 3),
(14, 405, 14, 4),
(15, 322, 15, 5),
(16, 111, 1, 6),
(17, 254, 2, 7),
(18, 57, 3, 8),
(19, 389, 4, 9),
(20, 497, 5, 10),
(21, 123, 6, 1),
(22, 294, 7, 2),
(23, 85, 8, 3),
(24, 167, 9, 4),
(25, 412, 10, 5);
-------------------------------------------HISTORIAL_PRECIOS---------------------------------------------------------
INSERT INTO HISTORIAL_PRECIOS (id, id_producto, precio, fechaDesde, fechaHasta)
VALUES
  (1, 1, 18500.00, '2020-04-15', '2022-12-31'),
  (2, 2, 750.00, '2020-10-20', '2022-11-30'),
  (3, 3, 655.50, '2018-07-12', '2022-10-31'),
  (4, 4, 1600.25, '2019-03-25', '2022-09-30'),
  (5, 5, 1400.75, '2022-01-05', '2022-08-31'),
  (6, 6, 1215.80, '2021-08-10', '2022-07-31'),
  (7, 7, 655.25, '2020-12-30', '2022-06-30'),
  (8, 8, 1206.50, '2023-01-30', '2022-05-31'),
  (9, 9, 656.00, '2019-11-20', '2022-04-30'),
  (10, 10, 1550.00, '2021-04-02', '2022-03-31'),
  (11, 11, 19500.00, '2019-04-15', '2021-12-31'),
  (12, 12, 800.00, '2020-10-20', '2021-11-30'),
  (13, 13, 705.50, '2018-07-12', '2021-10-31'),
  (14, 14, 1650.25, '2019-03-25', '2021-09-30'),
  (15, 15, 1450.75, '2021-01-05', '2021-08-31'),
  (16, 16, 1265.80, '2021-08-10', '2021-07-31'),
  (17, 17, 705.25, '2020-12-30', '2021-06-30'),
  (18, 18, 1256.50, '2022-01-30', '2021-05-31'),
  (19, 19, 705.00, '2020-11-20', '2021-04-30'),
  (20, 20, 1600.00, '2021-04-02', '2021-03-31'),
  (21, 1, 18550.00, '2018-04-15', '2020-12-31'),
  (22, 2, 760.00, '2020-10-20', '2020-11-30'),
  (23, 3, 665.50, '2018-07-12', '2020-10-31'),
  (24, 4, 1605.25, '2019-03-25', '2020-09-30'),
  (25, 5, 1405.75, '2020-01-05', '2020-08-31'),
  (26, 6, 1225.80, '2020-08-10', '2020-07-31'),
  (27, 7, 665.25, '2020-06-30', '2020-06-30'),
  (28, 8, 1208.50, '2020-01-30', '2020-05-31'),
  (29, 9, 658.00, '2019-11-20', '2020-04-30'),
  (30, 10, 1555.00, '2020-04-02', '2020-03-31'),
  (31, 1, 18600.00, '2015-04-15', '2019-12-31'),
  (32, 2, 770.00, '2019-10-20', '2019-11-30'),
  (33, 3, 675.50, '2017-07-12', '2019-10-31'),
  (34, 4, 1610.25, '2018-03-25', '2019-09-30'),
  (35, 5, 1410.75, '2019-01-05', '2019-08-31'),
  (36, 6, 1235.80, '2019-08-10', '2019-07-31'),
  (37, 7, 675.25, '2019-06-30', '2019-06-30'),
  (38, 8, 1210.50, '2019-01-30', '2019-05-31'),
  (39, 9, 660.00, '2018-11-20', '2019-04-30'),
  (40, 10, 1560.00, '2019-04-02', '2019-03-31');

-----------------------------------------AUTOPLANES-----------------------------------------------------------------------------------------
INSERT INTO AUTOPLANES (id_autoplan, descripcion, fecha_inicio, fecha_hasta, id_tipo_autoplan) VALUES
(1, 'AutoPlan Standar', '2023-01-01', '2023-12-31', 1),
(2, 'AutoPlan Estrella', '2023-02-01', '2025-01-31', 2),
(3, 'AutoPlan Verano', '2023-03-01', '2026-02-28', 3),
(4, 'AutoPlan Invierno', '2023-04-01', '2027-03-31', 4),
(5, 'AutoPlan Oto�o', '2023-05-01', '2028-04-30', 5),
(6, 'AutoPlan Primavera', '2023-06-01', '2024-05-31', 6),
(7, 'AutoPlan Descuento', '2023-07-01', '2024-06-30', 1),
(8, 'AutoPlan Pobre', '2023-08-01', '2025-07-31', 2),
(9, 'AutoPlan Rico', '2023-09-01', '2026-08-31', 3),
(10, 'AutoPlan Argentina', '2023-10-01', '2027-09-30', 4),
(11, 'AutoPlan Brasil', '2023-11-01', '2028-10-31', 5),
(12, 'AutoPlan Personalizado ', '2023-12-01', '2024-11-30', 6);

 -----------------------------------------DETALLE AUTOPLANES-----------------------------------------------------------------------------------------
INSERT INTO DETALLE_AUTOPLANES (id_detalle, id_autoplan, cant_cuotas, intereses, id_producto) VALUES
(1, 1, 12, 0.05, 1),
(2, 2, 24, 0.06, 11),
(3, 3, 36, 0.07, 21),
(4, 4, 48, 0.08, 22),
(5, 5, 60, 0.09, 23),
(6, 6, 11, 0.04, 24),
(7, 7, 12, 0.05, 25),
(8, 8, 24, 0.06, 26),
(9, 9, 36, 0.07, 27),
(10, 10, 48, 0.08, 28),
(11, 11, 60, 0.09, 29),
(12, 12, 11, 0.04, 30);

 -----------------------------------------ORDEN PEDIDOS-----------------------------------------------------------------------------------------
INSERT INTO ORDEN_PEDIDOS ( fecha_creacion, especificaciones) VALUES
( '2021-05-15', 'Especificaci�n 1'),
( '2021-07-20', NULL),
( '2021-09-10', 'Especificaci�n 2'),
( '2021-11-05', NULL),
( '2022-02-15', 'Especificaci�n 3'),
( '2022-04-30', NULL),
( '2022-06-18', 'Especificaci�n 4'),
( '2022-08-22', NULL),
( '2022-10-11', 'Especificaci�n 5'),
( '2022-12-25', NULL),
( '2023-02-28', 'Especificaci�n 6'),
( '2023-04-17', NULL),
( '2023-06-09', 'Especificaci�n 7'),
( '2023-08-12', NULL),
( '2023-10-05', 'Especificaci�n 8');

-------------------------------------DETALLE_PEDIDOS--------------------------------------------------
INSERT INTO DETALLE_PEDIDOS( fecha_entrega, id_orden_pedido, id_producto, cantidad, precio)
VALUES ( '2023-09-15', 8, 23, 10, 600);
INSERT INTO DETALLE_PEDIDOS( fecha_entrega, id_orden_pedido, id_producto, cantidad, precio)
VALUES ( '2023-08-20', 12, 17, 25, 700);
INSERT INTO DETALLE_PEDIDOS( fecha_entrega, id_orden_pedido, id_producto, cantidad, precio)
VALUES ( '2023-07-25', 6, 30, 15, 800);
INSERT INTO DETALLE_PEDIDOS( fecha_entrega, id_orden_pedido, id_producto, cantidad, precio)
VALUES ( '2023-09-10', 3, 5, 5, 900);
INSERT INTO DETALLE_PEDIDOS( fecha_entrega, id_orden_pedido, id_producto, cantidad, precio)
VALUES ( '2023-09-05', 14, 12, 20, 1000);
INSERT INTO DETALLE_PEDIDOS( fecha_entrega, id_orden_pedido, id_producto, cantidad, precio)
VALUES ('2023-08-30', 1, 2, 8, 1100);
INSERT INTO DETALLE_PEDIDOS( fecha_entrega, id_orden_pedido, id_producto, cantidad, precio)
VALUES ( '2023-08-10', 9, 27, 18, 1200);
INSERT INTO DETALLE_PEDIDOS( fecha_entrega, id_orden_pedido, id_producto, cantidad, precio)
VALUES ( '2023-07-05', 5, 14, 12, 1300);
INSERT INTO DETALLE_PEDIDOS( fecha_entrega, id_orden_pedido, id_producto, cantidad, precio)
VALUES ( '2023-09-15', 11, 1, 3, 1400);
INSERT INTO DETALLE_PEDIDOS( fecha_entrega, id_orden_pedido, id_producto, cantidad, precio)
VALUES ( '2023-07-20', 10, 9, 7, 1500);
INSERT INTO DETALLE_PEDIDOS( fecha_entrega, id_orden_pedido, id_producto, cantidad, precio)
VALUES ( '2023-09-30', 15, 28, 23, 1600);
INSERT INTO DETALLE_PEDIDOS( fecha_entrega, id_orden_pedido, id_producto, cantidad, precio)
VALUES ( '2023-08-15', 7, 21, 14, 1700);
INSERT INTO DETALLE_PEDIDOS( fecha_entrega, id_orden_pedido, id_producto, cantidad, precio)
VALUES ( '2023-07-10', 2, 11, 6, 1800);
INSERT INTO DETALLE_PEDIDOS( fecha_entrega, id_orden_pedido, id_producto, cantidad, precio)
VALUES ( '2023-08-05', 13, 16, 9, 1900);
INSERT INTO DETALLE_PEDIDOS( fecha_entrega, id_orden_pedido, id_producto, cantidad, precio)
VALUES ( '2023-07-30', 4, 26, 11, 2000);

--------------------------------------------FACTURAS---------------------------------------------
INSERT INTO FACTURAS( fecha, cod_cliente, id_orden_pedido, id_tipo_factura)
VALUES ( '2023-07-15', 8, 9, 2);
INSERT INTO FACTURAS( fecha, cod_cliente, id_orden_pedido, id_tipo_factura)
VALUES ( '2021-11-05', 16, 11, 3);
INSERT INTO FACTURAS( fecha, cod_cliente, id_orden_pedido, id_tipo_factura)
VALUES ( '2022-08-25', 2, 14, 4);
INSERT INTO FACTURAS( fecha, cod_cliente, id_orden_pedido, id_tipo_factura)
VALUES ( '2023-01-30', 7, 12, 1);
INSERT INTO FACTURAS( fecha, cod_cliente, id_orden_pedido, id_tipo_factura)
VALUES ( '2022-10-20', 20, 3, 2);
INSERT INTO FACTURAS( fecha, cod_cliente, id_orden_pedido, id_tipo_factura)
VALUES ( '2022-02-18', 13, 10, 3);
INSERT INTO FACTURAS( fecha, cod_cliente, id_orden_pedido, id_tipo_factura)
VALUES ( '2021-12-12', 4, 15, 4);
INSERT INTO FACTURAS( fecha, cod_cliente, id_orden_pedido, id_tipo_factura)
VALUES ( '2021-10-05', 12, 7, 1);
INSERT INTO FACTURAS( fecha, cod_cliente, id_orden_pedido, id_tipo_factura)
VALUES ( '2023-06-23', 19, 6, 2);
INSERT INTO FACTURAS( fecha, cod_cliente, id_orden_pedido, id_tipo_factura)
VALUES ( '2021-09-08', 9, 1, 3);
INSERT INTO FACTURAS( fecha, cod_cliente, id_orden_pedido, id_tipo_factura)
VALUES ( '2022-05-14', 6, 5, 4);
INSERT INTO FACTURAS( fecha, cod_cliente, id_orden_pedido, id_tipo_factura)
VALUES ( '2022-07-29', 5, 8, 1);
INSERT INTO FACTURAS( fecha, cod_cliente, id_orden_pedido, id_tipo_factura)
VALUES ( '2022-09-10', 1, 4, 2);
INSERT INTO FACTURAS( fecha, cod_cliente, id_orden_pedido, id_tipo_factura)
VALUES ( '2023-03-02', 18, 2, 3);
INSERT INTO FACTURAS( fecha, cod_cliente, id_orden_pedido, id_tipo_factura)
VALUES ( '2023-05-17', 17, 13, 4);

---------------------------FACTURAS_X_FORMAS_PAGOS-------------------------------
INSERT INTO FACTURAS_X_FORMA_PAGOS(id, id_forma, nro_factura, descuento)
VALUES (1, 2, 1, 0);
INSERT INTO FACTURAS_X_FORMA_PAGOS(id, id_forma, nro_factura, descuento)
VALUES (2, 5, 2, 0);
INSERT INTO FACTURAS_X_FORMA_PAGOS(id, id_forma, nro_factura, descuento)
VALUES (3, 4, 3, 0.1);
INSERT INTO FACTURAS_X_FORMA_PAGOS(id, id_forma, nro_factura, descuento)
VALUES (4, 1, 4, 0);
INSERT INTO FACTURAS_X_FORMA_PAGOS(id, id_forma, nro_factura, descuento)
VALUES (5, 6, 5, 0);
INSERT INTO FACTURAS_X_FORMA_PAGOS(id, id_forma, nro_factura, descuento)
VALUES (6, 3, 6, 0.05);
INSERT INTO FACTURAS_X_FORMA_PAGOS(id, id_forma, nro_factura, descuento)
VALUES (7, 2, 7, 0);
INSERT INTO FACTURAS_X_FORMA_PAGOS(id, id_forma, nro_factura, descuento)
VALUES (8, 5, 8, 0);
INSERT INTO FACTURAS_X_FORMA_PAGOS(id, id_forma, nro_factura, descuento)
VALUES (9, 4, 9, 0.15);
INSERT INTO FACTURAS_X_FORMA_PAGOS(id, id_forma, nro_factura, descuento)
VALUES (10, 1, 10, 0);
INSERT INTO FACTURAS_X_FORMA_PAGOS(id, id_forma, nro_factura, descuento)
VALUES (11, 6, 11, 0);
INSERT INTO FACTURAS_X_FORMA_PAGOS(id, id_forma, nro_factura, descuento)
VALUES (12, 3, 12, 0.2);
INSERT INTO FACTURAS_X_FORMA_PAGOS(id, id_forma, nro_factura, descuento)
VALUES (13, 2, 13, 0);
INSERT INTO FACTURAS_X_FORMA_PAGOS(id, id_forma, nro_factura, descuento)
VALUES (14, 5, 14, 0);
INSERT INTO FACTURAS_X_FORMA_PAGOS(id, id_forma, nro_factura, descuento)
VALUES (15, 4, 15, 0.25)

------------------------DETALLE_FACTURAS-------------------------------------
INSERT INTO DETALLE_FACTURAS ( nro_factura, cod_producto, pre_unitario, cantidad)
VALUES
( 1, 1, 15000.50, 5),
( 1, 2, 45.75, 10),
( 2, 3, 35.20, 8),
( 2, 4, 120.00, 3),
( 3, 5, 95.50, 6),
( 3, 6, 75.80, 4),
( 4, 7, 20.25, 12),
( 4, 8, 85.99, 2),
( 5, 9, 49.50, 7),
( 5, 10, 120.75, 3),
( 6, 11, 50000.00, 2),
( 6, 12, 2000.00, 4),
( 7, 13, 1000.00, 5),
( 7, 14, 3000.00, 2),
( 8, 15, 500.00, 8);

-------------------------------------TIPO_CONTACTO---------------------------------------------------
INSERT INTO TIPO_CONTACTOS (id, descripcion) VALUES (1, 'Email');
INSERT INTO TIPO_CONTACTOS (id, descripcion) VALUES (2, 'Tel�fono');
INSERT INTO TIPO_CONTACTOS (id, descripcion) VALUES (3, 'WhatsApp');
INSERT INTO TIPO_CONTACTOS (id, descripcion) VALUES (4, 'Instagram');
INSERT INTO TIPO_CONTACTOS (id, descripcion) VALUES (5, 'Facebook');
INSERT INTO TIPO_CONTACTOS (id, descripcion) VALUES (6, 'Twitter');
INSERT INTO TIPO_CONTACTOS (id, descripcion) VALUES (7, 'LinkedIn');
INSERT INTO TIPO_CONTACTOS (id, descripcion) VALUES (8, 'Direcci�n');
INSERT INTO TIPO_CONTACTOS (id, descripcion) VALUES (9, 'Sitio web');
INSERT INTO TIPO_CONTACTOS (id, descripcion) VALUES (10, 'Skype');
INSERT INTO TIPO_CONTACTOS (id, descripcion) VALUES (11, 'Tel�fono m�vil');
INSERT INTO TIPO_CONTACTOS (id, descripcion) VALUES (12, 'Fax');

-------------------------------------CONTACTOS--------------------------------------------------
INSERT INTO CONTACTOS ( descripcion, id_tipo_contacto, cod_cliente) VALUES
( 'contacto1@email.com', 1, 1),
( '123-456-7890', 2, 2),
( 'contacto3@email.com', 1, 3),
( '789-123-4567', 2, 4),
('+1234567890', 3, 5),
( '@instagram_contacto6', 4, 6),
( '/facebook_contacto7', 5, 7),
( '@twitter_contacto8', 6, 8),
( 'linkedin.com/in/contacto9', 7, 9),
( '123 Main St, Ciudad, Pa�s', 8, 10),
( 'www.sitiowebcontacto11.com', 9, 11),
( 'skype_contacto12', 10, 12),
( '+7891234567', 3, 13),
( 'contacto14@email.com', 1, 14),
( '+4567890123', 3, 15),
( 'contacto16@email.com', 1, 16),
( '124-567-8901', 2, 17),
( 'contacto18@email.com', 1, 18),
( '+5678901234', 3, 19),
( '@instagram_contacto20', 4, 20),
( '/facebook_contacto21', 5, 1),
( 'www.sitiowebcontacto22.com', 9, 2),
( 'linkedin.com/in/contacto23', 7, 3),
( '125 Main St, Ciudad, Pa�s', 8, 4),
( 'skype_contacto25', 10, 5),
( '+2345678901', 3, 6),
( 'contacto27@email.com', 1, 7),
( '+6789012345', 3, 8),
( 'contacto29@email.com', 1, 9),
( '126-789-0123', 2, 10),
( 'contacto31@email.com', 1, 11),
( '+3456789012', 3, 12),
( '@instagram_contacto33', 4, 13),
( '/facebook_contacto34', 5, 14),
( 'www.sitiowebcontacto35.com', 9, 15),
( 'linkedin.com/in/contacto36', 7, 16),
( '127 Main St, Ciudad, Pa�s', 8, 17),
( 'skype_contacto38', 10, 18),
( '+4567890123', 3, 19),
( 'contacto40@email.com', 1, 20);

-------------------------------------AUTOPLANES CLIENTES--------------------------------------------------
INSERT INTO AUTOPLANES_CLIENTES (id, cod_cliente, id_autoplan) VALUES (1, 1, 1);
INSERT INTO AUTOPLANES_CLIENTES (id, cod_cliente, id_autoplan) VALUES (2, 2, 2);
INSERT INTO AUTOPLANES_CLIENTES (id, cod_cliente, id_autoplan) VALUES (3, 3, 3);
INSERT INTO AUTOPLANES_CLIENTES (id, cod_cliente, id_autoplan) VALUES (4, 4, 4);
INSERT INTO AUTOPLANES_CLIENTES (id, cod_cliente, id_autoplan) VALUES (5, 5, 5);
INSERT INTO AUTOPLANES_CLIENTES (id, cod_cliente, id_autoplan) VALUES (6, 6, 6);
INSERT INTO AUTOPLANES_CLIENTES (id, cod_cliente, id_autoplan) VALUES (7, 7, 7);
INSERT INTO AUTOPLANES_CLIENTES (id, cod_cliente, id_autoplan) VALUES (8, 8, 8);
INSERT INTO AUTOPLANES_CLIENTES (id, cod_cliente, id_autoplan) VALUES (9, 9, 9);
INSERT INTO AUTOPLANES_CLIENTES (id, cod_cliente, id_autoplan) VALUES (10, 10, 10);
INSERT INTO AUTOPLANES_CLIENTES (id, cod_cliente, id_autoplan) VALUES (11, 11, 11);
INSERT INTO AUTOPLANES_CLIENTES (id, cod_cliente, id_autoplan) VALUES (12, 12, 12);
INSERT INTO AUTOPLANES_CLIENTES (id, cod_cliente, id_autoplan) VALUES (13, 13, 1);
INSERT INTO AUTOPLANES_CLIENTES (id, cod_cliente, id_autoplan) VALUES (14, 14, 2);
INSERT INTO AUTOPLANES_CLIENTES (id, cod_cliente, id_autoplan) VALUES (15, 15, 3);
INSERT INTO AUTOPLANES_CLIENTES (id, cod_cliente, id_autoplan) VALUES (16, 16, 4);
INSERT INTO AUTOPLANES_CLIENTES (id, cod_cliente, id_autoplan) VALUES (17, 17, 5);
INSERT INTO AUTOPLANES_CLIENTES (id, cod_cliente, id_autoplan) VALUES (18, 18, 6);
INSERT INTO AUTOPLANES_CLIENTES (id, cod_cliente, id_autoplan) VALUES (19, 19, 7);
INSERT INTO AUTOPLANES_CLIENTES (id, cod_cliente, id_autoplan) VALUES (20, 20, 8);

go
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


------
go
--
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
	 -- Obtener el �ltimo cod_cliente insertado
    SET @id= SCOPE_IDENTITY()
end
go
--
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

--lauti--
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


--mine

create procedure sp_insertar_factura
@cliente int,
@tipo_facturas int,
@producto int,
@precio float,
@cantidad int,
@orden int = null-- es null en caso de que no este asociada una orden de pedido
as
begin
	declare @factura int; --variable para la id de facturas

	if (@cantidad> (select cantidad_total from STOCK s where s.id_producto = @producto)) -- si cantidad es mayor que el stock, salta error
		begin
			raiserror('la cantidad es mayor que el stock actual en la empresa, haga una orden de pedido',-1,-1)
		end
	else --si no hay error se procede con la insersion
		begin
			insert into FACTURAS(fecha,cod_cliente,id_tipo_factura,id_orden_pedido)
			values(GETDATE(), @cliente,@tipo_facturas,@orden);-- getdate es para ingresar la fecha como el momento en que se inserta

			set @factura = SCOPE_IDENTITY();--para detalle de factura el id es necesario, se saca con el scopeidentity

			insert into DETALLE_FACTURAS (nro_factura,cod_producto,pre_unitario,cantidad)
			values (@factura,@producto,@precio,@cantidad);
		end
end
go
create procedure sp_insert_orden
@detalles varchar(150),
@fecha date,-- fecha pactada a la entrega
@producto int,
@cantidad int,
@precio float
as
begin
	declare @orden int; --para sacar el id de orden de pedidos

	insert into ORDEN_PEDIDOS(fecha_creacion,especificaciones)
	values (GETDATE(),@detalles); -- se carga la fecha con el getdate

	set @orden = SCOPE_IDENTITY();-- se consigue el id que carga en orden de pedidos

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

-- sofi's

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