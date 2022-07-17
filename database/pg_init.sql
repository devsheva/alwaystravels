-- DROP TABLE IF EXISTS <TABLE_NAME> CASCADE;
-- DROP TABLE IF EXISTS "Travels" CASCADE;
-- DROP TABLE IF EXISTS "Stages" CASCADE;
-- DROP TABLE IF EXISTS "Packages" CASCADE;
-- DROP TABLE IF EXISTS "SP" CASCADE;

-- Travels
CREATE TABLE "Travels" (
    "Id" serial PRIMARY KEY,
    "Title" varchar(128) NOT NULL,
    "StartDate" date NOT NULL,
    "EndDate" date NOT NULL
);

-- Stages
CREATE TABLE "Stages"(
    "Id" serial PRIMARY KEY,
    "Title" varchar(128) NOT NULL,
    "Date" date NOT NULL,
    "TravelId" int REFERENCES "Travels" ("Id")
);

-- Packages
CREATE TABLE "Packages"(
    "Id" serial PRIMARY KEY,
    "Description" text NOT NULL
);

-- Junction table Stages-Packages
CREATE TABLE "SP"(
    "Id" serial PRIMARY KEY,
    "StageId" int REFERENCES "Stages" ("Id"),
    "PackageId" int REFERENCES "Packages" ("Id")
);