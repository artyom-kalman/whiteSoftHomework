import 'package:the_cook/action.dart';
import 'package:the_cook/ingredient/ingredient.dart';
import 'package:the_cook/recipe/recipe.dart';
import 'package:the_cook/soup.dart';

class Chef {

    void cookSoup(Recipe recipe, List<Ingredient> ingredients) {
        print('Готовлю ${recipe.name}!');
        print(recipe);

        if (!_isEnoughIngredients(recipe, ingredients)) {
            print('У меня недостаточно ингредиентов!');
            return;
        }

        final steps = recipe.steps;
        for(final step in steps) {
            print('Подготавливаю ${step.ingredient}!');

            final ingredient = ingredients.firstWhere((ingredient) => 
                ingredient.name == step.ingredient.name
            );

            _prepIngredient(ingredient, step.action);
        }

        Soup soup = _combine(recipe.name, ingredients);

        return _serveSoup(soup);
    }

    bool _isEnoughIngredients(Recipe recipe, List<Ingredient> ingredients) {
        for(final needIngredient in recipe.requiredIngredients) {
            final haveIngredient = ingredients.firstWhere((ingredient) => 
                ingredient.name == needIngredient.name
            );
            if (needIngredient.amount > haveIngredient.amount) return false;
        }
        return true;
    }

    void _prepIngredient(Ingredient ingredient, Action action) {
        return ingredient.prep(action);
    }

    Soup _combine(String soupName, List<Ingredient> ingredients) {
        return Soup(soupName, ingredients);
    }

    void _serveSoup(Soup soup) {
        print('Суп готов!');
        print(soup);
    }
}