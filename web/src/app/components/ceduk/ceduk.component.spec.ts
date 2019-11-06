import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CedukComponent } from './ceduk.component';

describe('CedukComponent', () => {
  let component: CedukComponent;
  let fixture: ComponentFixture<CedukComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CedukComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CedukComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
