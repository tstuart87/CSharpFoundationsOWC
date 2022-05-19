using TipCalculator;

Console.WriteLine("1. ENGLISH\n" +
                "2. ESPANOL\n" +
                "3. MANDARIN\n" +
                "4. HINDI\n" +
                "5. FRENCH\n" +
                "6. DEUTSCH\n" +
                "7. BENGALI\n");

string input = Console.ReadLine();

ICustomConsole console;

switch (input)
{
    case "1":
        console = new English();
        break;
    case "2":
        console = new Espanol();
        break;
    case "3":
        console = new Mandarin();
        break;
    case "4":
        console = new Hindi();
        break;
    case "5":
        console = new French();
        break;
    case "6":
        console = new Deutsch();
        break;
    case "7":
        console = new Bengali();
        break;
    default:
        console = new English();
        break;
}

UserInterface _ui = new UserInterface(console);

_ui.Start();

