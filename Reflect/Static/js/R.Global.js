var R = R || {};

R.Global = {
   AjaxCall: function (url, method, data, onsuccessfn, datatype, contenttype, onerrorfn) {
      method = method || "Get";
      datatype = datatype || "Html";
      var onerrorfn = onerrorfn || function () {

      };
      $.ajax({
         url: url,
         method: method,
         data: data,
         dataType: datatype,
         contentType: contenttype,
         success: onsuccessfn,
         error: onerrorfn
      });
   },

   CreateModal: function (message) {
      vex.defaultOptions.className = 'vex-theme-os'
      vex.dialog.alert({
         message: 'Testing the wireframe theme.',
         className: 'vex-theme-flat-attack' // Overwrites defaultOptions,

      })
   }
}