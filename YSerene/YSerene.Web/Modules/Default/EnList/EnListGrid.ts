
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

        //设置页面操作按钮
        public getButtons() {
            return [];
        }
        //控制列属性
//        public getColumns() {
//            return [];
//        }
    }
}