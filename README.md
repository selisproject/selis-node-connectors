## Depositor Order Adapter

The depositor order adapter is the main adapter used in the Supply Chain Visibility interfaces. It handles the transformation of Customers, Products, Depositor Orders, as well as the final Invoices from a specified directory. After the parsing is complete , the items are transformed to the SELIS SCV data models and then published to the PubSub in JSON format as a .csv message. 


## ThreePL Adapter

The ThreePL adapter  handles the transformation of answers to depositor orders sent after the depositor orders are received. After the parsing is complete , the items are transformed to the SELIS SCV data models and then published to the PubSub in JSON format as a .csv message. 

## PoD Adapter

The PoD adapter handles the transformation of Proof of Delivery documents sent after the depositor orders are invoiced and delivered. After the parsing is complete , the items are transformed to the SELIS SCV data models and then published to the PubSub in JSON format as a .csv message. 

## OrderWMS Adapter

The OrderWMS Adapter parses .csv files containing Orders sourced from WMS systems, transforms them to the SELIS SCV model and publishes them to the configured pubsub in JSON format as a .csv message.


## Usage

All adapters contain sample files working with the various parsing methods.

