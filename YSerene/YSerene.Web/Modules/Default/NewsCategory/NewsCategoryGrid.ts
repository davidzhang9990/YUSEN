
namespace YSerene.Default {

    @Serenity.Decorators.registerClass()
    export class NewsCategoryGrid extends Serenity.EntityGrid<NewsCategoryRow, any> {
        protected getColumnsKey() { return 'Default.NewsCategory'; }
        protected getDialogType() { return NewsCategoryDialog; }
        protected getIdProperty() { return NewsCategoryRow.idProperty; }
        protected getLocalTextPrefix() { return NewsCategoryRow.localTextPrefix; }
        protected getService() { return NewsCategoryService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}