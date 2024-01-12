import { NgModule, NgModuleFactory, ModuleWithProviders } from '@angular/core';
import { CoreModule, LazyModuleFactory } from '@abp/ng.core';
import { ThemeSharedModule } from '@abp/ng.theme.shared';
import { HederaComponent } from './components/hedera.component';
import { HederaRoutingModule } from './hedera-routing.module';

@NgModule({
  declarations: [HederaComponent],
  imports: [CoreModule, ThemeSharedModule, HederaRoutingModule],
  exports: [HederaComponent],
})
export class HederaModule {
  static forChild(): ModuleWithProviders<HederaModule> {
    return {
      ngModule: HederaModule,
      providers: [],
    };
  }

  static forLazy(): NgModuleFactory<HederaModule> {
    return new LazyModuleFactory(HederaModule.forChild());
  }
}
