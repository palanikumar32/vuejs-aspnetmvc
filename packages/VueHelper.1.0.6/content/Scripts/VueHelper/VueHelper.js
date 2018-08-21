Vue.component('v-select', VueSelect.VueSelect);
Vue.component('vue-numeric', VueNumeric.default);
Vue.component('v-datepicker', vuejsDatepicker);
$.postData = function (url, data, callBack) {
    $.post(url, data && data instanceof Object ? encodeData(cloneObject(data)) : data, function (res) {
        if (!callBack) return;
        callBack(res && res instanceof Object ? decodeData(res) : res);
    });
};
$.select = function (json, prop) {
    var obj = [];
    $(json).each(function () {
        obj.push(this[prop]);
    });
    return obj;
};
function encodeData(data) {
    if (data && data instanceof Object) {
        for (var prop in data) {
            if (data[prop] instanceof Date) {
                data[prop] = data[prop].toJSON();
            }
            else if (data[prop] instanceof Object)
                data[prop] = encodeData(data[prop]);
            else if (typeof data[prop] === "string" && /<[a-z][\s\S]*>/i.test(data[prop]))
                data[prop] = encodeURIComponent(data[prop]);
        }
    }
    return data;
}
function decodeData(data) {
    if (data && data instanceof Object) {
        for (var prop in data) {
            if (typeof data[prop] === "string" && data[prop].indexOf('/Date') === 0) {
                data[prop] = JDate(data[prop]);
            }
            else if (data[prop] instanceof Object)
                data[prop] = decodeData(data[prop]);
        }
    }
    return data;
}
function JDate(jDate) {
    return !jDate || jDate instanceof Date || jDate.indexOf('/') < 0 ? jDate : new Date(parseInt(jDate.substr(6)));
}
function cloneObject(obj) {
    return JSON.parse(JSON.stringify(decodeData(obj)));
}