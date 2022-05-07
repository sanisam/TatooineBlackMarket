import { Shadow } from '../web-components-cms-template/src/es/components/prototypes/Shadow.js';

export default class Basket extends Shadow() {





    constructor(...args) {
        super(...args);
        this.products = localStorage.getItem('basket') ? JSON.parse(localStorage.getItem('basket')) : [];
        
        
        
        this.setOrderListener = event => {

            let product = this.products.find(p => p.id === event.detail.productId);

            if (!product){
                this.products.push({id: event.detail.productId, count: 1});
            } else {
                product.count++;
            }          
            localStorage.setItem('basket', JSON.stringify(this.products));
        }
    }


    connectedCallback() {


        this.addEventListener('addToBasket', this.setOrderListener);

    }



    disconnectedCallback() {
        this.removeEventListener('addToBasket', this.setOrderListener);
    }

}