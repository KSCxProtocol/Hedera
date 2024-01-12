import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';
import { HederaComponent } from './components/hedera.component';
import { HederaService } from '@kar.Web3/hedera';
import { of } from 'rxjs';

describe('HederaComponent', () => {
  let component: HederaComponent;
  let fixture: ComponentFixture<HederaComponent>;
  const mockHederaService = jasmine.createSpyObj('HederaService', {
    sample: of([]),
  });
  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [HederaComponent],
      providers: [
        {
          provide: HederaService,
          useValue: mockHederaService,
        },
      ],
    }).compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(HederaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
