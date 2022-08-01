kamel run end2.xml --property file:svc.properties \
-t prometheus.enabled=true \
-t tracing.enabled=true \
-t tracing.endpoint=http://jaeger-all-in-one-inmemory-collector.demo-tracing.svc:14268/api/traces
