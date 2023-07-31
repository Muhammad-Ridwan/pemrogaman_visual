<?php
require_once 'database.php';

class Rawatjalan
{
    private $db;
    private $table = 'rawat_jalan';
    public $id = "";
    public $no_recmd = "";
    public $nrp = "";
    public $nama = "";
    public $nama_dokter = "";
    public $biaya = "";
    public $hasil_diagnosa = "";
    public $harga_obat = "";
    public $total = "";

    public function __construct(MySQLDatabase $db)
    {
        $this->db = $db;
    }

    public function get_all()
    {
        $query = "SELECT * FROM $this->table";
        $result_set = $this->db->query($query);
        return $result_set;
    }

    public function get_by_id(int $id)
    {
        $query = "SELECT * FROM $this->table WHERE id = $id";
        $result_set = $this->db->query($query);
        return $result_set;
    }

    public function get_by_no_recmd(int $no_recmd)
    {
        $query = "SELECT * FROM $this->table WHERE no_recmd = $no_recmd";
        $result_set = $this->db->query($query);
        return $result_set;
    }

    public function insert(): int
    {
        $query = "INSERT INTO $this->table (`no_recmd`, `nrp`, `nama`, `nama_dokter`, `biaya`, `hasil_diagnosa`, `harga_obat`, `total`)
        VALUES ('$this->no_recmd', '$this->nrp', '$this->nama', '$this->nama_dokter', '$this->biaya', '$this->hasil_diagnosa', '$this->harga_obat', '$this->total')";
        $this->db->query($query);
        return $this->db->insert_id();
    }

    public function update(int $id): int
    {
        $query = "UPDATE $this->table SET no_recmd = '$this->no_recmd', nrp = '$this->nrp', nama = '$this->nama', nama_dokter = '$this->nama_dokter',
        biaya = '$this->biaya', hasil_diagnosa = '$this->hasil_diagnosa', harga_obat = '$this->harga_obat', total = '$this->total' WHERE id = $id";
        $this->db->query($query);
        return $this->db->affected_rows();
    }

    public function update_by_no_recmd($no_recmd): int
    {
        $query = "UPDATE $this->table SET nrp = '$this->nrp', nama = '$this->nama', nama_dokter = '$this->nama_dokter',
        biaya = '$this->biaya', hasil_diagnosa = '$this->hasil_diagnosa', harga_obat = '$this->harga_obat', total = '$this->total' WHERE no_recmd = $no_recmd";
        $this->db->query($query);
        return $this->db->affected_rows();
    }

    public function delete(int $id): int
    {
        $query = "DELETE FROM $this->table WHERE id = $id";
        $this->db->query($query);
        return $this->db->affected_rows();
    }

    public function delete_by_no_recmd($no_recmd): int
    {
        $query = "DELETE FROM $this->table WHERE no_recmd = $no_recmd";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
}
?>
