import 'package:dart_sort/dart_sort.dart';
import 'package:test/test.dart';

void main() {
    group('quickSort tests', () {
        test('test #1', () {
            final actual = quickSort([3, 2, 5, 0, 1, 8, 7, 6, 9, 4]);
            final expected = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];

            expect(actual, expected);
        });

        test('test #2', () {
            var array = <num>[0, 1, 0, 1, -1, -2, -3, 0, 1, 0, 1];
            final actual = quickSort(array);
            array.sort();

            expect(actual, array);
        });

        test('test #3', () {
            var array = <num>[-3.2, -500.5, 1003.67, 43.09, 6];
            final actual = quickSort(array);
            array.sort();

            expect(actual, array);
        });

    });

}
