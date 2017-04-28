(function () {
    $(function () {
        var _classTypeService = abp.services.app.classType;

        var _createClassTypeModal = new app.ModalManager({
            viewUrl: abp.appPath + 'Mpa/ClassType/CreateClassTypeModal',
            scriptUrl: abp.appPath + 'Areas/Mpa/Views/ClassType/_CreateClassTypeModal.js',
            modalClass: 'CreateClassTypeModal'
        });

        $('#CreateNewClassTypeButton').click(function (e) {
            e.preventDefault();
            _createClassTypeModal.open();
        });

        $('#AllClassTypesList button.delete-classType').click(function (e) {
            e.preventDefault();

            var $listItem = $(this).closest('.list-group-item');
            var classTypeId = $listItem.attr('data-classType-id');

            abp.message.confirm(
                app.localize('AreYouSureToDeleteTheClassType'),
                function (isConfirmed) {
                    if (isConfirmed) {
                        _classTypeService.deleteClassType({
                            id: classTypeId
                        }).done(function () {
                            abp.notify.info(app.localize('SuccessfullyDeleted'));
                            $listItem.remove();
                        });
                    }
                }
            );
        });

        //Edit classType button
        $('#AllClassTypesList button.edit-classType').click(function (e) {
            e.preventDefault();

            var $listItem = $(this).closest('.list-group-item');

            $listItem
                .toggleClass('classType-editing')
                .siblings().removeClass('classType-editing');
        });

    });
})();