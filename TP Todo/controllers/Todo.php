<?php

/** @property TodoModel  $todoModel 
 * 
 */
class Todo extends CI_Controller {

    public function __construct() {
        parent::__construct();
        $this->load->model('todoModel');
        $this->load->helper('url','form');
        $this->load->library('form_validation');
                
    }

    public function index() {
        /* 1- charger les données */
        $all_todo=array();
        $all_todo=$this->todoModel->get_all();

        /* 2- préparer les données pour la vue */
        $data=array();
        $data['titre']="Liste de mes travaux";
        $data['todos']=$all_todo;

        /* 3- générer la vue et la réstituer à l'utilisateur */
        $this->load->view('TodoIndex',$data);
    }
    
    public function fait($id){
        $param=array('completed'=>1);
        $this->todoModel->update($id, $param);
        redirect(base_url('Todo'));
    }
    
    public function add(){
                $this->form_validation->set_rules('ordre','ordre','required|numeric');
                $this->form_validation->set_rules('ordre','ordre','required|max_length[66]');
                                if($this->form_validation->run()==true){
                                    $task=$this->input->post('task');
                                    $ordre=$this->input->post('ordre');
                                    $param=array('task'=>$task,'ordre'=>$ordre,'completed'=>0);
                                    $this->todoModel->add($param);
                                    $this->load->view('TodoAdd');
                                    redirect(base_url("Todo"));
                                }
                                else{
                                    $this->load->view('TodoAdd');
                                    
                                }
    }
    
    public function update($id){
        $this->form_validation->set_rules('ordre','ordre','required|numeric');
        $this->form_validation->set_rules('ordre','ordre','required|max_length[66]');
                if($this->form_validation->run()==true){
                    
                    $task=$this->input->post('task');
                    $ordre=$this->input->post('ordre');
                    $param=array('task'=>$task,'ordre'=>$ordre);
                    $this->todoModel->update($id, $param);
                    $this->load->view('TodoModifier');
                    redirect(base_url("Todo"));
                }
                else{
                   echo "Vous modifiez sur l'id= $id";
                   
                   $this->todoModel->get_By_Id($id);
                   $this->load->view('TodoModifier'); 
                }
        
        
    }
    

}