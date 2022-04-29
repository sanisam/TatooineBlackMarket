import { Shadow } from '../web-components-cms-template/src/es/components/prototypes/Shadow.js';

export default class Basket extends HTMLElement  {


    products = [{name: 'test'}];


    constructor(...args) {
        super(...args);



        this.setOrderListener = event => {
            debugger
        }

    }


    connectedCallback() {
        debugger;
        this.addEventListener('addToBasket', this.setOrderListener);
    }



    disconnectedCallback() {
        debugger;
        this.removeEventListener('addToBasket', this.setOrderListener);
    }

}