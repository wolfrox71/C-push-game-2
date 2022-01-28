namespace Board {
    using System;
    using Item;
    using Block;
    using Wall;
    using System.Linq;
    class board {
        public object[,] positions; 
        public board (int width, int height) {
            positions = new object[height, width]; //rows, columns
        }
        public void showBoard(){
            for (int x = 0; x < positions.GetLength(0); x++) {
                for (int y = 0; y < positions.GetLength(1); y++) {
                    var  j = positions[x,y];
                    if (j != null) { // this is an object
                        Console.WriteLine($"{j.x}");
                    }
                }
            }
            
            /*
            for (int x = 0; x < positions.GetLength(0); x++) {
                for (int y = 0; y < positions.GetLength(1); y++) {
                    Console.Write(positions[x,y]);//is Item.item);
                }
                Console.WriteLine("");
            }
            */
        }
    }
}