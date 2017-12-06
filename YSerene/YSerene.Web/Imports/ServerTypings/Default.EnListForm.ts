namespace YSerene.Default {
    export class EnListForm extends Serenity.PrefixedContext {
        static formKey = 'Default.EnList';

    }

    export interface EnListForm {
        ParentName: Serenity.StringEditor;
        Mobile: Serenity.StringEditor;
        ChildName: Serenity.StringEditor;
        Sex: Serenity.EnumEditor;
        Birthday: Serenity.DateEditor;
    }

    [['ParentName', () => Serenity.StringEditor], ['Mobile', () => Serenity.StringEditor], ['ChildName', () => Serenity.StringEditor], ['Sex', () => Serenity.EnumEditor], ['Birthday', () => Serenity.DateEditor]].forEach(x => Object.defineProperty(EnListForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

