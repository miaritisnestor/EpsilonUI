using EpsilonDbContext.Models;

namespace EpsilonUI.StateContainers
{
    public class CustomerStateContainer
    {
        private Customer? customer;

        public Customer Property
        {
            get => customer ?? new Customer();
            set
            {
                customer = value;
                NotifyStateChanged();
            }
        }

        public event Action? OnChange;

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
