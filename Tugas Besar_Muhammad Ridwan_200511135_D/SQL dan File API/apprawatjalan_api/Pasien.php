<?php
require_once 'database.php';

class Pasien 
{
    private $db;
    private $table = 'pasien';
    public $id = "";
    public $nrp = "";
    public $nama = "";
    public $jk = "";
    public $tgl_lahir = "";
    public $alamat = "";
    public $kota = "";

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

    public function get_by_nrp(int $nrp)
    {
        $query = "SELECT * FROM $this->table WHERE nrp = $nrp";
        $result_set = $this->db->query($query);   
        return $result_set;
    }

    public function insert(): int
    {
        $query = "INSERT INTO $this->table (`nrp`, `nama`, `jk`, `tgl_lahir`, `alamat`, `kota`) 
        VALUES ('$this->nrp', '$this->nama', '$this->jk', '$this->tgl_lahir', '$this->alamat', '$this->kota')";
        $this->db->query($query);
        return $this->db->insert_id();
    }

    public function update(int $id): int
    {
        $query = "UPDATE $this->table SET nrp = '$this->nrp', nama = '$this->nama', jk = '$this->jk', tgl_lahir = '$this->tgl_lahir', 
        alamat = '$this->alamat', kota = '$this->kota' WHERE id = $id";
        $this->db->query($query);
        return $this->db->affected_rows();
    }

    public function update_by_nrp($nrp): int
    {
        $query = "UPDATE $this->table SET nrp = '$this->nrp', nama = '$this->nama', jk = '$this->jk', tgl_lahir = '$this->tgl_lahir', 
        alamat = '$this->alamat', kota = '$this->kota' WHERE nrp = $nrp";
        $this->db->query($query);
        return $this->db->affected_rows();
    }

    public function delete(int $id): int
    {
        $query = "DELETE FROM $this->table WHERE id = $id";
        $this->db->query($query);
        return $this->db->affected_rows();
    }

    public function delete_by_nrp($nrp): int
    {
        $query = "DELETE FROM $this->table WHERE nrp = $nrp";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
}
?>