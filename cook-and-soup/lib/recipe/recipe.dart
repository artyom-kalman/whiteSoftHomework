import 'package:the_cook/action.dart';
import 'package:the_cook/ingredient/ingredient.dart';
import 'package:the_cook/recipe/recipe_step.dart';

class Recipe {
    String name;
    List<Ingredient> requiredIngredients;
    List<RecipeStep> steps;

    Recipe(this.name, this.requiredIngredients, this.steps);

    @override
    String toString() {
        String output = 'Рецепт супа:\n';
        for(final step in steps) {
            output += '${step.action.name} ${step.ingredient.name} ${step.ingredient.amount}г\n';
        }
        return output;
    }
}