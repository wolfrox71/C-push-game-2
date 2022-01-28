namespace Wall {
    using Item;
    using System;
    class wall : Item.item {
        public wall(int enteredX, int enteredY) {
            x = enteredX;
            y = enteredY;
            pushable = false;
            symbol = "W";
            type = "wall";
            forgroundColour = ConsoleColor.Blue;
        }
    }
}