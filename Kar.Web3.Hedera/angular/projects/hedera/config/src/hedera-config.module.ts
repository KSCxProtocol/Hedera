import { ModuleWithProviders, NgModule } from '@angular/core';
import { HEDERA_ROUTE_PROVIDERS } from './providers/route.provider';

@NgModule()
export class HederaConfigModule {
  static forRoot(): ModuleWithProviders<HederaConfigModule> {
    return {
      ngModule: HederaConfigModule,
      providers: [HEDERA_ROUTE_PROVIDERS],
    };
  }
}
