from setuptools import setup, find_packages

dependencies = [
    "pandas==1.0.3",
]

setup(
    name="primavera-carbon-mk",
    version="2.5",
    description="A package that includes several features to detect anomalies in time series",
    author="PRIMAVERABSS-DTX",
    packages=find_packages(exclude=["tests","examples"]),
    install_requires=dependencies,
    include_package_data=True,
    zip_safe=False,
    tests_require=["pytest","pyspark","pandas"],
)
