import 'package:the_cook/chef.dart';
import 'package:the_cook/ingredient/ingredient.dart';
import 'package:the_cook/ingredient/ingredient_state.dart';
import 'package:the_cook/ingredient/taste.dart';
import 'package:the_cook/recipe/recipe.dart';
import 'package:the_cook/action.dart';
import 'package:the_cook/recipe/recipe_step.dart';

void main(List<String> arguments) {
    Ingredient carrot = Ingredient.withTaste('Морковка', 100, IngredientState.raw, Taste.sweet);
    Ingredient onion  = Ingredient('Лук', 100, IngredientState.raw);
    Ingredient potato = Ingredient('Картошка', 100, IngredientState.raw);
    Ingredient brouth = Ingredient.withTaste('Бульон', 1000, IngredientState.cooked, Taste.salty);

    final requiredIngredients = <Ingredient>[
        carrot, onion, potato, brouth
    ];

    Recipe simpleSoup = Recipe('Простой суп', requiredIngredients, [
        RecipeStep(Action.fry, onion),
        RecipeStep(Action.addSalte, onion),
        RecipeStep(Action.grate, carrot),
        RecipeStep(Action.boil, potato),
        RecipeStep(Action.addPepper, potato),
    ]);

    Chef chef = Chef();

    chef.cookSoup(simpleSoup, [
        carrot,
        onion,
        potato,
        brouth
    ]);
}
