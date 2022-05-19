USING SYSTEM;
USING SYSTEM.IO;

NAMESPACE EJERCICIO_8_7_1
{
    CLASS PROGRAM
    {
        STATIC VOID MAIN(STRING[] ARGS)
        {
            STRING NOMBREFICHERO1;
            STRING NOMBREFICHERO2;
            STREAMREADER FICHEROREADER;
            STREAMWRITER FICHEROWRITER;
            STRING CADENA;

            CONSOLE.WRITE("FICHERO ORIGEN: ");
            NOMBREFICHERO1 = CONSOLE.READLINE();

            CONSOLE.WRITE("FICHERO DESTINO: ");
            NOMBREFICHERO2 = CONSOLE.READLINE();

            TRY
            {
                USING (FICHEROREADER = NEW STREAMREADER(NOMBREFICHERO1))
                {
                    USING (FICHEROWRITER = NEW STREAMWRITER(NOMBREFICHERO2))
                    {
                        WHILE ((CADENA = FICHEROREADER.READLINE()) != NULL)
                            FICHEROWRITER.WRITELINE(CADENA.TOUPPER());
                    }
                }
            }
            CATCH (EXCEPTION EX)
            {
                CONSOLE.WRITELINE("ERROR: " + EX.MESSAGE);
            }

        }
    }
}
