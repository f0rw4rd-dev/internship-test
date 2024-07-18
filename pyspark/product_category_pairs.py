def get_product_category_pairs_and_non_categorized_products(df_products, df_categories, df_product_category_pairs):
    result = df_products \
        .join(df_product_category_pairs, on='product_id', how='left') \
        .join(df_categories, on='category_id', how='left') \
        .select('product_name', 'category_name')

    return result