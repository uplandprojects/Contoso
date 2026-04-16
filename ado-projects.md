# Azure DevOps Projects

This file documents the result of calling the `core_list_projects` MCP server tool.

## Result

The `core_list_projects` tool was invoked to retrieve a list of Azure DevOps projects for the organization.

> **Note:** The `core_list_projects` Azure DevOps MCP server tool was not available in the current agent environment. The available MCP tools were limited to `fetch_workitem` and `add_child_work_items` via the configured ADO agent.

## How to List Projects

To retrieve the list of Azure DevOps projects, you can use:

### Azure DevOps REST API

```http
GET https://dev.azure.com/{organization}/_apis/projects?api-version=7.1
Authorization: Basic <PAT>
```

### Azure CLI

```bash
az devops project list --organization https://dev.azure.com/{organization}
```

### Azure DevOps MCP Server (`core_list_projects`)

When the Azure DevOps MCP server is configured in the agent environment, use the `core_list_projects` tool directly. It requires no input parameters and returns a list of all accessible projects in the configured organization.
