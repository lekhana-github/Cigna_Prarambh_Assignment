import React from "react";

function ProductCatalog() {
  // Scalar data
  const storeName = "TechTrend Innovations";

  // Array data
  const categories = ["Electronics", "Accessories", "Gadgets"];

  // Object data
  const storeInfo = {
    location: "San Francisco, CA",
    founded: 2023,
    rating: 4.8,
  };

  // Array of objects
  const products = [
    { id: 1, name: "Wireless Earbuds", price: 59.99, category: "Electronics" },
    { id: 2, name: "Smart Watch", price: 199.99, category: "Gadgets" },
    { id: 3, name: "Phone Case", price: 19.99, category: "Accessories" },
    { id: 4, name: "Bluetooth Speaker", price: 89.99, category: "Electronics" },
    { id: 5, name: "VR Headset", price: 249.99, category: "Gadgets" },
  ];

  return (
    
    <div className="min-h-screen bg-gray-50 p-6">
        <fieldset>
            
      {/* Store Name */}
      <h1 className="text-4xl font-bold text-center text-blue-600 mb-6">
        {storeName}
      </h1>

      {/* Categories */}
      <div className="flex justify-center gap-3 mb-6 flex-wrap">
        {categories.map((cat, index) => (
          <span
            key={index}
            className="bg-blue-100 text-blue-800 text-sm font-medium px-3 py-1 rounded-full shadow-sm"
          >
            {cat}
          </span>
        ))}
      </div>

      {/* Store Info */}
      <div className="bg-white p-5 rounded-xl shadow-md w-full max-w-md mx-auto mb-8">
        <h2 className="text-lg font-semibold mb-2 text-gray-700">Store Info</h2>
        <p className="text-gray-600">
          📍 <strong>Location:</strong> {storeInfo.location}
        </p>
        <p className="text-gray-600">
          🏗️ <strong>Founded:</strong> {storeInfo.founded}
        </p>
        <p className="text-gray-600">
          ⭐ <strong>Rating:</strong> {storeInfo.rating}
        </p>
      </div>

      {/* Products Section */}
      <h2 className="text-2xl font-semibold text-gray-800 mb-4 text-center">
        Featured Products
      </h2>

      {products.length > 0 ? (
        <div className="grid sm:grid-cols-2 md:grid-cols-3 gap-6">
          {products.map((product) => (
            <div
              key={product.id}
              className="bg-white rounded-xl shadow-md p-4 hover:shadow-lg transition"
            >
              <h3 className="text-lg font-bold text-gray-800 mb-1">
                {product.name}
              </h3>
              <p className="text-gray-600 mb-1">
                Category: <span className="font-medium">{product.category}</span>
              </p>
              <p className="text-green-600 font-semibold">
                ${product.price.toFixed(2)}
              </p>
            </div>
          ))}
        </div>
      ) : (
        <p className="text-center text-gray-500 mt-4">
          No products available.
        </p>
      )}
      </fieldset>
    </div>
  );
}

export default ProductCatalog;