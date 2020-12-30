from primavera.carbon.ads import applications, configurations, models, utilities
from primavera.carbon.ads.applications.modules.schema import ID_COLUMN, DATE_COLUMN, FEATURE_COLUMN

__all__ = ['applications', 'configurations','models', 'utilities']


def help():

    import textwrap
    from primavera.carbon.ads.models.algorithms.algorithms_enum import SwAlgorithm

    print(
        textwrap.dedent(
            """

    Anomaly Detection Application.
    This application will detect anomalies given a DataFrame and a selected Algorithm.
    A DataFrame with the following Schema is expected

    +-------+-------------------+------------------+
    |{id}     |               {date}|           {feature}|
    +-------+-------------------+------------------+
    |string |          timestamp|             float|
    +-------+-------------------+------------------+

    Example:

    +-------+-------------------+------------------+
    |{id}     |               {date}|           {feature}|
    +-------+-------------------+------------------+
    |E_11877|2013-01-05 00:00:00|              70.0|
    |E_11877|2014-07-14 00:00:00|240.83085781048382|
    |E_11877|2014-08-11 00:00:00|289.61182751944125|
    +-------+-------------------+------------------+

    Available Algorithms:
    """.format(
                id=ID_COLUMN, date=DATE_COLUMN, feature=FEATURE_COLUMN
            )
        )
    )

    available_algorithms = [x.value for x in SwAlgorithm]
    print(*available_algorithms, sep="\n")
