
namespace YSerene.Default {

    @Serenity.Decorators.registerClass()
    export class EnListGrid extends Serenity.EntityGrid<EnListRow, any> {
        protected getColumnsKey() { return 'Default.EnList'; }
        protected getDialogType() { return EnListDialog; }
        protected getIdProperty() { return EnListRow.idProperty; }
        protected getLocalTextPrefix() { return EnListRow.localTextPrefix; }
        protected getService() { return EnListService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}