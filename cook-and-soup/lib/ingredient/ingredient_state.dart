enum IngredientState {
    raw('Сырой'),
    fried('Жаренный'),
    boiled('Сваренный'),
    sliced('Нарезанный'),
    grated('Натёртый'),
    cooked('Приготовленный');

    const IngredientState(this.name);
    final String name;
}