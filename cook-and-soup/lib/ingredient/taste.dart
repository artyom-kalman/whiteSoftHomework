enum Taste {
    salty('Солёный'),
    spicy('Острый'),
    sweet('Сладкий'),
    sour('Кислый'),
    bitter('Горький'),
    tasteless('Безвкусный');

    final String name;
    const Taste(this.name);
}