namespace YSerene.Membership {

    @Serenity.Decorators.registerClass()
    export class CreateEnListPanel extends Serenity.PropertyPanel<CreateEnListRequest, any> {

        protected getFormKey() { return EnListForm.formKey; }

        private form: EnListForm;

        constructor(container: JQuery) {
            super(container);

            this.form = new EnListForm(this.idPrefix);

//            this.form.ConfirmEmail.addValidationRule(this.uniqueName, e => {
//                if (this.form.ConfirmEmail.value !== this.form.Email.value) {
//                    return Q.text('Validation.EmailConfirm');
//                }
//            });
//
//            this.form.ConfirmPassword.addValidationRule(this.uniqueName, e => {
//                if (this.form.ConfirmPassword.value !== this.form.Password.value) {
//                    return Q.text('Validation.PasswordConfirm');
//                }
//            });

            this.byId('SubmitButton').click(e => {
                e.preventDefault();

                if (!this.validateForm()) {
                    return;
                }
                Q.serviceCall({
                    url: Q.resolveUrl('~/CreateEnList'),
                    request: {
                        ParentName: this.form.ParentName.value,
                        Mobile: this.form.Mobile.value,
                        ChildName: this.form.ChildName.value,
                        Sex: this.form.Sex.value,
                        Birthday: this.form.Birthday.value
                    },
                    onSuccess: response => {
                        Q.information("报名成功", () => {
                            window.location.href = Q.resolveUrl('~/');
                        });
                    }
                });

            });
        }
    }
}