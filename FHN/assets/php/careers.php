<?php
session_start(); 
$site_name = "BOOKRA";
if($_POST){
    $first_name=$_POST['first_name'];
    $last_name=$_POST['last_name'];
    $email=$_POST['contact-email'];
    $age=$_POST['age'];
    $salary=$_POST['salary'];
    $website=$_POST['website'];
    $position=$_POST['position'];
    $details=$_POST['details'];
 
if(isset($_POST['contact-email'])) {
    $email_to = "email@your-domain.com";
    $email_subject = "Job Application Recieved from : ".$site_name;
    function died($error) {
        echo "We are very sorry, but there were error(s) found with the form you submitted. ";
        echo "These errors appear below.<br /><br />";
        echo $error."<br /><br />";
        echo "Please go back and fix these errors.<br /><br />";
        die();
    }
    if(!isset($_POST['first_name']) ||
        !isset($_POST['last_name']) ||
        !isset($_POST['contact-email']) ||
        !isset($_POST['age']) ||
        !isset($_POST['salary']) ||
        !isset($_POST['website']) ||
        !isset($_POST['position']) ||
        !isset($_POST['details'])) {
        died('We are sorry, but there appears to be a problem with the form you submitted.');       
    }
    
    $first_name = $_POST['first_name']; // required
    $last_name = $_POST['last_name']; // required
    $email_from = $_POST['contact-email']; // required
    $age = $_POST['age']; // not required
    $salary = $_POST['salary']; // not required
    $website = $_POST['website']; // not required
    $position = $_POST['position']; // required
    $details = $_POST['details']; // required
    $error_message = "";
    $email_exp = '/^[A-Za-z0-9._%-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}$/';
  if(!preg_match($email_exp,$email_from)) {
    $error_message .= 'The Email Address you entered does not appear to be valid.<br />';
  }
  if(strlen($details) < 2) {
    $error_message .= 'The message you entered do not appear to be valid.<br />';
  }
  if(strlen($error_message) > 0) {
    died($error_message);
  }
    //$email_message = '<html><body><div>';
    $email_message = "Contact us message details below: \n\n";
    function clean_string($string) {
      $bad = array("content-type","bcc:","to:","cc:","href");
      return str_replace($bad,"",$string);
    }
    $email_message .= "Name: ".clean_string($first_name)." ".clean_string($last_name)."\n";
    $email_message .= "Email: ".clean_string($email_from)."\n";
    $email_message .= "Position: ".clean_string($position)."\n";
    $email_message .= "Age: ".clean_string($age)."\n";
    $email_message .= "Expected Salary: ".clean_string($salary)."\n";
    $email_message .= "Website: ".clean_string($website)."\n";
    $email_message .= "Details: ".clean_string($details)."\n";
    //$email_message .='</div></body></html>';
    // email header
    $_header = "MIME-Version: 1.0\r\nContent-type: text/plain; charset=UTF-8\r\n";
    $headers = 'From: '.$email_from."\r\n".
    'Reply-To: '.$email_from."\r\n" .
    'X-Mailer: PHP/' . phpversion();
    @mail($email_to, '=?UTF-8?B?'.base64_encode($email_subject).'?=', $email_message, $_header . $headers);  
    $result=1;

    if($result){
        echo "Thanks ".clean_string($name)." We'll get back to you soon.";
    }
}
   
exit();
}
?>