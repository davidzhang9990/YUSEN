
namespace YSerene.Default {

    @Serenity.Decorators.registerClass()
    export class PicturesGrid extends Serenity.EntityGrid<PicturesRow, any> {
        protected getColumnsKey() { return 'Default.Pictures'; }
        protected getDialogType() { return PicturesDialog; }
        protected getIdProperty() { return PicturesRow.idProperty; }
        protected getLocalTextPrefix() { return PicturesRow.localTextPrefix; }
        protected getService() { return PicturesService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}