import { Component, OnInit } from '@angular/core';
import { HederaService } from '../services/hedera.service';

@Component({
  selector: 'lib-hedera',
  template: ` <p>hedera works!</p> `,
  styles: [],
})
export class HederaComponent implements OnInit {
  constructor(private service: HederaService) {}

  ngOnInit(): void {
    this.service.sample().subscribe(console.log);
  }
}
