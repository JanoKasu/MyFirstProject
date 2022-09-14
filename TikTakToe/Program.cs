using System;
using System.Collections.Generic;

class Program
{
    public static void printBoard(char[] board)
    {
        Console.WriteLine("   |   |");
        Console.WriteLine($" {board[1]} | {board[2]} | {board[3]}");
        Console.WriteLine("   |   |");
        Console.WriteLine("-----------");
        Console.WriteLine("   |   |");
        Console.WriteLine($" {board[4]} | {board[5]} | {board[6]}");
        Console.WriteLine("   |   |");
        Console.WriteLine("-----------");
        Console.WriteLine("   |   |");
        Console.WriteLine($" {board[7]} | {board[8]} | {board[9]}");
        Console.WriteLine("   |   |");
    }

    public bool spaceIsFree(char[] board, int position)
    {
        if (board[position] == ' ') return true;
        else return false;
    }

    public bool isWinner(char[] board, char letter)
    {
        return false;
    }

    /*
    public playerTurn()
    public compTurn()
    public selectRandom(board)
    */


    public static bool isBoardFull(char[] board)
    {
        int sum = 0;
        foreach (char c in board)
        {
            if (c != ' ') sum++;
        }
        if (sum == 9) return true;
        else return false;
    }

    static void Main(string[] args)
    {
        bool win = false;
        char[] board = new char[10];
        for (int i = 0; i < 10; i++)
        {
            board[i] = ' ';
        }
        do
        {
            try
            {
                if (isBoardFull(board)) { Console.WriteLine("Tie Game."); win = true; }
                printBoard(board);
                Console.WriteLine($"X's turn! Choose a number 1-9 (0 to quit).");
                int x = Int32.Parse(Console.ReadLine());
                if (x == 0) { Console.WriteLine("You have quit the game."); win = true; }
                else if (x < 1 || x > 9) throw new IndexOutOfRangeException();
                board[x] = 'X';
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        } while (!win);
    }
}