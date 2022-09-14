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
        char[] players = new char[] { 'X', 'O' }
        foreach (char c in players)
        {
        }
    }

    public playerTurn()
    {

    }

    static void Main(string[] args)
    {
        bool win = false;
        char[] board = new char[10];
        do
        {
            try
            {
                printBoard(board);
                Console.WriteLine($"X's turn! Choose a number 1-9 (0 to quit).");
                int x = Int32.Parse(Console.ReadLine());
                if (x < 1 || x > 9) throw new IndexOutOfRangeException();
                board[x] = 'X';
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        } while (!win);
    }
}