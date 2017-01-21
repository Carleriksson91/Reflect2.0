var R = R || {};

R.Question = {
   Add: function ($form) { 
      var onsuccessfn = function (response) {
         $form.fadeOut(200).html(response).fadeIn(200);
         
      }
      R.Global.AjaxCall($form.attr("action"), $form.attr("method"), $form.serialize(), onsuccessfn);
   }

}