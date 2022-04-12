using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Una flota de taxis tiene una cantidad determinada de unidades.Se calcula que cada unidad recorre unos 90 km por día
//y que cada litro de combustible permite recorrer 15 km.Se calcula también que los días de lluvia se trabaja más, llegando
//a un recorrido de 110 km por unidad.Teniendo en cuenta que el litro de combustible cuesta $130, debemos hacer un programa 
//que nos permita calcular el costo del combustible para una flota completa de taxis en un período de días determinado.

//Se requiere el ingreso por Inspector de la cantidad de unidades que tiene la flota, la cantidad total de días y 
//una cantidad de días de lluvia a tener en cuenta.

//El programa debe cumplir los siguientes requerimientos:

//El programa debe devolver la información calculada mediante un mensaje en el siguiente formato:
//“Una flota de[cantidadDeUnidades] unidades trabajando durante [periodoDeDias] 
//días implicará un gasto de[costoTotalCombustible] pesos en concepto de combustible”.

//El programa debe devolver un mensaje de error y no realizar ningún cálculo si la cantidad de días total
//es menor que 5 o si la cantidad de días de lluvia es negativa o mayor que la cantidad total de días. 

	//dia normal = 90km 
	//dia lluvia = 110km
	//1L = 15km
	//1L = $130
	//dias normales + dias lluvia 
	//para 90km se necesitan 6L

public class FlotaDeTaxis : MonoBehaviour
{
	public int unidadesFlota;
	public int periodoDeDias;
	public int cantidadDiasLluvia;

	int litrosDiaNormal = 90 / 15;
	int litrosDiaLluvia = 110 / 15;

	int costoTotalCombustible;

	// Start is called before the first frame update
	void Start()
	{
		if (periodoDeDias < 5 || cantidadDiasLluvia < 0 || cantidadDiasLluvia > periodoDeDias)
		{
			Debug.Log("Error");
		}
		else
		{
			
			costoTotalCombustible = ((periodoDeDias-cantidadDiasLluvia)*(unidadesFlota * litrosDiaNormal * 130)) + (cantidadDiasLluvia* unidadesFlota * litrosDiaLluvia * 130);

			Debug.Log("Una flota de " + unidadesFlota + " unidades trabajando durante "
				+ periodoDeDias + " días implicará un gasto de " + costoTotalCombustible + " pesos en combustible");
		}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
