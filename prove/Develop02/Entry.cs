using System;

class Entry
{
   private string date = "";

    private string input = "";

    public Entry(string date, string input) {
        this.date = date;
        this.input = input;
    }

    public void Display() {
        Console.WriteLine($" [{date}]\n{this.input}\n");
    } 
}