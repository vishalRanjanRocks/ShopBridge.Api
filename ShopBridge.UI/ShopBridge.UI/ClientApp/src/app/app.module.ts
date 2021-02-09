import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component'
import { ShopBridgeFormComponent } from './shopbridge-form/shopBridge-form.component';
import { LayoutComponent } from './layout/layout.component';
import { ShopBridgeGridComponent } from './shopBridge-grid/shopBridge-grid.component';
import { ShopbridgeService } from './sevices/shopbridge.service';

@NgModule({
  declarations: [
    AppComponent,
    ShopBridgeFormComponent,
    ShopBridgeGridComponent,
    LayoutComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: 'form', component: ShopBridgeFormComponent },
      { path: '', component: ShopBridgeGridComponent}
    ])
  ],
  providers: [ShopbridgeService],
  bootstrap: [AppComponent]
})
export class AppModule { }
