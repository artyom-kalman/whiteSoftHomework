enum Action {
    fry('Жарить'),
    boil('Варить'),
    slice('Нарезать'),
    grate('Натерать'),
    combine('Смешать'),
    addSalte('Добавить соль'),
    addPepper('Добавить перец'),
    addSugar('Добавить сахар');

    const Action(this.name);
    final String name;
}