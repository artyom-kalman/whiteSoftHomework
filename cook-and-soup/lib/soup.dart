import 'package:the_cook/ingredient/ingredient.dart';

class Soup {
    String name;
    List<Ingredient> ingredients;

    Soup(this.name, this.ingredients);

    @override
    String toString() {
        String output = '$name состоит из:\n';
        ingredients.forEach((ingredient) {
            output += '${ingredient.name} ${ingredient.state.name} ${ingredient.taste.name}\n';
        });
        return output;
    }
}