namespace YSerene.Default {
    export interface EnListRow {
        EnId?: number;
        ParentName?: string;
        Mobile?: string;
        ChildName?: string;
        Sex?: Common.MemberSex;
        Birthday?: string;
        InsertUserId?: number;
        InsertDate?: string;
        UpdateUserId?: number;
        UpdateDate?: string;
    }

    export namespace EnListRow {
        export const idProperty = 'EnId';
        export const nameProperty = 'ParentName';
        export const localTextPrefix = 'Default.EnList';

        export namespace Fields {
            export declare const EnId: string;
            export declare const ParentName: string;
            export declare const Mobile: string;
            export declare const ChildName: string;
            export declare const Sex: string;
            export declare const Birthday: string;
            export declare const InsertUserId: string;
            export declare const InsertDate: string;
            export declare const UpdateUserId: string;
            export declare const UpdateDate: string;
        }

        [
            'EnId', 
            'ParentName', 
            'Mobile', 
            'ChildName', 
            'Sex', 
            'Birthday', 
            'InsertUserId', 
            'InsertDate', 
            'UpdateUserId', 
            'UpdateDate'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

