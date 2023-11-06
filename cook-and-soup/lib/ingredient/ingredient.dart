import 'package:the_cook/action.dart';
import 'package:the_cook/ingredient/ingredient_state.dart';
import 'package:the_cook/ingredient/taste.dart';

class Ingredient {
    String name;
    num amount;
    IngredientState state;
    Taste taste = Taste.tasteless;

    Ingredient(this.name, this.amount, this.state);
    
    Ingredient.withTaste(this.name, this.amount, this.state, this.taste);

    void prep(Action action) {
        switch(action) {
            case Action.boil:
                state = IngredientState.boiled;
            case Action.fry:
                state = IngredientState.fried;
            case Action.grate:
                state = IngredientState.grated;
            case Action.slice:
                state = IngredientState.sliced;
            case Action.combine:
                state = IngredientState.cooked;
            case Action.addSalte:
                taste = Taste.salty;
            case Action.addPepper:
                taste = Taste.spicy;
            case Action.addSugar:
                taste = Taste.sweet;
        }
    }

    @override
    String toString() {
        return name;
    }
}