namespace App9.ItemTemplates
{
    using Xamarin.Forms;

    public abstract class ItemTemplateBase : Grid
    {
        protected ItemTemplateBase()
        {
        }

        protected abstract void SetupItem();

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            this.SetupItem();
        }
    }
}
