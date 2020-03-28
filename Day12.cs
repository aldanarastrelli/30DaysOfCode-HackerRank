using System;
using System.Linq;

class Person{
	protected string firstName;
	protected string lastName;
	protected int id;
	
	public Person(){}
	public Person(string firstName, string lastName, int identification){
			this.firstName = firstName;
			this.lastName = lastName;
			this.id = identification;
	}
	public void printPerson(){
		Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id); 
	}
}

class Student : Person{
    int[] testScores;  
    
    public Student(string firstName, string lastName, int identification, int[] testScores) : base(firstName, lastName, identification) {
        
        this.testScores = testScores;
    }
    
    public char Calculate(){
        int totalScores = 0;
        int additionScores = 0;
        foreach(int score in this.testScores){
            totalScores++;
            additionScores+=score;
        }

        int average = additionScores / totalScores;

        if (average < 40){ return 'T'; }
        if (average <55){ return 'D'; }
        if (average <70){return 'P'; }
        if (average < 80){return 'A'; }        
        if (average <90){return 'E'; }
        return 'O';

    }
}

class Solution {
