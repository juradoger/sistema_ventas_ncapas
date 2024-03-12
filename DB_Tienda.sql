---crear base de datos
CREATE DATABASE TIENDABD;
--para posicionarse a la DB
USE TIENDABD;
CREATE TABLE PERSONA (
	idpersona	INT PRIMARY KEY,
	nombre		NVARCHAR(40) not null,
	apellido	NVARCHAR(20)not null,
	telefono	NVARCHAR (20)not null,
	ci			NVARCHAR(20)not null,
	correo		NVARCHAR(20)not null,
	estado		NVARCHAR(20)not null,
);
create table USUARIO
(
	idusuario		INT primary key,
	idpersona		INT not null,
	nombreuser		NVARCHAR(20) not null,
	contrasena		NVARCHAR(20)not null,
	fechareg		datetime not null,
	foreign key(idpersona) references persona(idpersona)
);
create table ROL
(
	idrol INT primary key,
	nombre NVARCHAR(20) not null,
	estado NVARCHAR(20)not null,
);
create table USUARIO_ROL
(
	idusuariorol int primary key,
	idusuario int not null,
	idrol int not null,
	fechaasigna datetime not null,
	estado varchar (20)not null,
	foreign key(idusuario) references usuario(idusuario),
	foreign key(idrol) references rol(idrol)
);
create table CLIENTE
(
	idcliente int primary key,
	idpersona int not null,
	tipocliente varchar(20) not null,
	codigocliente varchar(20)not null,
	estado varchar(20)not null,
	foreign key(idpersona) references persona(idpersona),
);
create table VENTA
(
	idventa int primary key,
	idcliente int not null, 
	idvendedor int not null,
	fecha datetime not null,
	total varchar(20) not null,
	estado varchar(20) not null,
	foreign key(idcliente) references cliente(idcliente),
	foreign key(idvendedor) references usuario(idusuario)
);
create table TIPO_PRODUCTO
(
	idtipoprod int primary key,
	nombre varchar(20) not null,
	estado varchar(20) not null,
);
create table MARCA
(
	idmarca int primary key,
	nombre varchar(20) not null,
	estado varchar(20) not null,
);
create table PRODUCTO
(
	idproducto int primary key,
	idtipoproducto int not null,
	nombre varchar(20) not null,
	codigobarra varchar(20) not null,
	idmarca int not null,
	unidad varchar(20) not null,
	descripcion varchar(20) not null,
	estado varchar(20) not null,
	foreign key (idtipoproducto) references tipo_producto(idtipoprod), 
	foreign key (idmarca) references marca(idmarca)
);
create table DETALLE_VENTA
(
	iddetallevent int primary key,
	idventa int not null,
	idproducto int not null,
	cantidad varchar(20) not null,
	precioventa varchar(20) not null,
	subtotal varchar(20) not null,
	estado varchar(20) not null,
	foreign key(idventa) references venta(idventa),
	foreign key (idproducto) references producto(idproducto)
);
create table PROVEEDOR
(
	idproveedor int primary key,
	nombre varchar(20) not null,
	telefono varchar(20) not null,
	direccion varchar(20) not null,
	estado varchar(20) not null,
);
create table INGRESO
(
	idingreso int primary key,
	idproveedor int not null,
	fechaingreso datetime not null,
	total varchar(20) not null,
	estado varchar(20) not null,
	foreign key (idproveedor) references proveedor(idproveedor)
);
create table DETALLE_INGRESO
(
	iddetalleing int primary key,
	idproducto int not null,
	idingreso int not null,
	fechavenc datetime not null,
	cantidad varchar(20) not null,
	preciocosto varchar(20) not null,
	precioventa varchar(20) not null,
	subtotal varchar(20) not null,
	estado varchar(20) not null,
	foreign key (idproducto) references producto(idproducto),
	foreign key (idingreso) references ingreso(idingreso),
)
create table PROVEE
(
	idprovee int primary key,
	idproducto int not null,
	idproveedor int not null,
	fecha varchar(20) not null,
	precio varchar(20) not null,
	foreign key(idproducto) references producto(idproducto),
	foreign key(idproveedor) references proveedor(idproveedor)
);