namespace App9.ItemTemplates
{
    using Xamarin.Forms;

    public partial class BearTemplate  : ItemTemplateBase
    {
        public BearTemplate()
        {
            InitializeComponent();
        }

        protected override void SetupItem()
        {
            if (this.BindingContext is Animal item)
            {
                this.AnimalName.Text = item.Name;
            }
        }
    }
}