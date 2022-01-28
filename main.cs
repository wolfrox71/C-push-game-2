using System;
using Block;
using Wall;
using Board;
class Program {
    public static void Main (string[] args) {
        Board.board board = new Board.board(6,6);
        dynamic new_wall = new Wall.wall(1,2);
        board.addItem(new_wall);
        board.addItem(new Block.block(3,4));

        for (int x = 0; x < board.positions.GetLength(0); x++) {
            for (int y = 0; y < board.positions.GetLength(1); y++) {
                var value = board.positions[x,y];
                if (value is Block.block) {
                    value.draw();
                    continue;
                }
                if (value is Wall.wall) {
                    value.draw();
                    continue;
                }
                Console.Write("A");
            }
            Console.WriteLine("");
        }
    }
}