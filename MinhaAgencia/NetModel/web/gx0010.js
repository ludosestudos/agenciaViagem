gx.evt.autoSkip=!1;gx.define("gx0010",!1,function(){var n,t;this.ServerClass="gx0010";this.PackageName="GeneXus.Programs";this.ServerFullClass="gx0010.aspx";this.setObjectType("web");this.anyGridBaseTable=!0;this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV11pClienteId=gx.fn.getIntegerValue("vPCLIENTEID",".")};this.Validv_Cclienteemail=function(){return this.validCliEvt("Validv_Cclienteemail",0,function(){try{var n=gx.util.balloon.getNew("vCCLIENTEEMAIL");if(this.AnyError=0,!(gx.util.regExp.isMatch(this.AV10cClienteEmail,"^((\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*)|(\\s*))$")||gx.text.compare("",this.AV10cClienteEmail)===0))try{n.setError("O valor de Cliente Email não coincide com o padrão especificado");this.AnyError=gx.num.trunc(1,0)}catch(t){}}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0})};this.e16071_client=function(){return this.clearMessages(),gx.text.compare(gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class"),"AdvancedContainer")==0?(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer AdvancedContainerVisible"),gx.fn.setCtrlProperty("BTNTOGGLE","Class",gx.fn.getCtrlProperty("BTNTOGGLE","Class")+" BtnToggleActive")):(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer"),gx.fn.setCtrlProperty("BTNTOGGLE","Class","BtnToggle")),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]),this.OnClientEventEnd(),gx.$.Deferred().resolve()};this.e11071_client=function(){return this.clearMessages(),gx.text.compare(gx.fn.getCtrlProperty("CLIENTEIDFILTERCONTAINER","Class"),"AdvancedContainerItem")==0?(gx.fn.setCtrlProperty("CLIENTEIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCCLIENTEID","Visible",!0)):(gx.fn.setCtrlProperty("CLIENTEIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCCLIENTEID","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("CLIENTEIDFILTERCONTAINER","Class")',ctrl:"CLIENTEIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCLIENTEID","Visible")',ctrl:"vCCLIENTEID",prop:"Visible"}]),this.OnClientEventEnd(),gx.$.Deferred().resolve()};this.e12071_client=function(){return this.clearMessages(),gx.text.compare(gx.fn.getCtrlProperty("CLIENTENOMEFILTERCONTAINER","Class"),"AdvancedContainerItem")==0?(gx.fn.setCtrlProperty("CLIENTENOMEFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCCLIENTENOME","Visible",!0)):(gx.fn.setCtrlProperty("CLIENTENOMEFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCCLIENTENOME","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("CLIENTENOMEFILTERCONTAINER","Class")',ctrl:"CLIENTENOMEFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCLIENTENOME","Visible")',ctrl:"vCCLIENTENOME",prop:"Visible"}]),this.OnClientEventEnd(),gx.$.Deferred().resolve()};this.e13071_client=function(){return this.clearMessages(),gx.text.compare(gx.fn.getCtrlProperty("CLIENTESOBRENOMEFILTERCONTAINER","Class"),"AdvancedContainerItem")==0?(gx.fn.setCtrlProperty("CLIENTESOBRENOMEFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCCLIENTESOBRENOME","Visible",!0)):(gx.fn.setCtrlProperty("CLIENTESOBRENOMEFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCCLIENTESOBRENOME","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("CLIENTESOBRENOMEFILTERCONTAINER","Class")',ctrl:"CLIENTESOBRENOMEFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCLIENTESOBRENOME","Visible")',ctrl:"vCCLIENTESOBRENOME",prop:"Visible"}]),this.OnClientEventEnd(),gx.$.Deferred().resolve()};this.e14071_client=function(){return this.clearMessages(),gx.text.compare(gx.fn.getCtrlProperty("CLIENTETELEFONEFILTERCONTAINER","Class"),"AdvancedContainerItem")==0?(gx.fn.setCtrlProperty("CLIENTETELEFONEFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCCLIENTETELEFONE","Visible",!0)):(gx.fn.setCtrlProperty("CLIENTETELEFONEFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCCLIENTETELEFONE","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("CLIENTETELEFONEFILTERCONTAINER","Class")',ctrl:"CLIENTETELEFONEFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCLIENTETELEFONE","Visible")',ctrl:"vCCLIENTETELEFONE",prop:"Visible"}]),this.OnClientEventEnd(),gx.$.Deferred().resolve()};this.e15071_client=function(){return this.clearMessages(),gx.text.compare(gx.fn.getCtrlProperty("CLIENTEEMAILFILTERCONTAINER","Class"),"AdvancedContainerItem")==0?(gx.fn.setCtrlProperty("CLIENTEEMAILFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCCLIENTEEMAIL","Visible",!0)):(gx.fn.setCtrlProperty("CLIENTEEMAILFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCCLIENTEEMAIL","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("CLIENTEEMAILFILTERCONTAINER","Class")',ctrl:"CLIENTEEMAILFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCLIENTEEMAIL","Visible")',ctrl:"vCCLIENTEEMAIL",prop:"Visible"}]),this.OnClientEventEnd(),gx.$.Deferred().resolve()};this.e19072_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e20071_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,65,66,67,68,69,70,71,72];this.GXLastCtrlId=72;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",64,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx0010",[],!1,1,!1,!0,10,!0,!1,!1,"",0,"px",0,"px","Novo registro",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);t=this.Grid1Container;t.addBitmap("&Linkselection","vLINKSELECTION",65,0,"px",17,"px",null,"","","SelectionAttribute","WWActionColumn");t.addSingleLineEdit(1,66,"CLIENTEID","Id","","ClienteId","int",0,"px",4,4,"right",null,[],1,"ClienteId",!0,0,!1,!1,"Attribute",1,"WWColumn");t.addSingleLineEdit(2,67,"CLIENTENOME","Nome","","ClienteNome","char",0,"px",20,20,"left",null,[],2,"ClienteNome",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");t.addSingleLineEdit(3,68,"CLIENTESOBRENOME","Sobre Nome","","ClienteSobreNome","char",0,"px",30,30,"left",null,[],3,"ClienteSobreNome",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(5,69,"CLIENTETELEFONE","Telefone","","ClienteTelefone","char",0,"px",20,20,"left",null,[],5,"ClienteTelefone",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");this.Grid1Container.emptyText="";this.setGrid(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAIN",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"ADVANCEDCONTAINER",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"CLIENTEIDFILTERCONTAINER",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"LBLCLIENTEIDFILTER",format:1,grid:0,evt:"e11071_client",ctrltype:"textblock"};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCCLIENTEID",gxz:"ZV6cClienteId",gxold:"OV6cClienteId",gxvar:"AV6cClienteId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6cClienteId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV6cClienteId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCCLIENTEID",gx.O.AV6cClienteId,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6cClienteId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCCLIENTEID",".")},nac:gx.falseFn};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"",grid:0};n[19]={id:19,fld:"CLIENTENOMEFILTERCONTAINER",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"LBLCLIENTENOMEFILTER",format:1,grid:0,evt:"e12071_client",ctrltype:"textblock"};n[23]={id:23,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"",grid:0};n[26]={id:26,lvl:0,type:"char",len:20,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCCLIENTENOME",gxz:"ZV7cClienteNome",gxold:"OV7cClienteNome",gxvar:"AV7cClienteNome",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV7cClienteNome=n)},v2z:function(n){n!==undefined&&(gx.O.ZV7cClienteNome=n)},v2c:function(){gx.fn.setControlValue("vCCLIENTENOME",gx.O.AV7cClienteNome,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV7cClienteNome=this.val())},val:function(){return gx.fn.getControlValue("vCCLIENTENOME")},nac:gx.falseFn};n[27]={id:27,fld:"",grid:0};n[28]={id:28,fld:"",grid:0};n[29]={id:29,fld:"CLIENTESOBRENOMEFILTERCONTAINER",grid:0};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"LBLCLIENTESOBRENOMEFILTER",format:1,grid:0,evt:"e13071_client",ctrltype:"textblock"};n[33]={id:33,fld:"",grid:0};n[34]={id:34,fld:"",grid:0};n[35]={id:35,fld:"",grid:0};n[36]={id:36,lvl:0,type:"char",len:30,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCCLIENTESOBRENOME",gxz:"ZV8cClienteSobreNome",gxold:"OV8cClienteSobreNome",gxvar:"AV8cClienteSobreNome",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV8cClienteSobreNome=n)},v2z:function(n){n!==undefined&&(gx.O.ZV8cClienteSobreNome=n)},v2c:function(){gx.fn.setControlValue("vCCLIENTESOBRENOME",gx.O.AV8cClienteSobreNome,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV8cClienteSobreNome=this.val())},val:function(){return gx.fn.getControlValue("vCCLIENTESOBRENOME")},nac:gx.falseFn};n[37]={id:37,fld:"",grid:0};n[38]={id:38,fld:"",grid:0};n[39]={id:39,fld:"CLIENTETELEFONEFILTERCONTAINER",grid:0};n[40]={id:40,fld:"",grid:0};n[41]={id:41,fld:"",grid:0};n[42]={id:42,fld:"LBLCLIENTETELEFONEFILTER",format:1,grid:0,evt:"e14071_client",ctrltype:"textblock"};n[43]={id:43,fld:"",grid:0};n[44]={id:44,fld:"",grid:0};n[45]={id:45,fld:"",grid:0};n[46]={id:46,lvl:0,type:"char",len:20,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCCLIENTETELEFONE",gxz:"ZV9cClienteTelefone",gxold:"OV9cClienteTelefone",gxvar:"AV9cClienteTelefone",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV9cClienteTelefone=n)},v2z:function(n){n!==undefined&&(gx.O.ZV9cClienteTelefone=n)},v2c:function(){gx.fn.setControlValue("vCCLIENTETELEFONE",gx.O.AV9cClienteTelefone,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV9cClienteTelefone=this.val())},val:function(){return gx.fn.getControlValue("vCCLIENTETELEFONE")},nac:gx.falseFn};n[47]={id:47,fld:"",grid:0};n[48]={id:48,fld:"",grid:0};n[49]={id:49,fld:"CLIENTEEMAILFILTERCONTAINER",grid:0};n[50]={id:50,fld:"",grid:0};n[51]={id:51,fld:"",grid:0};n[52]={id:52,fld:"LBLCLIENTEEMAILFILTER",format:1,grid:0,evt:"e15071_client",ctrltype:"textblock"};n[53]={id:53,fld:"",grid:0};n[54]={id:54,fld:"",grid:0};n[55]={id:55,fld:"",grid:0};n[56]={id:56,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Cclienteemail,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCCLIENTEEMAIL",gxz:"ZV10cClienteEmail",gxold:"OV10cClienteEmail",gxvar:"AV10cClienteEmail",ucs:[],op:[56],ip:[56],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV10cClienteEmail=n)},v2z:function(n){n!==undefined&&(gx.O.ZV10cClienteEmail=n)},v2c:function(){gx.fn.setControlValue("vCCLIENTEEMAIL",gx.O.AV10cClienteEmail,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV10cClienteEmail=this.val())},val:function(){return gx.fn.getControlValue("vCCLIENTEEMAIL")},nac:gx.falseFn};n[57]={id:57,fld:"",grid:0};n[58]={id:58,fld:"GRIDTABLE",grid:0};n[59]={id:59,fld:"",grid:0};n[60]={id:60,fld:"",grid:0};n[61]={id:61,fld:"BTNTOGGLE",grid:0,evt:"e16071_client"};n[62]={id:62,fld:"",grid:0};n[63]={id:63,fld:"",grid:0};n[65]={id:65,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:64,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV5LinkSelection=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5LinkSelection=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(64),gx.O.AV5LinkSelection,gx.O.AV15Linkselection_GXI)},c2v:function(n){gx.O.AV15Linkselection_GXI=this.val_GXI();this.val(n)!==undefined&&(gx.O.AV5LinkSelection=this.val(n))},val:function(n){return gx.fn.getGridControlValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(64))},val_GXI:function(n){return gx.fn.getGridControlValue("vLINKSELECTION_GXI",n||gx.fn.currentGridRowImpl(64))},gxvar_GXI:"AV15Linkselection_GXI",nac:gx.falseFn};n[66]={id:66,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:64,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CLIENTEID",gxz:"Z1ClienteId",gxold:"O1ClienteId",gxvar:"A1ClienteId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A1ClienteId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z1ClienteId=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("CLIENTEID",n||gx.fn.currentGridRowImpl(64),gx.O.A1ClienteId,0)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A1ClienteId=gx.num.intval(this.val(n)))},val:function(n){return gx.fn.getGridIntegerValue("CLIENTEID",n||gx.fn.currentGridRowImpl(64),".")},nac:gx.falseFn};n[67]={id:67,lvl:2,type:"char",len:20,dec:0,sign:!1,ro:1,isacc:0,grid:64,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CLIENTENOME",gxz:"Z2ClienteNome",gxold:"O2ClienteNome",gxvar:"A2ClienteNome",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A2ClienteNome=n)},v2z:function(n){n!==undefined&&(gx.O.Z2ClienteNome=n)},v2c:function(n){gx.fn.setGridControlValue("CLIENTENOME",n||gx.fn.currentGridRowImpl(64),gx.O.A2ClienteNome,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A2ClienteNome=this.val(n))},val:function(n){return gx.fn.getGridControlValue("CLIENTENOME",n||gx.fn.currentGridRowImpl(64))},nac:gx.falseFn};n[68]={id:68,lvl:2,type:"char",len:30,dec:0,sign:!1,ro:1,isacc:0,grid:64,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CLIENTESOBRENOME",gxz:"Z3ClienteSobreNome",gxold:"O3ClienteSobreNome",gxvar:"A3ClienteSobreNome",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A3ClienteSobreNome=n)},v2z:function(n){n!==undefined&&(gx.O.Z3ClienteSobreNome=n)},v2c:function(n){gx.fn.setGridControlValue("CLIENTESOBRENOME",n||gx.fn.currentGridRowImpl(64),gx.O.A3ClienteSobreNome,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A3ClienteSobreNome=this.val(n))},val:function(n){return gx.fn.getGridControlValue("CLIENTESOBRENOME",n||gx.fn.currentGridRowImpl(64))},nac:gx.falseFn};n[69]={id:69,lvl:2,type:"char",len:20,dec:0,sign:!1,ro:1,isacc:0,grid:64,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CLIENTETELEFONE",gxz:"Z5ClienteTelefone",gxold:"O5ClienteTelefone",gxvar:"A5ClienteTelefone",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"tel",v2v:function(n){n!==undefined&&(gx.O.A5ClienteTelefone=n)},v2z:function(n){n!==undefined&&(gx.O.Z5ClienteTelefone=n)},v2c:function(n){gx.fn.setGridControlValue("CLIENTETELEFONE",n||gx.fn.currentGridRowImpl(64),gx.O.A5ClienteTelefone,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A5ClienteTelefone=this.val(n))},val:function(n){return gx.fn.getGridControlValue("CLIENTETELEFONE",n||gx.fn.currentGridRowImpl(64))},nac:gx.falseFn};n[70]={id:70,fld:"",grid:0};n[71]={id:71,fld:"",grid:0};n[72]={id:72,fld:"BTN_CANCEL",grid:0,evt:"e20071_client"};this.AV6cClienteId=0;this.ZV6cClienteId=0;this.OV6cClienteId=0;this.AV7cClienteNome="";this.ZV7cClienteNome="";this.OV7cClienteNome="";this.AV8cClienteSobreNome="";this.ZV8cClienteSobreNome="";this.OV8cClienteSobreNome="";this.AV9cClienteTelefone="";this.ZV9cClienteTelefone="";this.OV9cClienteTelefone="";this.AV10cClienteEmail="";this.ZV10cClienteEmail="";this.OV10cClienteEmail="";this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z1ClienteId=0;this.O1ClienteId=0;this.Z2ClienteNome="";this.O2ClienteNome="";this.Z3ClienteSobreNome="";this.O3ClienteSobreNome="";this.Z5ClienteTelefone="";this.O5ClienteTelefone="";this.AV6cClienteId=0;this.AV7cClienteNome="";this.AV8cClienteSobreNome="";this.AV9cClienteTelefone="";this.AV10cClienteEmail="";this.AV11pClienteId=0;this.A6ClienteEmail="";this.AV5LinkSelection="";this.A1ClienteId=0;this.A2ClienteNome="";this.A3ClienteSobreNome="";this.A5ClienteTelefone="";this.Events={e19072_client:["ENTER",!0],e20071_client:["CANCEL",!0],e16071_client:["'TOGGLE'",!1],e11071_client:["LBLCLIENTEIDFILTER.CLICK",!1],e12071_client:["LBLCLIENTENOMEFILTER.CLICK",!1],e13071_client:["LBLCLIENTESOBRENOMEFILTER.CLICK",!1],e14071_client:["LBLCLIENTETELEFONEFILTER.CLICK",!1],e15071_client:["LBLCLIENTEEMAILFILTER.CLICK",!1]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cClienteId",fld:"vCCLIENTEID",pic:"ZZZ9"},{av:"AV7cClienteNome",fld:"vCCLIENTENOME",pic:""},{av:"AV8cClienteSobreNome",fld:"vCCLIENTESOBRENOME",pic:""},{av:"AV9cClienteTelefone",fld:"vCCLIENTETELEFONE",pic:""},{av:"AV10cClienteEmail",fld:"vCCLIENTEEMAIL",pic:""}],[]];this.EvtParms["'TOGGLE'"]=[[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]];this.EvtParms["LBLCLIENTEIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("CLIENTEIDFILTERCONTAINER","Class")',ctrl:"CLIENTEIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("CLIENTEIDFILTERCONTAINER","Class")',ctrl:"CLIENTEIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCLIENTEID","Visible")',ctrl:"vCCLIENTEID",prop:"Visible"}]];this.EvtParms["LBLCLIENTENOMEFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("CLIENTENOMEFILTERCONTAINER","Class")',ctrl:"CLIENTENOMEFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("CLIENTENOMEFILTERCONTAINER","Class")',ctrl:"CLIENTENOMEFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCLIENTENOME","Visible")',ctrl:"vCCLIENTENOME",prop:"Visible"}]];this.EvtParms["LBLCLIENTESOBRENOMEFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("CLIENTESOBRENOMEFILTERCONTAINER","Class")',ctrl:"CLIENTESOBRENOMEFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("CLIENTESOBRENOMEFILTERCONTAINER","Class")',ctrl:"CLIENTESOBRENOMEFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCLIENTESOBRENOME","Visible")',ctrl:"vCCLIENTESOBRENOME",prop:"Visible"}]];this.EvtParms["LBLCLIENTETELEFONEFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("CLIENTETELEFONEFILTERCONTAINER","Class")',ctrl:"CLIENTETELEFONEFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("CLIENTETELEFONEFILTERCONTAINER","Class")',ctrl:"CLIENTETELEFONEFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCLIENTETELEFONE","Visible")',ctrl:"vCCLIENTETELEFONE",prop:"Visible"}]];this.EvtParms["LBLCLIENTEEMAILFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("CLIENTEEMAILFILTERCONTAINER","Class")',ctrl:"CLIENTEEMAILFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("CLIENTEEMAILFILTERCONTAINER","Class")',ctrl:"CLIENTEEMAILFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCLIENTEEMAIL","Visible")',ctrl:"vCCLIENTEEMAIL",prop:"Visible"}]];this.EvtParms.ENTER=[[{av:"A1ClienteId",fld:"CLIENTEID",pic:"ZZZ9",hsh:!0}],[{av:"AV11pClienteId",fld:"vPCLIENTEID",pic:"ZZZ9"}]];this.EvtParms.GRID1_FIRSTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cClienteId",fld:"vCCLIENTEID",pic:"ZZZ9"},{av:"AV7cClienteNome",fld:"vCCLIENTENOME",pic:""},{av:"AV8cClienteSobreNome",fld:"vCCLIENTESOBRENOME",pic:""},{av:"AV9cClienteTelefone",fld:"vCCLIENTETELEFONE",pic:""},{av:"AV10cClienteEmail",fld:"vCCLIENTEEMAIL",pic:""}],[]];this.EvtParms.GRID1_PREVPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cClienteId",fld:"vCCLIENTEID",pic:"ZZZ9"},{av:"AV7cClienteNome",fld:"vCCLIENTENOME",pic:""},{av:"AV8cClienteSobreNome",fld:"vCCLIENTESOBRENOME",pic:""},{av:"AV9cClienteTelefone",fld:"vCCLIENTETELEFONE",pic:""},{av:"AV10cClienteEmail",fld:"vCCLIENTEEMAIL",pic:""}],[]];this.EvtParms.GRID1_NEXTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cClienteId",fld:"vCCLIENTEID",pic:"ZZZ9"},{av:"AV7cClienteNome",fld:"vCCLIENTENOME",pic:""},{av:"AV8cClienteSobreNome",fld:"vCCLIENTESOBRENOME",pic:""},{av:"AV9cClienteTelefone",fld:"vCCLIENTETELEFONE",pic:""},{av:"AV10cClienteEmail",fld:"vCCLIENTEEMAIL",pic:""}],[]];this.EvtParms.GRID1_LASTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cClienteId",fld:"vCCLIENTEID",pic:"ZZZ9"},{av:"AV7cClienteNome",fld:"vCCLIENTENOME",pic:""},{av:"AV8cClienteSobreNome",fld:"vCCLIENTESOBRENOME",pic:""},{av:"AV9cClienteTelefone",fld:"vCCLIENTETELEFONE",pic:""},{av:"AV10cClienteEmail",fld:"vCCLIENTEEMAIL",pic:""}],[]];this.EvtParms.VALIDV_CCLIENTEEMAIL=[[],[]];this.setVCMap("AV11pClienteId","vPCLIENTEID",0,"int",4,0);t.addRefreshingParm({rfrProp:"Rows",gxGrid:"Grid1"});t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar(this.GXValidFnc[26]);t.addRefreshingVar(this.GXValidFnc[36]);t.addRefreshingVar(this.GXValidFnc[46]);t.addRefreshingVar(this.GXValidFnc[56]);t.addRefreshingParm(this.GXValidFnc[16]);t.addRefreshingParm(this.GXValidFnc[26]);t.addRefreshingParm(this.GXValidFnc[36]);t.addRefreshingParm(this.GXValidFnc[46]);t.addRefreshingParm(this.GXValidFnc[56]);this.Initialize()});gx.wi(function(){gx.createParentObj(this.gx0010)})