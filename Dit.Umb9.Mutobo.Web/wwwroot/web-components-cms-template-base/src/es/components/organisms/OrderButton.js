import { Shadow } from '../web-components-cms-template/src/es/components/prototypes/Shadow.js';

export default class OrderButton extends Shadow() {

    constructor(...args) {
        super(...args);

        this.order = product => {

        };
    }

    connectedCallback() {
        if (this.shouldComponentRenderCSS()) this.renderCSS();
        if (this.shouldComponentRenderHTML()) this.renderHTML();
    }



    disconnectedCallback() {

    }

    shouldComponentRenderHTML() {
        return !this.root.querySelector('div');
    }

    shouldComponentRenderCSS() {
        return !this.root.querySelector('style[_css]');
    }

    renderCSS() {

    }


    fireEvent(event) {

        const customEvent = new CustomEvent('addToBasket',
            {
                detail: {
                    
                },
                bubbles: true,
                cancelable: true,
                component: true,
            });

        
        this.dispatchEvent(customEvent);

    }

    renderHTML() {

        this.container = document.createElement('DIV');
        this.button = document.createElement('BUTTON');
        this.button.setAttribute('data-id', this.getAttribute('product-id'));
        this.button.addEventListener('click', event => this.fireEvent(event));
        this.button.textContent = 'Klick mich';
        this.container.appendChild(this.button);
        this.html = this.container;
    }

}