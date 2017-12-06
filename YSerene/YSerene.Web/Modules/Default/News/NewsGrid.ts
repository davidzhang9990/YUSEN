
namespace YSerene.Default {

    @Serenity.Decorators.registerClass()
    export class NewsGrid extends Serenity.EntityGrid<NewsRow, any> {
        protected getColumnsKey() { return 'Default.News'; }
        protected getDialogType() { return NewsDialog; }
        protected getIdProperty() { return NewsRow.idProperty; }
        protected getLocalTextPrefix() { return NewsRow.localTextPrefix; }
        protected getService() { return NewsService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}