// https://github.com/CodeSeven/toastr
// https://codeseven.github.io/toastr/

window.ShowToastr = (type, message) => {
    if (type === "success") {
        toastr.success(message, "Operación correcta", { timeOut: 10000 });
    }
    if (type === "error") {
        toastr.error(message, "Operación fallida", { timeOut: 10000 });
    }

    if (type === "info") {
        toastr.info(message, "Información de la operación", { timeOut: 10000 });
    }

    if (type === "warning") {
        toastr.warning(message, "Warning en la operación", { timeOut: 10000 });
    }
};