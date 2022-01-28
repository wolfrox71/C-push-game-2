namespace Board {
    using System;
    using Item;
    using Block;
    using Wall;
    using System.Linq;
    class board {
        public dynamic[,] positions; 
        public board (int width, int height) {
            positions = new object[height, width]; //rows, columns
        }
        public void addItem(dynamic obj) {
            positions[obj.y-1, obj.x-1] = obj;
        }
        /*public void addItem(Block.block obj) { // for some reason these have to be overloaded as object type doesnt work
            positions[obj.y-1, obj.x-1] = obj;
        }*/
    }
}