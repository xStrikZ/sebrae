import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SebraeLayoutComponent } from './sebrae-layout.component';

describe('SebraeLayoutComponent', () => {
  let component: SebraeLayoutComponent;
  let fixture: ComponentFixture<SebraeLayoutComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SebraeLayoutComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SebraeLayoutComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
