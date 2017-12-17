namespace YSerene.Default {
    export interface PicturesRow {
        PictureId?: number;
        Title?: string;
        KeyImage?: string;
        ImageList?: string;
        Description?: string;
        InsertUserId?: number;
        InsertDate?: string;
        UpdateUserId?: number;
        UpdateDate?: string;
    }

    export namespace PicturesRow {
        export const idProperty = 'PictureId';
        export const nameProperty = 'Title';
        export const localTextPrefix = 'Default.Pictures';

        export namespace Fields {
            export declare const PictureId: string;
            export declare const Title: string;
            export declare const KeyImage: string;
            export declare const ImageList: string;
            export declare const Description: string;
            export declare const InsertUserId: string;
            export declare const InsertDate: string;
            export declare const UpdateUserId: string;
            export declare const UpdateDate: string;
        }

        [
            'PictureId', 
            'Title', 
            'KeyImage', 
            'ImageList', 
            'Description', 
            'InsertUserId', 
            'InsertDate', 
            'UpdateUserId', 
            'UpdateDate'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

