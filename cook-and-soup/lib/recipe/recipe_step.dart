import 'package:the_cook/action.dart';
import 'package:the_cook/ingredient/ingredient.dart';

class RecipeStep {
    Action action;
    Ingredient ingredient;

    RecipeStep(this.action, this.ingredient);
}