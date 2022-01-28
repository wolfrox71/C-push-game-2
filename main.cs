using System;
using Block;
using Wall;
using Board;
class Program {
    public static void Main (string[] args) {
        Board.board board = new Board.board(6,6);
        Console.WriteLine(board.positions);
        Wall.wall wall1 = new Wall.wall(1,2);
        board.positions[1,2] = wall1;
        Console.WriteLine(board.positions[1,2]);
        board.showBoard();
    }

}