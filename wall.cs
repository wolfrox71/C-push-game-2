namespace Wall {
    using Item;
    class wall : Item.item {
        public wall(int enteredX, int enteredY) {
            x = enteredX;
            y = enteredY;
            pushable = false;
        }
    }
}