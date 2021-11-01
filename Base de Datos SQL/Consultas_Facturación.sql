/* Consultas */
/* Lista de precios de todos los productos */
select * from productos

/* Obtener lista de productos cuya existencia en el inventario haya llegado al minimo permitido (5 unidades) */
select * from detalle_factura
where cantidad=5;

/* Obtener una lista de clientes no mayores de 35 años que hayan realizado compras entre el 4 de Agosto del 2021 y el 7 de Junio del 2021  */
select * from clientes,factura
where edad<=35 and Fecha between '04-08-2021' and '07-06-2021' ;

/* Obtener el total del valor vendido por producto en el año 2021 */
select sum(Pr_venta)as Total_vendido_xcada_producto from productos,factura
where year(Fecha)=2021;

/* Obtener la ultima fecha de compra de un cliente y segun su frecuencia de compra estimar en que fecha podria volver a comprar. 
Cálculo de frecuencia de compra (FP) = (Numero de compras en (x tiempo))/(Total de numero de cliente en (x tiempo))*/
/* Numero de compras */

/*Calculo del tiempo entre compras.
Tiempo entre compras (TBP)= 365 días/(FP) frecuencia de compra*/
select count(Fecha) / count(pr_venta) / 365 as Tiempo_entre_compras  from factura,productos
where idcliente=idcliente ;








