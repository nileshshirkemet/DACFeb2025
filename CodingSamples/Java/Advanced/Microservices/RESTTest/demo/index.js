//const restUri = "http://localhost:5000/api/sales";
const restUri = "rest/api/sales";

class SalesDataSource {

    constructor() {
        this.orderList = [];
        this.orderEntry = {"customerId": "", "productNo": 0, "quantity": 0};
        this.statusReport = "";
    }

    async readOrders() {
        let response = await fetch(`${restUri}/${this.orderEntry.customerId}`);
        if(response.ok){
            this.orderList = await response.json();
            this.statusReport = "";
        }else{
            this.orderList = [];
            this.statusReport = "Cannot fetch orders!";
        }
    }

    async createOrder() {
        this.orderList = [];
        let request = {
            method: "post",
            headers: {"Content-Type": "application/json"},
            body: JSON.stringify(this.orderEntry)
        };
        let response = await fetch(restUri, request);
        if(response.ok){
            let result = await response.json();
            this.statusReport = `Order ${result.orderNo} placed.`;
        }else{
            this.statusReport = "Cannot place order!";
        }
            
    }
}
