import { Component, OnInit } from '@angular/core';
import { NavigationExtras, Router } from '@angular/router';
import { ShopbridgeService } from '../sevices/shopbridge.service';
import { ShopBridge } from '../shopbridge-form/shopBridge-model';


@Component({
  selector: 'shopBridge-grid',
  templateUrl: './shopBridge-grid.component.html'
})
export class ShopBridgeGridComponent implements OnInit {

  records: ShopBridge[];
  constructor(private router: Router, private shopbridgeService: ShopbridgeService) {
  }

  ngOnInit() {
    this.getAllData()
  }

  delete(record) {
    if (record) {
       this.shopbridgeService.deleteData(record).subscribe((data: any[]) => {
        this.getAllData()
      })
      //this.getAllData();
    }
  }

  edit(record: ShopBridge) {
    let navigationExtras: NavigationExtras = {
      queryParams: {
        "id": record.id,
        "name": record.name,
        "description": record.description,
        "price": record.price
      },
    };
    this.router.navigate(["/form"], navigationExtras);
  }

  getAllData() {
    this.shopbridgeService.sendGetRequest().subscribe((data: any[]) => {
      this.records = data;
    })
  }
}