kamel run end1.xml \
-t prometheus.enabled=true \
-t tracing.enabled=true \
-t tracing.endpoint=http://jaeger-all-in-one-inmemory-collector.demo-tracing.svc:14268/api/traces
