
namespace YSerene.Default {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class EnListDialog extends Serenity.EntityDialog<EnListRow, any> {
        protected getFormKey() { return EnListForm.formKey; }
        protected getIdProperty() { return EnListRow.idProperty; }
        protected getLocalTextPrefix() { return EnListRow.localTextPrefix; }
        protected getNameProperty() { return EnListRow.nameProperty; }
        protected getService() { return EnListService.baseUrl; }

        protected form = new EnListForm(this.idPrefix);

        //隐藏保存按钮
        protected updateInterface(): void {
            this.toolbar.findButton('apply-changes-button').hide();
            this.toolbar.findButton('save-and-close-button').hide();
            this.toolbar.findButton('undo-delete-button').hide();
            this.toolbar.findButton('localization-button').hide();
            this.toolbar.findButton('clone-button').hide();
        }
    }
}