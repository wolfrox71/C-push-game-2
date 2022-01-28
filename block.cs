namespace Block {
    using Item;
    class block : Item.item {
        public block(int enteredX, int enteredY) {
            x = enteredX;
            y = enteredY;
            pushable = true;
        }
    }
}