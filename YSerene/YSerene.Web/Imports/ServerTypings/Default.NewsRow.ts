namespace YSerene.Default {
    export interface NewsRow {
        NewsId?: number;
        Title?: string;
        Image?: string;
        CategoryId?: number;
        SourceSite?: string;
        CreateDate?: string;
        Description?: string;
        CategoryCategoryName?: string;
        InsertUserId?: number;
        InsertDate?: string;
        UpdateUserId?: number;
        UpdateDate?: string;
    }

    export namespace NewsRow {
        export const idProperty = 'NewsId';
        export const nameProperty = 'Title';
        export const localTextPrefix = 'Default.News';

        export namespace Fields {
            export declare const NewsId: string;
            export declare const Title: string;
            export declare const Image: string;
            export declare const CategoryId: string;
            export declare const SourceSite: string;
            export declare const CreateDate: string;
            export declare const Description: string;
            export declare const CategoryCategoryName: string;
            export declare const InsertUserId: string;
            export declare const InsertDate: string;
            export declare const UpdateUserId: string;
            export declare const UpdateDate: string;
        }

        [
            'NewsId', 
            'Title', 
            'Image', 
            'CategoryId', 
            'SourceSite', 
            'CreateDate', 
            'Description', 
            'CategoryCategoryName', 
            'InsertUserId', 
            'InsertDate', 
            'UpdateUserId', 
            'UpdateDate'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

