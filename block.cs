namespace Block {
    using Item;
    using System;
    class block : Item.item {
        public block(int enteredX, int enteredY) {
            x = enteredX;
            y = enteredY;
            pushable = true;
            symbol = "B";
            type = "block";
            forgroundColour = ConsoleColor.Green;
        }
    }
}