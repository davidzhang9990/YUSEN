namespace YSerene.Default {
    export interface NewsCategoryRow {
        CategoryId?: number;
        CategoryName?: string;
        Description?: string;
        InsertUserId?: number;
        InsertDate?: string;
        UpdateUserId?: number;
        UpdateDate?: string;
    }

    export namespace NewsCategoryRow {
        export const idProperty = 'CategoryId';
        export const nameProperty = 'CategoryName';
        export const localTextPrefix = 'Default.NewsCategory';
        export const lookupKey = 'Default.NewsCategory';

        export function getLookup(): Q.Lookup<NewsCategoryRow> {
            return Q.getLookup<NewsCategoryRow>('Default.NewsCategory');
        }

        export namespace Fields {
            export declare const CategoryId: string;
            export declare const CategoryName: string;
            export declare const Description: string;
            export declare const InsertUserId: string;
            export declare const InsertDate: string;
            export declare const UpdateUserId: string;
            export declare const UpdateDate: string;
        }

        [
            'CategoryId', 
            'CategoryName', 
            'Description', 
            'InsertUserId', 
            'InsertDate', 
            'UpdateUserId', 
            'UpdateDate'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

