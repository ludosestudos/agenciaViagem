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
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
namespace GeneXus.Programs {
   public class reorg : GXReorganization
   {
      public reorg( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public reorg( IGxContext context )
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

      void executePrivate( )
      {
         if ( PreviousCheck() )
         {
            ExecuteReorganization( ) ;
         }
      }

      private void FirstActions( )
      {
         /* Load data into tables. */
      }

      public void ReorganizeAtracao( )
      {
         string cmdBuffer = "";
         /* Indices for table Atracao */
         try
         {
            cmdBuffer=" CREATE TABLE [GXA0002] ([AtracaoId] smallint NOT NULL IDENTITY(1,1), [AtracaoNome] nchar(20) NOT NULL , [PaisId] smallint NOT NULL , [CategoriaId] smallint NULL , [AtracaoFoto] VARBINARY(MAX) NOT NULL , [AtracaoFoto_GXI] varchar(2048) NOT NULL )  "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch
         {
            try
            {
               DropTableConstraints( "[GXA0002]") ;
               cmdBuffer=" DROP TABLE [GXA0002] "
               ;
               RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
               RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
               RGZ.ExecuteStmt() ;
               RGZ.Drop();
            }
            catch
            {
               try
               {
                  DropTableConstraints( "[GXA0002]") ;
                  cmdBuffer=" DROP VIEW [GXA0002] "
                  ;
                  RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
                  RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
                  RGZ.ExecuteStmt() ;
                  RGZ.Drop();
               }
               catch
               {
                  try
                  {
                     DropTableConstraints( "[GXA0002]") ;
                     cmdBuffer=" DROP FUNCTION [GXA0002] "
                     ;
                     RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
                     RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
                     RGZ.ExecuteStmt() ;
                     RGZ.Drop();
                  }
                  catch
                  {
                  }
               }
            }
            cmdBuffer=" CREATE TABLE [GXA0002] ([AtracaoId] smallint NOT NULL IDENTITY(1,1), [AtracaoNome] nchar(20) NOT NULL , [PaisId] smallint NOT NULL , [CategoriaId] smallint NULL , [AtracaoFoto] VARBINARY(MAX) NOT NULL , [AtracaoFoto_GXI] varchar(2048) NOT NULL )  "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         new atracaoconversion(context ).execute( ) ;
         try
         {
            DropTableConstraints( "[Atracao]") ;
            cmdBuffer=" DROP TABLE [Atracao] "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch
         {
            try
            {
               DropTableConstraints( "[Atracao]") ;
               cmdBuffer=" DROP VIEW [Atracao] "
               ;
               RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
               RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
               RGZ.ExecuteStmt() ;
               RGZ.Drop();
            }
            catch
            {
               try
               {
                  DropTableConstraints( "[Atracao]") ;
                  cmdBuffer=" DROP FUNCTION [Atracao] "
                  ;
                  RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
                  RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
                  RGZ.ExecuteStmt() ;
                  RGZ.Drop();
               }
               catch
               {
               }
            }
         }
         RGZ = new GxCommand(dsDefault.Db, "sp_rename", dsDefault,0,true,false,null);
         RGZ.CommandType = CommandType.StoredProcedure;
         RGZ.AddParameter("@objname","[GXA0002]");
         RGZ.AddParameter("@newname","Atracao");
         RGZ.ExecuteStmt();
         cmdBuffer=" ALTER TABLE [Atracao] ADD PRIMARY KEY([AtracaoId]) "
         ;
         RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
         RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
         RGZ.ExecuteStmt() ;
         RGZ.Drop();
         try
         {
            cmdBuffer=" CREATE NONCLUSTERED INDEX [IATRACAO1] ON [Atracao] ([PaisId] ) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch
         {
            cmdBuffer=" DROP INDEX [IATRACAO1] ON [Atracao] "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
            cmdBuffer=" CREATE NONCLUSTERED INDEX [IATRACAO1] ON [Atracao] ([PaisId] ) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         try
         {
            cmdBuffer=" CREATE NONCLUSTERED INDEX [IATRACAO2] ON [Atracao] ([CategoriaId] ) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch
         {
            cmdBuffer=" DROP INDEX [IATRACAO2] ON [Atracao] "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
            cmdBuffer=" CREATE NONCLUSTERED INDEX [IATRACAO2] ON [Atracao] ([CategoriaId] ) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
      }

      public void RIAtracaoPais( )
      {
         string cmdBuffer;
         try
         {
            cmdBuffer=" ALTER TABLE [Atracao] ADD CONSTRAINT [IATRACAO1] FOREIGN KEY ([PaisId]) REFERENCES [Pais] ([PaisId]) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch
         {
            try
            {
               cmdBuffer=" ALTER TABLE [Atracao] DROP CONSTRAINT [IATRACAO1] "
               ;
               RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
               RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
               RGZ.ExecuteStmt() ;
               RGZ.Drop();
            }
            catch
            {
            }
            cmdBuffer=" ALTER TABLE [Atracao] ADD CONSTRAINT [IATRACAO1] FOREIGN KEY ([PaisId]) REFERENCES [Pais] ([PaisId]) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
      }

      public void RIAtracaoCategoria( )
      {
         string cmdBuffer;
         try
         {
            cmdBuffer=" ALTER TABLE [Atracao] ADD CONSTRAINT [IATRACAO2] FOREIGN KEY ([CategoriaId]) REFERENCES [Categoria] ([CategoriaId]) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch
         {
            try
            {
               cmdBuffer=" ALTER TABLE [Atracao] DROP CONSTRAINT [IATRACAO2] "
               ;
               RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
               RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
               RGZ.ExecuteStmt() ;
               RGZ.Drop();
            }
            catch
            {
            }
            cmdBuffer=" ALTER TABLE [Atracao] ADD CONSTRAINT [IATRACAO2] FOREIGN KEY ([CategoriaId]) REFERENCES [Categoria] ([CategoriaId]) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
      }

      private void TablesCount( )
      {
         if ( ! IsResumeMode( ) )
         {
            /* Using cursor P00012 */
            pr_default.execute(0);
            AtracaoCount = P00012_AAtracaoCount[0];
            pr_default.close(0);
            PrintRecordCount ( "Atracao" ,  AtracaoCount );
         }
      }

      private bool PreviousCheck( )
      {
         if ( ! IsResumeMode( ) )
         {
            if ( GXUtil.DbmsVersion( context, "DEFAULT") < 10 )
            {
               SetCheckError ( GXResourceManager.GetMessage("GXM_bad_DBMS_version", new   object[]  {"2012"}) ) ;
               return false ;
            }
         }
         if ( ! MustRunCheck( ) )
         {
            return true ;
         }
         if ( GXUtil.IsSQLSERVER2005( context, "DEFAULT") )
         {
            /* Using cursor P00023 */
            pr_default.execute(1);
            while ( (pr_default.getStatus(1) != 101) )
            {
               sSchemaVar = P00023_AsSchemaVar[0];
               nsSchemaVar = P00023_nsSchemaVar[0];
               pr_default.readNext(1);
            }
            pr_default.close(1);
         }
         else
         {
            /* Using cursor P00034 */
            pr_default.execute(2);
            while ( (pr_default.getStatus(2) != 101) )
            {
               sSchemaVar = P00034_AsSchemaVar[0];
               nsSchemaVar = P00034_nsSchemaVar[0];
               pr_default.readNext(2);
            }
            pr_default.close(2);
         }
         if ( ! tableexist("Atracao",sSchemaVar) )
         {
            SetCheckError ( GXResourceManager.GetMessage("GXM_table_not_exist", new   object[]  {"Atracao"}) ) ;
            return false ;
         }
         return true ;
      }

      private bool tableexist( string sTableName ,
                               string sMySchemaName )
      {
         bool result;
         result = false;
         /* Using cursor P00045 */
         pr_default.execute(3, new Object[] {sTableName, sMySchemaName});
         while ( (pr_default.getStatus(3) != 101) )
         {
            tablename = P00045_Atablename[0];
            ntablename = P00045_ntablename[0];
            schemaname = P00045_Aschemaname[0];
            nschemaname = P00045_nschemaname[0];
            result = true;
            pr_default.readNext(3);
         }
         pr_default.close(3);
         return result ;
      }

      private bool ColumnExist( string sTableName ,
                                string sMySchemaName ,
                                string sMyColumnName )
      {
         bool result;
         result = false;
         /* Using cursor P00056 */
         pr_default.execute(4, new Object[] {sTableName, sMySchemaName, sMyColumnName});
         while ( (pr_default.getStatus(4) != 101) )
         {
            tablename = P00056_Atablename[0];
            ntablename = P00056_ntablename[0];
            schemaname = P00056_Aschemaname[0];
            nschemaname = P00056_nschemaname[0];
            columnname = P00056_Acolumnname[0];
            ncolumnname = P00056_ncolumnname[0];
            result = true;
            pr_default.readNext(4);
         }
         pr_default.close(4);
         return result ;
      }

      private void ExecuteOnlyTablesReorganization( )
      {
         ReorgExecute.RegisterBlockForSubmit( 1 ,  "ReorganizeAtracao" , new Object[]{ });
      }

      private void ExecuteOnlyRisReorganization( )
      {
         ReorgExecute.RegisterBlockForSubmit( 2 ,  "RIAtracaoPais" , new Object[]{ });
         ReorgExecute.RegisterBlockForSubmit( 3 ,  "RIAtracaoCategoria" , new Object[]{ });
      }

      private void ExecuteTablesReorganization( )
      {
         ExecuteOnlyTablesReorganization( ) ;
         ExecuteOnlyRisReorganization( ) ;
         ReorgExecute.SubmitAll() ;
      }

      private void SetPrecedence( )
      {
         SetPrecedencetables( ) ;
         SetPrecedenceris( ) ;
      }

      private void SetPrecedencetables( )
      {
         GXReorganization.SetMsg( 1 ,  GXResourceManager.GetMessage("GXM_fileupdate", new   object[]  {"Atracao", ""}) );
      }

      private void SetPrecedenceris( )
      {
         GXReorganization.SetMsg( 2 ,  GXResourceManager.GetMessage("GXM_refintcrea", new   object[]  {"[IATRACAO1]"}) );
         ReorgExecute.RegisterPrecedence( "RIAtracaoPais" ,  "ReorganizeAtracao" );
         GXReorganization.SetMsg( 3 ,  GXResourceManager.GetMessage("GXM_refintcrea", new   object[]  {"[IATRACAO2]"}) );
         ReorgExecute.RegisterPrecedence( "RIAtracaoCategoria" ,  "ReorganizeAtracao" );
      }

      private void ExecuteReorganization( )
      {
         if ( ErrCode == 0 )
         {
            TablesCount( ) ;
            if ( ! PrintOnlyRecordCount( ) )
            {
               FirstActions( ) ;
               SetPrecedence( ) ;
               ExecuteTablesReorganization( ) ;
            }
         }
      }

      public void DropTableConstraints( string sTableName )
      {
         string cmdBuffer;
         /* Using cursor P00067 */
         pr_default.execute(5, new Object[] {sTableName});
         while ( (pr_default.getStatus(5) != 101) )
         {
            constid = P00067_Aconstid[0];
            nconstid = P00067_nconstid[0];
            fkeyid = P00067_Afkeyid[0];
            nfkeyid = P00067_nfkeyid[0];
            rkeyid = P00067_Arkeyid[0];
            nrkeyid = P00067_nrkeyid[0];
            cmdBuffer = "ALTER TABLE " + "[" + fkeyid + "] DROP CONSTRAINT " + constid;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
            pr_default.readNext(5);
         }
         pr_default.close(5);
      }

      public void UtilsCleanup( )
      {
         this.cleanup();
      }

      public override void cleanup( )
      {
         CloseOpenCursors();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         scmdbuf = "";
         P00012_AAtracaoCount = new int[1] ;
         sSchemaVar = "";
         nsSchemaVar = false;
         P00023_AsSchemaVar = new string[] {""} ;
         P00023_nsSchemaVar = new bool[] {false} ;
         P00034_AsSchemaVar = new string[] {""} ;
         P00034_nsSchemaVar = new bool[] {false} ;
         sTableName = "";
         sMySchemaName = "";
         tablename = "";
         ntablename = false;
         schemaname = "";
         nschemaname = false;
         P00045_Atablename = new string[] {""} ;
         P00045_ntablename = new bool[] {false} ;
         P00045_Aschemaname = new string[] {""} ;
         P00045_nschemaname = new bool[] {false} ;
         sMyColumnName = "";
         columnname = "";
         ncolumnname = false;
         P00056_Atablename = new string[] {""} ;
         P00056_ntablename = new bool[] {false} ;
         P00056_Aschemaname = new string[] {""} ;
         P00056_nschemaname = new bool[] {false} ;
         P00056_Acolumnname = new string[] {""} ;
         P00056_ncolumnname = new bool[] {false} ;
         constid = "";
         nconstid = false;
         fkeyid = "";
         nfkeyid = false;
         P00067_Aconstid = new string[] {""} ;
         P00067_nconstid = new bool[] {false} ;
         P00067_Afkeyid = new string[] {""} ;
         P00067_nfkeyid = new bool[] {false} ;
         P00067_Arkeyid = new int[1] ;
         P00067_nrkeyid = new bool[] {false} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.reorg__default(),
            new Object[][] {
                new Object[] {
               P00012_AAtracaoCount
               }
               , new Object[] {
               P00023_AsSchemaVar
               }
               , new Object[] {
               P00034_AsSchemaVar
               }
               , new Object[] {
               P00045_Atablename, P00045_Aschemaname
               }
               , new Object[] {
               P00056_Atablename, P00056_Aschemaname, P00056_Acolumnname
               }
               , new Object[] {
               P00067_Aconstid, P00067_Afkeyid, P00067_Arkeyid
               }
            }
         );
         /* GeneXus formulas. */
      }

      protected short ErrCode ;
      protected int AtracaoCount ;
      protected int rkeyid ;
      protected string scmdbuf ;
      protected string sSchemaVar ;
      protected string sTableName ;
      protected string sMySchemaName ;
      protected string sMyColumnName ;
      protected bool nsSchemaVar ;
      protected bool ntablename ;
      protected bool nschemaname ;
      protected bool ncolumnname ;
      protected bool nconstid ;
      protected bool nfkeyid ;
      protected bool nrkeyid ;
      protected string tablename ;
      protected string schemaname ;
      protected string columnname ;
      protected string constid ;
      protected string fkeyid ;
      protected IGxDataStore dsDefault ;
      protected GxCommand RGZ ;
      protected IDataStoreProvider pr_default ;
      protected int[] P00012_AAtracaoCount ;
      protected string[] P00023_AsSchemaVar ;
      protected bool[] P00023_nsSchemaVar ;
      protected string[] P00034_AsSchemaVar ;
      protected bool[] P00034_nsSchemaVar ;
      protected string[] P00045_Atablename ;
      protected bool[] P00045_ntablename ;
      protected string[] P00045_Aschemaname ;
      protected bool[] P00045_nschemaname ;
      protected string[] P00056_Atablename ;
      protected bool[] P00056_ntablename ;
      protected string[] P00056_Aschemaname ;
      protected bool[] P00056_nschemaname ;
      protected string[] P00056_Acolumnname ;
      protected bool[] P00056_ncolumnname ;
      protected string[] P00067_Aconstid ;
      protected bool[] P00067_nconstid ;
      protected string[] P00067_Afkeyid ;
      protected bool[] P00067_nfkeyid ;
      protected int[] P00067_Arkeyid ;
      protected bool[] P00067_nrkeyid ;
   }

   public class reorg__default : DataStoreHelperBase, IDataStoreHelper
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
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP00012;
          prmP00012 = new Object[] {
          };
          Object[] prmP00023;
          prmP00023 = new Object[] {
          };
          Object[] prmP00034;
          prmP00034 = new Object[] {
          };
          Object[] prmP00045;
          prmP00045 = new Object[] {
          new ParDef("@sTableName",GXType.Char,255,0) ,
          new ParDef("@sMySchemaName",GXType.Char,255,0)
          };
          Object[] prmP00056;
          prmP00056 = new Object[] {
          new ParDef("@sTableName",GXType.Char,255,0) ,
          new ParDef("@sMySchemaName",GXType.Char,255,0) ,
          new ParDef("@sMyColumnName",GXType.Char,255,0)
          };
          Object[] prmP00067;
          prmP00067 = new Object[] {
          new ParDef("@sTableName",GXType.Char,255,0)
          };
          def= new CursorDef[] {
              new CursorDef("P00012", "SELECT COUNT(*) FROM [Atracao] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00012,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("P00023", "SELECT SCHEMA_NAME() ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00023,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("P00034", "SELECT USER_NAME() ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00034,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("P00045", "SELECT TABLE_NAME, TABLE_SCHEMA FROM INFORMATION_SCHEMA.TABLES WHERE (TABLE_NAME = @sTableName) AND (TABLE_SCHEMA = @sMySchemaName) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00045,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("P00056", "SELECT TABLE_NAME, TABLE_SCHEMA, COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE (TABLE_NAME = @sTableName) AND (TABLE_SCHEMA = @sMySchemaName) AND (COLUMN_NAME = @sMyColumnName) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00056,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("P00067", "SELECT OBJECT_NAME(object_id), OBJECT_NAME(parent_object_id), referenced_object_id FROM sys.foreign_keys WHERE referenced_object_id = OBJECT_ID(RTRIM(LTRIM(@sTableName))) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00067,100, GxCacheFrequency.OFF ,true,false )
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
                ((int[]) buf[0])[0] = rslt.getInt(1);
                return;
             case 1 :
                ((string[]) buf[0])[0] = rslt.getString(1, 255);
                return;
             case 2 :
                ((string[]) buf[0])[0] = rslt.getString(1, 255);
                return;
             case 3 :
                ((string[]) buf[0])[0] = rslt.getVarchar(1);
                ((string[]) buf[1])[0] = rslt.getVarchar(2);
                return;
             case 4 :
                ((string[]) buf[0])[0] = rslt.getVarchar(1);
                ((string[]) buf[1])[0] = rslt.getVarchar(2);
                ((string[]) buf[2])[0] = rslt.getVarchar(3);
                return;
             case 5 :
                ((string[]) buf[0])[0] = rslt.getVarchar(1);
                ((string[]) buf[1])[0] = rslt.getVarchar(2);
                ((int[]) buf[2])[0] = rslt.getInt(3);
                return;
       }
    }

 }

}
