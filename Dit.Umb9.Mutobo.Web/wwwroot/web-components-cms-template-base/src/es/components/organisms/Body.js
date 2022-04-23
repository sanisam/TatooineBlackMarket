// @ts-check
import BaseBody from '../web-components-cms-template/src/es/components/organisms/Body.js'

/* global self */

/**
 * Defines a body body for content and maps variables to global tags
 * Example at: /src/es/components/pages/General.html
 * As an organism, this component shall hold molecules and/or atoms
 *
 * @export
 * @class Body
 * @type {CustomElementConstructor}
 * @css {
 *  NOTE: grid-area: body;
 *  --content-spacing [40px]
 *  --content-width [80%]
 *  --h1-color [--color, black]
 *  --font-family-secondary
 * }
 */
export default class Body extends BaseBody {

  constructor (...args) {
    super(...args);

    this.scrollButtonEventListener = event => {
        const targetPosition = this.root.getElementById(event.target.getAttribute('target-id')).getBoundingClientRect().bottom * 0.9;
        window.scrollTo({
          top: targetPosition - targetPosition * 0.2,
          behavior: 'smooth'
        })
    };
  }

  connectedCallback () {
    this.root.addEventListener('scroll-to', this.scrollButtonEventListener);
    super.connectedCallback();
  }

  disconnectedCallback () {
    this.root.removeEventListener('scroll-to', this.scrollButtonEventListener);
    super.disconnectedCallback();
  }



  renderCSS () {
    super.renderCSS()
    this.css = /* css */`
      ${this.hasAttribute('home')
        ? /* css */`
          :host > main {

            align-items: center;
            display: flex;
            height: var(--height, max(75vh, calc(100% - 4.1em)));
            overflow: visible;
          }
        `
        : ''}
      :host > main > *[content-width] {
        width: var(--content-width, 80%);
        margin-bottom: var(--content-spacing);
      }
      :host > main > q {
        width: var(--content-width-not-web-component, 80%);
      }
      :host > main > .q > q {
        margin: var(--q-margin);
      }
      :host > main > q, :host > main > .q > q {
        display: var(--q-display, block);
        font-size: var(--q-font-size, var(--font-size));
        quotes: var(--q-quotes, none);
      }
      :host > main > q, :host > main > .q * {
        text-align: var(--q-text-align, center);
      }
      :host > main sparx-a-heading {
        margin: var(--sparx-a-heading-margin);
      }
      :host > main h2 {
        margin: var(--h2-margin);
      }
      :host > main h3 {
        margin: var(--h3-margin);
      }
      :host > main p {
        margin: var(--p-margin);
      }
      :host > main .highlight {
        color: var(--highlight-color, var(--background-color));
        background-color: var(--highlight-background-color, var(--color));
        padding: var(--highlight-padding, 0 0.2em);
      }
      :host > main a:hover, :host > main a:active, :host > main a:focus, :host > main a:hover *, :host > main a:active *, :host > main a:focus * {
        font-family: var(--a-font-family-hover);
      }
      @media only screen and (max-width: ${this.getAttribute('mobile-breakpoint') ? this.getAttribute('mobile-breakpoint') : self.Environment && !!self.Environment.mobileBreakpoint ? self.Environment.mobileBreakpoint : '1000px'}) {
        :host > main > *[content-width] {
          width: var(--content-width-mobile, 80%);
          margin-bottom: var(--content-spacing-mobile);
        }
        :host > main > q {
          width: var(--content-width-not-web-component-mobile, var(--content-width-not-web-component, var(--content-width-mobile, var(--content-width, 90%))));
        }
        :host > main > .q > q {
          margin: var(--q-margin-mobile, var(--q-margin)); 
        }
        :host > main > q, :host > main > .q > q {
          font-size: var(--q-font-size-mobile, var(--font-size-mobile, var(--q-font-size)));
        }
        :host > main h2 {
          margin: var(--h2-margin-mobile, var(--h2-margin));
        }
        :host > main sparx-a-heading {
          margin: var(--sparx-a-heading-margin-mobile, var(--sparx-a-heading-margin));
        }
        :host > main h3 {
          margin: var(--h3-margin-mobile, var(--h3-margin));
        }
        :host > main p {
          margin: var(--p-margin-mobile, var(--p-margin));
        }
        :host > main > div.sparx-a-call-for-ideas + div.spacer {
          display: none;
        }
      }
    `
  }
}