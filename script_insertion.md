-- Insertion de données dans la table User
INSERT INTO [User] (Name) VALUES 
('Alice Smith'),
('Bob Johnson'),
('Charlie Brown');

-- Insertion de données dans la table UserProfile
INSERT INTO [UserProfile] (Biography, ProfilePictureUrl, UserId) VALUES
('Alice est une développeuse full-stack passionnée par le cloud computing.', 'https://example.com/alice.jpg', 1),
('Bob est un analyste de données qui adore les défis mathématiques.', 'https://example.com/bob.jpg', 2),
('Charlie est un designer UI/UX créatif avec une passion pour l’art numérique.', 'https://example.com/charlie.jpg', 3);


-- Insertion des catégories dans la table Category
INSERT INTO [Categories] (Name) VALUES
('Électronique'),
('Vêtements'),
('Meubles');

-- Insertion des produits dans la table Product
INSERT INTO [Products] (Name, Price, CategoryId) VALUES
('Télévision', 499.99, 1),
('Ordinateur portable', 899.99, 1),
('T-shirt', 19.99, 2),
('Jean', 39.99, 2),
('Canapé', 299.99, 3),
('Table basse', 99.99, 3);