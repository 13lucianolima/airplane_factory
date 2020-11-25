export class Result<TModel> {
    success: boolean;
    data: TModel;
    errors: string[];
}