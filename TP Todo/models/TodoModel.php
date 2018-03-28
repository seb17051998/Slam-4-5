<?php

/** @property CI_DB $db 
 * 
 */
class TodoModel extends CI_Model {

    public function __construct() {
        parent::__construct();
    }

    /* crud sur la table todo
     * create
     * read
     * update
     * delete
     * c'est le minimum à mettre en place pour toutes les tables de la base de données
     */

    public function get_By_Id($id) {
        return $this->db->get_where('todo',array('id'=>$id))->row_object();
    }

    public function get_all() {
        return $this->db->get('todo')->result_object();
    }

    public function add($param) {
        $this->db->insert('todo',$param);
        return $this->db->insert_id();
    }

    public function delete($id) {
        $this->db->delete('todo',array('id',$id));
    }

    public function update($id,$param) {
        $this->db->where('id',$id);
        $this->db->update('todo',$param);
    }
    
    

}