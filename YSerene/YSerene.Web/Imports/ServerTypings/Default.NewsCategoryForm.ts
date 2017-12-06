namespace YSerene.Default {
    export class NewsCategoryForm extends Serenity.PrefixedContext {
        static formKey = 'Default.NewsCategory';

    }

    export interface NewsCategoryForm {
        CategoryName: Serenity.StringEditor;
        Description: Serenity.TextAreaEditor;
    }

    [['CategoryName', () => Serenity.StringEditor], ['Description', () => Serenity.TextAreaEditor]].forEach(x => Object.defineProperty(NewsCategoryForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

