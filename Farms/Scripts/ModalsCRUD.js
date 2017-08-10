function validate() {
    var flag = true;

    $("div input[type='text']").each(function () {
        if (!$(this).val().trim()) {
            AddRemoveClasses($(this).closest("div[class*='form-group']"), "has-error", "has-success");
            flag = false;
        } else {
            AddRemoveClasses($(this).closest("div[class*='form-group']"), "has-success", "has-error");
        }
    });

    var NumberInput = $("div input[type='number']");
    if (!$.isNumeric(NumberInput.val().trim())) {
        AddRemoveClasses(NumberInput.closest("div[class*='form-group']"), "has-error", "has-success");
        flag = false;
    } else {
        AddRemoveClasses(NumberInput.closest("div[class*='form-group']"), "has-success", "has-error");
    }

    return flag;

}