Create DataBase automotriz
go
use automotriz 
go


create table Barrios
(idBarrio int identity (1,1),
barrio varchar(50),
constraint pk_barrio primary key (idBarrio))

create table Formas_Pago
(idFormaPago int,
formaPago varchar(50), 
constraint pk_forma_pago primary key (idFormaPago))

create table Tipos_Clientes
(idTipoCliente int identity (1,1),
descripcion varchar(50),
constraint pk_tipo_cliente primary key (idTipoCliente))

create table Auto_Planes
(idAutoPlan int identity (1,1),
descripcion varchar(50),
constraint pk_auto_plan primary key(idAutoPlan))


create table Clientes
(idCliente int identity (1,1),
nomCliente varchar(50),
apeCliente varchar(50),
calle varchar(50),
altura int,
idBarrio int,
idTipoCliente int,
idAutoPlan int,
constraint pk_cliente primary key (idCliente),
constraint fk_barrio_cliente foreign key (idBarrio) references Barrios (idBarrio),
constraint fk_tipo_cliente foreign key (idTipoCliente) references Tipos_Clientes (idTipoCliente),
constraint fk_plan_cliente foreign key (idAutoPlan) references Auto_Planes(idAutoPlan))

create table Facturas
(nroFactura int identity (1,1),
idCliente int,
fecha datetime,
descuento int,
interes int,
cuotas int,
idFormaPago int,
 constraint pk_facturas primary key (nroFactura),
 constraint fk_cliente_factura foreign key (idCliente) references Clientes(idCliente),
 constraint fk_forma_pago_Factura foreign key (idFormaPago) references Formas_Pago (idFormaPago))

 create table Pedidos
 (nroPedido int identity (1,1),
 fechaOrden datetime,
 fechaPedido datetime,
 idCliente int,
 constraint pk_pedidos primary key(nroPedido),
 constraint fk_cliente_pedido foreign key (idCliente) references Clientes(idCliente))

 create table Tipos_Productos
 (idTipoProducto int identity (1,1),
 descripcion varchar(50),
 constraint pk_tipo_producto primary key (idTipoProducto))

 create table Productos 
 (idProducto int identity (1,1),
 descripcion varchar(50),
 stock_min int,
 stock_actual int,
 precio money, 
 idTipoProducto int,
 constraint pk_productos primary key (idProducto),
 constraint fk_tipo_prod foreign key (idTipoProducto) references Tipos_Productos (idTipoProducto))

 create table Historial
 (idHistorial int identity (1,1),
 idProducto int,
 precio money,
 fecha datetime,
 constraint pk_historial primary key (idHistorial, idProducto),
 constraint fk_producto_hist foreign key (idProducto) references Productos(idProducto))

 create table Detalles_Factura
 (idDetalleFactura int,
 nroFactura int,
 idProducto int,
 cantidad int,
 pre_unitario money,
 constraint pk_detalleFactura primary key (idDetalleFactura,nroFactura),
 constraint fk_factura_detalle foreign key(nroFactura) references Facturas(nroFactura),
 constraint fk_producto_detalle foreign key(idProducto) references Productos(idProducto))

 create table Detalles_Pedidos
 (idDetallePedido int,
 nroPedido int,
 idProducto int,
 cantidad int,
constraint pk_detalle_pedidos primary key (idDetallePedido, nroPedido),
constraint fk_pedido_detalle foreign key (nroPedido) references Pedidos(nroPedido),
constraint fk_detalle_producto foreign key(idProducto) references Productos(idProducto))