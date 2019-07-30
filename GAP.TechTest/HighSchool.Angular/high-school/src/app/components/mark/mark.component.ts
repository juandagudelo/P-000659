import { Component, OnInit } from '@angular/core';
import { MarkService } from '../../../app/services/marks.service';
import { FilterModel } from '../../../app/models/filter.model';
import { SubjectModel } from '../../../app/models/subject.model';
import { SubjectService } from '../../../app/services/subjects.service';
import { MarkResultModel } from '../../../app/models/mark-result.model';

@Component({
  selector: 'app-mark',
  templateUrl: './mark.component.html',
  styleUrls: ['./mark.component.css']
})
export class MarkComponent implements OnInit {

  public filters: FilterModel = new FilterModel();
  public markResultList: MarkResultModel[] = [];
  public subjectList: SubjectModel[] = [];
  public loading: boolean;
  constructor(
    private _markService: MarkService,
    private _subjectService: SubjectService,
  ) { 
    
  }

  ngOnInit() {
    this.loading = true;
    this.getData();
    this._subjectService.getAll().subscribe((data: SubjectModel[]) => {
      this.subjectList = data;
      this.loading = false;
    })
  }

  getData()
  {
    this.loading = true;

    this._markService.getAllFilter(this.filters).subscribe((data: MarkResultModel[]) => {
      this.markResultList = data;
      this.loading = false;
    })
  }

}
