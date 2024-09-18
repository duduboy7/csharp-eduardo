-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 16-Jun-2022 às 03:05
-- Versão do servidor: 10.4.21-MariaDB
-- versão do PHP: 7.3.31

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `urna`
--
CREATE DATABASE IF NOT EXISTS `urna` DEFAULT CHARACTER SET utf8 COLLATE utf8_swedish_ci;
USE `urna`;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tab_admin`
--

CREATE TABLE `tab_admin` (
  `id_admin` int(11) NOT NULL,
  `nome` varchar(50) CHARACTER SET utf8mb4 NOT NULL,
  `email` varchar(50) CHARACTER SET utf8mb4 NOT NULL,
  `login` varchar(20) CHARACTER SET utf8mb4 NOT NULL,
  `senha` varchar(200) CHARACTER SET utf8mb4 NOT NULL,
  `frase_seguranca` varchar(200) CHARACTER SET utf8mb4 NOT NULL,
  `nivel` int(11) NOT NULL,
  `ativo` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_swedish_ci;

--
-- Extraindo dados da tabela `tab_admin`
--

INSERT INTO `tab_admin` (`id_admin`, `nome`, `email`, `login`, `senha`, `frase_seguranca`, `nivel`, `ativo`) VALUES
(1, 'Eduardo', 'eduuhbr007@gmail.com', 'admin', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 'padrao', 1, 1),
(2, 'Vinicin JR', 'vinicin@paiva.com', 'vinicin', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 'padrao', 0, 0);

-- --------------------------------------------------------

--
-- Estrutura da tabela `tab_candidato`
--

CREATE TABLE `tab_candidato` (
  `id_candidato` int(10) NOT NULL,
  `nome` varchar(50) COLLATE utf8_swedish_ci NOT NULL,
  `numero` int(3) NOT NULL,
  `partido` varchar(50) COLLATE utf8_swedish_ci NOT NULL,
  `foto` varchar(50) COLLATE utf8_swedish_ci NOT NULL,
  `ativo` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_swedish_ci;

--
-- Extraindo dados da tabela `tab_candidato`
--

INSERT INTO `tab_candidato` (`id_candidato`, `nome`, `numero`, `partido`, `foto`, `ativo`) VALUES
(4, 'Sub-Zero', 10, 'Lin Kuei', 'sub-zero.png', 1),
(5, 'Scorpion', 20, 'Shirai Ryu', 'scorpion.png', 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `tab_eleitor`
--

CREATE TABLE `tab_eleitor` (
  `id_eleitor` int(10) NOT NULL,
  `identificacao` varchar(100) COLLATE utf8_swedish_ci NOT NULL,
  `numero` int(2) NOT NULL,
  `partido` int(9) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_swedish_ci;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tab_votos`
--

CREATE TABLE `tab_votos` (
  `id_voto` int(11) NOT NULL,
  `id_candidato` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_swedish_ci;

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `tab_admin`
--
ALTER TABLE `tab_admin`
  ADD PRIMARY KEY (`id_admin`);

--
-- Índices para tabela `tab_candidato`
--
ALTER TABLE `tab_candidato`
  ADD PRIMARY KEY (`id_candidato`);

--
-- Índices para tabela `tab_eleitor`
--
ALTER TABLE `tab_eleitor`
  ADD PRIMARY KEY (`id_eleitor`);

--
-- Índices para tabela `tab_votos`
--
ALTER TABLE `tab_votos`
  ADD PRIMARY KEY (`id_voto`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `tab_admin`
--
ALTER TABLE `tab_admin`
  MODIFY `id_admin` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de tabela `tab_candidato`
--
ALTER TABLE `tab_candidato`
  MODIFY `id_candidato` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de tabela `tab_eleitor`
--
ALTER TABLE `tab_eleitor`
  MODIFY `id_eleitor` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `tab_votos`
--
ALTER TABLE `tab_votos`
  MODIFY `id_voto` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
