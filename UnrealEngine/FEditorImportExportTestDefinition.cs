using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000A56 RID: 2646
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.EditorImportExportTestDefinition")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FEditorImportExportTestDefinition : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008FB7 RID: 36791 RVA: 0x000CDAFE File Offset: 0x000CBCFE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FEditorImportExportTestDefinition._ScriptStructPtr != 0) ? FEditorImportExportTestDefinition._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.EditorImportExportTestDefinition", ref FEditorImportExportTestDefinition._ScriptStructPtr);
		}

		// Token: 0x170021EF RID: 8687
		// (get) Token: 0x06008FB8 RID: 36792 RVA: 0x000CDB24 File Offset: 0x000CBD24
		// (set) Token: 0x06008FB9 RID: 36793 RVA: 0x000CDB67 File Offset: 0x000CBD67
		public FFilePath ImportFilePath
		{
			get
			{
				base.FastCheckIsValid();
				FFilePath result;
				if ((result = this._ImportFilePath) == null)
				{
					result = (this._ImportFilePath = new FFilePath(base.NativePtr + (IntPtr)FEditorImportExportTestDefinition.__PropertyOffset_ImportFilePath, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFilePath.StaticStruct(), base.NativePtr + (IntPtr)FEditorImportExportTestDefinition.__PropertyOffset_ImportFilePath, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170021F0 RID: 8688
		// (get) Token: 0x06008FBA RID: 36794 RVA: 0x000CDB88 File Offset: 0x000CBD88
		// (set) Token: 0x06008FBB RID: 36795 RVA: 0x000CDB9C File Offset: 0x000CBD9C
		public unsafe string ExportFileExtension
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FEditorImportExportTestDefinition.__PropertyOffset_ExportFileExtension)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FEditorImportExportTestDefinition.__PropertyOffset_ExportFileExtension)), value);
			}
		}

		// Token: 0x170021F1 RID: 8689
		// (get) Token: 0x06008FBC RID: 36796 RVA: 0x000CDBB1 File Offset: 0x000CBDB1
		// (set) Token: 0x06008FBD RID: 36797 RVA: 0x000CDBC1 File Offset: 0x000CBDC1
		public unsafe bool bSkipExport
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEditorImportExportTestDefinition.__PropertyOffset_bSkipExport) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEditorImportExportTestDefinition.__PropertyOffset_bSkipExport) = (value ? 1 : 0);
			}
		}

		// Token: 0x170021F2 RID: 8690
		// (get) Token: 0x06008FBE RID: 36798 RVA: 0x000CDBD4 File Offset: 0x000CBDD4
		// (set) Token: 0x06008FBF RID: 36799 RVA: 0x000CDC17 File Offset: 0x000CBE17
		public TArray<FImportFactorySettingValues> FactorySettings
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FImportFactorySettingValues> result;
				if ((result = this._FactorySettings) == null)
				{
					result = (this._FactorySettings = new TArray<FImportFactorySettingValues>(base.NativePtr + (IntPtr)FEditorImportExportTestDefinition.__PropertyOffset_FactorySettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FactorySettings.CopyAssign(value);
			}
		}

		// Token: 0x06008FC0 RID: 36800 RVA: 0x000CDC25 File Offset: 0x000CBE25
		public FEditorImportExportTestDefinition()
		{
		}

		// Token: 0x06008FC1 RID: 36801 RVA: 0x000CDC2D File Offset: 0x000CBE2D
		public FEditorImportExportTestDefinition(FFilePath ImportFilePath, string ExportFileExtension, bool bSkipExport, TArray<FImportFactorySettingValues> FactorySettings)
		{
			this.ImportFilePath = ImportFilePath;
			this.ExportFileExtension = ExportFileExtension;
			this.bSkipExport = bSkipExport;
			this.FactorySettings = FactorySettings;
		}

		// Token: 0x06008FC2 RID: 36802 RVA: 0x000CDC52 File Offset: 0x000CBE52
		protected override IntPtr GetUStructPtr()
		{
			return FEditorImportExportTestDefinition.StaticStruct();
		}

		// Token: 0x06008FC3 RID: 36803 RVA: 0x000CDC5E File Offset: 0x000CBE5E
		[NullableContext(2)]
		public FEditorImportExportTestDefinition(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008FC4 RID: 36804 RVA: 0x000CDC68 File Offset: 0x000CBE68
		public FEditorImportExportTestDefinition(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008FC5 RID: 36805 RVA: 0x000CDC73 File Offset: 0x000CBE73
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FEditorImportExportTestDefinition(Pointer, false, true);
		}

		// Token: 0x06008FC6 RID: 36806 RVA: 0x000CDC7D File Offset: 0x000CBE7D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FEditorImportExportTestDefinition(Pointer, MemoryOwner);
		}

		// Token: 0x04004709 RID: 18185
		public const string __ObjectPath = "/Script/Engine.EditorImportExportTestDefinition";

		// Token: 0x0400470A RID: 18186
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400470B RID: 18187
		internal static int __PropertyOffset_ImportFilePath;

		// Token: 0x0400470C RID: 18188
		[Nullable(2)]
		private FFilePath _ImportFilePath;

		// Token: 0x0400470D RID: 18189
		internal static int __PropertyOffset_ExportFileExtension;

		// Token: 0x0400470E RID: 18190
		internal static int __PropertyOffset_bSkipExport;

		// Token: 0x0400470F RID: 18191
		internal static int __PropertyOffset_FactorySettings;

		// Token: 0x04004710 RID: 18192
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FImportFactorySettingValues> _FactorySettings;
	}
}
