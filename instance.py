import boto3
import sys

region = sys.argv[1]
access_key = sys.argv[2]
secret_key = sys.argv[3]

client = boto3.client('ec2',region_name=region,aws_access_key_id=access_key,aws_secret_access_key=secret_key)

data1 = client.describe_instances()
for data2 in data1["Reservations"]:
	for data3 in data2["Instances"]:
		print(data3["InstanceId"])