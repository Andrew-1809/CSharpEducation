using System;

class TicTacToe
{
    static string[] board = { "  1  ", "  2  ", "  3  ", "  4  ", "  5  ", "  6  ", "  7  ", "  8  ", "  9  " };
    static int currentPlayer = 1;
    const string X = "| X |";
    const string O = "| O |";
    static void Main()
    {
        int choice;
        bool validInput;

        do
        {
            Console.Clear();
            DrawBoard();

            Console.WriteLine($"Игрок {currentPlayer}, введите номер ячейки:");

            // Проверяем корректность ввода: число от 1 до 9, и ячейка не должна быть занята
            validInput = int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 9 && board[choice - 1] != X && board[choice - 1] != O;

            if (validInput)
            {
                // Заполняем ячейку текущим символом (X или O)
                board[choice - 1] = (currentPlayer == 1) ? X : O;

                // Проверяем на наличие выигрышной комбинации
                if (CheckForWin())
                {
                    Console.Clear();
                    DrawBoard();
                    Console.WriteLine($"Победил игрок {currentPlayer}!");
                    break;
                }

                // Проверяем на наступление ничьей
                if (CheckForDraw())
                {
                    Console.Clear();
                    DrawBoard();
                    Console.WriteLine("Ничья!");
                    break;
                }

                // Меняем текущего игрока
                currentPlayer = (currentPlayer == 1) ? 2 : 1;
            }
            else
            {
                Console.WriteLine("Используйте цифры от 1 до 9, при этом ячейка должна быть свободна. Попробуйте снова. Для продолжения нажмите любую клавишу.");
                Console.ReadKey();
            }

        } while (true);
    }

    // Выводим текущее состояние игрового поля
    static void DrawBoard()
    {
        Console.WriteLine(" _________________");
        Console.WriteLine("|     |     |     |");
        Console.WriteLine($"|{board[0]}|{board[1]}|{board[2]}|");
        Console.WriteLine("|_____|_____|_____|");
        Console.WriteLine("|     |     |     |");
        Console.WriteLine($"|{board[3]}|{board[4]}|{board[5]}|");
        Console.WriteLine("|_____|_____|_____|");
        Console.WriteLine("|     |     |     |");
        Console.WriteLine($"|{board[6]}|{board[7]}|{board[8]}|");
        Console.WriteLine("|_____|_____|_____|");
    }

    // Проверяем на выигрыш
    static bool CheckForWin()
    {
        return (board[0] == board[1] && board[1] == board[2]) ||
               (board[3] == board[4] && board[4] == board[5]) ||
               (board[6] == board[7] && board[7] == board[8]) ||
               (board[0] == board[3] && board[3] == board[6]) ||
               (board[1] == board[4] && board[4] == board[7]) ||
               (board[2] == board[5] && board[5] == board[8]) ||
               (board[0] == board[4] && board[4] == board[8]) ||
               (board[2] == board[4] && board[4] == board[6]);
    }

    // Проверяем на ничью
    static bool CheckForDraw()
    {
        // Проверяем, остались ли свободные ячейки
        foreach (string cell in board)
        {
            if (cell != X && cell != O)
                return false;
        }
        return true;
    }
}
