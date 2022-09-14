using System;

public class EndGameException : Exception
{
	public EndGameException() : base() { }
	public EndGameException(string message) : base(message) { }
}
