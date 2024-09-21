FROM postgres:latest

# Ustawienie zmiennych środowiskowych
ENV POSTGRES_USER=postgres
ENV POSTGRES_PASSWORD=postgres
ENV POSTGRES_DB=postgres

# Otworzymy niestandardowy port 6432
EXPOSE 6432

# Zmiana domyślnego portu PostgreSQL na 6432
CMD ["postgres", "-p", "6432"]