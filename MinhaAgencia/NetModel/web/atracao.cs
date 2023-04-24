using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Cryptography;
using System.Data;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class atracao : GXDataArea
   {
      protected void INITENV( )
      {
         if ( GxWebError != 0 )
         {
            return  ;
         }
      }

      protected void INITTRN( )
      {
         initialize_properties( ) ;
         entryPointCalled = false;
         gxfirstwebparm = GetNextPar( );
         gxfirstwebparm_bkp = gxfirstwebparm;
         gxfirstwebparm = DecryptAjaxCall( gxfirstwebparm);
         toggleJsOutput = isJsOutputEnabled( );
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         if ( StringUtil.StrCmp(gxfirstwebparm, "dyncall") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            dyncall( GetNextPar( )) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_2") == 0 )
         {
            A9PaisId = (short)(NumberUtil.Val( GetPar( "PaisId"), "."));
            AssignAttri("", false, "A9PaisId", StringUtil.LTrimStr( (decimal)(A9PaisId), 4, 0));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_2( A9PaisId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_3") == 0 )
         {
            A11CategoriaId = (short)(NumberUtil.Val( GetPar( "CategoriaId"), "."));
            n11CategoriaId = false;
            AssignAttri("", false, "A11CategoriaId", StringUtil.LTrimStr( (decimal)(A11CategoriaId), 4, 0));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_3( A11CategoriaId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxEvt") == 0 )
         {
            setAjaxEventMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxfirstwebparm = GetNextPar( );
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxfullajaxEvt") == 0 )
         {
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxfirstwebparm = GetNextPar( );
         }
         else
         {
            if ( ! IsValidAjaxCall( false) )
            {
               GxWebError = 1;
               return  ;
            }
            gxfirstwebparm = gxfirstwebparm_bkp;
         }
         if ( toggleJsOutput )
         {
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
         {
            gxcookieaux = context.SetCookie( "GX_SESSION_ID", Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", (short)(context.GetHttpSecure( )));
         }
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         toggleJsOutput = isJsOutputEnabled( );
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_web_controls( ) ;
         if ( toggleJsOutput )
         {
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
         }
         if ( ! context.isSpaRequest( ) )
         {
            if ( context.ExposeMetadata( ) )
            {
               Form.Meta.addItem("generator", "GeneXus .NET 17_0_9-159740", 0) ;
            }
            Form.Meta.addItem("description", "Atracao", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         if ( ! context.isAjaxRequest( ) )
         {
            GX_FocusControl = edtAtracaoId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         wbErr = false;
         context.SetDefaultTheme("Carmine");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public atracao( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public atracao( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void execute( )
      {
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITENV( ) ;
         INITTRN( ) ;
         if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
         {
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("rwdmasterpage", "GeneXus.Programs.rwdmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,false);
            ValidateSpaRequest();
            MasterPageObj.webExecute();
            if ( ( GxWebError == 0 ) && context.isAjaxRequest( ) )
            {
               enableOutput();
               if ( ! context.isAjaxRequest( ) )
               {
                  context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
               }
               if ( ! context.WillRedirect( ) )
               {
                  AddString( context.getJSONResponse( )) ;
               }
               else
               {
                  if ( context.isAjaxRequest( ) )
                  {
                     disableOutput();
                  }
                  RenderHtmlHeaders( ) ;
                  context.Redirect( context.wjLoc );
                  context.DispatchAjaxCommands();
               }
            }
         }
         this.cleanup();
      }

      protected void fix_multi_value_controls( )
      {
      }

      protected void Draw( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! GxWebStd.gx_redirect( context) )
         {
            disable_std_buttons( ) ;
            enableDisable( ) ;
            set_caption( ) ;
            /* Form start */
            DrawControls( ) ;
            fix_multi_value_controls( ) ;
         }
         /* Execute Exit event if defined. */
      }

      protected void DrawControls( )
      {
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, divMaintable_Internalname, 1, 0, "px", 0, "px", "WWAdvancedContainer", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8 col-sm-offset-2", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, divTitlecontainer_Internalname, 1, 0, "px", 0, "px", "TableTop", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
         /* Text block */
         GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Atracao", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, 0, "HLP_Atracao.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
         ClassString = "ErrorViewer";
         StyleString = "";
         GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8 col-sm-offset-2", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, divFormcontainer_Internalname, 1, 0, "px", 0, "px", "FormContainer", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, divToolbarcell_Internalname, 1, 0, "px", 0, "px", "col-xs-12 col-sm-9 col-sm-offset-3 ToolbarCellClass", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group ActionGroup", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "btn-group", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"";
         ClassString = "BtnFirst";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Atracao.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
         ClassString = "BtnPrevious";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_Atracao.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
         ClassString = "BtnNext";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_Atracao.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
         ClassString = "BtnLast";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Atracao.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
         ClassString = "BtnSelect";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Selecionar", bttBtn_select_Jsonclick, 4, "Selecionar", "", StyleString, ClassString, bttBtn_select_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "gx.popup.openPrompt('"+"gx0020.aspx"+"',["+"{Ctrl:gx.dom.el('"+"ATRACAOID"+"'), id:'"+"ATRACAOID"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", 2, "HLP_Atracao.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCellAdvanced", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtAtracaoId_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtAtracaoId_Internalname, "Id", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtAtracaoId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A7AtracaoId), 4, 0, ",", "")), StringUtil.LTrim( ((edtAtracaoId_Enabled!=0) ? context.localUtil.Format( (decimal)(A7AtracaoId), "ZZZ9") : context.localUtil.Format( (decimal)(A7AtracaoId), "ZZZ9"))), " inputmode=\"numeric\" pattern=\"[0-9]*\""+TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtAtracaoId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtAtracaoId_Enabled, 0, "text", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "", "HLP_Atracao.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtAtracaoNome_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtAtracaoNome_Internalname, "Nome", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtAtracaoNome_Internalname, StringUtil.RTrim( A8AtracaoNome), StringUtil.RTrim( context.localUtil.Format( A8AtracaoNome, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,39);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtAtracaoNome_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtAtracaoNome_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "Nome", "left", true, "", "HLP_Atracao.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtPaisId_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtPaisId_Internalname, "Pais Id", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtPaisId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A9PaisId), 4, 0, ",", "")), StringUtil.LTrim( ((edtPaisId_Enabled!=0) ? context.localUtil.Format( (decimal)(A9PaisId), "ZZZ9") : context.localUtil.Format( (decimal)(A9PaisId), "ZZZ9"))), " inputmode=\"numeric\" pattern=\"[0-9]*\""+TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,44);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtPaisId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtPaisId_Enabled, 0, "text", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "", "HLP_Atracao.htm");
         /* Static images/pictures */
         ClassString = "gx-prompt Image";
         StyleString = "";
         sImgUrl = (string)(context.GetImagePath( "prompt.gif", "", context.GetTheme( )));
         GxWebStd.gx_bitmap( context, imgprompt_9_Internalname, sImgUrl, imgprompt_9_Link, "", "", context.GetTheme( ), imgprompt_9_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Atracao.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtPaisNome_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtPaisNome_Internalname, "Pais Nome", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         GxWebStd.gx_single_line_edit( context, edtPaisNome_Internalname, StringUtil.RTrim( A10PaisNome), StringUtil.RTrim( context.localUtil.Format( A10PaisNome, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtPaisNome_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtPaisNome_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "Nome", "left", true, "", "HLP_Atracao.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtCategoriaId_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtCategoriaId_Internalname, "Categoria Id", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtCategoriaId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A11CategoriaId), 4, 0, ",", "")), StringUtil.LTrim( ((edtCategoriaId_Enabled!=0) ? context.localUtil.Format( (decimal)(A11CategoriaId), "ZZZ9") : context.localUtil.Format( (decimal)(A11CategoriaId), "ZZZ9"))), " inputmode=\"numeric\" pattern=\"[0-9]*\""+TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(this,54);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtCategoriaId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtCategoriaId_Enabled, 0, "text", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "", "HLP_Atracao.htm");
         /* Static images/pictures */
         ClassString = "gx-prompt Image";
         StyleString = "";
         sImgUrl = (string)(context.GetImagePath( "prompt.gif", "", context.GetTheme( )));
         GxWebStd.gx_bitmap( context, imgprompt_11_Internalname, sImgUrl, imgprompt_11_Link, "", "", context.GetTheme( ), imgprompt_11_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Atracao.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtCategoriaNome_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtCategoriaNome_Internalname, "Categoria Nome", "col-sm-3 AttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         GxWebStd.gx_single_line_edit( context, edtCategoriaNome_Internalname, StringUtil.RTrim( A12CategoriaNome), StringUtil.RTrim( context.localUtil.Format( A12CategoriaNome, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtCategoriaNome_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtCategoriaNome_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "Nome", "left", true, "", "HLP_Atracao.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+imgAtracaoFoto_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, "", "Foto", "col-sm-3 ImageAttributeLabel", 1, true, "");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Static Bitmap Variable */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'',0)\"";
         ClassString = "ImageAttribute";
         StyleString = "";
         A13AtracaoFoto_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( A13AtracaoFoto))&&String.IsNullOrEmpty(StringUtil.RTrim( A40000AtracaoFoto_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( A13AtracaoFoto)));
         sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( A13AtracaoFoto)) ? A40000AtracaoFoto_GXI : context.PathToRelativeUrl( A13AtracaoFoto));
         GxWebStd.gx_bitmap( context, imgAtracaoFoto_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, imgAtracaoFoto_Enabled, "", "", 1, -1, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,64);\"", "", "", "", 0, A13AtracaoFoto_IsBlob, true, context.GetImageSrcSet( sImgUrl), "HLP_Atracao.htm");
         AssignProp("", false, imgAtracaoFoto_Internalname, "URL", (String.IsNullOrEmpty(StringUtil.RTrim( A13AtracaoFoto)) ? A40000AtracaoFoto_GXI : context.PathToRelativeUrl( A13AtracaoFoto)), true);
         AssignProp("", false, imgAtracaoFoto_Internalname, "IsBlob", StringUtil.BoolToStr( A13AtracaoFoto_IsBlob), true);
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "Center", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group Confirm", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 69,'',false,'',0)\"";
         ClassString = "BtnEnter";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Atracao.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 71,'',false,'',0)\"";
         ClassString = "BtnCancel";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Fechar", bttBtn_cancel_Jsonclick, 1, "Fechar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Atracao.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'',0)\"";
         ClassString = "BtnDelete";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Atracao.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "Center", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
      }

      protected void UserMain( )
      {
         standaloneStartup( ) ;
      }

      protected void UserMainFullajax( )
      {
         INITENV( ) ;
         INITTRN( ) ;
         UserMain( ) ;
         Draw( ) ;
         SendCloseFormHiddens( ) ;
      }

      protected void standaloneStartup( )
      {
         standaloneStartupServer( ) ;
         disable_std_buttons( ) ;
         enableDisable( ) ;
         Process( ) ;
      }

      protected void standaloneStartupServer( )
      {
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read saved values. */
            Z7AtracaoId = (short)(context.localUtil.CToN( cgiGet( "Z7AtracaoId"), ",", "."));
            Z8AtracaoNome = cgiGet( "Z8AtracaoNome");
            Z9PaisId = (short)(context.localUtil.CToN( cgiGet( "Z9PaisId"), ",", "."));
            Z11CategoriaId = (short)(context.localUtil.CToN( cgiGet( "Z11CategoriaId"), ",", "."));
            n11CategoriaId = ((0==A11CategoriaId) ? true : false);
            IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", "."));
            IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", "."));
            Gx_mode = cgiGet( "Mode");
            A40000AtracaoFoto_GXI = cgiGet( "ATRACAOFOTO_GXI");
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtAtracaoId_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtAtracaoId_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "ATRACAOID");
               AnyError = 1;
               GX_FocusControl = edtAtracaoId_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               A7AtracaoId = 0;
               AssignAttri("", false, "A7AtracaoId", StringUtil.LTrimStr( (decimal)(A7AtracaoId), 4, 0));
            }
            else
            {
               A7AtracaoId = (short)(context.localUtil.CToN( cgiGet( edtAtracaoId_Internalname), ",", "."));
               AssignAttri("", false, "A7AtracaoId", StringUtil.LTrimStr( (decimal)(A7AtracaoId), 4, 0));
            }
            A8AtracaoNome = cgiGet( edtAtracaoNome_Internalname);
            AssignAttri("", false, "A8AtracaoNome", A8AtracaoNome);
            if ( ( ( context.localUtil.CToN( cgiGet( edtPaisId_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtPaisId_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "PAISID");
               AnyError = 1;
               GX_FocusControl = edtPaisId_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               A9PaisId = 0;
               AssignAttri("", false, "A9PaisId", StringUtil.LTrimStr( (decimal)(A9PaisId), 4, 0));
            }
            else
            {
               A9PaisId = (short)(context.localUtil.CToN( cgiGet( edtPaisId_Internalname), ",", "."));
               AssignAttri("", false, "A9PaisId", StringUtil.LTrimStr( (decimal)(A9PaisId), 4, 0));
            }
            A10PaisNome = cgiGet( edtPaisNome_Internalname);
            AssignAttri("", false, "A10PaisNome", A10PaisNome);
            if ( ( ( context.localUtil.CToN( cgiGet( edtCategoriaId_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtCategoriaId_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "CATEGORIAID");
               AnyError = 1;
               GX_FocusControl = edtCategoriaId_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               A11CategoriaId = 0;
               n11CategoriaId = false;
               AssignAttri("", false, "A11CategoriaId", StringUtil.LTrimStr( (decimal)(A11CategoriaId), 4, 0));
            }
            else
            {
               A11CategoriaId = (short)(context.localUtil.CToN( cgiGet( edtCategoriaId_Internalname), ",", "."));
               n11CategoriaId = false;
               AssignAttri("", false, "A11CategoriaId", StringUtil.LTrimStr( (decimal)(A11CategoriaId), 4, 0));
            }
            n11CategoriaId = ((0==A11CategoriaId) ? true : false);
            A12CategoriaNome = cgiGet( edtCategoriaNome_Internalname);
            AssignAttri("", false, "A12CategoriaNome", A12CategoriaNome);
            A13AtracaoFoto = cgiGet( imgAtracaoFoto_Internalname);
            AssignAttri("", false, "A13AtracaoFoto", A13AtracaoFoto);
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            getMultimediaValue(imgAtracaoFoto_Internalname, ref  A13AtracaoFoto, ref  A40000AtracaoFoto_GXI);
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            standaloneNotModal( ) ;
         }
         else
         {
            standaloneNotModal( ) ;
            if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") == 0 )
            {
               Gx_mode = "DSP";
               AssignAttri("", false, "Gx_mode", Gx_mode);
               A7AtracaoId = (short)(NumberUtil.Val( GetPar( "AtracaoId"), "."));
               AssignAttri("", false, "A7AtracaoId", StringUtil.LTrimStr( (decimal)(A7AtracaoId), 4, 0));
               getEqualNoModal( ) ;
               Gx_mode = "DSP";
               AssignAttri("", false, "Gx_mode", Gx_mode);
               disable_std_buttons_dsp( ) ;
               standaloneModal( ) ;
            }
            else
            {
               Gx_mode = "INS";
               AssignAttri("", false, "Gx_mode", Gx_mode);
               standaloneModal( ) ;
            }
         }
      }

      protected void Process( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read Transaction buttons. */
            sEvt = cgiGet( "_EventName");
            EvtGridId = cgiGet( "_EventGridId");
            EvtRowId = cgiGet( "_EventRowId");
            if ( StringUtil.Len( sEvt) > 0 )
            {
               sEvtType = StringUtil.Left( sEvt, 1);
               sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1));
               if ( StringUtil.StrCmp(sEvtType, "M") != 0 )
               {
                  if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                  {
                     sEvtType = StringUtil.Right( sEvt, 1);
                     if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                     {
                        sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                        if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_enter( ) ;
                           /* No code required for Cancel button. It is implemented as the Reset button. */
                        }
                        else if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_first( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "PREVIOUS") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_previous( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_next( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_last( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "SELECT") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_select( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DELETE") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_delete( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                        {
                           context.wbHandled = 1;
                           AfterKeyLoadScreen( ) ;
                        }
                     }
                     else
                     {
                     }
                  }
                  context.wbHandled = 1;
               }
            }
         }
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( endTrnMsgTxt)) )
            {
               GX_msglist.addItem(endTrnMsgTxt, endTrnMsgCod, 0, "", true);
            }
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( IsIns( )  )
            {
               /* Clear variables for new insertion. */
               InitAll022( ) ;
               standaloneNotModal( ) ;
               standaloneModal( ) ;
            }
         }
         endTrnMsgTxt = "";
      }

      public override string ToString( )
      {
         return "" ;
      }

      public GxContentInfo GetContentInfo( )
      {
         return (GxContentInfo)(null) ;
      }

      protected void disable_std_buttons( )
      {
         if ( IsIns( ) )
         {
            bttBtn_delete_Enabled = 0;
            AssignProp("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_delete_Enabled), 5, 0), true);
         }
      }

      protected void disable_std_buttons_dsp( )
      {
         bttBtn_delete_Visible = 0;
         AssignProp("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_delete_Visible), 5, 0), true);
         bttBtn_first_Visible = 0;
         AssignProp("", false, bttBtn_first_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_first_Visible), 5, 0), true);
         bttBtn_previous_Visible = 0;
         AssignProp("", false, bttBtn_previous_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_previous_Visible), 5, 0), true);
         bttBtn_next_Visible = 0;
         AssignProp("", false, bttBtn_next_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_next_Visible), 5, 0), true);
         bttBtn_last_Visible = 0;
         AssignProp("", false, bttBtn_last_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_last_Visible), 5, 0), true);
         bttBtn_select_Visible = 0;
         AssignProp("", false, bttBtn_select_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_select_Visible), 5, 0), true);
         bttBtn_delete_Visible = 0;
         AssignProp("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_delete_Visible), 5, 0), true);
         if ( IsDsp( ) )
         {
            bttBtn_enter_Visible = 0;
            AssignProp("", false, bttBtn_enter_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_enter_Visible), 5, 0), true);
         }
         DisableAttributes022( ) ;
      }

      protected void set_caption( )
      {
         if ( ( IsConfirmed == 1 ) && ( AnyError == 0 ) )
         {
            if ( IsDlt( ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_confdelete", ""), 0, "", true);
            }
            else
            {
               GX_msglist.addItem(context.GetMessage( "GXM_mustconfirm", ""), 0, "", true);
            }
         }
      }

      protected void ResetCaption020( )
      {
      }

      protected void ZM022( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            if ( ! IsIns( ) )
            {
               Z8AtracaoNome = T00023_A8AtracaoNome[0];
               Z9PaisId = T00023_A9PaisId[0];
               Z11CategoriaId = T00023_A11CategoriaId[0];
            }
            else
            {
               Z8AtracaoNome = A8AtracaoNome;
               Z9PaisId = A9PaisId;
               Z11CategoriaId = A11CategoriaId;
            }
         }
         if ( GX_JID == -1 )
         {
            Z7AtracaoId = A7AtracaoId;
            Z8AtracaoNome = A8AtracaoNome;
            Z13AtracaoFoto = A13AtracaoFoto;
            Z40000AtracaoFoto_GXI = A40000AtracaoFoto_GXI;
            Z9PaisId = A9PaisId;
            Z11CategoriaId = A11CategoriaId;
            Z10PaisNome = A10PaisNome;
            Z12CategoriaNome = A12CategoriaNome;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_9_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0030.aspx"+"',["+"{Ctrl:gx.dom.el('"+"PAISID"+"'), id:'"+"PAISID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         imgprompt_11_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0040.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CATEGORIAID"+"'), id:'"+"CATEGORIAID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
      }

      protected void standaloneModal( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            bttBtn_delete_Enabled = 0;
            AssignProp("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_delete_Enabled), 5, 0), true);
         }
         else
         {
            bttBtn_delete_Enabled = 1;
            AssignProp("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_delete_Enabled), 5, 0), true);
         }
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            bttBtn_enter_Enabled = 0;
            AssignProp("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_enter_Enabled), 5, 0), true);
         }
         else
         {
            bttBtn_enter_Enabled = 1;
            AssignProp("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_enter_Enabled), 5, 0), true);
         }
      }

      protected void Load022( )
      {
         /* Using cursor T00026 */
         pr_default.execute(4, new Object[] {A7AtracaoId});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound2 = 1;
            A8AtracaoNome = T00026_A8AtracaoNome[0];
            AssignAttri("", false, "A8AtracaoNome", A8AtracaoNome);
            A10PaisNome = T00026_A10PaisNome[0];
            AssignAttri("", false, "A10PaisNome", A10PaisNome);
            A12CategoriaNome = T00026_A12CategoriaNome[0];
            AssignAttri("", false, "A12CategoriaNome", A12CategoriaNome);
            A40000AtracaoFoto_GXI = T00026_A40000AtracaoFoto_GXI[0];
            AssignProp("", false, imgAtracaoFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A13AtracaoFoto)) ? A40000AtracaoFoto_GXI : context.convertURL( context.PathToRelativeUrl( A13AtracaoFoto))), true);
            AssignProp("", false, imgAtracaoFoto_Internalname, "SrcSet", context.GetImageSrcSet( A13AtracaoFoto), true);
            A9PaisId = T00026_A9PaisId[0];
            AssignAttri("", false, "A9PaisId", StringUtil.LTrimStr( (decimal)(A9PaisId), 4, 0));
            A11CategoriaId = T00026_A11CategoriaId[0];
            n11CategoriaId = T00026_n11CategoriaId[0];
            AssignAttri("", false, "A11CategoriaId", StringUtil.LTrimStr( (decimal)(A11CategoriaId), 4, 0));
            A13AtracaoFoto = T00026_A13AtracaoFoto[0];
            AssignAttri("", false, "A13AtracaoFoto", A13AtracaoFoto);
            AssignProp("", false, imgAtracaoFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A13AtracaoFoto)) ? A40000AtracaoFoto_GXI : context.convertURL( context.PathToRelativeUrl( A13AtracaoFoto))), true);
            AssignProp("", false, imgAtracaoFoto_Internalname, "SrcSet", context.GetImageSrcSet( A13AtracaoFoto), true);
            ZM022( -1) ;
         }
         pr_default.close(4);
         OnLoadActions022( ) ;
      }

      protected void OnLoadActions022( )
      {
      }

      protected void CheckExtendedTable022( )
      {
         nIsDirty_2 = 0;
         Gx_BScreen = 1;
         standaloneModal( ) ;
         /* Using cursor T00024 */
         pr_default.execute(2, new Object[] {A9PaisId});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("Não existe 'Pais'.", "ForeignKeyNotFound", 1, "PAISID");
            AnyError = 1;
            GX_FocusControl = edtPaisId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A10PaisNome = T00024_A10PaisNome[0];
         AssignAttri("", false, "A10PaisNome", A10PaisNome);
         pr_default.close(2);
         /* Using cursor T00025 */
         pr_default.execute(3, new Object[] {n11CategoriaId, A11CategoriaId});
         if ( (pr_default.getStatus(3) == 101) )
         {
            if ( ! ( (0==A11CategoriaId) ) )
            {
               GX_msglist.addItem("Não existe 'Categoria'.", "ForeignKeyNotFound", 1, "CATEGORIAID");
               AnyError = 1;
               GX_FocusControl = edtCategoriaId_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         A12CategoriaNome = T00025_A12CategoriaNome[0];
         AssignAttri("", false, "A12CategoriaNome", A12CategoriaNome);
         pr_default.close(3);
      }

      protected void CloseExtendedTableCursors022( )
      {
         pr_default.close(2);
         pr_default.close(3);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_2( short A9PaisId )
      {
         /* Using cursor T00027 */
         pr_default.execute(5, new Object[] {A9PaisId});
         if ( (pr_default.getStatus(5) == 101) )
         {
            GX_msglist.addItem("Não existe 'Pais'.", "ForeignKeyNotFound", 1, "PAISID");
            AnyError = 1;
            GX_FocusControl = edtPaisId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A10PaisNome = T00027_A10PaisNome[0];
         AssignAttri("", false, "A10PaisNome", A10PaisNome);
         GxWebStd.set_html_headers( context, 0, "", "");
         AddString( "[[") ;
         AddString( "\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A10PaisNome))+"\"") ;
         AddString( "]") ;
         if ( (pr_default.getStatus(5) == 101) )
         {
            AddString( ",") ;
            AddString( "101") ;
         }
         AddString( "]") ;
         pr_default.close(5);
      }

      protected void gxLoad_3( short A11CategoriaId )
      {
         /* Using cursor T00028 */
         pr_default.execute(6, new Object[] {n11CategoriaId, A11CategoriaId});
         if ( (pr_default.getStatus(6) == 101) )
         {
            if ( ! ( (0==A11CategoriaId) ) )
            {
               GX_msglist.addItem("Não existe 'Categoria'.", "ForeignKeyNotFound", 1, "CATEGORIAID");
               AnyError = 1;
               GX_FocusControl = edtCategoriaId_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         A12CategoriaNome = T00028_A12CategoriaNome[0];
         AssignAttri("", false, "A12CategoriaNome", A12CategoriaNome);
         GxWebStd.set_html_headers( context, 0, "", "");
         AddString( "[[") ;
         AddString( "\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A12CategoriaNome))+"\"") ;
         AddString( "]") ;
         if ( (pr_default.getStatus(6) == 101) )
         {
            AddString( ",") ;
            AddString( "101") ;
         }
         AddString( "]") ;
         pr_default.close(6);
      }

      protected void GetKey022( )
      {
         /* Using cursor T00029 */
         pr_default.execute(7, new Object[] {A7AtracaoId});
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound2 = 1;
         }
         else
         {
            RcdFound2 = 0;
         }
         pr_default.close(7);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00023 */
         pr_default.execute(1, new Object[] {A7AtracaoId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM022( 1) ;
            RcdFound2 = 1;
            A7AtracaoId = T00023_A7AtracaoId[0];
            AssignAttri("", false, "A7AtracaoId", StringUtil.LTrimStr( (decimal)(A7AtracaoId), 4, 0));
            A8AtracaoNome = T00023_A8AtracaoNome[0];
            AssignAttri("", false, "A8AtracaoNome", A8AtracaoNome);
            A40000AtracaoFoto_GXI = T00023_A40000AtracaoFoto_GXI[0];
            AssignProp("", false, imgAtracaoFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A13AtracaoFoto)) ? A40000AtracaoFoto_GXI : context.convertURL( context.PathToRelativeUrl( A13AtracaoFoto))), true);
            AssignProp("", false, imgAtracaoFoto_Internalname, "SrcSet", context.GetImageSrcSet( A13AtracaoFoto), true);
            A9PaisId = T00023_A9PaisId[0];
            AssignAttri("", false, "A9PaisId", StringUtil.LTrimStr( (decimal)(A9PaisId), 4, 0));
            A11CategoriaId = T00023_A11CategoriaId[0];
            n11CategoriaId = T00023_n11CategoriaId[0];
            AssignAttri("", false, "A11CategoriaId", StringUtil.LTrimStr( (decimal)(A11CategoriaId), 4, 0));
            A13AtracaoFoto = T00023_A13AtracaoFoto[0];
            AssignAttri("", false, "A13AtracaoFoto", A13AtracaoFoto);
            AssignProp("", false, imgAtracaoFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A13AtracaoFoto)) ? A40000AtracaoFoto_GXI : context.convertURL( context.PathToRelativeUrl( A13AtracaoFoto))), true);
            AssignProp("", false, imgAtracaoFoto_Internalname, "SrcSet", context.GetImageSrcSet( A13AtracaoFoto), true);
            Z7AtracaoId = A7AtracaoId;
            sMode2 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load022( ) ;
            if ( AnyError == 1 )
            {
               RcdFound2 = 0;
               InitializeNonKey022( ) ;
            }
            Gx_mode = sMode2;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound2 = 0;
            InitializeNonKey022( ) ;
            sMode2 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode2;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey022( ) ;
         if ( RcdFound2 == 0 )
         {
            Gx_mode = "INS";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound2 = 0;
         /* Using cursor T000210 */
         pr_default.execute(8, new Object[] {A7AtracaoId});
         if ( (pr_default.getStatus(8) != 101) )
         {
            while ( (pr_default.getStatus(8) != 101) && ( ( T000210_A7AtracaoId[0] < A7AtracaoId ) ) )
            {
               pr_default.readNext(8);
            }
            if ( (pr_default.getStatus(8) != 101) && ( ( T000210_A7AtracaoId[0] > A7AtracaoId ) ) )
            {
               A7AtracaoId = T000210_A7AtracaoId[0];
               AssignAttri("", false, "A7AtracaoId", StringUtil.LTrimStr( (decimal)(A7AtracaoId), 4, 0));
               RcdFound2 = 1;
            }
         }
         pr_default.close(8);
      }

      protected void move_previous( )
      {
         RcdFound2 = 0;
         /* Using cursor T000211 */
         pr_default.execute(9, new Object[] {A7AtracaoId});
         if ( (pr_default.getStatus(9) != 101) )
         {
            while ( (pr_default.getStatus(9) != 101) && ( ( T000211_A7AtracaoId[0] > A7AtracaoId ) ) )
            {
               pr_default.readNext(9);
            }
            if ( (pr_default.getStatus(9) != 101) && ( ( T000211_A7AtracaoId[0] < A7AtracaoId ) ) )
            {
               A7AtracaoId = T000211_A7AtracaoId[0];
               AssignAttri("", false, "A7AtracaoId", StringUtil.LTrimStr( (decimal)(A7AtracaoId), 4, 0));
               RcdFound2 = 1;
            }
         }
         pr_default.close(9);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey022( ) ;
         if ( IsIns( ) )
         {
            /* Insert record */
            GX_FocusControl = edtAtracaoId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            Insert022( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound2 == 1 )
            {
               if ( A7AtracaoId != Z7AtracaoId )
               {
                  A7AtracaoId = Z7AtracaoId;
                  AssignAttri("", false, "A7AtracaoId", StringUtil.LTrimStr( (decimal)(A7AtracaoId), 4, 0));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "ATRACAOID");
                  AnyError = 1;
                  GX_FocusControl = edtAtracaoId_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( IsDlt( ) )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtAtracaoId_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "UPD";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  /* Update record */
                  Update022( ) ;
                  GX_FocusControl = edtAtracaoId_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A7AtracaoId != Z7AtracaoId )
               {
                  Gx_mode = "INS";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtAtracaoId_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert022( ) ;
                  if ( AnyError == 1 )
                  {
                     GX_FocusControl = "";
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "ATRACAOID");
                     AnyError = 1;
                     GX_FocusControl = edtAtracaoId_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     Gx_mode = "INS";
                     AssignAttri("", false, "Gx_mode", Gx_mode);
                     /* Insert record */
                     GX_FocusControl = edtAtracaoId_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert022( ) ;
                     if ( AnyError == 1 )
                     {
                        GX_FocusControl = "";
                        AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
         }
         AfterTrn( ) ;
      }

      protected void btn_delete( )
      {
         if ( A7AtracaoId != Z7AtracaoId )
         {
            A7AtracaoId = Z7AtracaoId;
            AssignAttri("", false, "A7AtracaoId", StringUtil.LTrimStr( (decimal)(A7AtracaoId), 4, 0));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "ATRACAOID");
            AnyError = 1;
            GX_FocusControl = edtAtracaoId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtAtracaoId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            getByPrimaryKey( ) ;
         }
         CloseOpenCursors();
      }

      protected void btn_get( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
         getEqualNoModal( ) ;
         if ( RcdFound2 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "ATRACAOID");
            AnyError = 1;
            GX_FocusControl = edtAtracaoId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GX_FocusControl = edtAtracaoNome_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
         ScanStart022( ) ;
         if ( RcdFound2 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtAtracaoNome_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd022( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
         move_previous( ) ;
         if ( RcdFound2 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtAtracaoNome_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_next( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
         move_next( ) ;
         if ( RcdFound2 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtAtracaoNome_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
         ScanStart022( ) ;
         if ( RcdFound2 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound2 != 0 )
            {
               ScanNext022( ) ;
            }
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtAtracaoNome_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd022( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency022( )
      {
         if ( ! IsIns( ) )
         {
            /* Using cursor T00022 */
            pr_default.execute(0, new Object[] {A7AtracaoId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Atracao"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z8AtracaoNome, T00022_A8AtracaoNome[0]) != 0 ) || ( Z9PaisId != T00022_A9PaisId[0] ) || ( Z11CategoriaId != T00022_A11CategoriaId[0] ) )
            {
               if ( StringUtil.StrCmp(Z8AtracaoNome, T00022_A8AtracaoNome[0]) != 0 )
               {
                  GXUtil.WriteLog("atracao:[seudo value changed for attri]"+"AtracaoNome");
                  GXUtil.WriteLogRaw("Old: ",Z8AtracaoNome);
                  GXUtil.WriteLogRaw("Current: ",T00022_A8AtracaoNome[0]);
               }
               if ( Z9PaisId != T00022_A9PaisId[0] )
               {
                  GXUtil.WriteLog("atracao:[seudo value changed for attri]"+"PaisId");
                  GXUtil.WriteLogRaw("Old: ",Z9PaisId);
                  GXUtil.WriteLogRaw("Current: ",T00022_A9PaisId[0]);
               }
               if ( Z11CategoriaId != T00022_A11CategoriaId[0] )
               {
                  GXUtil.WriteLog("atracao:[seudo value changed for attri]"+"CategoriaId");
                  GXUtil.WriteLogRaw("Old: ",Z11CategoriaId);
                  GXUtil.WriteLogRaw("Current: ",T00022_A11CategoriaId[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Atracao"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert022( )
      {
         BeforeValidate022( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable022( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM022( 0) ;
            CheckOptimisticConcurrency022( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm022( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert022( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000212 */
                     pr_default.execute(10, new Object[] {A8AtracaoNome, A13AtracaoFoto, A40000AtracaoFoto_GXI, A9PaisId, n11CategoriaId, A11CategoriaId});
                     A7AtracaoId = T000212_A7AtracaoId[0];
                     AssignAttri("", false, "A7AtracaoId", StringUtil.LTrimStr( (decimal)(A7AtracaoId), 4, 0));
                     pr_default.close(10);
                     dsDefault.SmartCacheProvider.SetUpdated("Atracao");
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           endTrnMsgTxt = context.GetMessage( "GXM_sucadded", "");
                           endTrnMsgCod = "SuccessfullyAdded";
                           ResetCaption020( ) ;
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
            else
            {
               Load022( ) ;
            }
            EndLevel022( ) ;
         }
         CloseExtendedTableCursors022( ) ;
      }

      protected void Update022( )
      {
         BeforeValidate022( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable022( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency022( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm022( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate022( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000213 */
                     pr_default.execute(11, new Object[] {A8AtracaoNome, A9PaisId, n11CategoriaId, A11CategoriaId, A7AtracaoId});
                     pr_default.close(11);
                     dsDefault.SmartCacheProvider.SetUpdated("Atracao");
                     if ( (pr_default.getStatus(11) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Atracao"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate022( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           endTrnMsgTxt = context.GetMessage( "GXM_sucupdated", "");
                           endTrnMsgCod = "SuccessfullyUpdated";
                           ResetCaption020( ) ;
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                        AnyError = 1;
                     }
                  }
               }
            }
            EndLevel022( ) ;
         }
         CloseExtendedTableCursors022( ) ;
      }

      protected void DeferredUpdate022( )
      {
         if ( AnyError == 0 )
         {
            /* Using cursor T000214 */
            pr_default.execute(12, new Object[] {A13AtracaoFoto, A40000AtracaoFoto_GXI, A7AtracaoId});
            pr_default.close(12);
            dsDefault.SmartCacheProvider.SetUpdated("Atracao");
         }
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         BeforeValidate022( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency022( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls022( ) ;
            AfterConfirm022( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete022( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000215 */
                  pr_default.execute(13, new Object[] {A7AtracaoId});
                  pr_default.close(13);
                  dsDefault.SmartCacheProvider.SetUpdated("Atracao");
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound2 == 0 )
                        {
                           InitAll022( ) ;
                           Gx_mode = "INS";
                           AssignAttri("", false, "Gx_mode", Gx_mode);
                        }
                        else
                        {
                           getByPrimaryKey( ) ;
                           Gx_mode = "UPD";
                           AssignAttri("", false, "Gx_mode", Gx_mode);
                        }
                        endTrnMsgTxt = context.GetMessage( "GXM_sucdeleted", "");
                        endTrnMsgCod = "SuccessfullyDeleted";
                        ResetCaption020( ) ;
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
         }
         sMode2 = Gx_mode;
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         EndLevel022( ) ;
         Gx_mode = sMode2;
         AssignAttri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls022( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T000216 */
            pr_default.execute(14, new Object[] {A9PaisId});
            A10PaisNome = T000216_A10PaisNome[0];
            AssignAttri("", false, "A10PaisNome", A10PaisNome);
            pr_default.close(14);
            /* Using cursor T000217 */
            pr_default.execute(15, new Object[] {n11CategoriaId, A11CategoriaId});
            A12CategoriaNome = T000217_A12CategoriaNome[0];
            AssignAttri("", false, "A12CategoriaNome", A12CategoriaNome);
            pr_default.close(15);
         }
      }

      protected void EndLevel022( )
      {
         if ( ! IsIns( ) )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete022( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            pr_default.close(14);
            pr_default.close(15);
            context.CommitDataStores("atracao",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues020( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            pr_default.close(14);
            pr_default.close(15);
            context.RollbackDataStores("atracao",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart022( )
      {
         /* Using cursor T000218 */
         pr_default.execute(16);
         RcdFound2 = 0;
         if ( (pr_default.getStatus(16) != 101) )
         {
            RcdFound2 = 1;
            A7AtracaoId = T000218_A7AtracaoId[0];
            AssignAttri("", false, "A7AtracaoId", StringUtil.LTrimStr( (decimal)(A7AtracaoId), 4, 0));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext022( )
      {
         /* Scan next routine */
         pr_default.readNext(16);
         RcdFound2 = 0;
         if ( (pr_default.getStatus(16) != 101) )
         {
            RcdFound2 = 1;
            A7AtracaoId = T000218_A7AtracaoId[0];
            AssignAttri("", false, "A7AtracaoId", StringUtil.LTrimStr( (decimal)(A7AtracaoId), 4, 0));
         }
      }

      protected void ScanEnd022( )
      {
         pr_default.close(16);
      }

      protected void AfterConfirm022( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert022( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate022( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete022( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete022( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate022( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes022( )
      {
         edtAtracaoId_Enabled = 0;
         AssignProp("", false, edtAtracaoId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAtracaoId_Enabled), 5, 0), true);
         edtAtracaoNome_Enabled = 0;
         AssignProp("", false, edtAtracaoNome_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAtracaoNome_Enabled), 5, 0), true);
         edtPaisId_Enabled = 0;
         AssignProp("", false, edtPaisId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtPaisId_Enabled), 5, 0), true);
         edtPaisNome_Enabled = 0;
         AssignProp("", false, edtPaisNome_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtPaisNome_Enabled), 5, 0), true);
         edtCategoriaId_Enabled = 0;
         AssignProp("", false, edtCategoriaId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtCategoriaId_Enabled), 5, 0), true);
         edtCategoriaNome_Enabled = 0;
         AssignProp("", false, edtCategoriaNome_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtCategoriaNome_Enabled), 5, 0), true);
         imgAtracaoFoto_Enabled = 0;
         AssignProp("", false, imgAtracaoFoto_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(imgAtracaoFoto_Enabled), 5, 0), true);
      }

      protected void send_integrity_lvl_hashes022( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues020( )
      {
      }

      public override void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, true);
      }

      public override void RenderHtmlOpenForm( )
      {
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.WriteHtmlText( "<title>") ;
         context.SendWebValue( Form.Caption) ;
         context.WriteHtmlTextNl( "</title>") ;
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         if ( StringUtil.Len( sDynURL) > 0 )
         {
            context.WriteHtmlText( "<BASE href=\""+sDynURL+"\" />") ;
         }
         define_styles( ) ;
         MasterPageObj.master_styles();
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 214480), false, true);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 214480), false, true);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 214480), false, true);
         context.AddJavascriptSource("gxcfg.js", "?202342418355143", false, true);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         FormProcess = " data-HasEnter=\"true\" data-Skiponenter=\"false\"";
         context.WriteHtmlText( "<body ") ;
         bodyStyle = "" + "background-color:" + context.BuildHTMLColor( Form.Backcolor) + ";color:" + context.BuildHTMLColor( Form.Textcolor) + ";";
         bodyStyle += "-moz-opacity:0;opacity:0;";
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            bodyStyle += " background-image:url(" + context.convertURL( Form.Background) + ")";
         }
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("atracao.aspx") +"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         context.WriteHtmlText( "<input type=\"submit\" title=\"submit\" style=\"display:block;height:0;border:0;padding:0\" disabled>") ;
         AssignProp("", false, "FORM", "Class", "form-horizontal Form", true);
         toggleJsOutput = isJsOutputEnabled( );
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
      }

      protected void send_integrity_footer_hashes( )
      {
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z7AtracaoId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z7AtracaoId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z8AtracaoNome", StringUtil.RTrim( Z8AtracaoNome));
         GxWebStd.gx_hidden_field( context, "Z9PaisId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z9PaisId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z11CategoriaId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z11CategoriaId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "ATRACAOFOTO_GXI", A40000AtracaoFoto_GXI);
         GXCCtlgxBlob = "ATRACAOFOTO" + "_gxBlob";
         GxWebStd.gx_hidden_field( context, GXCCtlgxBlob, A13AtracaoFoto);
      }

      public override void RenderHtmlCloseForm( )
      {
         SendCloseFormHiddens( ) ;
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendSecurityToken(sPrefix);
         SendComponentObjects();
         SendServerCommands();
         SendState();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         context.WriteHtmlTextNl( "</form>") ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         include_jscripts( ) ;
      }

      public override short ExecuteStartEvent( )
      {
         standaloneStartup( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         return gxajaxcallmode ;
      }

      public override void RenderHtmlContent( )
      {
         context.WriteHtmlText( "<div") ;
         GxWebStd.ClassAttribute( context, "gx-ct-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
         context.WriteHtmlText( ">") ;
         Draw( ) ;
         context.WriteHtmlText( "</div>") ;
      }

      public override void DispatchEvents( )
      {
         Process( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override string GetSelfLink( )
      {
         return formatLink("atracao.aspx")  ;
      }

      public override string GetPgmname( )
      {
         return "Atracao" ;
      }

      public override string GetPgmdesc( )
      {
         return "Atracao" ;
      }

      protected void InitializeNonKey022( )
      {
         A8AtracaoNome = "";
         AssignAttri("", false, "A8AtracaoNome", A8AtracaoNome);
         A9PaisId = 0;
         AssignAttri("", false, "A9PaisId", StringUtil.LTrimStr( (decimal)(A9PaisId), 4, 0));
         A10PaisNome = "";
         AssignAttri("", false, "A10PaisNome", A10PaisNome);
         A11CategoriaId = 0;
         n11CategoriaId = false;
         AssignAttri("", false, "A11CategoriaId", StringUtil.LTrimStr( (decimal)(A11CategoriaId), 4, 0));
         n11CategoriaId = ((0==A11CategoriaId) ? true : false);
         A12CategoriaNome = "";
         AssignAttri("", false, "A12CategoriaNome", A12CategoriaNome);
         A13AtracaoFoto = "";
         AssignAttri("", false, "A13AtracaoFoto", A13AtracaoFoto);
         AssignProp("", false, imgAtracaoFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A13AtracaoFoto)) ? A40000AtracaoFoto_GXI : context.convertURL( context.PathToRelativeUrl( A13AtracaoFoto))), true);
         AssignProp("", false, imgAtracaoFoto_Internalname, "SrcSet", context.GetImageSrcSet( A13AtracaoFoto), true);
         A40000AtracaoFoto_GXI = "";
         AssignProp("", false, imgAtracaoFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A13AtracaoFoto)) ? A40000AtracaoFoto_GXI : context.convertURL( context.PathToRelativeUrl( A13AtracaoFoto))), true);
         AssignProp("", false, imgAtracaoFoto_Internalname, "SrcSet", context.GetImageSrcSet( A13AtracaoFoto), true);
         Z8AtracaoNome = "";
         Z9PaisId = 0;
         Z11CategoriaId = 0;
      }

      protected void InitAll022( )
      {
         A7AtracaoId = 0;
         AssignAttri("", false, "A7AtracaoId", StringUtil.LTrimStr( (decimal)(A7AtracaoId), 4, 0));
         InitializeNonKey022( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ));
         bool outputEnabled = isOutputEnabled( );
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((string)Form.Jscriptsrc.Item(idxLst))), "?202342418355150", true, true);
            idxLst = (int)(idxLst+1);
         }
         if ( ! outputEnabled )
         {
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.por.js", "?"+GetCacheInvalidationToken( ), false, true);
         context.AddJavascriptSource("atracao.js", "?202342418355150", false, true);
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblTitle_Internalname = "TITLE";
         divTitlecontainer_Internalname = "TITLECONTAINER";
         bttBtn_first_Internalname = "BTN_FIRST";
         bttBtn_previous_Internalname = "BTN_PREVIOUS";
         bttBtn_next_Internalname = "BTN_NEXT";
         bttBtn_last_Internalname = "BTN_LAST";
         bttBtn_select_Internalname = "BTN_SELECT";
         divToolbarcell_Internalname = "TOOLBARCELL";
         edtAtracaoId_Internalname = "ATRACAOID";
         edtAtracaoNome_Internalname = "ATRACAONOME";
         edtPaisId_Internalname = "PAISID";
         edtPaisNome_Internalname = "PAISNOME";
         edtCategoriaId_Internalname = "CATEGORIAID";
         edtCategoriaNome_Internalname = "CATEGORIANOME";
         imgAtracaoFoto_Internalname = "ATRACAOFOTO";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         imgprompt_9_Internalname = "PROMPT_9";
         imgprompt_11_Internalname = "PROMPT_11";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("Carmine");
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Atracao";
         bttBtn_delete_Enabled = 1;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         imgAtracaoFoto_Enabled = 1;
         edtCategoriaNome_Jsonclick = "";
         edtCategoriaNome_Enabled = 0;
         imgprompt_11_Visible = 1;
         imgprompt_11_Link = "";
         edtCategoriaId_Jsonclick = "";
         edtCategoriaId_Enabled = 1;
         edtPaisNome_Jsonclick = "";
         edtPaisNome_Enabled = 0;
         imgprompt_9_Visible = 1;
         imgprompt_9_Link = "";
         edtPaisId_Jsonclick = "";
         edtPaisId_Enabled = 1;
         edtAtracaoNome_Jsonclick = "";
         edtAtracaoNome_Enabled = 1;
         edtAtracaoId_Jsonclick = "";
         edtAtracaoId_Enabled = 1;
         bttBtn_select_Visible = 1;
         bttBtn_last_Visible = 1;
         bttBtn_next_Visible = 1;
         bttBtn_previous_Visible = 1;
         bttBtn_first_Visible = 1;
         context.GX_msglist.DisplayMode = 1;
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void AfterKeyLoadScreen( )
      {
         IsConfirmed = 0;
         AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
         getEqualNoModal( ) ;
         GX_FocusControl = edtAtracaoNome_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      protected bool IsIns( )
      {
         return ((StringUtil.StrCmp(Gx_mode, "INS")==0) ? true : false) ;
      }

      protected bool IsDlt( )
      {
         return ((StringUtil.StrCmp(Gx_mode, "DLT")==0) ? true : false) ;
      }

      protected bool IsUpd( )
      {
         return ((StringUtil.StrCmp(Gx_mode, "UPD")==0) ? true : false) ;
      }

      protected bool IsDsp( )
      {
         return ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? true : false) ;
      }

      public void Valid_Atracaoid( )
      {
         context.wbHandled = 1;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         send_integrity_footer_hashes( ) ;
         dynload_actions( ) ;
         /*  Sending validation outputs */
         AssignAttri("", false, "A8AtracaoNome", StringUtil.RTrim( A8AtracaoNome));
         AssignAttri("", false, "A9PaisId", StringUtil.LTrim( StringUtil.NToC( (decimal)(A9PaisId), 4, 0, ".", "")));
         AssignAttri("", false, "A11CategoriaId", StringUtil.LTrim( StringUtil.NToC( (decimal)(A11CategoriaId), 4, 0, ".", "")));
         AssignAttri("", false, "A13AtracaoFoto", context.PathToRelativeUrl( A13AtracaoFoto));
         GXCCtlgxBlob = "ATRACAOFOTO" + "_gxBlob";
         AssignAttri("", false, "GXCCtlgxBlob", GXCCtlgxBlob);
         GxWebStd.gx_hidden_field( context, GXCCtlgxBlob, context.PathToRelativeUrl( A13AtracaoFoto));
         AssignAttri("", false, "A40000AtracaoFoto_GXI", A40000AtracaoFoto_GXI);
         AssignAttri("", false, "A10PaisNome", StringUtil.RTrim( A10PaisNome));
         AssignAttri("", false, "A12CategoriaNome", StringUtil.RTrim( A12CategoriaNome));
         AssignAttri("", false, "Gx_mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "Z7AtracaoId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z7AtracaoId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z8AtracaoNome", StringUtil.RTrim( Z8AtracaoNome));
         GxWebStd.gx_hidden_field( context, "Z9PaisId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z9PaisId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z11CategoriaId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z11CategoriaId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z13AtracaoFoto", context.PathToRelativeUrl( Z13AtracaoFoto));
         GxWebStd.gx_hidden_field( context, "Z40000AtracaoFoto_GXI", Z40000AtracaoFoto_GXI);
         GxWebStd.gx_hidden_field( context, "Z10PaisNome", StringUtil.RTrim( Z10PaisNome));
         GxWebStd.gx_hidden_field( context, "Z12CategoriaNome", StringUtil.RTrim( Z12CategoriaNome));
         AssignProp("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_delete_Enabled), 5, 0), true);
         AssignProp("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_enter_Enabled), 5, 0), true);
         SendCloseFormHiddens( ) ;
      }

      public void Valid_Paisid( )
      {
         /* Using cursor T000216 */
         pr_default.execute(14, new Object[] {A9PaisId});
         if ( (pr_default.getStatus(14) == 101) )
         {
            GX_msglist.addItem("Não existe 'Pais'.", "ForeignKeyNotFound", 1, "PAISID");
            AnyError = 1;
            GX_FocusControl = edtPaisId_Internalname;
         }
         A10PaisNome = T000216_A10PaisNome[0];
         pr_default.close(14);
         dynload_actions( ) ;
         /*  Sending validation outputs */
         AssignAttri("", false, "A10PaisNome", StringUtil.RTrim( A10PaisNome));
      }

      public void Valid_Categoriaid( )
      {
         n11CategoriaId = false;
         /* Using cursor T000217 */
         pr_default.execute(15, new Object[] {n11CategoriaId, A11CategoriaId});
         if ( (pr_default.getStatus(15) == 101) )
         {
            if ( ! ( (0==A11CategoriaId) ) )
            {
               GX_msglist.addItem("Não existe 'Categoria'.", "ForeignKeyNotFound", 1, "CATEGORIAID");
               AnyError = 1;
               GX_FocusControl = edtCategoriaId_Internalname;
            }
         }
         A12CategoriaNome = T000217_A12CategoriaNome[0];
         pr_default.close(15);
         dynload_actions( ) ;
         /*  Sending validation outputs */
         AssignAttri("", false, "A12CategoriaNome", StringUtil.RTrim( A12CategoriaNome));
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("VALID_ATRACAOID","{handler:'Valid_Atracaoid',iparms:[{av:'A7AtracaoId',fld:'ATRACAOID',pic:'ZZZ9'},{av:'Gx_mode',fld:'vMODE',pic:'@!'}]");
         setEventMetadata("VALID_ATRACAOID",",oparms:[{av:'A8AtracaoNome',fld:'ATRACAONOME',pic:''},{av:'A9PaisId',fld:'PAISID',pic:'ZZZ9'},{av:'A11CategoriaId',fld:'CATEGORIAID',pic:'ZZZ9'},{av:'A13AtracaoFoto',fld:'ATRACAOFOTO',pic:''},{av:'A40000AtracaoFoto_GXI',fld:'ATRACAOFOTO_GXI',pic:''},{av:'A10PaisNome',fld:'PAISNOME',pic:''},{av:'A12CategoriaNome',fld:'CATEGORIANOME',pic:''},{av:'Gx_mode',fld:'vMODE',pic:'@!'},{av:'Z7AtracaoId'},{av:'Z8AtracaoNome'},{av:'Z9PaisId'},{av:'Z11CategoriaId'},{av:'Z13AtracaoFoto'},{av:'Z40000AtracaoFoto_GXI'},{av:'Z10PaisNome'},{av:'Z12CategoriaNome'},{ctrl:'BTN_DELETE',prop:'Enabled'},{ctrl:'BTN_ENTER',prop:'Enabled'}]}");
         setEventMetadata("VALID_PAISID","{handler:'Valid_Paisid',iparms:[{av:'A9PaisId',fld:'PAISID',pic:'ZZZ9'},{av:'A10PaisNome',fld:'PAISNOME',pic:''}]");
         setEventMetadata("VALID_PAISID",",oparms:[{av:'A10PaisNome',fld:'PAISNOME',pic:''}]}");
         setEventMetadata("VALID_CATEGORIAID","{handler:'Valid_Categoriaid',iparms:[{av:'A11CategoriaId',fld:'CATEGORIAID',pic:'ZZZ9'},{av:'A12CategoriaNome',fld:'CATEGORIANOME',pic:''}]");
         setEventMetadata("VALID_CATEGORIAID",",oparms:[{av:'A12CategoriaNome',fld:'CATEGORIANOME',pic:''}]}");
         return  ;
      }

      public override void cleanup( )
      {
         flushBuffer();
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections();
         }
      }

      protected void CloseOpenCursors( )
      {
         pr_default.close(1);
         pr_default.close(14);
         pr_default.close(15);
      }

      public override void initialize( )
      {
         sPrefix = "";
         Z8AtracaoNome = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         GXKey = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Form = new GXWebForm();
         GX_FocusControl = "";
         lblTitle_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         TempTags = "";
         bttBtn_first_Jsonclick = "";
         bttBtn_previous_Jsonclick = "";
         bttBtn_next_Jsonclick = "";
         bttBtn_last_Jsonclick = "";
         bttBtn_select_Jsonclick = "";
         A8AtracaoNome = "";
         sImgUrl = "";
         A10PaisNome = "";
         A12CategoriaNome = "";
         A13AtracaoFoto = "";
         A40000AtracaoFoto_GXI = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gx_mode = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         endTrnMsgTxt = "";
         endTrnMsgCod = "";
         Z13AtracaoFoto = "";
         Z40000AtracaoFoto_GXI = "";
         Z10PaisNome = "";
         Z12CategoriaNome = "";
         T00026_A7AtracaoId = new short[1] ;
         T00026_A8AtracaoNome = new string[] {""} ;
         T00026_A10PaisNome = new string[] {""} ;
         T00026_A12CategoriaNome = new string[] {""} ;
         T00026_A40000AtracaoFoto_GXI = new string[] {""} ;
         T00026_A9PaisId = new short[1] ;
         T00026_A11CategoriaId = new short[1] ;
         T00026_n11CategoriaId = new bool[] {false} ;
         T00026_A13AtracaoFoto = new string[] {""} ;
         T00024_A10PaisNome = new string[] {""} ;
         T00025_A12CategoriaNome = new string[] {""} ;
         T00027_A10PaisNome = new string[] {""} ;
         T00028_A12CategoriaNome = new string[] {""} ;
         T00029_A7AtracaoId = new short[1] ;
         T00023_A7AtracaoId = new short[1] ;
         T00023_A8AtracaoNome = new string[] {""} ;
         T00023_A40000AtracaoFoto_GXI = new string[] {""} ;
         T00023_A9PaisId = new short[1] ;
         T00023_A11CategoriaId = new short[1] ;
         T00023_n11CategoriaId = new bool[] {false} ;
         T00023_A13AtracaoFoto = new string[] {""} ;
         sMode2 = "";
         T000210_A7AtracaoId = new short[1] ;
         T000211_A7AtracaoId = new short[1] ;
         T00022_A7AtracaoId = new short[1] ;
         T00022_A8AtracaoNome = new string[] {""} ;
         T00022_A40000AtracaoFoto_GXI = new string[] {""} ;
         T00022_A9PaisId = new short[1] ;
         T00022_A11CategoriaId = new short[1] ;
         T00022_n11CategoriaId = new bool[] {false} ;
         T00022_A13AtracaoFoto = new string[] {""} ;
         T000212_A7AtracaoId = new short[1] ;
         T000216_A10PaisNome = new string[] {""} ;
         T000217_A12CategoriaNome = new string[] {""} ;
         T000218_A7AtracaoId = new short[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXCCtlgxBlob = "";
         ZZ8AtracaoNome = "";
         ZZ13AtracaoFoto = "";
         ZZ40000AtracaoFoto_GXI = "";
         ZZ10PaisNome = "";
         ZZ12CategoriaNome = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.atracao__default(),
            new Object[][] {
                new Object[] {
               T00022_A7AtracaoId, T00022_A8AtracaoNome, T00022_A40000AtracaoFoto_GXI, T00022_A9PaisId, T00022_A11CategoriaId, T00022_n11CategoriaId, T00022_A13AtracaoFoto
               }
               , new Object[] {
               T00023_A7AtracaoId, T00023_A8AtracaoNome, T00023_A40000AtracaoFoto_GXI, T00023_A9PaisId, T00023_A11CategoriaId, T00023_n11CategoriaId, T00023_A13AtracaoFoto
               }
               , new Object[] {
               T00024_A10PaisNome
               }
               , new Object[] {
               T00025_A12CategoriaNome
               }
               , new Object[] {
               T00026_A7AtracaoId, T00026_A8AtracaoNome, T00026_A10PaisNome, T00026_A12CategoriaNome, T00026_A40000AtracaoFoto_GXI, T00026_A9PaisId, T00026_A11CategoriaId, T00026_n11CategoriaId, T00026_A13AtracaoFoto
               }
               , new Object[] {
               T00027_A10PaisNome
               }
               , new Object[] {
               T00028_A12CategoriaNome
               }
               , new Object[] {
               T00029_A7AtracaoId
               }
               , new Object[] {
               T000210_A7AtracaoId
               }
               , new Object[] {
               T000211_A7AtracaoId
               }
               , new Object[] {
               T000212_A7AtracaoId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000216_A10PaisNome
               }
               , new Object[] {
               T000217_A12CategoriaNome
               }
               , new Object[] {
               T000218_A7AtracaoId
               }
            }
         );
      }

      private short Z7AtracaoId ;
      private short Z9PaisId ;
      private short Z11CategoriaId ;
      private short GxWebError ;
      private short A9PaisId ;
      private short A11CategoriaId ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A7AtracaoId ;
      private short GX_JID ;
      private short RcdFound2 ;
      private short nIsDirty_2 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short ZZ7AtracaoId ;
      private short ZZ9PaisId ;
      private short ZZ11CategoriaId ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtAtracaoId_Enabled ;
      private int edtAtracaoNome_Enabled ;
      private int edtPaisId_Enabled ;
      private int imgprompt_9_Visible ;
      private int edtPaisNome_Enabled ;
      private int edtCategoriaId_Enabled ;
      private int imgprompt_11_Visible ;
      private int edtCategoriaNome_Enabled ;
      private int imgAtracaoFoto_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int idxLst ;
      private string sPrefix ;
      private string Z8AtracaoNome ;
      private string scmdbuf ;
      private string gxfirstwebparm ;
      private string gxfirstwebparm_bkp ;
      private string GXKey ;
      private string PreviousTooltip ;
      private string PreviousCaption ;
      private string GX_FocusControl ;
      private string edtAtracaoId_Internalname ;
      private string divMaintable_Internalname ;
      private string divTitlecontainer_Internalname ;
      private string lblTitle_Internalname ;
      private string lblTitle_Jsonclick ;
      private string ClassString ;
      private string StyleString ;
      private string divFormcontainer_Internalname ;
      private string divToolbarcell_Internalname ;
      private string TempTags ;
      private string bttBtn_first_Internalname ;
      private string bttBtn_first_Jsonclick ;
      private string bttBtn_previous_Internalname ;
      private string bttBtn_previous_Jsonclick ;
      private string bttBtn_next_Internalname ;
      private string bttBtn_next_Jsonclick ;
      private string bttBtn_last_Internalname ;
      private string bttBtn_last_Jsonclick ;
      private string bttBtn_select_Internalname ;
      private string bttBtn_select_Jsonclick ;
      private string edtAtracaoId_Jsonclick ;
      private string edtAtracaoNome_Internalname ;
      private string A8AtracaoNome ;
      private string edtAtracaoNome_Jsonclick ;
      private string edtPaisId_Internalname ;
      private string edtPaisId_Jsonclick ;
      private string sImgUrl ;
      private string imgprompt_9_Internalname ;
      private string imgprompt_9_Link ;
      private string edtPaisNome_Internalname ;
      private string A10PaisNome ;
      private string edtPaisNome_Jsonclick ;
      private string edtCategoriaId_Internalname ;
      private string edtCategoriaId_Jsonclick ;
      private string imgprompt_11_Internalname ;
      private string imgprompt_11_Link ;
      private string edtCategoriaNome_Internalname ;
      private string A12CategoriaNome ;
      private string edtCategoriaNome_Jsonclick ;
      private string imgAtracaoFoto_Internalname ;
      private string bttBtn_enter_Internalname ;
      private string bttBtn_enter_Jsonclick ;
      private string bttBtn_cancel_Internalname ;
      private string bttBtn_cancel_Jsonclick ;
      private string bttBtn_delete_Internalname ;
      private string bttBtn_delete_Jsonclick ;
      private string Gx_mode ;
      private string sEvt ;
      private string EvtGridId ;
      private string EvtRowId ;
      private string sEvtType ;
      private string endTrnMsgTxt ;
      private string endTrnMsgCod ;
      private string Z10PaisNome ;
      private string Z12CategoriaNome ;
      private string sMode2 ;
      private string sDynURL ;
      private string FormProcess ;
      private string bodyStyle ;
      private string GXCCtlgxBlob ;
      private string ZZ8AtracaoNome ;
      private string ZZ10PaisNome ;
      private string ZZ12CategoriaNome ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool n11CategoriaId ;
      private bool wbErr ;
      private bool A13AtracaoFoto_IsBlob ;
      private string A40000AtracaoFoto_GXI ;
      private string Z40000AtracaoFoto_GXI ;
      private string ZZ40000AtracaoFoto_GXI ;
      private string A13AtracaoFoto ;
      private string Z13AtracaoFoto ;
      private string ZZ13AtracaoFoto ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] T00026_A7AtracaoId ;
      private string[] T00026_A8AtracaoNome ;
      private string[] T00026_A10PaisNome ;
      private string[] T00026_A12CategoriaNome ;
      private string[] T00026_A40000AtracaoFoto_GXI ;
      private short[] T00026_A9PaisId ;
      private short[] T00026_A11CategoriaId ;
      private bool[] T00026_n11CategoriaId ;
      private string[] T00026_A13AtracaoFoto ;
      private string[] T00024_A10PaisNome ;
      private string[] T00025_A12CategoriaNome ;
      private string[] T00027_A10PaisNome ;
      private string[] T00028_A12CategoriaNome ;
      private short[] T00029_A7AtracaoId ;
      private short[] T00023_A7AtracaoId ;
      private string[] T00023_A8AtracaoNome ;
      private string[] T00023_A40000AtracaoFoto_GXI ;
      private short[] T00023_A9PaisId ;
      private short[] T00023_A11CategoriaId ;
      private bool[] T00023_n11CategoriaId ;
      private string[] T00023_A13AtracaoFoto ;
      private short[] T000210_A7AtracaoId ;
      private short[] T000211_A7AtracaoId ;
      private short[] T00022_A7AtracaoId ;
      private string[] T00022_A8AtracaoNome ;
      private string[] T00022_A40000AtracaoFoto_GXI ;
      private short[] T00022_A9PaisId ;
      private short[] T00022_A11CategoriaId ;
      private bool[] T00022_n11CategoriaId ;
      private string[] T00022_A13AtracaoFoto ;
      private short[] T000212_A7AtracaoId ;
      private string[] T000216_A10PaisNome ;
      private string[] T000217_A12CategoriaNome ;
      private short[] T000218_A7AtracaoId ;
      private GXWebForm Form ;
   }

   public class atracao__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
         ,new ForEachCursor(def[4])
         ,new ForEachCursor(def[5])
         ,new ForEachCursor(def[6])
         ,new ForEachCursor(def[7])
         ,new ForEachCursor(def[8])
         ,new ForEachCursor(def[9])
         ,new ForEachCursor(def[10])
         ,new UpdateCursor(def[11])
         ,new UpdateCursor(def[12])
         ,new UpdateCursor(def[13])
         ,new ForEachCursor(def[14])
         ,new ForEachCursor(def[15])
         ,new ForEachCursor(def[16])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00026;
          prmT00026 = new Object[] {
          new ParDef("@AtracaoId",GXType.Int16,4,0)
          };
          Object[] prmT00024;
          prmT00024 = new Object[] {
          new ParDef("@PaisId",GXType.Int16,4,0)
          };
          Object[] prmT00025;
          prmT00025 = new Object[] {
          new ParDef("@CategoriaId",GXType.Int16,4,0){Nullable=true}
          };
          Object[] prmT00027;
          prmT00027 = new Object[] {
          new ParDef("@PaisId",GXType.Int16,4,0)
          };
          Object[] prmT00028;
          prmT00028 = new Object[] {
          new ParDef("@CategoriaId",GXType.Int16,4,0){Nullable=true}
          };
          Object[] prmT00029;
          prmT00029 = new Object[] {
          new ParDef("@AtracaoId",GXType.Int16,4,0)
          };
          Object[] prmT00023;
          prmT00023 = new Object[] {
          new ParDef("@AtracaoId",GXType.Int16,4,0)
          };
          Object[] prmT000210;
          prmT000210 = new Object[] {
          new ParDef("@AtracaoId",GXType.Int16,4,0)
          };
          Object[] prmT000211;
          prmT000211 = new Object[] {
          new ParDef("@AtracaoId",GXType.Int16,4,0)
          };
          Object[] prmT00022;
          prmT00022 = new Object[] {
          new ParDef("@AtracaoId",GXType.Int16,4,0)
          };
          Object[] prmT000212;
          prmT000212 = new Object[] {
          new ParDef("@AtracaoNome",GXType.NChar,20,0) ,
          new ParDef("@AtracaoFoto",GXType.Blob,1024,0){InDB=false} ,
          new ParDef("@AtracaoFoto_GXI",GXType.VarChar,2048,0){AddAtt=true, ImgIdx=1, Tbl="Atracao", Fld="AtracaoFoto"} ,
          new ParDef("@PaisId",GXType.Int16,4,0) ,
          new ParDef("@CategoriaId",GXType.Int16,4,0){Nullable=true}
          };
          Object[] prmT000213;
          prmT000213 = new Object[] {
          new ParDef("@AtracaoNome",GXType.NChar,20,0) ,
          new ParDef("@PaisId",GXType.Int16,4,0) ,
          new ParDef("@CategoriaId",GXType.Int16,4,0){Nullable=true} ,
          new ParDef("@AtracaoId",GXType.Int16,4,0)
          };
          Object[] prmT000214;
          prmT000214 = new Object[] {
          new ParDef("@AtracaoFoto",GXType.Blob,1024,0){InDB=false} ,
          new ParDef("@AtracaoFoto_GXI",GXType.VarChar,2048,0){AddAtt=true, ImgIdx=0, Tbl="Atracao", Fld="AtracaoFoto"} ,
          new ParDef("@AtracaoId",GXType.Int16,4,0)
          };
          Object[] prmT000215;
          prmT000215 = new Object[] {
          new ParDef("@AtracaoId",GXType.Int16,4,0)
          };
          Object[] prmT000218;
          prmT000218 = new Object[] {
          };
          Object[] prmT000216;
          prmT000216 = new Object[] {
          new ParDef("@PaisId",GXType.Int16,4,0)
          };
          Object[] prmT000217;
          prmT000217 = new Object[] {
          new ParDef("@CategoriaId",GXType.Int16,4,0){Nullable=true}
          };
          def= new CursorDef[] {
              new CursorDef("T00022", "SELECT [AtracaoId], [AtracaoNome], [AtracaoFoto_GXI], [PaisId], [CategoriaId], [AtracaoFoto] FROM [Atracao] WITH (UPDLOCK) WHERE [AtracaoId] = @AtracaoId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00022,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00023", "SELECT [AtracaoId], [AtracaoNome], [AtracaoFoto_GXI], [PaisId], [CategoriaId], [AtracaoFoto] FROM [Atracao] WHERE [AtracaoId] = @AtracaoId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00023,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00024", "SELECT [PaisNome] FROM [Pais] WHERE [PaisId] = @PaisId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00024,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00025", "SELECT [CategoriaNome] FROM [Categoria] WHERE [CategoriaId] = @CategoriaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00025,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00026", "SELECT TM1.[AtracaoId], TM1.[AtracaoNome], T2.[PaisNome], T3.[CategoriaNome], TM1.[AtracaoFoto_GXI], TM1.[PaisId], TM1.[CategoriaId], TM1.[AtracaoFoto] FROM (([Atracao] TM1 INNER JOIN [Pais] T2 ON T2.[PaisId] = TM1.[PaisId]) LEFT JOIN [Categoria] T3 ON T3.[CategoriaId] = TM1.[CategoriaId]) WHERE TM1.[AtracaoId] = @AtracaoId ORDER BY TM1.[AtracaoId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00026,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00027", "SELECT [PaisNome] FROM [Pais] WHERE [PaisId] = @PaisId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00027,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00028", "SELECT [CategoriaNome] FROM [Categoria] WHERE [CategoriaId] = @CategoriaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00028,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00029", "SELECT [AtracaoId] FROM [Atracao] WHERE [AtracaoId] = @AtracaoId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00029,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000210", "SELECT TOP 1 [AtracaoId] FROM [Atracao] WHERE ( [AtracaoId] > @AtracaoId) ORDER BY [AtracaoId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000210,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T000211", "SELECT TOP 1 [AtracaoId] FROM [Atracao] WHERE ( [AtracaoId] < @AtracaoId) ORDER BY [AtracaoId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000211,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T000212", "INSERT INTO [Atracao]([AtracaoNome], [AtracaoFoto], [AtracaoFoto_GXI], [PaisId], [CategoriaId]) VALUES(@AtracaoNome, @AtracaoFoto, @AtracaoFoto_GXI, @PaisId, @CategoriaId); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT000212)
             ,new CursorDef("T000213", "UPDATE [Atracao] SET [AtracaoNome]=@AtracaoNome, [PaisId]=@PaisId, [CategoriaId]=@CategoriaId  WHERE [AtracaoId] = @AtracaoId", GxErrorMask.GX_NOMASK,prmT000213)
             ,new CursorDef("T000214", "UPDATE [Atracao] SET [AtracaoFoto]=@AtracaoFoto, [AtracaoFoto_GXI]=@AtracaoFoto_GXI  WHERE [AtracaoId] = @AtracaoId", GxErrorMask.GX_NOMASK,prmT000214)
             ,new CursorDef("T000215", "DELETE FROM [Atracao]  WHERE [AtracaoId] = @AtracaoId", GxErrorMask.GX_NOMASK,prmT000215)
             ,new CursorDef("T000216", "SELECT [PaisNome] FROM [Pais] WHERE [PaisId] = @PaisId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000216,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000217", "SELECT [CategoriaNome] FROM [Categoria] WHERE [CategoriaId] = @CategoriaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000217,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000218", "SELECT [AtracaoId] FROM [Atracao] ORDER BY [AtracaoId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000218,100, GxCacheFrequency.OFF ,true,false )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((short[]) buf[0])[0] = rslt.getShort(1);
                ((string[]) buf[1])[0] = rslt.getString(2, 20);
                ((string[]) buf[2])[0] = rslt.getMultimediaUri(3);
                ((short[]) buf[3])[0] = rslt.getShort(4);
                ((short[]) buf[4])[0] = rslt.getShort(5);
                ((bool[]) buf[5])[0] = rslt.wasNull(5);
                ((string[]) buf[6])[0] = rslt.getMultimediaFile(6, rslt.getVarchar(3));
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1);
                ((string[]) buf[1])[0] = rslt.getString(2, 20);
                ((string[]) buf[2])[0] = rslt.getMultimediaUri(3);
                ((short[]) buf[3])[0] = rslt.getShort(4);
                ((short[]) buf[4])[0] = rslt.getShort(5);
                ((bool[]) buf[5])[0] = rslt.wasNull(5);
                ((string[]) buf[6])[0] = rslt.getMultimediaFile(6, rslt.getVarchar(3));
                return;
             case 2 :
                ((string[]) buf[0])[0] = rslt.getString(1, 20);
                return;
             case 3 :
                ((string[]) buf[0])[0] = rslt.getString(1, 20);
                return;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1);
                ((string[]) buf[1])[0] = rslt.getString(2, 20);
                ((string[]) buf[2])[0] = rslt.getString(3, 20);
                ((string[]) buf[3])[0] = rslt.getString(4, 20);
                ((string[]) buf[4])[0] = rslt.getMultimediaUri(5);
                ((short[]) buf[5])[0] = rslt.getShort(6);
                ((short[]) buf[6])[0] = rslt.getShort(7);
                ((bool[]) buf[7])[0] = rslt.wasNull(7);
                ((string[]) buf[8])[0] = rslt.getMultimediaFile(8, rslt.getVarchar(5));
                return;
             case 5 :
                ((string[]) buf[0])[0] = rslt.getString(1, 20);
                return;
             case 6 :
                ((string[]) buf[0])[0] = rslt.getString(1, 20);
                return;
             case 7 :
                ((short[]) buf[0])[0] = rslt.getShort(1);
                return;
             case 8 :
                ((short[]) buf[0])[0] = rslt.getShort(1);
                return;
             case 9 :
                ((short[]) buf[0])[0] = rslt.getShort(1);
                return;
             case 10 :
                ((short[]) buf[0])[0] = rslt.getShort(1);
                return;
             case 14 :
                ((string[]) buf[0])[0] = rslt.getString(1, 20);
                return;
             case 15 :
                ((string[]) buf[0])[0] = rslt.getString(1, 20);
                return;
             case 16 :
                ((short[]) buf[0])[0] = rslt.getShort(1);
                return;
       }
    }

 }

}
