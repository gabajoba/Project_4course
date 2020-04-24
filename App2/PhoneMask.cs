using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App2
{
    public class PhoneNumberMaskBehavior : Behavior<Entry>
    {
        public static PhoneNumberMaskBehavior Instance = new PhoneNumberMaskBehavior();

        ///  
        /// Attaches when the page is first created.  
        ///   

        protected override void OnAttachedTo(Entry entry)
        {
            entry.TextChanged += OnEntryTextChanged;
            base.OnAttachedTo(entry);
        }

        ///  
        /// Detaches when the page is destroyed.  
        ///   

        protected override void OnDetachingFrom(Entry entry)
        {
            entry.TextChanged -= OnEntryTextChanged;
            base.OnDetachingFrom(entry);
        }

        private void OnEntryTextChanged(object sender, TextChangedEventArgs args)
        {
            if (!string.IsNullOrWhiteSpace(args.NewTextValue))
            {
                // If the new value is longer than the old value, the user is  
                if (args.OldTextValue != null && args.NewTextValue.Length < args.OldTextValue.Length)
                    return;

                var value = args.NewTextValue;
                switch (value.Length)
                {
                    case 1: 
                        {
                            ((Entry)sender).Text += "(";
                            return;
                        }
                    case 5:
                        {
                            ((Entry)sender).Text += ")";
                            return;
                        }
                    case 9:
                        {
                            ((Entry)sender).Text += "-";
                            return;
                        }
                    case 12:
                        {
                            ((Entry)sender).Text += "-";
                            return;
                        }
                    //case 2:
                    //    {
                    //        ((Entry)sender).Text.Remove(((Entry)sender).Text.Length - 1);
                    //        return;
                    //    }
                    //case 6:
                    //    {
                    //        ((Entry)sender).Text.Remove(((Entry)sender).Text.Length - 1);
                    //        return;
                    //    }
                    //case 10:
                    //    {
                    //        ((Entry)sender).Text.Remove(((Entry)sender).Text.Length - 1);
                    //        return;
                    //    }
                }



              
                

                ((Entry)sender).Text = args.NewTextValue;
            }
        }
    }
}
