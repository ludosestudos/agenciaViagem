gx.evt.autoSkip=!1;gx.define("cliente",!1,function(){this.ServerClass="cliente";this.PackageName="GeneXus.Programs";this.ServerFullClass="cliente.aspx";this.setObjectType("trn");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){};this.Valid_Clienteid=function(){return this.validSrvEvt("Valid_Clienteid",0).then(function(n){return n}.closure(this))};this.Valid_Clienteemail=function(){return this.validCliEvt("Valid_Clienteemail",0,function(){try{var n=gx.util.balloon.getNew("CLIENTEEMAIL");if(this.AnyError=0,!gx.util.regExp.isMatch(this.A6ClienteEmail,"^((\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*)|(\\s*))$"))try{n.setError("O valor de Cliente Email não coincide com o padrão especificado");this.AnyError=gx.num.trunc(1,0)}catch(t){}}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0})};this.e11011_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e12011_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68];this.GXLastCtrlId=68;n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAINTABLE",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TITLECONTAINER",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"TITLE",format:0,grid:0,ctrltype:"textblock"};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"FORMCONTAINER",grid:0};n[16]={id:16,fld:"",grid:0};n[17]={id:17,fld:"TOOLBARCELL",grid:0};n[18]={id:18,fld:"",grid:0};n[19]={id:19,fld:"",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"BTN_FIRST",grid:0,evt:"e13011_client",std:"FIRST"};n[22]={id:22,fld:"",grid:0};n[23]={id:23,fld:"BTN_PREVIOUS",grid:0,evt:"e14011_client",std:"PREVIOUS"};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"BTN_NEXT",grid:0,evt:"e15011_client",std:"NEXT"};n[26]={id:26,fld:"",grid:0};n[27]={id:27,fld:"BTN_LAST",grid:0,evt:"e16011_client",std:"LAST"};n[28]={id:28,fld:"",grid:0};n[29]={id:29,fld:"BTN_SELECT",grid:0,evt:"e17011_client",std:"SELECT"};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"",grid:0};n[33]={id:33,fld:"",grid:0};n[34]={id:34,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Clienteid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CLIENTEID",gxz:"Z1ClienteId",gxold:"O1ClienteId",gxvar:"A1ClienteId",ucs:[],op:[59,54,49,44,39],ip:[59,54,49,44,39,34],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A1ClienteId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z1ClienteId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("CLIENTEID",gx.O.A1ClienteId,0)},c2v:function(){this.val()!==undefined&&(gx.O.A1ClienteId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("CLIENTEID",".")},nac:gx.falseFn};n[35]={id:35,fld:"",grid:0};n[36]={id:36,fld:"",grid:0};n[37]={id:37,fld:"",grid:0};n[38]={id:38,fld:"",grid:0};n[39]={id:39,lvl:0,type:"char",len:20,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CLIENTENOME",gxz:"Z2ClienteNome",gxold:"O2ClienteNome",gxvar:"A2ClienteNome",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A2ClienteNome=n)},v2z:function(n){n!==undefined&&(gx.O.Z2ClienteNome=n)},v2c:function(){gx.fn.setControlValue("CLIENTENOME",gx.O.A2ClienteNome,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A2ClienteNome=this.val())},val:function(){return gx.fn.getControlValue("CLIENTENOME")},nac:gx.falseFn};this.declareDomainHdlr(39,function(){});n[40]={id:40,fld:"",grid:0};n[41]={id:41,fld:"",grid:0};n[42]={id:42,fld:"",grid:0};n[43]={id:43,fld:"",grid:0};n[44]={id:44,lvl:0,type:"char",len:30,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CLIENTESOBRENOME",gxz:"Z3ClienteSobreNome",gxold:"O3ClienteSobreNome",gxvar:"A3ClienteSobreNome",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A3ClienteSobreNome=n)},v2z:function(n){n!==undefined&&(gx.O.Z3ClienteSobreNome=n)},v2c:function(){gx.fn.setControlValue("CLIENTESOBRENOME",gx.O.A3ClienteSobreNome,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A3ClienteSobreNome=this.val())},val:function(){return gx.fn.getControlValue("CLIENTESOBRENOME")},nac:gx.falseFn};this.declareDomainHdlr(44,function(){});n[45]={id:45,fld:"",grid:0};n[46]={id:46,fld:"",grid:0};n[47]={id:47,fld:"",grid:0};n[48]={id:48,fld:"",grid:0};n[49]={id:49,lvl:0,type:"svchar",len:1024,dec:0,sign:!1,ro:0,multiline:!0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CLIENTEENDERECO",gxz:"Z4ClienteEndereco",gxold:"O4ClienteEndereco",gxvar:"A4ClienteEndereco",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A4ClienteEndereco=n)},v2z:function(n){n!==undefined&&(gx.O.Z4ClienteEndereco=n)},v2c:function(){gx.fn.setControlValue("CLIENTEENDERECO",gx.O.A4ClienteEndereco,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A4ClienteEndereco=this.val())},val:function(){return gx.fn.getControlValue("CLIENTEENDERECO")},nac:gx.falseFn};this.declareDomainHdlr(49,function(){gx.fn.setCtrlProperty("CLIENTEENDERECO","Link",gx.fn.getCtrlProperty("CLIENTEENDERECO","Enabled")?"":"http://maps.google.com/maps?q="+encodeURIComponent(this.A4ClienteEndereco))});n[50]={id:50,fld:"",grid:0};n[51]={id:51,fld:"",grid:0};n[52]={id:52,fld:"",grid:0};n[53]={id:53,fld:"",grid:0};n[54]={id:54,lvl:0,type:"char",len:20,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CLIENTETELEFONE",gxz:"Z5ClienteTelefone",gxold:"O5ClienteTelefone",gxvar:"A5ClienteTelefone",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A5ClienteTelefone=n)},v2z:function(n){n!==undefined&&(gx.O.Z5ClienteTelefone=n)},v2c:function(){gx.fn.setControlValue("CLIENTETELEFONE",gx.O.A5ClienteTelefone,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A5ClienteTelefone=this.val())},val:function(){return gx.fn.getControlValue("CLIENTETELEFONE")},nac:gx.falseFn};this.declareDomainHdlr(54,function(){});n[55]={id:55,fld:"",grid:0};n[56]={id:56,fld:"",grid:0};n[57]={id:57,fld:"",grid:0};n[58]={id:58,fld:"",grid:0};n[59]={id:59,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Clienteemail,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CLIENTEEMAIL",gxz:"Z6ClienteEmail",gxold:"O6ClienteEmail",gxvar:"A6ClienteEmail",ucs:[],op:[],ip:[59],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A6ClienteEmail=n)},v2z:function(n){n!==undefined&&(gx.O.Z6ClienteEmail=n)},v2c:function(){gx.fn.setControlValue("CLIENTEEMAIL",gx.O.A6ClienteEmail,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A6ClienteEmail=this.val())},val:function(){return gx.fn.getControlValue("CLIENTEEMAIL")},nac:gx.falseFn};this.declareDomainHdlr(59,function(){gx.fn.setCtrlProperty("CLIENTEEMAIL","Link",gx.fn.getCtrlProperty("CLIENTEEMAIL","Enabled")?"":"mailto:"+this.A6ClienteEmail)});n[60]={id:60,fld:"",grid:0};n[61]={id:61,fld:"",grid:0};n[62]={id:62,fld:"",grid:0};n[63]={id:63,fld:"",grid:0};n[64]={id:64,fld:"BTN_ENTER",grid:0,evt:"e11011_client",std:"ENTER"};n[65]={id:65,fld:"",grid:0};n[66]={id:66,fld:"BTN_CANCEL",grid:0,evt:"e12011_client"};n[67]={id:67,fld:"",grid:0};n[68]={id:68,fld:"BTN_DELETE",grid:0,evt:"e18011_client",std:"DELETE"};this.A1ClienteId=0;this.Z1ClienteId=0;this.O1ClienteId=0;this.A2ClienteNome="";this.Z2ClienteNome="";this.O2ClienteNome="";this.A3ClienteSobreNome="";this.Z3ClienteSobreNome="";this.O3ClienteSobreNome="";this.A4ClienteEndereco="";this.Z4ClienteEndereco="";this.O4ClienteEndereco="";this.A5ClienteTelefone="";this.Z5ClienteTelefone="";this.O5ClienteTelefone="";this.A6ClienteEmail="";this.Z6ClienteEmail="";this.O6ClienteEmail="";this.A1ClienteId=0;this.A2ClienteNome="";this.A3ClienteSobreNome="";this.A4ClienteEndereco="";this.A5ClienteTelefone="";this.A6ClienteEmail="";this.Events={e11011_client:["ENTER",!0],e12011_client:["CANCEL",!0]};this.EvtParms.ENTER=[[{postForm:!0}],[]];this.EvtParms.REFRESH=[[],[]];this.EvtParms.VALID_CLIENTEID=[[{av:"A1ClienteId",fld:"CLIENTEID",pic:"ZZZ9"},{av:"Gx_mode",fld:"vMODE",pic:"@!"}],[{av:"A2ClienteNome",fld:"CLIENTENOME",pic:""},{av:"A3ClienteSobreNome",fld:"CLIENTESOBRENOME",pic:""},{av:"A4ClienteEndereco",fld:"CLIENTEENDERECO",pic:""},{av:"A5ClienteTelefone",fld:"CLIENTETELEFONE",pic:""},{av:"A6ClienteEmail",fld:"CLIENTEEMAIL",pic:""},{av:"Gx_mode",fld:"vMODE",pic:"@!"},{av:"Z1ClienteId"},{av:"Z2ClienteNome"},{av:"Z3ClienteSobreNome"},{av:"Z4ClienteEndereco"},{av:"Z5ClienteTelefone"},{av:"Z6ClienteEmail"},{ctrl:"BTN_DELETE",prop:"Enabled"},{ctrl:"BTN_ENTER",prop:"Enabled"}]];this.EvtParms.VALID_CLIENTEEMAIL=[[{av:"A6ClienteEmail",fld:"CLIENTEEMAIL",pic:""}],[]];this.EnterCtrl=["BTN_ENTER"];this.Initialize()});gx.wi(function(){gx.createParentObj(this.cliente)})