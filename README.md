# Access Control Platform

Internal administration platform to manage users, roles and permissions.

---

## What is this project?

Access Control Platform is an internal admin panel used to control who can access an application and what actions each user can perform.

It is designed as a typical company backoffice where administrators can:
- Create and manage users
- Assign roles and permissions
- Track user actions through an audit log

This type of application is commonly used in companies, public institutions and enterprise environments.

---

## Main features

- User authentication
- Role-based access control (RBAC)
- Permission management
- Audit log of user actions
- Health check endpoint for monitoring

---

## Tech stack

- Backend: ASP.NET Core Web API
- Frontend: Angular (planned)
- Database: PostgreSQL
- Infrastructure: Docker & Docker Compose
- Version control: Git & GitHub

---

## Project structure

```
access-control-platform/
├─ src/
│  ├─ api/                # ASP.NET Core Web API
│  │  └─ AccessControl.Api
│  └─ web/                # Angular application (planned)
├─ infra/
│  └─ docker/             # Docker configuration
├─ README.md
└─ .gitignore
```

---

## Running the API locally

From the project root:

```bash
cd src/api/AccessControl.Api
dotnet run
```

The API will start on HTTP and HTTPS ports.

### Health check endpoint

```
GET /health
```

If the API is running correctly, it will return:

```json
{ "status": "ok" }
```

---

## Project status

This project is under active development.
New features will be added incrementally following a real-world development workflow.