
namespace YSerene.Default {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class PicturesDialog extends Serenity.EntityDialog<PicturesRow, any> {
        protected getFormKey() { return PicturesForm.formKey; }
        protected getIdProperty() { return PicturesRow.idProperty; }
        protected getLocalTextPrefix() { return PicturesRow.localTextPrefix; }
        protected getNameProperty() { return PicturesRow.nameProperty; }
        protected getService() { return PicturesService.baseUrl; }

        protected form = new PicturesForm(this.idPrefix);

    }
}