package banking;

//an exception type that extends Exception but not RuntimeException
//is checked at compile time and as such it can only occur in a try
//block which catches that exception or in a body of a method
//which declares to throw that exception
public class InsufficientFundsException extends Exception {}
