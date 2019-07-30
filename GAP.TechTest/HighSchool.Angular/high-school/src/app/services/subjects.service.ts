import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from "@angular/core";
import { FilterModel } from '../models/filter.model';
import { Observable } from 'rxjs';
import { retry, catchError } from 'rxjs/operators';
import { BaseService } from './_base.service';
import { SubjectModel } from '../models/subject.model';
import { environment } from '../../environments/environment';

@Injectable()
export class SubjectService extends BaseService{
    constructor(
        protected _httpClient: HttpClient
    ) {
        super();
    };

    public getAll(): Observable<SubjectModel[]> {
        return this._httpClient.get<SubjectModel[]>(`${environment.apiUrl}subject`)
            .pipe(
                retry(1),
                catchError(this.handleError)
            )
    }

}