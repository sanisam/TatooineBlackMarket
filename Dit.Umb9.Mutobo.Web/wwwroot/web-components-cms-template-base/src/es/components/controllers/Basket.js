import { Shadow } from '../web-components-cms-template/src/es/components/prototypes/Shadow.js';

export default class Basket extends Shadow() {





    constructor(...args) {
        super(...args);
        this.setOrderListener = event => {

            let product = window.basket.find(p => p.id === event.detail.productId);

            if (!product){
                window.basket.push({id: event.detail.productId, count: 1});
            } else {
                product.count++;
            }
               
            localStorage.setItem('basket', JSON.stringify(window.basket));

            const customEvent = new CustomEvent('basket-update',
            {
                detail: {
                    basket: window.basket /* TODO: change to getter zto avoid global scope */           
                },
                bubbles: true,
                cancelable: false,
                composed: true
               
            });

            this.dispatchEvent(customEvent);
            
        }
    }





    connectedCallback() {
        this.addEventListener('addToBasket', this.setOrderListener);
    }



    disconnectedCallback() {
        this.removeEventListener('addToBasket', this.setOrderListener);
    }

}