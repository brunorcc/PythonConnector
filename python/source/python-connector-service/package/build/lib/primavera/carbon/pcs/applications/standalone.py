import pandas as pd
import json


def calculate_anomalies(input_str, input_file, output_file):
    json_input = json.loads(input_str)
    with open(output_file, 'w') as json_file:
        json.dump(json_input, json_file, indent=4, sort_keys=True)
    dataframe = pd.read_csv(input_file)
    json_txt = dataframe.to_json(orient="records")
    return json_txt
