
using System;




namespace kolko_i_krzyzyk_ob
{
    enum TypGracza
    {
        X,
        O,
        puste
    }

    
    class Program
    {

        public static void Main(string[] args)
        {
            Ui ui = new Ui();
            Player player1 = new Player("X", ui.inputyourName());
            Player player2 = new Player("O", ui.inputyourName());
            Player draw = new Player("Dupa", "remis");



            Game game = new Game(player1, player2, draw, ui);


            ui.displayMessage(" rozpoczynamy grę!");

            Player winner = game.start(player1, player2, ui);

            ui.displayWinner(winner);
            // end for


            ui.displayMessage("globalny score " + player1.getNumberOfWins() + " " + player1.getNumberOfWins() + "gratulacje!");
}
    }

}
        
