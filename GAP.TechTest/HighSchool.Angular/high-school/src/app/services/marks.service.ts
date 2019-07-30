import { HttpClient } from '@angular/common/http';
import { Injectable } from "@angular/core";
import { FilterModel } from '../models/filter.model';
import { Observable } from 'rxjs';
import { retry, catchError } from 'rxjs/operators';
import { BaseService } from './_base.service';
import { MarkResultModel } from '../models/mark-result.model';
import { environment } from '../../environments/environment';
import { HttpHeaders } from '@angular/common/http';

@Injectable()
export class MarkService extends BaseService {
    constructor(
        protected _httpClient: HttpClient
    ) {
        super();
        
    }

    public getAllFilter(filter: FilterModel): Observable<MarkResultModel[]> {
        return this._httpClient.post<MarkResultModel[]>(`${environment.apiUrl}mark/getfiltered`, filter)
            .pipe(
                retry(1),
                catchError(this.handleError)
            )
    }
   
}