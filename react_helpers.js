const setItemProgress = (items, item, state) => {
    newItems = items.map((i) => {
        if (i.id == item.id) {
            item.progress = state;
            return item;
        }
        return item;
    });
    return newItems;
};

export { setItemProgress };