using System;

using Xamarin.Forms;

namespace GraphQLAssignment.Model
{
    public class StarwarsApi : ContentPage
    {
        public StarwarsApi()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

