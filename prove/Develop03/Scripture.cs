class Scripture
{
    private string book;

    private int chapter;

    private int verseStart;

    private int verseEnd;

    private Reference reference;

    public Scripture(string book, int chapter, int verseStart, string reference)
    {
        this.book = book;
        this.chapter = chapter;
        this.verseStart = verseStart;
        this.reference = new Reference(reference);
    }

    public Scripture(string book, int chapter, int verseStart, int verseEnd, string reference)
    {
        this.book = book;
        this.chapter = chapter;
        this.verseStart = verseStart;
        this.verseEnd = verseEnd;
        this.reference = new Reference(reference);
    }

        public void Practice(int Hide = 3) {
        bool practicing = true;
        while (practicing) {
            Console.Clear();
            
            if (this.reference.Hidden()) {
                practicing = false;
                Console.WriteLine("All words are hidden");
            }
            else{
                Console.WriteLine("Enter to continue or type 'quit' to quit.");
            }
            
            string input = Console.ReadLine();
            if (input == "quit") {
                break;
            }
            this.reference.HideWords(Hide);
        }
    }

    public override string ToString() {
        string result = book + " " + chapter + ":" + verseStart;
        if (verseStart != verseEnd) {
            result += "-" + verseEnd;
        }
        result += " " + reference.ToString();
        return result;
    }
}