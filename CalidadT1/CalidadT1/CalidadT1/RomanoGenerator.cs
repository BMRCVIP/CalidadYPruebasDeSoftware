namespace CalidadT1;
public class RomanoGenerator
{
    private Dictionary<int, string> romanos = new Dictionary<int, string>()
    {
        //...
        //añadir el 1000
        { 1000, "M"},
        { 500, "D" },
        { 100, "C" },
        { 50, "L" },
        { 49, "XLIX"},
        { 40, "XL"},
        { 10, "X" },
        { 9, "IX"},
        { 5, "V" },
        //agregar el 4 al diccionario
        { 4, "IV"},
        { 1, "I" },
    };
    // si se envia un numero menor a 1 debe enviar error/ validar hasta el 1000
    public string GetRomano(int number)
    {
        if (number <= 0)
            return "error";
        if (number > 1000)
            return "numero mayor a mil";
        var romano = "";
            while (number > 0)
            {
                foreach (KeyValuePair<int, string> entry in romanos)
                {
                    if (number < entry.Key) continue;
                    romano += entry.Value;
                    number -= entry.Key;
                    break;
                }
            }
            return romano;
    }
}