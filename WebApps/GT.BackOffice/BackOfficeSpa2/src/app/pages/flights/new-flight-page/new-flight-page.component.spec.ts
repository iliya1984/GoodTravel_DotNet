import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { NewFlightPageComponent } from './new-flight-page.component';

describe('NewFlightPageComponent', () => {
  let component: NewFlightPageComponent;
  let fixture: ComponentFixture<NewFlightPageComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ NewFlightPageComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(NewFlightPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
