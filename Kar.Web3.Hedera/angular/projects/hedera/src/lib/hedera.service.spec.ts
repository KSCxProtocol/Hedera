import { TestBed } from '@angular/core/testing';
import { HederaService } from './services/hedera.service';
import { RestService } from '@abp/ng.core';

describe('HederaService', () => {
  let service: HederaService;
  const mockRestService = jasmine.createSpyObj('RestService', ['request']);
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [
        {
          provide: RestService,
          useValue: mockRestService,
        },
      ],
    });
    service = TestBed.inject(HederaService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
