Console.WriteLine("A door must be created, enter a numerical passcode for your new door:");
int passcode;

// validation to ensure that an int is entered
// doesn't cover every scenario but I haven't learned more advanced methods yet.
// TryParse hasn't even been mentioned in the book, gotten from internet
while (Int32.TryParse(Console.ReadLine(), out passcode) == false)
{
    Console.WriteLine("That is not a valid entry. Please enter a numerical value.");
}

// creation of door object if the user enters a valid password
Door myDoor = new Door();
myDoor.Passcode = passcode;

Console.WriteLine($"The door is currently {myDoor.State}, what do you wish to do?");
Console.WriteLine($"You can type \"open\", \"close\", \"lock\", \"unlock\", or \"change passcode\".");

string answer = Console.ReadLine();

// loop to catch invalid entries
while (answer != "open" && answer != "close" && answer != "lock" && answer != "unlock" && answer != "change passcode")
{
    Console.WriteLine("Invalid action, please type \"open\", \"close\", \"lock\", \"unlock\", or \"change passcode\".");
    answer = Console.ReadLine();
}

// main loop to go through various door states endlessly
while (answer == "open" || answer == "close" || answer == "lock" || answer == "unlock" || answer == "change passcode")
{
    if (answer == "open")
    {
        myDoor.CheckOpen();
    }
    else if (answer == "close")
    {
        myDoor.CheckClose(); 
    }
    else if (answer == "lock")
    {
        myDoor.CheckLock();
    }
    else if (answer == "unlock")
    {
        myDoor.CheckUnlock();
    }
    else if (answer == "change passcode")
    {
        myDoor.CheckPasscodeChange();
    }
    else
    {
        Console.WriteLine("Invalid action, please type \"open\", \"close\", \"lock\", \"unlock\", or \"change passcode\".");
    }

    answer = Console.ReadLine();
    while (answer != "open" && answer != "close" && answer != "lock" && answer != "unlock" && answer != "change passcode")
    {
        Console.WriteLine("Invalid action, please type \"open\", \"close\", \"lock\", \"unlock\", or \"change passcode\".");
        answer = Console.ReadLine();
    }
}



class Door
{
    // fields
    private DoorState _state;
    private int _passcode;

    // properties
    public DoorState State
    {
        get { return _state; }
        set { _state = value; }
    }

    public int Passcode
    {
        get { return _passcode; }
        set { _passcode = value; }
    }

    // constructors

    // object initialization
    public Door (int passcode)
    {
        _state = State;
        _passcode = Passcode;
    }

    // default values
    public Door ()
    {
        _state = DoorState.locked;
        _passcode = 12345;
    }

    // methods to transition between door states
    public void CheckOpen()
    {
        while (State != DoorState.open)
        {
            if (State == DoorState.closed)
            {
                Console.WriteLine("You open the door.");
                State = DoorState.open;
                break;
            }
            else if (State == DoorState.locked)
            {
                Console.WriteLine("The door needs to be unlocked before you can open it.");
                break;
            }

        }
        if (State == DoorState.open)
        {
            Console.WriteLine("The door is already open.");
        }
    }

    public void CheckClose()
    {
        while (State != DoorState.closed)
        {
            if (State == DoorState.open)
            {
                Console.WriteLine("You close the door.");
                State = DoorState.closed;
                break;
            }
            else if (State == DoorState.locked)
            {
                Console.WriteLine("The door is already closed and locked.");
                break;
            }
        }
        if (State == DoorState.closed)
        {
            Console.WriteLine("The door is already closed.");
        }
    }

    public void CheckLock()
    {
        if (State == DoorState.locked)
        {
            Console.WriteLine("The door is already locked.");
        }

        while (State != DoorState.locked)
        {
            if (State == DoorState.closed)
            {
                Console.WriteLine("You lock the door.");
                State = DoorState.locked;
                break;
            }
            else if (State == DoorState.open)
            {
                Console.WriteLine("The door is open and must be closed before you can lock it.");
                break;
            }
        }
        
    }

    public void CheckUnlock()
    {
        if (State != DoorState.locked)
        {
            Console.WriteLine("The door is not locked.");
        }
        while (State == DoorState.locked)
        {

            Console.WriteLine("To unlock the door, you must enter the current password.");
            int passcodeGuess;

            while (Int32.TryParse(Console.ReadLine(), out passcodeGuess) == false) // validate initial entry
            {
                Console.WriteLine("That is not a valid entry. Please enter a numerical value for your passcode attmept.");
            }

            while (passcodeGuess != Passcode) // validate multiple incorrect entries
            {
                Console.WriteLine("That is not the correct passcode. Please enter the correct passcode to unlock the door.");

                while (Int32.TryParse(Console.ReadLine(), out passcodeGuess) == false)
                {
                    Console.WriteLine("That is not a valid entry. Please enter a numerical value for your passcode attmept.");
                }
            }

            if (passcodeGuess == Passcode)
            {
                Console.WriteLine("You unlock the door.");
                State = DoorState.closed;
                break;
            }
        }

    }

    public void CheckPasscodeChange()
    {
        int passcodeGuess;
        Console.WriteLine("To change the passcode, enter the current passcode.");

        while (Int32.TryParse(Console.ReadLine(), out passcodeGuess) == false) // validate initial entry
        {
            Console.WriteLine("That is not a valid entry. Please enter a numerical value for your passcode attmept.");
        }

        while (passcodeGuess != Passcode) // validate multiple incorrect entries
        {
            Console.WriteLine("That is not the correct passcode. Please enter the correct passcode to unlock the door.");

            while (Int32.TryParse(Console.ReadLine(), out passcodeGuess) == false)
            {
                Console.WriteLine("That is not a valid entry. Please enter a numerical value for your passcode attmept.");
            }
        }

        if (passcodeGuess == Passcode)
        {
            int newPasscode;
            Console.WriteLine("Passcode accepted. Enter new passcode:");

            while (Int32.TryParse(Console.ReadLine(), out newPasscode) == false) // validate initial entry
            {
                Console.WriteLine("That is not a valid entry. Please enter a numerical value for your new passcode.");
            }

            Console.WriteLine("New passcode set.");

            Passcode = newPasscode;

        }

    }
}

enum DoorState { open, closed, locked }