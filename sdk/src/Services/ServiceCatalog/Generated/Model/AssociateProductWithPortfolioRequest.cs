/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateProductWithPortfolio operation.
    /// Associates a product with a portfolio.
    /// </summary>
    public partial class AssociateProductWithPortfolioRequest : AmazonServiceCatalogRequest
    {
        private string _acceptLanguage;
        private string _portfolioId;
        private string _productId;
        private string _sourcePortfolioId;

        /// <summary>
        /// Gets and sets the property AcceptLanguage. 
        /// <para>
        /// The language code to use for this operation. Supported language codes are as follows:
        /// </para>
        ///  
        /// <para>
        /// "en" (English)
        /// </para>
        ///  
        /// <para>
        /// "jp" (Japanese)
        /// </para>
        ///  
        /// <para>
        /// "zh" (Chinese)
        /// </para>
        ///  
        /// <para>
        /// If no code is specified, "en" is used as the default.
        /// </para>
        /// </summary>
        public string AcceptLanguage
        {
            get { return this._acceptLanguage; }
            set { this._acceptLanguage = value; }
        }

        // Check to see if AcceptLanguage property is set
        internal bool IsSetAcceptLanguage()
        {
            return this._acceptLanguage != null;
        }

        /// <summary>
        /// Gets and sets the property PortfolioId. 
        /// <para>
        /// The portfolio identifier.
        /// </para>
        /// </summary>
        public string PortfolioId
        {
            get { return this._portfolioId; }
            set { this._portfolioId = value; }
        }

        // Check to see if PortfolioId property is set
        internal bool IsSetPortfolioId()
        {
            return this._portfolioId != null;
        }

        /// <summary>
        /// Gets and sets the property ProductId. 
        /// <para>
        /// The product identifier.
        /// </para>
        /// </summary>
        public string ProductId
        {
            get { return this._productId; }
            set { this._productId = value; }
        }

        // Check to see if ProductId property is set
        internal bool IsSetProductId()
        {
            return this._productId != null;
        }

        /// <summary>
        /// Gets and sets the property SourcePortfolioId. 
        /// <para>
        /// The identifier of the source portfolio to use with this association.
        /// </para>
        /// </summary>
        public string SourcePortfolioId
        {
            get { return this._sourcePortfolioId; }
            set { this._sourcePortfolioId = value; }
        }

        // Check to see if SourcePortfolioId property is set
        internal bool IsSetSourcePortfolioId()
        {
            return this._sourcePortfolioId != null;
        }

    }
}