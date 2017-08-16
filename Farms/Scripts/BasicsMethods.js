function addAndRemoveClassByIdElem(elementIdentifier, classToAdd, classToRemove) {
    $(elementIdentifier).addClass(classToAdd).removeClass(classToRemove);
}

function ShowHide(tr, closeIt) {
    var row = $table.row(tr);

    if (row.child.isShown() || closeIt) {
        //Child is opened, so close it
        row.child.hide();
        tr.removeClass("shown");
    } else {
        //Child is closed, so open it
        row.child(ExtractInfo(row.data().Id)).show();
        tr.addClass("shown");
    }
}

function ModifyDeleteModal(index) {
    $("#IdDeleter").val(index);
}