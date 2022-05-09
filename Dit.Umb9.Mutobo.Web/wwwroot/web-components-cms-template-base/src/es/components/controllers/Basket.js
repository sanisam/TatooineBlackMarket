import { Shadow } from '../web-components-cms-template/src/es/components/prototypes/Shadow.js';

export default class Basket extends Shadow() {





    constructor(...args) {
        super(...args);
        this.setOrderListener = event => {

           
            let basketItems = this.basket;
            let product = basketItems.find(p => p.id === event.detail.productId);
            if (!product){
                product = {id: event.detail.productId, count: 1};
                basketItems.push(product);
            } else {
                product.count++;
            }

            this.basket = basketItems;

            const customEvent = new CustomEvent('basket-update',
                {
                    detail: {
                        basket: this.basket 
                    },
                    bubbles: true,
                    cancelable: false,
                    composed: true

                });

            this.dispatchEvent(customEvent);

        }
    }





    get basket() {

        return localStorage.getItem('basket') ? JSON.parse(localStorage.getItem('basket')) : [];
    }

    set basket(value) {
        localStorage.setItem('basket', JSON.stringify(value));
    }




    connectedCallback() {
        this.addEventListener('addToBasket', this.setOrderListener);
    }



    disconnectedCallback() {
        this.removeEventListener('addToBasket', this.setOrderListener);
    }

}