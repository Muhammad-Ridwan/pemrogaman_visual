<?php
require_once 'database.php';
require_once 'Dokter.php';

$db = new MySQLDatabase();
$dokter = new Dokter($db);

$id = 0;
$nip = 0;

// Check the HTTP request method
$method = $_SERVER['REQUEST_METHOD'];

// Handle the different HTTP methods
switch ($method) {
    case 'GET':
        if (isset($_GET['id'])) {
            $id = $_GET['id'];
        }
        if (isset($_GET['nip'])) {
            $nip = $_GET['nip'];
        }
        if ($id > 0) {
            $result = $dokter->get_by_id($id);
        } elseif ($nip > 0) {
            $result = $dokter->get_by_nip($nip);
        } else {
            $result = $dokter->get_all();
        }

        $val = array();
        while ($row = $result->fetch_assoc()) {
            $val[] = $row;
        }

        header('Content-Type: application/json');
        echo json_encode($val);
        break;

    case 'POST':
        $data = array();

        if (isset($_POST['nip']) && isset($_POST['nama']) && isset($_POST['jk']) && isset($_POST['spesialis'])) {
            $dokter->nip = $_POST['nip'];
            $dokter->nama = $_POST['nama'];
            $dokter->jk = $_POST['jk'];
            $dokter->spesialis = $_POST['spesialis'];

            $dokter->insert();
            $a = $db->affected_rows();

            if ($a > 0) {
                $data['status'] = 'success';
                $data['message'] = 'Data Dokter created successfully.';
            } else {
                $data['status'] = 'failed';
                $data['message'] = 'Data Dokter not created.';
            }
        } else {
            $data['status'] = 'failed';
            $data['message'] = 'Missing required parameters.';
        }

        header('Content-Type: application/json');
        echo json_encode($data);
        break;

    case 'PUT':
        $data = array();

        // Update an existing data
        $_PUT = [];
        if (isset($_GET['id'])) {
            $id = $_GET['id'];
        }
        if (isset($_GET['nip'])) {
            $nip = $_GET['nip'];
        }
        parse_str(file_get_contents("php://input"), $_PUT);

        if (isset($_PUT['nip']) && isset($_PUT['nama']) && isset($_PUT['jk']) && isset($_PUT['spesialis'])) {
            $dokter->nip = $_PUT['nip'];
            $dokter->nama = $_PUT['nama'];
            $dokter->jk = $_PUT['jk'];
            $dokter->spesialis = $_PUT['spesialis'];

            if ($id > 0) {
                $dokter->update($id);
            } elseif ($nip !== "") {
                $dokter->update_by_nip($nip);
            }

            $a = $db->affected_rows();

            if ($a > 0) {
                $data['status'] = 'success';
                $data['message'] = 'Data Dokter updated successfully.';
            } else {
                $data['status'] = 'failed';
                $data['message'] = 'Data Dokter update failed.';
            }
        } else {
            $data['status'] = 'failed';
            $data['message'] = 'Missing required parameters.';
        }

        header('Content-Type: application/json');
        echo json_encode($data);
        break;

    case 'DELETE':
        $data = array();

        // Delete a user
        if (isset($_GET['id'])) {
            $id = $_GET['id'];
        }
        if (isset($_GET['nip'])) {
            $nip = $_GET['nip'];
        }
        if ($id > 0) {
            $dokter->delete($id);
        } elseif ($nip > 0) {
            $dokter->delete_by_nip($nip);
        }

        $a = $db->affected_rows();

        if ($a > 0) {
            $data['status'] = 'success';
            $data['message'] = 'Data Dokter deleted successfully.';
        } else {
            $data['status'] = 'failed';
            $data['message'] = 'Data Dokter delete failed.';
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