using BlazorMovies.Shared.Entities;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static BlazorMovies.Client.Shared.MainLayout;
using BlazorMovies.Shared;

namespace BlazorMovies.Client.Pages
{
    public partial class Counter
    {
        [Inject]
        SingletonService singleton { get; set; }
        
        [Inject] 
        TransientService transient { get; set; }

        [Inject]
        IJSRuntime js { get; set; }

        [CascadingParameter]
        public AppState AppState { get; set; }

        /*
        [CascadingParameter( Name = "Size")]
        public string Size { get; set; }
        */

        private List<Movie> movies;

        protected override void OnInitialized()
        {
            

            movies = new List<Movie>()
{
            new Movie() { Title = "War", ReleaseDate  = new DateTime(2019, 10, 2) },
            new Movie()
            {
                Title = "HouseFull 4", ReleaseDate = new DateTime(2019, 11, 10)
            },
            new Movie()
            {
                Title = "Good News",
                ReleaseDate = new DateTime(2020, 1, 3)
            }
        };
        }

        private int currentCount = 0;
        private static int currentCountStatic = 0;

        [JSInvokable]
        public async Task IncrementCount()
        {
            currentCount++;
            transient.Value = currentCount;
            singleton.Value = currentCount;
            currentCountStatic++;
            await js.InvokeVoidAsync("dotnetStaticInvocation");
        }

        private async Task IncrementCountJavaScript()
        {
            await js.InvokeVoidAsync("dotnetInstanceInvocation", DotNetObjectReference.Create(this));
        }

        [JSInvokable]
        public static Task<int> GetCurrentCount()
        {
            return Task.FromResult(currentCountStatic);
        }
    }
}
