
Local test:

	Run with Camel JBang

		camel run submit-fulfillment.xml

	Test with:

curl \
-H "content-type: application/json" \
-d '{"status": "completed","system_id": "system1","identifier": "100"}' \
http://localhost:8080/submit/fulfillment


Remote test

curl \
-H "content-type: application/json" \
-d '{"id":"123"}' \
http://`oc get route api-medium -o jsonpath='{..spec.host}'`/submit/fulfillment