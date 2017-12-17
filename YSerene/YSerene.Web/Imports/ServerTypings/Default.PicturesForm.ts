namespace YSerene.Default {
    export class PicturesForm extends Serenity.PrefixedContext {
        static formKey = 'Default.Pictures';

    }

    export interface PicturesForm {
        Title: Serenity.StringEditor;
        KeyImage: Serenity.ImageUploadEditor;
        ImageList: Serenity.MultipleImageUploadEditor;
        Description: Serenity.StringEditor;
    }

    [['Title', () => Serenity.StringEditor], ['KeyImage', () => Serenity.ImageUploadEditor], ['ImageList', () => Serenity.MultipleImageUploadEditor], ['Description', () => Serenity.StringEditor]].forEach(x => Object.defineProperty(PicturesForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

