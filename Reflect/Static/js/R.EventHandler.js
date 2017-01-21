var R = R || {};

R.EventHandler = {
   Init: function () {
      
      $("body").on("click", "[type='submit']", function (event) {
         event.preventDefault();
         
         var $form = $(this).closest("form");
         R.Question.Add($form);
      });

      $("body").on("click", ".vexmodal", function () {
         R.Global.CreateModal();
      });
   }


}