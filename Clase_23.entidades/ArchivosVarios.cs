using Clase_23.entidades;
public delegate void LimiteSueldoDelegado(double sueldo, Empleado empleado);
public delegate void LimiteSueldoManejadoDel(Empleado emp, EmpleadoEventArgs e);
public enum TipoManejador
{
    LimiteSueldo,
    LimiteSueldoMejorado,
    Todos
}