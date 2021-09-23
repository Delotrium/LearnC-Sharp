using System;

namespace LearnCS
{
    class DataTypes
    {
        static void Main(string[] args)
        {
            datatype();
        }
        static void datatype()
        {
            byte number; //8-bit unsigned integer, values from 0 to 255
            sbyte number2; //8-bit signed integer, values from -128 to 127
            short number3; //16-bit signed integer, values from -32,768 to 32,767
            ushort number4; //16-bit unsigned integer, values from 0 to 65,535
            int number5; //32-bit signed integer, values from  -2,147,483,648 to 2,147,483,647
            uint number6;  //32-bit unsigned integer, values from 0 to 4,294,967,295
            long number7; //64-bit signed integer, values from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            ulong number8; //64-bit unsigned integer, values from 0 to 18,446,744,073,709,551,615
            float number9; //32-bit Single-precision floating point type, values from -3.402823e38 to 3.402823e38
            double number10; //64-bit double-precision floating point type, values from -1.79769313486232e308 to 1.79769313486232e308
            decimal number11;   //128-bit decimal type for financial and monetary calculations, (+ or -)1.0 x 10e-28 to 7.9 x 10e28
            char character; //16-bit single Unicode character, values from any valid character, e.g. a,*, \x0058 (hex), or\u0058 (Unicode)
            bool trueOrfalse; //8-bit logical true/false value, values are true and false
            object AnObject; //Base type of all other types.
            string phrase; //A sequence of Unicode characters
            DateTime time; //Represents date and time, values from 0:00:00am 1/1/01 to 11:59:59pm 12 / 31 / 9999
        }
    }
}
