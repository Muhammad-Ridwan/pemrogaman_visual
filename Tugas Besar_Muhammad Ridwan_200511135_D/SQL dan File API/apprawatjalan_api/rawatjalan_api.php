<?php
require_once 'database.php';
require_once 'Rawatjalan.php';

$db = new MySQLDatabase();
$rawat_jalan = new Rawatjalan($db);

$id = 0;
$nrp = 0;

// Check the HTTP request method
$method = $_SERVER['REQUEST_METHOD'];

// Handle the different HTTP methods
switch ($method) {
    case 'GET':
        if (isset($_GET['id'])) {
            $id = $_GET['id'];
        }
        if (isset($_GET['nrp'])) {
            $nrp = $_GET['nrp'];
        }
        
        if ($id > 0) {
            $result = $rawat_jalan->get_by_id($id);
        } elseif ($nrp > 0) {
            $result = $rawat_jalan->get_by_nrp($nrp);
        } else {
            $result = $rawat_jalan->get_all();
        }
       
        $val = array();
        while ($row = $result->fetch_assoc()) {
            $val[] = $row;
        }
        
        header('Content-Type: application/json');
        echo json_encode($val);
        break;
    
    case 'POST':
        // Add a new data
        $rawat_jalan->no_recmd = $_POST['no_recmd'];
        $rawat_jalan->nrp = $_POST['nrp'];
        $rawat_jalan->nama = $_POST['nama'];
        $rawat_jalan->nama_dokter = $_POST['nama_dokter'];
        $rawat_jalan->biaya = $_POST['biaya'];
        $rawat_jalan->hasil_diagnosa = $_POST['hasil_diagnosa'];
        $rawat_jalan->harga_obat = $_POST['harga_obat'];
        $rawat_jalan->total = $_POST['total'];
       
        $rawat_jalan->insert();
        $a = $db->affected_rows();
        
        if ($a > 0) {
            $data['status'] = 'success';
            $data['message'] = 'Data inserted successfully.';
        } else {
            $data['status'] = 'failed';
            $data['message'] = 'Data insertion failed.';
        }
        
        header('Content-Type: application/json');
        echo json_encode($data);
        break;
    
    case 'PUT':
        // Update an existing data
        $_PUT = [];
        parse_str(file_get_contents("php://input"), $_PUT);
        
        if (isset($_GET['id'])) {
            $id = $_GET['id'];
        }
        if (isset($_GET['nrp'])) {
            $nrp = $_GET['nrp'];
        }
        $rawat_jalan->no_recmd = $_PUT['no_recmd'];
        $rawat_jalan->nrp = $_PUT['nrp'];
        $rawat_jalan->nama = $_PUT['nama'];
        $rawat_jalan->nama_dokter = $_PUT['nama_dokter'];
        $rawat_jalan->biaya = $_PUT['biaya'];
        $rawat_jalan->hasil_diagnosa = $_PUT['hasil_diagnosa'];
        $rawat_jalan->harga_obat = $_PUT['harga_obat'];
        $rawat_jalan->total = $_PUT['total'];
        
        if ($id > 0) {
            $rawat_jalan->update($id);
        } elseif ($nrp != "") {
            $rawat_jalan->update_by_nrp($nrp);
        } else {
            // Handle invalid request
        } 
        
        $a = $db->affected_rows();
        
        if ($a > 0) {
            $data['status'] = 'success';
            $data['message'] = 'Data updated successfully.';
        } else {
            $data['status'] = 'failed';
            $data['message'] = 'Data update failed.';
        }
        
        header('Content-Type: application/json');
        echo json_encode($data);
        break;
    
    case 'DELETE':
        // Delete a data
        if (isset($_GET['id'])) {
            $id = $_GET['id'];
        }
        if (isset($_GET['nrp'])) {
            $nrp = $_GET['nrp'];
        }
        
        if ($id > 0) {
            $rawat_jalan->delete($id);
        } elseif ($nrp != "") {
            $rawat_jalan->delete_by_nrp($nrp);
        } else {
            // Handle invalid request
        } 
        
        $a = $db->affected_rows();
        
        if ($a > 0) {
            $data['status'] = 'success';
            $data['message'] = 'Data deleted successfully.';
        } else {
            $data['status'] = 'failed';
            $data['message'] = 'Data delete failed.';
        }
        
        header('Content-Type: application/json');
        echo json_encode($data);
        break;
    
    default:
        header("HTTP/1.0 405 Method Not Allowed");
        break;
}

$db->close();
?>
