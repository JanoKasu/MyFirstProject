﻿using System;
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
        Console.WriteLine("   |   |\n");
    }

    public static bool spaceIsFree(char[] board, int position)
    {
        if (board[position] == ' ') return true;
        return false;
    }

    public static bool isWinner(char[] board, char letter)
    {
        if (board[1].Equals(letter) && board[5].Equals(letter) && board[9].Equals(letter)) return true;
        else if (board[3].Equals(letter) && board[5].Equals(letter) && board[7].Equals(letter)) return true;

        for (int i = 1; i <= 9; i+=3)
        {
            if (board[i].Equals(letter) && board[i + 1].Equals(letter) && board[i + 2].Equals(letter)) return true;
        }

        for (int i = 1; i <= 3; i++)
        {
            if (board[i].Equals(letter) && board[i + 3].Equals(letter) && board[i + 6].Equals(letter)) return true;
        }

        return false;
    }

    public static int playerTurn(char[] board)
    {
        Console.WriteLine($"X's turn! Choose a number 1-9 (0 to quit).");
        int x;
        do
        {
            x = int.Parse(Console.ReadLine());
            if (x == 0) throw new EndGameException("You have quit the game.");
            else if (x < 1 || x > 9) throw new IndexOutOfRangeException("Choose a number between 1 and 9.");
            else if (!spaceIsFree(board, x)) Console.WriteLine("Choose a valid spot.");
        } while(!spaceIsFree(board, x));
        return x;
    }

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
        AI myAI = new AI();
        bool endGame = false;
        char[] board = new char[10];
        for (int i = 0; i < 10; i++)
        {
            board[i] = ' ';
        }
        printBoard(board);
        do
        {
            try
            {
                //Player turn
                board[playerTurn(board)] = 'X';
                printBoard(board);
                if (isWinner(board, 'X')) throw new EndGameException("X wins!");
                else if (isBoardFull(board)) throw new EndGameException("Tie Game.");

                //AI turn
                board[myAI.compTurn(board)] = 'O';
                printBoard(board);
                if (isWinner(board, 'O')) throw new EndGameException("O wins!");
                else if (isBoardFull(board)) throw new EndGameException("Tie Game.");
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (EndGameException e)
            {
                Console.WriteLine(e.Message);
                endGame = true;
            }
        } while (!endGame);
    }
}