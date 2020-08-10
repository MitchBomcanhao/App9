namespace App9.ItemTemplates
{
    using Xamarin.Forms;

    public partial class ElephantTemplate : ItemTemplateBase
    {
        public ElephantTemplate()
        {
            InitializeComponent();
        }

        protected override void SetupItem()
        {
            if (this.BindingContext is Animal item)
            {
                this.AnimalName.Text = item.Category + " # " + item.Name;
            }
        }
    }
}