gx.evt.autoSkip=!1;gx.define("gx0040",!1,function(){var n,t;this.ServerClass="gx0040";this.PackageName="GeneXus.Programs";this.ServerFullClass="gx0040.aspx";this.setObjectType("web");this.anyGridBaseTable=!0;this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV8pCategoriaId=gx.fn.getIntegerValue("vPCATEGORIAID",".")};this.e130a1_client=function(){return this.clearMessages(),gx.text.compare(gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class"),"AdvancedContainer")==0?(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer AdvancedContainerVisible"),gx.fn.setCtrlProperty("BTNTOGGLE","Class",gx.fn.getCtrlProperty("BTNTOGGLE","Class")+" BtnToggleActive")):(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer"),gx.fn.setCtrlProperty("BTNTOGGLE","Class","BtnToggle")),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]),this.OnClientEventEnd(),gx.$.Deferred().resolve()};this.e110a1_client=function(){return this.clearMessages(),gx.text.compare(gx.fn.getCtrlProperty("CATEGORIAIDFILTERCONTAINER","Class"),"AdvancedContainerItem")==0?(gx.fn.setCtrlProperty("CATEGORIAIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCCATEGORIAID","Visible",!0)):(gx.fn.setCtrlProperty("CATEGORIAIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCCATEGORIAID","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("CATEGORIAIDFILTERCONTAINER","Class")',ctrl:"CATEGORIAIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCATEGORIAID","Visible")',ctrl:"vCCATEGORIAID",prop:"Visible"}]),this.OnClientEventEnd(),gx.$.Deferred().resolve()};this.e120a1_client=function(){return this.clearMessages(),gx.text.compare(gx.fn.getCtrlProperty("CATEGORIANOMEFILTERCONTAINER","Class"),"AdvancedContainerItem")==0?(gx.fn.setCtrlProperty("CATEGORIANOMEFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCCATEGORIANOME","Visible",!0)):(gx.fn.setCtrlProperty("CATEGORIANOMEFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCCATEGORIANOME","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("CATEGORIANOMEFILTERCONTAINER","Class")',ctrl:"CATEGORIANOMEFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCATEGORIANOME","Visible")',ctrl:"vCCATEGORIANOME",prop:"Visible"}]),this.OnClientEventEnd(),gx.$.Deferred().resolve()};this.e160a2_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e170a1_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,35,36,37,38,39,40];this.GXLastCtrlId=40;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",34,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx0040",[],!1,1,!1,!0,10,!0,!1,!1,"",0,"px",0,"px","Novo registro",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);t=this.Grid1Container;t.addBitmap("&Linkselection","vLINKSELECTION",35,0,"px",17,"px",null,"","","SelectionAttribute","WWActionColumn");t.addSingleLineEdit(11,36,"CATEGORIAID","Id","","CategoriaId","int",0,"px",4,4,"right",null,[],11,"CategoriaId",!0,0,!1,!1,"Attribute",1,"WWColumn");t.addSingleLineEdit(12,37,"CATEGORIANOME","Nome","","CategoriaNome","char",0,"px",20,20,"left",null,[],12,"CategoriaNome",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");this.Grid1Container.emptyText="";this.setGrid(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAIN",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"ADVANCEDCONTAINER",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"CATEGORIAIDFILTERCONTAINER",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"LBLCATEGORIAIDFILTER",format:1,grid:0,evt:"e110a1_client",ctrltype:"textblock"};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCCATEGORIAID",gxz:"ZV6cCategoriaId",gxold:"OV6cCategoriaId",gxvar:"AV6cCategoriaId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6cCategoriaId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV6cCategoriaId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCCATEGORIAID",gx.O.AV6cCategoriaId,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6cCategoriaId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCCATEGORIAID",".")},nac:gx.falseFn};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"",grid:0};n[19]={id:19,fld:"CATEGORIANOMEFILTERCONTAINER",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"LBLCATEGORIANOMEFILTER",format:1,grid:0,evt:"e120a1_client",ctrltype:"textblock"};n[23]={id:23,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"",grid:0};n[26]={id:26,lvl:0,type:"char",len:20,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCCATEGORIANOME",gxz:"ZV7cCategoriaNome",gxold:"OV7cCategoriaNome",gxvar:"AV7cCategoriaNome",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV7cCategoriaNome=n)},v2z:function(n){n!==undefined&&(gx.O.ZV7cCategoriaNome=n)},v2c:function(){gx.fn.setControlValue("vCCATEGORIANOME",gx.O.AV7cCategoriaNome,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV7cCategoriaNome=this.val())},val:function(){return gx.fn.getControlValue("vCCATEGORIANOME")},nac:gx.falseFn};n[27]={id:27,fld:"",grid:0};n[28]={id:28,fld:"GRIDTABLE",grid:0};n[29]={id:29,fld:"",grid:0};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"BTNTOGGLE",grid:0,evt:"e130a1_client"};n[32]={id:32,fld:"",grid:0};n[33]={id:33,fld:"",grid:0};n[35]={id:35,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV5LinkSelection=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5LinkSelection=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(34),gx.O.AV5LinkSelection,gx.O.AV12Linkselection_GXI)},c2v:function(n){gx.O.AV12Linkselection_GXI=this.val_GXI();this.val(n)!==undefined&&(gx.O.AV5LinkSelection=this.val(n))},val:function(n){return gx.fn.getGridControlValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(34))},val_GXI:function(n){return gx.fn.getGridControlValue("vLINKSELECTION_GXI",n||gx.fn.currentGridRowImpl(34))},gxvar_GXI:"AV12Linkselection_GXI",nac:gx.falseFn};n[36]={id:36,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CATEGORIAID",gxz:"Z11CategoriaId",gxold:"O11CategoriaId",gxvar:"A11CategoriaId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A11CategoriaId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z11CategoriaId=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("CATEGORIAID",n||gx.fn.currentGridRowImpl(34),gx.O.A11CategoriaId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A11CategoriaId=gx.num.intval(this.val(n)))},val:function(n){return gx.fn.getGridIntegerValue("CATEGORIAID",n||gx.fn.currentGridRowImpl(34),".")},nac:gx.falseFn};n[37]={id:37,lvl:2,type:"char",len:20,dec:0,sign:!1,ro:1,isacc:0,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CATEGORIANOME",gxz:"Z12CategoriaNome",gxold:"O12CategoriaNome",gxvar:"A12CategoriaNome",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A12CategoriaNome=n)},v2z:function(n){n!==undefined&&(gx.O.Z12CategoriaNome=n)},v2c:function(n){gx.fn.setGridControlValue("CATEGORIANOME",n||gx.fn.currentGridRowImpl(34),gx.O.A12CategoriaNome,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A12CategoriaNome=this.val(n))},val:function(n){return gx.fn.getGridControlValue("CATEGORIANOME",n||gx.fn.currentGridRowImpl(34))},nac:gx.falseFn};n[38]={id:38,fld:"",grid:0};n[39]={id:39,fld:"",grid:0};n[40]={id:40,fld:"BTN_CANCEL",grid:0,evt:"e170a1_client"};this.AV6cCategoriaId=0;this.ZV6cCategoriaId=0;this.OV6cCategoriaId=0;this.AV7cCategoriaNome="";this.ZV7cCategoriaNome="";this.OV7cCategoriaNome="";this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z11CategoriaId=0;this.O11CategoriaId=0;this.Z12CategoriaNome="";this.O12CategoriaNome="";this.AV6cCategoriaId=0;this.AV7cCategoriaNome="";this.AV8pCategoriaId=0;this.AV5LinkSelection="";this.A11CategoriaId=0;this.A12CategoriaNome="";this.Events={e160a2_client:["ENTER",!0],e170a1_client:["CANCEL",!0],e130a1_client:["'TOGGLE'",!1],e110a1_client:["LBLCATEGORIAIDFILTER.CLICK",!1],e120a1_client:["LBLCATEGORIANOMEFILTER.CLICK",!1]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cCategoriaId",fld:"vCCATEGORIAID",pic:"ZZZ9"},{av:"AV7cCategoriaNome",fld:"vCCATEGORIANOME",pic:""}],[]];this.EvtParms["'TOGGLE'"]=[[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]];this.EvtParms["LBLCATEGORIAIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("CATEGORIAIDFILTERCONTAINER","Class")',ctrl:"CATEGORIAIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("CATEGORIAIDFILTERCONTAINER","Class")',ctrl:"CATEGORIAIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCATEGORIAID","Visible")',ctrl:"vCCATEGORIAID",prop:"Visible"}]];this.EvtParms["LBLCATEGORIANOMEFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("CATEGORIANOMEFILTERCONTAINER","Class")',ctrl:"CATEGORIANOMEFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("CATEGORIANOMEFILTERCONTAINER","Class")',ctrl:"CATEGORIANOMEFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCATEGORIANOME","Visible")',ctrl:"vCCATEGORIANOME",prop:"Visible"}]];this.EvtParms.ENTER=[[{av:"A11CategoriaId",fld:"CATEGORIAID",pic:"ZZZ9",hsh:!0}],[{av:"AV8pCategoriaId",fld:"vPCATEGORIAID",pic:"ZZZ9"}]];this.EvtParms.GRID1_FIRSTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cCategoriaId",fld:"vCCATEGORIAID",pic:"ZZZ9"},{av:"AV7cCategoriaNome",fld:"vCCATEGORIANOME",pic:""}],[]];this.EvtParms.GRID1_PREVPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cCategoriaId",fld:"vCCATEGORIAID",pic:"ZZZ9"},{av:"AV7cCategoriaNome",fld:"vCCATEGORIANOME",pic:""}],[]];this.EvtParms.GRID1_NEXTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cCategoriaId",fld:"vCCATEGORIAID",pic:"ZZZ9"},{av:"AV7cCategoriaNome",fld:"vCCATEGORIANOME",pic:""}],[]];this.EvtParms.GRID1_LASTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cCategoriaId",fld:"vCCATEGORIAID",pic:"ZZZ9"},{av:"AV7cCategoriaNome",fld:"vCCATEGORIANOME",pic:""}],[]];this.setVCMap("AV8pCategoriaId","vPCATEGORIAID",0,"int",4,0);t.addRefreshingParm({rfrProp:"Rows",gxGrid:"Grid1"});t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar(this.GXValidFnc[26]);t.addRefreshingParm(this.GXValidFnc[16]);t.addRefreshingParm(this.GXValidFnc[26]);this.Initialize()});gx.wi(function(){gx.createParentObj(this.gx0040)})