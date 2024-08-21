# Define variables
WEBAPP_NAME = ToDoAPICodeBehind
RESOURCE_GROUP = nikolaysm_rg_8481
SKU = F1
TIMESTAMP_FILE = last_action.timestamp

# Default target
.PHONY: all
all: restart

# Target to ensure the timestamp file exists
$(TIMESTAMP_FILE):
	@touch $(TIMESTAMP_FILE)


# Target to deploy or update the web app
.PHONY: deploy
deploy: $(TIMESTAMP_FILE)
	az webapp up --sku $(SKU) --name $(WEBAPP_NAME) --resource-group $(RESOURCE_GROUP)
	@touch $(TIMESTAMP_FILE)
	@echo "Web app deployed or updated and timestamp file updated."

# Target to update the web app settings or configuration
.PHONY: update
update: $(TIMESTAMP_FILE)
	az webapp update --name $(WEBAPP_NAME) --resource-group $(RESOURCE_GROUP)
	@touch $(TIMESTAMP_FILE)
	@echo "Web app updated and timestamp file updated."

# Target to restart the web app
.PHONY: restart
restart: $(TIMESTAMP_FILE)
	az webapp restart --name $(WEBAPP_NAME) --resource-group $(RESOURCE_GROUP)
	@touch $(TIMESTAMP_FILE)
	@echo "Web app restarted and timestamp file updated."

# Target to start the web app
.PHONY: start
start: $(TIMESTAMP_FILE)
	az webapp start --name $(WEBAPP_NAME) --resource-group $(RESOURCE_GROUP)
	@touch $(TIMESTAMP_FILE)
	@echo "Web app started and timestamp file updated."

# Target to stop the web app
.PHONY: stop
stop: $(TIMESTAMP_FILE)
	az webapp stop --name $(WEBAPP_NAME) --resource-group $(RESOURCE_GROUP)
	@touch $(TIMESTAMP_FILE)
	@echo "Web app stopped and timestamp file updated."

# Target to delete the web app
.PHONY: delete
delete:
	az webapp delete --name $(WEBAPP_NAME) --resource-group $(RESOURCE_GROUP)
	@touch $(TIMESTAMP_FILE)
	@echo "Web app deleted."


# Target to show the status of the timestamp file
.PHONY: status
status:
	@echo "Timestamp file: $(TIMESTAMP_FILE)"
	@ls -l $(TIMESTAMP_FILE)