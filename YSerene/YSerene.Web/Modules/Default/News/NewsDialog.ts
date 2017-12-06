
namespace YSerene.Default {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.panel()
    export class NewsDialog extends Serenity.EntityDialog<NewsRow, any> {
        protected getFormKey() { return NewsForm.formKey; }
        protected getIdProperty() { return NewsRow.idProperty; }
        protected getLocalTextPrefix() { return NewsRow.localTextPrefix; }
        protected getNameProperty() { return NewsRow.nameProperty; }
        protected getService() { return NewsService.baseUrl; }

        protected form = new NewsForm(this.idPrefix);

    }
}