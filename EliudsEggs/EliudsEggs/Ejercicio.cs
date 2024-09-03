namespace EliudsEggs
{

    /*
    Consigna:
        Tu amigo Eliud heredó una granja de su abuela Tigist. Su abuela era inventora y tenía tendencia a construir cosas de una manera demasiado complicada. El gallinero tiene una pantalla digital que muestra un número codificado que representa las posiciones de todos los huevos que se pueden recoger.

        Eliud te pide que escribas un programa que muestre el número real de huevos en el gallinero.

        La codificación de la información de posición se calcula de la siguiente manera:

        Escanee los lugares potenciales para poner huevos y marque un 1para un huevo existente o un 0para un lugar vacío.
        Convierte el número de binario a decimal.
        Mostrar el resultado en la pantalla.

        Ejemplo 1:

            Chicken Coop:
             _ _ _ _ _ _ _
            |E| |E|E| | |E|

            Resulting Binary:
             1 0 1 1 0 0 1

            Decimal number on the display:
            89

            Actual eggs in the coop:
            4
        Ejemplo 2:

            Chicken Coop:
             _ _ _ _ _ _ _ _
            | | | |E| | | | |

            Resulting Binary:
             0 0 0 1 0 0 0 0

            Decimal number on the display:
            16

            Actual eggs in the coop:
            1

        Instrucciones
        Su tarea es contar la cantidad de bits 1 en la representación binaria de un número.

        Restricciones
        ¡No utilices la función de recuento de bits que ofrece tu biblioteca estándar! Resuelve este problema tú mismo utilizando otras herramientas básicas.
    */

    public static class EliudsEggs
    {
        public static int EggCount(int encodedCount)
        {
            string binario = Convert.ToString(encodedCount, 2);


            int count = 0;
            foreach (char bit in binario)
            {
                if (bit == '1')
                {
                    count++;
                }
            }

            return count;
        }
    }

}
