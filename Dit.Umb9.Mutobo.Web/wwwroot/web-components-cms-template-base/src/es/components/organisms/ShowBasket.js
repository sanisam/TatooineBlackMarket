import { Shadow } from '../web-components-cms-template/src/es/components/prototypes/Shadow.js';


export default class ShowBasket extends Shadow () {


    constructor(...args) {
        super(...args);
       
    }


    connectedCallback () {
        debugger;
        if (this.shouldComponentRenderCSS()) this.renderCSS();
        if (this.shouldComponentRenderHTML()) this.renderHTML();
    }

    disconnectedCallback () {

    }

    renderCSS() {
        this.css = `
            @import url("https://cdn.jsdelivr.net/npm/bootstrap-icons@1.8.1/font/bootstrap-icons.css");

            :host {
                position: fixed;
                top: 10vh;
                right: 0;
                width: auto !important;
                background-color: rgba(0,0,0,0.3);
                color: white;
            }

            :host div.basket-header {
                display: flex;
                justify-content: flex-end;
            }



            :host div i {
                font-size: 4em;
                cursor: pointer;
            }
        `;
    }

    async fetchBasket(data) {

        debugger;
        const response = await fetch('/Umbraco/Api/Basket/GetBasket',{
            method: 'POST',
            mode: 'cors',
            cache: 'no-cache',
            credentials: 'same-origin', 
            headers: {
              'Content-Type': 'application/json'
            },
            redirect: 'follow',
            referrerPolicy: 'no-referrer', 
            body: JSON.stringify(data)
        });

    
        return response.json();
    }


    
    shouldComponentRenderHTML() {

        return !this.root.querySelector('div');
    }

    shouldComponentRenderCSS() {
        return !this.root.querySelector('style[_css]');
    }

    openBasket(event){
        this.products = localStorage.getItem('basket') ? JSON.parse(localStorage.getItem('basket')) : [];
        this.html = '';
        this.fetchBasket(this.products).then(data => {
            debugger;
            this.basket = document.createElement('div');
            this.basketHeader = document.createElement('div');
            this.basketHeader.className = 'basket-header';
            this.basketCloseButton = document.createElement('i');
            this.basketCloseButton.className = 'bi bi-x';
            this.basketCloseButton.addEventListener('click', event => this.closeBasket(event));
            this.basketHeader.appendChild(this.basketCloseButton);
            this.basket.appendChild(this.basketHeader);
            this.basketContent = document.createElement('div'); 
            this.basketContent.innerHTML = `<ul>${data.products?.map(d => `<li>
            ${d.count} x ${d.name} à ${d.price} SFr.
            </li>`).join('')}</ul>
            <div>Total: ${data.totalPrice} SFr.</div>`;
            this.basket.appendChild(this.basketContent);
            this.html = this.basket;
        });
        
  

        // this.html = ``;
    }

    closeBasket(event) {
        debugger;
        this.html = '';
        this.renderHTML();
    }

    renderHTML () {
        this.basket = document.createElement('div');
        this.basketIcon = document.createElement('i');
        this.basketIcon.className = 'bi bi-cart4';
        this.basketIcon.addEventListener('click', event => this.openBasket(event));
        this.basket.appendChild(this.basketIcon);
        this.html = this.basket;
    }

}