using App2.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Linq;
using System.Threading.Tasks;

namespace App2.Controls
{
    public class DishSearchHandler : SearchHandler
    {
        public IList<Dish> Dishes { get; set; }
        public Type SelectedItemNavigationTarget { get; set; }

        protected override void OnQueryChanged(string oldValue, string newValue)
        {
            base.OnQueryChanged(oldValue, newValue);

            if (string.IsNullOrWhiteSpace(newValue))
            {
                ItemsSource = null;
            }
            else
            {
                ItemsSource = Dishes
                    .Where(dish => dish.Name.ToLower().Contains(newValue.ToLower()))
                    .ToList<Dish>();
            }
        }

        protected override async void OnItemSelected(object item)
        {
            base.OnItemSelected(item);
            await Task.Delay(1000);

            ShellNavigationState state = (App.Current.MainPage as Shell).CurrentState;
            // Note: strings will be URL encoded for navigation (e.g. "Blue Monkey" becomes "Blue%20Monkey"). Therefore, decode at the receiver.
            // This works because route names are unique in this application.
            await Shell.Current.GoToAsync($"{GetNavigationTarget()}?name={((Dish)item).Name}");
        }

        string GetNavigationTarget()
        {
            return (Shell.Current as AppShell).Routes.FirstOrDefault(route => route.Value.Equals(SelectedItemNavigationTarget)).Key;
        }
    }
}

