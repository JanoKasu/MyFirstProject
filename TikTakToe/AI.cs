﻿using System;
using System.Collections.Generic;

public class AI
{
    int[] arr;
    public AI()
	{
        arr = new int[9];
        arr[0] = 5;
        List<int> secondPrio = new List<int>() { 1, 3, 7, 9 };
        List<int> thirdPrio = new List<int>() { 2, 4, 6, 8 };
        for (int i = 1; i < 5; i++) {
            int temp1 = selectRandom(secondPrio);
            int temp2 = selectRandom(thirdPrio);
            arr[i] = temp1;
            arr[i+4] = temp2;
            secondPrio.Remove(temp1);
            thirdPrio.Remove(temp2);
        }
    }

    /*
    public int selectRandom(int i, int j)
    {
        Random rand = new Random();
        return rand.Next(i, j);
    }
    */
    
    public int selectRandom(List<int> list)
    {
        Random rand = new Random();
        return list[rand.Next(list.Count)];
    }
    
    //public int testForWins()

    public int compTurn(char[] board)
    {
        char[] boardCopy = new char[9];
        Array.Copy(board, boardCopy, 9);
        /*
        * Check to see if I can win
        * Check to see if I need to block
        * Determine the most profitable space
        */

        foreach (int i in arr)
        {
            Console.WriteLine("Win " + i);
            if (Program.spaceIsFree(boardCopy, i))
            {
                boardCopy[i] = 'O';
                if (Program.isWinner(boardCopy, 'O')) return i;
            }
            boardCopy[i] = ' ';
        }

        foreach (int i in arr)
        {
            Console.WriteLine("Block " + i);
            if (Program.spaceIsFree(boardCopy, i))
            {
                boardCopy[i] = 'X';
                if (Program.isWinner(boardCopy, 'X')) return i;
            }
            boardCopy[i] = ' ';
        }

        foreach (int i in arr)
        {
            if (Program.spaceIsFree(boardCopy, i))
            {
                Console.WriteLine("Random " + i); return i;
            }
        }
        return 0;
    }
}
