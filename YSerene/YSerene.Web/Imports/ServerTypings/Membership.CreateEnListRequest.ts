namespace YSerene.Membership {
    export interface CreateEnListRequest extends Serenity.ServiceRequest {
        ParentName?: string;
        Mobile?: string;
        ChildName?: string;
        Sex?: number;
        Birthday?: string;
    }
}

