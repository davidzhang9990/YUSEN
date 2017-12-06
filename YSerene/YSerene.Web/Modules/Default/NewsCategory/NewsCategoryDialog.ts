
namespace YSerene.Default {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class NewsCategoryDialog extends Serenity.EntityDialog<NewsCategoryRow, any> {
        protected getFormKey() { return NewsCategoryForm.formKey; }
        protected getIdProperty() { return NewsCategoryRow.idProperty; }
        protected getLocalTextPrefix() { return NewsCategoryRow.localTextPrefix; }
        protected getNameProperty() { return NewsCategoryRow.nameProperty; }
        protected getService() { return NewsCategoryService.baseUrl; }

        protected form = new NewsCategoryForm(this.idPrefix);

    }
}