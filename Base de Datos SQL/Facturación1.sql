CREATE DATABASE FACTURACION;
USE FACTURACION;

/* Crear 4 Tablas para Facturación */
create table productos(

Idproducto varchar(6) not null,
Producto varchar(50) not null,
Pr_venta decimal(7,3) not null,
primary key(Idproducto)
);

create table clientes(

Idcliente bigint identity(1,1) not null,
Nombre varchar(50) not null,
edad int not null,
Direccion varchar(80) not null,
Telefono varchar(9) not null,
Email varchar(25),
primary key(Idcliente)
);
select*from CLIENTES;

create table factura(

N_factura varchar(6) not null,
Idcliente bigint not null,
Fecha datetime not null,
Descuento varchar(6) not null,
Iva varchar(6) not null,
primary key(N_factura)
);

select*from factura;

create table detalle_factura(

N_factura varchar(6),
Idproducto varchar(6),
Cantidad bigint,
primary key(N_factura)
);

/*Inserciones en la tabla productos */
Insert into productos values('IH-123','Celular',350.000);
Insert into productos values('IH-456','Televisor',1350.0000);
Insert into productos values('IH-789','Computador',2350.000);
/*Consulta tabla productos */
select*from productos;

/*Inserciones en la tabla clientes */
Insert into clientes values('Sergio Ramos',34,'Avenida circunvalar 13','7433189','juano315@hotmail.com');
Insert into clientes values('Cristian Ronaldo',30,'Calle 46 #13-08','8879654','Crronaldo@hotmail.com');
Insert into clientes values('Luis Suarez',25,'Cra 26 #46-58','7433189','Lsuarez@hotmail.com');

/*Consulta tabla clientes*/
select*from clientes;

/* Inserciones tabla detalle_factura */
Insert into detalle_factura values('IH-123','1234',50);
Insert into detalle_factura values('IH-456','4567',5);
Insert into detalle_factura values('IH-789','8910',5);

/*Consulta tabla clientes*/
select*from detalle_factura;

/*Inserciones en la tabla factura */
Insert into factura values('NF-123','1234','04-08-2021','10%','16%');
Insert into factura values('NF-456','5678','05-07-2021','5%','16%');
Insert into factura values('NF-789','9112','06-07-2021','10%','16%');

/*Consulta tabla factura*/
select*from factura;



