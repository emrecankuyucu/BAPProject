#pragma checksum "C:\Users\Emre\Desktop\BAPFront\BAProjeFront\Views\Product\ProductDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7636855df5c144b4a894be74398ebc320c7c5de3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BAProjeFront.Models.Product.Views_Product_ProductDetails), @"mvc.1.0.view", @"/Views/Product/ProductDetails.cshtml")]
namespace BAProjeFront.Models.Product
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7636855df5c144b4a894be74398ebc320c7c5de3", @"/Views/Product/ProductDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7dce13a66a97e3bdbdb80892da7f61b438b56113", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ProductDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddProductToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<section>
		<div class=""container"">
			<div class=""row"">
                

                <div class=""col-sm-12 padding-right"">
					<div class=""product-details""><!--product-details-->
						<div class=""col-sm-4"">
							<div class=""view-product"">
								<img");
            BeginWriteAttribute("src", " src=\"", 295, "\"", 364, 2);
            WriteAttributeValue("", 301, "http://localhost:51061/api/images/GetProductImageById/", 301, 54, true);
#nullable restore
#line 11 "C:\Users\Emre\Desktop\BAPFront\BAProjeFront\Views\Product\ProductDetails.cshtml"
WriteAttributeValue("", 355, Model.Id, 355, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 365, "\"", 371, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n\t\t\t\t\t\t\t\t<h3>NEW</h3>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"col-sm-8\">\r\n\t\t\t\t\t\t\t<div class=\"product-information\"><!--/product-information-->\r\n\t\t\t\t\t\t\t\t<img src=\"images/product-details/new.jpg\" class=\"newarrival\"");
            BeginWriteAttribute("alt", " alt=\"", 595, "\"", 601, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n\t\t\t\t\t\t\t\t<h2>");
#nullable restore
#line 18 "C:\Users\Emre\Desktop\BAPFront\BAProjeFront\Views\Product\ProductDetails.cshtml"
                               Write(Model.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t<span>\r\n\t\t\t\t\t\t\t\t\t<span>");
#nullable restore
#line 22 "C:\Users\Emre\Desktop\BAPFront\BAProjeFront\Views\Product\ProductDetails.cshtml"
                                     Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" TL</span>\r\n\t\t\t\t\t\t\t\t\t<label>Quantity:</label>\r\n\t\t\t\t\t\t\t\t\t<input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 781, "\"", 809, 1);
#nullable restore
#line 24 "C:\Users\Emre\Desktop\BAPFront\BAProjeFront\Views\Product\ProductDetails.cshtml"
WriteAttributeValue("", 789, Model.StockQuantity, 789, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\t\t\t\t\t\t\t\t\t<button type=\"button\" class=\"btn btn-default add-to-cart\">\r\n\t\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7636855df5c144b4a894be74398ebc320c7c5de36505", async() => {
                WriteLiteral(" \r\n\t\t\t\t\t\t\t\t\t\t\t<i class=\"fa fa-shopping-cart\" ></i>\r\n\t\t\t\t\t\t\t\t\t\t\tAdd to cart\r\n\t\t\t\t\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 26 "C:\Users\Emre\Desktop\BAPFront\BAProjeFront\Views\Product\ProductDetails.cshtml"
                                                                                                 WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t</button>\r\n\t\t\t\t\t\t\t\t</span>\r\n\t\t\t\t\t\t\t\t<p><b>Availability:</b> In Stock</p>\r\n\t\t\t\t\t\t\t\t<p><b>Condition:</b> New</p>\r\n\t\t\t\t\t\t\t\t<p><b>Brand:</b> E-SHOPPER</p>\r\n                                <img src=\"/templateAssets/images/product-details/rating.png\"");
            BeginWriteAttribute("alt", " alt=\"", 1319, "\"", 1325, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n\t\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 1341, "\"", 1348, 0);
            EndWriteAttribute();
            WriteLiteral("><img src=\"/templateAssets/images/product-details/share.png\" class=\"share img-responsive\"");
            BeginWriteAttribute("alt", "  alt=\"", 1438, "\"", 1445, 0);
            EndWriteAttribute();
            WriteLiteral(@" /></a>
							</div><!--/product-information-->
					    </div>
                    </div>
            </div>      
       </div>           
</section>    
					<!--/product-details-->
					
					<div class=""category-tab shop-details-tab""><!--category-tab-->
						<div class=""col-sm-12"">
							<ul class=""nav nav-tabs"">
								<li><a href=""#details"" data-toggle=""tab"">Details</a></li>
								<li class=""active""><a href=""#reviews"" data-toggle=""tab"">Reviews (5)</a></li>
							</ul>
						</div>
						<div class=""tab-content"">
							<div class=""tab-pane fade"" id=""details"" >
								
								<div class=""col-sm-3"">
									<div class=""product-image-wrapper"">
										<div class=""single-products"">
											<div class=""productinfo text-center"">
												<img src=""images/home/gallery3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 2271, "\"", 2277, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
												<h2>$56</h2>
												<p>Easy Polo Black Edition</p>
												<button type=""button"" 
													class=""btn btn-default add-to-cart""><i class=""fa fa-shopping-cart""></i>Details
												</button>
											</div>
										</div>
									</div>
								</div>
								<div class=""col-sm-3"">
									<div class=""product-image-wrapper"">
										<div class=""single-products"">
											<div class=""productinfo text-center"">
												<img src=""images/home/gallery4.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 2791, "\"", 2797, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
												<h2>$56</h2>
												<p>Easy Polo Black Edition</p>
												<button type=""button"" class=""btn btn-default add-to-cart""><i class=""fa fa-shopping-cart""></i>Add to cart</button>
											</div>
										</div>
									</div>
								</div>
							</div>
							
							<div class=""tab-pane fade"" id=""companyprofile"" >
								<div class=""col-sm-3"">
									<div class=""product-image-wrapper"">
										<div class=""single-products"">
											<div class=""productinfo text-center"">
												<img src=""images/home/gallery1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 3367, "\"", 3373, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
												<h2>$56</h2>
												<p>Easy Polo Black Edition</p>
												<button type=""button"" class=""btn btn-default add-to-cart""><i class=""fa fa-shopping-cart""></i>Add to cart</button>
											</div>
										</div>
									</div>
								</div>
								<div class=""col-sm-3"">
									<div class=""product-image-wrapper"">
										<div class=""single-products"">
											<div class=""productinfo text-center"">
												<img src=""images/home/gallery3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 3862, "\"", 3868, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
												<h2>$56</h2>
												<p>Easy Polo Black Edition</p>
												<button type=""button"" class=""btn btn-default add-to-cart""><i class=""fa fa-shopping-cart""></i>Add to cart</button>
											</div>
										</div>
									</div>
								</div>
								<div class=""col-sm-3"">
									<div class=""product-image-wrapper"">
										<div class=""single-products"">
											<div class=""productinfo text-center"">
												<img src=""images/home/gallery2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 4357, "\"", 4363, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
												<h2>$56</h2>
												<p>Easy Polo Black Edition</p>
												<button type=""button"" class=""btn btn-default add-to-cart""><i class=""fa fa-shopping-cart""></i>Add to cart</button>
											</div>
										</div>
									</div>
								</div>
								<div class=""col-sm-3"">
									<div class=""product-image-wrapper"">
										<div class=""single-products"">
											<div class=""productinfo text-center"">
												<img src=""images/home/gallery4.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 4852, "\"", 4858, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
												<h2>$56</h2>
												<p>Easy Polo Black Edition</p>
												<button type=""button"" class=""btn btn-default add-to-cart""><i class=""fa fa-shopping-cart""></i>Add to cart</button>
											</div>
										</div>
									</div>
								</div>
							</div>
							
							<div class=""tab-pane fade"" id=""tag"" >
								<div class=""col-sm-3"">
									<div class=""product-image-wrapper"">
										<div class=""single-products"">
											<div class=""productinfo text-center"">
												<img src=""images/home/gallery1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 5417, "\"", 5423, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
												<h2>$56</h2>
												<p>Easy Polo Black Edition</p>
												<button type=""button"" class=""btn btn-default add-to-cart""><i class=""fa fa-shopping-cart""></i>Add to cart</button>
											</div>
										</div>
									</div>
								</div>
								<div class=""col-sm-3"">
									<div class=""product-image-wrapper"">
										<div class=""single-products"">
											<div class=""productinfo text-center"">
												<img src=""images/home/gallery2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 5912, "\"", 5918, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
												<h2>$56</h2>
												<p>Easy Polo Black Edition</p>
												<button type=""button"" class=""btn btn-default add-to-cart""><i class=""fa fa-shopping-cart""></i>Add to cart</button>
											</div>
										</div>
									</div>
								</div>
								<div class=""col-sm-3"">
									<div class=""product-image-wrapper"">
										<div class=""single-products"">
											<div class=""productinfo text-center"">
												<img src=""images/home/gallery3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 6407, "\"", 6413, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
												<h2>$56</h2>
												<p>Easy Polo Black Edition</p>
												<button type=""button"" class=""btn btn-default add-to-cart""><i class=""fa fa-shopping-cart""></i>Add to cart</button>
											</div>
										</div>
									</div>
								</div>
								<div class=""col-sm-3"">
									<div class=""product-image-wrapper"">
										<div class=""single-products"">
											<div class=""productinfo text-center"">
												<img src=""images/home/gallery4.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 6902, "\"", 6908, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
												<h2>$56</h2>
												<p>Easy Polo Black Edition</p>
												<button type=""button"" class=""btn btn-default add-to-cart""><i class=""fa fa-shopping-cart""></i>Add to cart</button>
											</div>
										</div>
									</div>
								</div>
							</div>
							
							<div class=""tab-pane fade active in"" id=""reviews"" >
								<div class=""col-sm-12"">
									<ul>
										<li><a");
            BeginWriteAttribute("href", " href=\"", 7329, "\"", 7336, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-user\"></i>EUGEN</a></li>\r\n\t\t\t\t\t\t\t\t\t\t<li><a");
            BeginWriteAttribute("href", " href=\"", 7396, "\"", 7403, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-clock-o\"></i>12:41 PM</a></li>\r\n\t\t\t\t\t\t\t\t\t\t<li><a");
            BeginWriteAttribute("href", " href=\"", 7469, "\"", 7476, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-calendar-o\"></i>31 DEC 2014</a></li>\r\n\t\t\t\t\t\t\t\t\t</ul>\r\n\t\t\t\t\t\t\t\t\t<p>");
#nullable restore
#line 192 "C:\Users\Emre\Desktop\BAPFront\BAProjeFront\Views\Product\ProductDetails.cshtml"
                                  Write(Model.ProductDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t\t\t\t\t<p><b>Write Your Review</b></p>\r\n\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7636855df5c144b4a894be74398ebc320c7c5de318321", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t<span>\r\n\t\t\t\t\t\t\t\t\t\t\t<input type=\"text\" placeholder=\"Your Name\"/>\r\n\t\t\t\t\t\t\t\t\t\t\t<input type=\"email\" placeholder=\"Email Address\"/>\r\n\t\t\t\t\t\t\t\t\t\t</span>\r\n\t\t\t\t\t\t\t\t\t\t<textarea");
                BeginWriteAttribute("name", " name=\"", 7847, "\"", 7854, 0);
                EndWriteAttribute();
                WriteLiteral(" ></textarea>\r\n\t\t\t\t\t\t\t\t\t\t<b>Rating: </b> <img src=\"images/product-details/rating.png\"");
                BeginWriteAttribute("alt", " alt=\"", 7940, "\"", 7946, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n\t\t\t\t\t\t\t\t\t\t<button type=\"button\" class=\"btn btn-default pull-right\">\r\n\t\t\t\t\t\t\t\t\t\t\tSubmit\r\n\t\t\t\t\t\t\t\t\t\t</button>\r\n\t\t\t\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
								</div>
							</div>
							
						</div>
					</div><!--/category-tab-->
					
					<div class=""recommended_items""><!--recommended_items-->
						<h2 class=""title text-center"">recommended items</h2>
						
						<div id=""recommended-item-carousel"" class=""carousel slide"" data-ride=""carousel"">
							<div class=""carousel-inner"">
								<div class=""item active"">	
									<div class=""col-sm-4"">
										<div class=""product-image-wrapper"">
											<div class=""single-products"">
												<div class=""productinfo text-center"">
													<img src=""images/home/recommend1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 8687, "\"", 8693, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
													<h2>$56</h2>
													<p>Easy Polo Black Edition</p>
													<button type=""button"" class=""btn btn-default add-to-cart""><i class=""fa fa-shopping-cart""></i>Add to cart</button>
												</div>
											</div>
										</div>
									</div>
									<div class=""col-sm-4"">
										<div class=""product-image-wrapper"">
											<div class=""single-products"">
												<div class=""productinfo text-center"">
													<img src=""images/home/recommend2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 9196, "\"", 9202, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
													<h2>$56</h2>
													<p>Easy Polo Black Edition</p>
													<button type=""button"" class=""btn btn-default add-to-cart""><i class=""fa fa-shopping-cart""></i>Add to cart</button>
												</div>
											</div>
										</div>
									</div>
									<div class=""col-sm-4"">
										<div class=""product-image-wrapper"">
											<div class=""single-products"">
												<div class=""productinfo text-center"">
													<img src=""images/home/recommend3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 9705, "\"", 9711, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
													<h2>$56</h2>
													<p>Easy Polo Black Edition</p>
													<button type=""button"" class=""btn btn-default add-to-cart""><i class=""fa fa-shopping-cart""></i>Add to cart</button>
												</div>
											</div>
										</div>
									</div>
								</div>
								<div class=""item"">	
									<div class=""col-sm-4"">
										<div class=""product-image-wrapper"">
											<div class=""single-products"">
												<div class=""productinfo text-center"">
													<img src=""images/home/recommend1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 10259, "\"", 10265, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
													<h2>$56</h2>
													<p>Easy Polo Black Edition</p>
													<button type=""button"" class=""btn btn-default add-to-cart""><i class=""fa fa-shopping-cart""></i>Add to cart</button>
												</div>
											</div>
										</div>
									</div>
									<div class=""col-sm-4"">
										<div class=""product-image-wrapper"">
											<div class=""single-products"">
												<div class=""productinfo text-center"">
													<img src=""images/home/recommend2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 10768, "\"", 10774, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
													<h2>$56</h2>
													<p>Easy Polo Black Edition</p>
													<button type=""button"" class=""btn btn-default add-to-cart""><i class=""fa fa-shopping-cart""></i>Add to cart</button>
												</div>
											</div>
										</div>
									</div>
									<div class=""col-sm-4"">
										<div class=""product-image-wrapper"">
											<div class=""single-products"">
												<div class=""productinfo text-center"">
													<img src=""images/home/recommend3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 11277, "\"", 11283, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
													<h2>$56</h2>
													<p>Easy Polo Black Edition</p>
													<button type=""button"" class=""btn btn-default add-to-cart""><i class=""fa fa-shopping-cart""></i>Add to cart</button>
												</div>
											</div>
										</div>
									</div>
								</div>
							</div>
							 <a class=""left recommended-item-control"" href=""#recommended-item-carousel"" data-slide=""prev"">
								<i class=""fa fa-angle-left""></i>
							  </a>
							  <a class=""right recommended-item-control"" href=""#recommended-item-carousel"" data-slide=""next"">
								<i class=""fa fa-angle-right""></i>
							  </a>			
						</div>
					</div><!--/recommended_items-->
					
</div>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductListModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
