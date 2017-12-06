namespace YSerene.Default {
    export class NewsForm extends Serenity.PrefixedContext {
        static formKey = 'Default.News';

    }

    export interface NewsForm {
        Title: Serenity.StringEditor;
        Image: Serenity.ImageUploadEditor;
        CategoryId: Serenity.LookupEditor;
        SourceSite: Serenity.StringEditor;
        CreateDate: Serenity.DateEditor;
        Description: Serenity.HtmlContentEditor;
    }

    [['Title', () => Serenity.StringEditor], ['Image', () => Serenity.ImageUploadEditor], ['CategoryId', () => Serenity.LookupEditor], ['SourceSite', () => Serenity.StringEditor], ['CreateDate', () => Serenity.DateEditor], ['Description', () => Serenity.HtmlContentEditor]].forEach(x => Object.defineProperty(NewsForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

