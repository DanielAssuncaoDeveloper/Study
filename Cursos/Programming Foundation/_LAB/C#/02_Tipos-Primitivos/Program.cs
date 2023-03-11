namespace _02_Tipos_Primitivos;
class Program
{
    static void Main(string[] args)
    {
        // Tipos internos de valor
        //-------------------------

        sbyte varSbyte = 0;     // -128 to 127                      | 8 bits
        byte varByte = 0;       // 0 to 255                         | 8 bits
        short varShort = 0;     // -32.768 to 32.767                | 16 bits
        short varUshort = 0;    // 0 to 65.535                      | 16 bits
        int varInt = 0;         // -2.147.483.648 to 2.147.483.647  | 32 bits
        uint varUint = 0;       // 0 to 2.147.483.647               | 32 bits
        long varLong = 0;       // -9.223.372.036.854.775.808 to
                                // 9.223.372.036.854.775.807        | 64 bits
        ulong varUlong = 0;     // 0 to 18.446.744.073.709.551.615  | 64 bits   
        nint varNint = 0;       // Depende da plataforma            | 32 ou 64 bits
        nuint varNuint = 0;     // Depende da plataforma            | 32 ou 64 bits

        bool varBool = false;   // true to false                    | 8 bits

        float varFloat = 0;     // ±1,5 x 10^−45 to ±3,4 x 10^38    | ~6 to 8 digits     | 32 bits
        double varDouble = 0;   // ±5.0 × 10^−324 to ±1.7 × 10^308  | ~15 to 17 digits   | 64 bits
        decimal varDecimal = 0; // ±1,0 x 10^-28 to ±7,9228 x 10^28 | 28 to 29 digits    | 128 bits

        char varChar = '0';     // U+0000 to U+FFFF                  | 16 bits


        // Tipos internos de referencia
        //-----------------------------

        // string é um tipo para conjunto de caracteres
        string varString = "";

        // Object é o pai de todos os tipos, logo todos podem ser atribuidos a ele e não conta com tipagem estática 
        object varObject = null;  
        varObject = false;
        varObject = 1.0;
        varObject = "";

        // Dynamic Se comporta como um object, porém seu tipo é definido em tempo de execução
        dynamic varDynamic = 10;
        varDynamic = "Daniel";
        varDynamic = varDynamic + 10; // A operação em tipos Dinamic implicitos é permitica (desde que os tipos possam operar entre sí)

        varObject = "Daniel";
        varObject = varObject + 10; // Porém a mesma operação com o tipo object não pode ser compilada
    }
}
