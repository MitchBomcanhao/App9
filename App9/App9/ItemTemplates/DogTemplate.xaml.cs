namespace App9.ItemTemplates
{
    using Xamarin.Forms;

    public partial class DogTemplate  : ItemTemplateBase
    {
        public DogTemplate()
        {
            InitializeComponent();
        }

        protected override void SetupItem()
        {
            if(this.BindingContext is Animal item)
            {
                this.AnimalName.Text = item.Name;
            }
            
        }
    }
}