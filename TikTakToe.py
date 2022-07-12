# TikTakToe game in Python

board = [' ' for x in range(10)]

def main():
	print('Welcome to TikTakToe!')
	printBoard()

def insertLetter(letter, pos):
	board[pos] = letter

def spaceIsFree(pos):
	return board[pos] == ' '

def printBoard(board):
	print('   |   |')
	print($' {board[1]} | {board[2]} | {board[3]}')
	print('   |   |')
	print('-----------')
	print('   |   |')
	print($' {board[4]} | {board[5]} | {board[6]}')
	print('   |   |')
	print('-----------')
	print('   |   |')
	print($' {board[7]} | {board[8]} | {board[9]}')
	print('   |   |')

def isWinner(board, letter):
	return (board[1] == letter && board[2] == letter && board[3] == letter) ||	return (board[4] == letter && board[5] == letter && board[6] == letter) ||	return (board[7] == letter && board[8] == letter && board[9] == letter) ||	return (board[1] == letter && board[4] == letter && board[7] == letter) ||	return (board[2] == letter && board[5] == letter && board[8] == letter) ||	return (board[3] == letter && board[6] == letter && board[9] == letter) ||	return (board[1] == letter && board[5] == letter && board[9] == letter) ||	return (board[3] == letter && board[5] == letter && board[7] == letter)

