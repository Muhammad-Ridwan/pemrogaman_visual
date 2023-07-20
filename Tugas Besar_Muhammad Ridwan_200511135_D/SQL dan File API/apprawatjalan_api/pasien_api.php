<?php
require_once 'database.php';
require_once 'Pasien.php';

$db = new MySQLDatabase();
$pasien = new Pasien($db);

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
            $result = $pasien->get_by_id($id);
        } elseif ($nrp > 0) {
            $result = $pasien->get_by_nrp($nrp);
        } else {
            $result = $pasien->get_all();
        }
       
        $val = array();
        while ($row = $result->fetch_assoc()) {
            $val[] = $row;
        }
        
        header('Content-Type: application/json');
        echo json_encode($val);
        break;
    
    case 'POST':
        // Add a new pasien
        $pasien->nrp = $_POST['nrp'];
        $pasien->nama = $_POST['nama'];
        $pasien->jk = $_POST['jk'];
        $pasien->tgl_lahir = $_POST['tgl_lahir'];
        $pasien->alamat = $_POST['alamat'];
        $pasien->kota = $_POST['kota'];
       
        $pasien->insert();
        $a = $db->affected_rows();
        
        if ($a > 0) {
            $data['status'] = 'success';
            $data['message'] = 'Data Pasien created successfully.';
        } else {
            $data['status'] = 'failed';
            $data['message'] = 'Data Pasien not created.';
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
        
        $pasien->nrp = $_PUT['nrp'];
        $pasien->nama = $_PUT['nama'];
        $pasien->jk = $_PUT['jk'];
        $pasien->tgl_lahir = $_PUT['tgl_lahir'];
        $pasien->alamat = $_PUT['alamat'];
        $pasien->kota = $_PUT['kota'];
        
        if ($id > 0) {
            $pasien->update($id);
        } elseif ($nrp != "") {
            $pasien->update_by_nrp($nrp);
        } else {
            // Handle invalid request
        } 
        
        $a = $db->affected_rows();
        
        if ($a > 0) {
            $data['status'] = 'success';
            $data['message'] = 'Data Pasien updated successfully.';
        } else {
            $data['status'] = 'failed';
            $data['message'] = 'Data Pasien update failed.';
        }
        
        header('Content-Type: application/json');
        echo json_encode($data);
        break;
    
    case 'DELETE':
        // Delete a user
        if (isset($_GET['id'])) {
            $id = $_GET['id'];
        }
        if (isset($_GET['nrp'])) {
            $nrp = $_GET['nrp'];
        }
        
        if ($id > 0) {
            $pasien->delete($id);
        } elseif ($nrp != "") {
            $pasien->delete_by_nrp($nrp);
        } else {
            // Handle invalid request
        } 
        
        $a = $db->affected_rows();
        
        if ($a > 0) {
            $data['status'] = 'success';
            $data['message'] = 'Data Pasien deleted successfully.';
        } else {
            $data['status'] = 'failed';
            $data['message'] = 'Data Pasien delete failed.';
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