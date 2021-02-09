import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { ShopbridgeService } from '../sevices/shopbridge.service';
import { ShopBridge } from './shopBridge-model';

@Component({
  selector: 'shopBridge-form',
  templateUrl: './shopBridge-form.component.html',
  styleUrls: ['./shopBridge-form.component.css']
})
export class ShopBridgeFormComponent {

  public model: ShopBridge;
  errorMessage: any;

  constructor(private activatedRoutes: ActivatedRoute, private router: Router, private shopbridgeService: ShopbridgeService) {
    this.model = new ShopBridge();
    this.activatedRoutes.queryParams.subscribe(params => {
      if (params) {
        this.model.id = params["id"];
        this.model.name = params["name"];
        this.model.price = params["price"];
        this.model.description = params["description"];
      }
    });
  }

  onSubmit() {
    if (this.model.id == "" || this.model.id == undefined || this.model.id == null) {
      this.shopbridgeService.postData(this.model).subscribe(result => {
        this.router.navigate(['']);
      })
    }
    else {
      this.shopbridgeService.updateData(this.model).subscribe(result => {
        this.router.navigate(['']);
      })
    }
  }
}
