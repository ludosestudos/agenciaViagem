using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Cryptography;
using GeneXus.Reorg;
using System.Threading;
using GeneXus.Programs;
using System.Data;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.Procedure;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
namespace GeneXus.Programs {
   public class atracaoconversion : GXProcedure
   {
      public atracaoconversion( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public atracaoconversion( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void execute( )
      {
         initialize();
         executePrivate();
      }

      public void executeSubmit( )
      {
         atracaoconversion objatracaoconversion;
         objatracaoconversion = new atracaoconversion();
         objatracaoconversion.context.SetSubmitInitialConfig(context);
         objatracaoconversion.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objatracaoconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((atracaoconversion)stateInfo).executePrivate();
         }
         catch ( Exception e )
         {
            GXUtil.SaveToEventLog( "Design", e);
            throw;
         }
      }

      void executePrivate( )
      {
         /* GeneXus formulas */
         /* Output device settings */
         cmdBuffer=" SET IDENTITY_INSERT [GXA0002] ON "
         ;
         RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
         RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
         RGZ.ExecuteStmt() ;
         RGZ.Drop();
         /* Using cursor ATRACAOCON2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A11CategoriaId = ATRACAOCON2_A11CategoriaId[0];
            n11CategoriaId = ATRACAOCON2_n11CategoriaId[0];
            A9PaisId = ATRACAOCON2_A9PaisId[0];
            A8AtracaoNome = ATRACAOCON2_A8AtracaoNome[0];
            A7AtracaoId = ATRACAOCON2_A7AtracaoId[0];
            A13AtracaoFoto = ATRACAOCON2_A13AtracaoFoto[0];
            /*
               INSERT RECORD ON TABLE GXA0002

            */
            AV2AtracaoId = A7AtracaoId;
            AV3AtracaoNome = A8AtracaoNome;
            AV4PaisId = A9PaisId;
            if ( ATRACAOCON2_n11CategoriaId[0] )
            {
               AV5CategoriaId = 0;
               nV5CategoriaId = false;
               nV5CategoriaId = true;
            }
            else
            {
               AV5CategoriaId = A11CategoriaId;
               nV5CategoriaId = false;
            }
            AV6AtracaoFoto = "";
            AV7AtracaoFoto_GXI = " ";
            /* Using cursor ATRACAOCON3 */
            pr_default.execute(1, new Object[] {AV2AtracaoId, AV3AtracaoNome, AV4PaisId, nV5CategoriaId, AV5CategoriaId, AV6AtracaoFoto, AV7AtracaoFoto_GXI});
            pr_default.close(1);
            dsDefault.SmartCacheProvider.SetUpdated("GXA0002");
            if ( (pr_default.getStatus(1) == 1) )
            {
               context.Gx_err = 1;
               Gx_emsg = (string)(GXResourceManager.GetMessage("GXM_noupdate"));
            }
            else
            {
               context.Gx_err = 0;
               Gx_emsg = "";
            }
            /* End Insert */
            pr_default.readNext(0);
         }
         pr_default.close(0);
         cmdBuffer=" SET IDENTITY_INSERT [GXA0002] OFF "
         ;
         RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
         RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
         RGZ.ExecuteStmt() ;
         RGZ.Drop();
         this.cleanup();
      }

      public override void cleanup( )
      {
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections();
         }
         ExitApp();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         cmdBuffer = "";
         scmdbuf = "";
         ATRACAOCON2_A11CategoriaId = new short[1] ;
         ATRACAOCON2_n11CategoriaId = new bool[] {false} ;
         ATRACAOCON2_A9PaisId = new short[1] ;
         ATRACAOCON2_A8AtracaoNome = new string[] {""} ;
         ATRACAOCON2_A7AtracaoId = new short[1] ;
         ATRACAOCON2_A13AtracaoFoto = new short[1] ;
         A8AtracaoNome = "";
         AV3AtracaoNome = "";
         AV6AtracaoFoto = "";
         AV7AtracaoFoto_GXI = "";
         Gx_emsg = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.atracaoconversion__default(),
            new Object[][] {
                new Object[] {
               ATRACAOCON2_A11CategoriaId, ATRACAOCON2_n11CategoriaId, ATRACAOCON2_A9PaisId, ATRACAOCON2_A8AtracaoNome, ATRACAOCON2_A7AtracaoId, ATRACAOCON2_A13AtracaoFoto
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A11CategoriaId ;
      private short A9PaisId ;
      private short A7AtracaoId ;
      private short A13AtracaoFoto ;
      private short AV2AtracaoId ;
      private short AV4PaisId ;
      private short AV5CategoriaId ;
      private int GIGXA0002 ;
      private string cmdBuffer ;
      private string scmdbuf ;
      private string A8AtracaoNome ;
      private string AV3AtracaoNome ;
      private string Gx_emsg ;
      private bool n11CategoriaId ;
      private bool nV5CategoriaId ;
      private string AV7AtracaoFoto_GXI ;
      private string AV6AtracaoFoto ;
      private IGxDataStore dsDefault ;
      private GxCommand RGZ ;
      private IDataStoreProvider pr_default ;
      private short[] ATRACAOCON2_A11CategoriaId ;
      private bool[] ATRACAOCON2_n11CategoriaId ;
      private short[] ATRACAOCON2_A9PaisId ;
      private string[] ATRACAOCON2_A8AtracaoNome ;
      private short[] ATRACAOCON2_A7AtracaoId ;
      private short[] ATRACAOCON2_A13AtracaoFoto ;
   }

   public class atracaoconversion__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new UpdateCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmATRACAOCON2;
          prmATRACAOCON2 = new Object[] {
          };
          Object[] prmATRACAOCON3;
          prmATRACAOCON3 = new Object[] {
          new ParDef("@AV2AtracaoId",GXType.Int16,4,0) ,
          new ParDef("@AV3AtracaoNome",GXType.Char,20,0) ,
          new ParDef("@AV4PaisId",GXType.Int16,4,0) ,
          new ParDef("@AV5CategoriaId",GXType.Int16,4,0){Nullable=true} ,
          new ParDef("@AV6AtracaoFoto",GXType.Blob,1024,0){InDB=false} ,
          new ParDef("@AV7AtracaoFoto_GXI",GXType.VarChar,2048,0)
          };
          def= new CursorDef[] {
              new CursorDef("ATRACAOCON2", "SELECT [CategoriaId], [PaisId], [AtracaoNome], [AtracaoId], [AtracaoFoto] FROM [Atracao] ORDER BY [AtracaoId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmATRACAOCON2,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("ATRACAOCON3", "INSERT INTO [GXA0002]([AtracaoId], [AtracaoNome], [PaisId], [CategoriaId], [AtracaoFoto], [AtracaoFoto_GXI]) VALUES(@AV2AtracaoId, @AV3AtracaoNome, @AV4PaisId, @AV5CategoriaId, @AV6AtracaoFoto, @AV7AtracaoFoto_GXI)", GxErrorMask.GX_NOMASK,prmATRACAOCON3)
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
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((short[]) buf[2])[0] = rslt.getShort(2);
                ((string[]) buf[3])[0] = rslt.getString(3, 20);
                ((short[]) buf[4])[0] = rslt.getShort(4);
                ((short[]) buf[5])[0] = rslt.getShort(5);
                return;
       }
    }

 }

}
