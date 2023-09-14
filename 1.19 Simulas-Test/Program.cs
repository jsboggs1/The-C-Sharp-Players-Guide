// using a variable to store the current chest state
ChestState current = ChestState.locked;

while (true)
{
    Console.Write($"The chest is {current}. What do you want to do? ");
    string answer = Console.ReadLine();

    if (answer == "unlock" && current == ChestState.locked)
    {
        current = ChestState.unlocked;
    }
    if (answer == "open" && current == ChestState.unlocked)
    {
        current = ChestState.opened;
    }
    if (answer == "close" && current == ChestState.opened)
    {
        current = ChestState.unlocked;
    }
    if (answer == "lock" && current == ChestState.unlocked)
    {
        current = ChestState.locked;
    }
}

// enumeration defining the state of the chest
enum ChestState { locked, unlocked, opened }