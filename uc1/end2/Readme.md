## Running locally the stub service with Camel JBang

Ensure Camel JBang is available in your machine

Run it executing the command below:

```
./jrun.sh
```

## Test your local stub service

You can send a `POST` request with the following `curl` command:

>**Note**: it's a dummy stub and the payload to send can be empty

```
curl \
-H "content-type: application/xml" \
-d '' \
http://localhost:8100/camel/subscriber/details
```


## Running the stub service

Run it executing the command below:

```
./run.sh
```

The Camel K operator will create a route to access the service.


## Testing the stub service

You can send a `POST` request with the following `curl` command:

>**Note**: it's a dummy stub and the payload to send can be empty

```
curl \
-H "content-type: application/xml" \
-d '' \
http://`oc get route end2 -o jsonpath='{..spec.host}'`/camel/subscriber/details
```

