-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Хост: 10.0.2.30
-- Время создания: Июл 20 2023 г., 17:51
-- Версия сервера: 5.7.37-40
-- Версия PHP: 7.2.34

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `f0833868_akademik`
--

-- --------------------------------------------------------

--
-- Структура таблицы `rawat_jalan`
--

CREATE TABLE `rawat_jalan` (
  `id` int(11) NOT NULL,
  `no_recmd` int(11) NOT NULL,
  `nrp` int(11) NOT NULL,
  `nama` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `nama_dokter` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `biaya` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `hasil_diagnosa` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `harga_obat` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `total` varchar(50) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Дамп данных таблицы `rawat_jalan`
--

INSERT INTO `rawat_jalan` (`id`, `no_recmd`, `nrp`, `nama`, `nama_dokter`, `biaya`, `hasil_diagnosa`, `harga_obat`, `total`) VALUES
(1, 2001, 1001, 'Gunawan', 'Dr.Ridwan', '200000', 'sakit ringan', '300000', '500000'),
(2, 0, 1005, 'Aceng', '', '', '', '', '');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `rawat_jalan`
--
ALTER TABLE `rawat_jalan`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `no_recmd` (`no_recmd`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `rawat_jalan`
--
ALTER TABLE `rawat_jalan`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
