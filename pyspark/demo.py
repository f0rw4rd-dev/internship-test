from product_category_pairs import get_product_category_pairs_and_non_categorized_products
from pyspark.sql import SparkSession

import os
import sys

os.environ['PYSPARK_PYTHON'] = sys.executable
os.environ['PYSPARK_DRIVER_PYTHON'] = sys.executable


def main():
    spark = SparkSession \
        .builder \
        .appName('ProductCategoryPairsDemo') \
        .getOrCreate()

    df_products = spark.createDataFrame([
        (1, 'Продукт A'),
        (2, 'Продукт B'),
        (3, 'Продукт C'),
        (4, 'Продукт D'),
        (5, 'Продукт E')
    ], ['product_id', 'product_name'])

    df_categories = spark.createDataFrame([
        (1, 'Категория 1'),
        (2, 'Категория 2'),
        (3, 'Категория 3'),
        (4, 'Категория 4'),
        (5, 'Категория 5'),
    ], ['category_id', 'category_name'])

    df_product_category_pairs = spark.createDataFrame([
        (1, 1),
        (2, 2),
        (2, 4),
        (4, 3),
        (4, 2)
    ], ['product_id', 'category_id'])

    df_pairs = get_product_category_pairs_and_non_categorized_products(df_products, df_categories, df_product_category_pairs)
    print(df_pairs.show())


if __name__ == '__main__':
    main()