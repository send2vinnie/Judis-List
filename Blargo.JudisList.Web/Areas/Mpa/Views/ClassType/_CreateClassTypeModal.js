(function ($) {
    app.modals.CreateClassTypeModal = function () {

        var _modalManager;
        var _classTypeService = abp.services.app.classType;
        var _$form = null;

        this.init = function (modalManager) {
            _modalManager = modalManager;

            _$form = _modalManager.getModal().find('form');
            _$form.validate();
        };

        this.save = function () {
            if (!_$form.valid()) {
                return;
            }

            var classType = _$form.serializeFormToObject();

            _modalManager.setBusy(true);
            _classTypeService.createClassType(classType).done(function () {
                _modalManager.close();
                location.reload();
            }).always(function () {
                _modalManager.setBusy(false);
            });
        };
    };
})(jQuery);