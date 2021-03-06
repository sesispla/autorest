/*
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

'use strict';

/**
 * Class representing a Product.
 */
class Product {
  /**
   * Create a Product.
   * @member {number} id
   * @member {string} [name]
   */
  constructor() {
  }

  /**
   * Defines the metadata of Product
   *
   * @returns {object} metadata of Product
   *
   */
  mapper() {
    return {
      required: false,
      serializedName: 'product',
      type: {
        name: 'Composite',
        className: 'Product',
        modelProperties: {
          id: {
            required: true,
            serializedName: 'id',
            type: {
              name: 'Number'
            }
          },
          name: {
            required: false,
            serializedName: 'name',
            type: {
              name: 'String'
            }
          }
        }
      }
    };
  }
}

module.exports = Product;
