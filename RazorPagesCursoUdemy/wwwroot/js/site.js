// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.
$.validator.methods.number = function (value, element) { return this.optional(element) || /^(?:-?\d+|-?\d{1,3}(?:.\d{3})+)?(?:\,\d+)?$/.test(value) }
// Write your JavaScript code.
