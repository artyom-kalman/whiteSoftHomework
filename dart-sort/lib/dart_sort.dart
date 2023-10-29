List<num> quickSort(List<num> array) {
    if (array.length < 2) return array;

    var sm = -1;
    var pv = array.length - 1;
    for (var i = 0; i < array.length; i++) {
        if (array[i] > array[pv]) continue;

        sm++;
        if (i == sm) continue;

        final tmp = array[i];
        array[i] = array[sm];
        array[sm] = tmp;

        if (i == pv) pv = sm;
    }

    var arrayLeft = array.sublist(0, pv);
    var arrayRight = array.sublist(pv + 1);

    return [
        ...quickSort(arrayLeft),
        ...[array[pv]],
        ...quickSort(arrayRight)
    ];
}
