using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000A57 RID: 2647
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.EditorImportWorkflowDefinition")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FEditorImportWorkflowDefinition : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008FC7 RID: 36807 RVA: 0x000CDC86 File Offset: 0x000CBE86
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FEditorImportWorkflowDefinition._ScriptStructPtr != 0) ? FEditorImportWorkflowDefinition._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.EditorImportWorkflowDefinition", ref FEditorImportWorkflowDefinition._ScriptStructPtr);
		}

		// Token: 0x170021F3 RID: 8691
		// (get) Token: 0x06008FC8 RID: 36808 RVA: 0x000CDCAC File Offset: 0x000CBEAC
		// (set) Token: 0x06008FC9 RID: 36809 RVA: 0x000CDCEF File Offset: 0x000CBEEF
		public FFilePath ImportFilePath
		{
			get
			{
				base.FastCheckIsValid();
				FFilePath result;
				if ((result = this._ImportFilePath) == null)
				{
					result = (this._ImportFilePath = new FFilePath(base.NativePtr + (IntPtr)FEditorImportWorkflowDefinition.__PropertyOffset_ImportFilePath, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFilePath.StaticStruct(), base.NativePtr + (IntPtr)FEditorImportWorkflowDefinition.__PropertyOffset_ImportFilePath, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170021F4 RID: 8692
		// (get) Token: 0x06008FCA RID: 36810 RVA: 0x000CDD10 File Offset: 0x000CBF10
		// (set) Token: 0x06008FCB RID: 36811 RVA: 0x000CDD53 File Offset: 0x000CBF53
		public TArray<FImportFactorySettingValues> FactorySettings
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FImportFactorySettingValues> result;
				if ((result = this._FactorySettings) == null)
				{
					result = (this._FactorySettings = new TArray<FImportFactorySettingValues>(base.NativePtr + (IntPtr)FEditorImportWorkflowDefinition.__PropertyOffset_FactorySettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FactorySettings.CopyAssign(value);
			}
		}

		// Token: 0x06008FCC RID: 36812 RVA: 0x000CDD61 File Offset: 0x000CBF61
		public FEditorImportWorkflowDefinition()
		{
		}

		// Token: 0x06008FCD RID: 36813 RVA: 0x000CDD69 File Offset: 0x000CBF69
		public FEditorImportWorkflowDefinition(FFilePath ImportFilePath, TArray<FImportFactorySettingValues> FactorySettings)
		{
			this.ImportFilePath = ImportFilePath;
			this.FactorySettings = FactorySettings;
		}

		// Token: 0x06008FCE RID: 36814 RVA: 0x000CDD7F File Offset: 0x000CBF7F
		protected override IntPtr GetUStructPtr()
		{
			return FEditorImportWorkflowDefinition.StaticStruct();
		}

		// Token: 0x06008FCF RID: 36815 RVA: 0x000CDD8B File Offset: 0x000CBF8B
		[NullableContext(2)]
		public FEditorImportWorkflowDefinition(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008FD0 RID: 36816 RVA: 0x000CDD95 File Offset: 0x000CBF95
		public FEditorImportWorkflowDefinition(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008FD1 RID: 36817 RVA: 0x000CDDA0 File Offset: 0x000CBFA0
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FEditorImportWorkflowDefinition(Pointer, false, true);
		}

		// Token: 0x06008FD2 RID: 36818 RVA: 0x000CDDAA File Offset: 0x000CBFAA
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FEditorImportWorkflowDefinition(Pointer, MemoryOwner);
		}

		// Token: 0x04004711 RID: 18193
		public const string __ObjectPath = "/Script/Engine.EditorImportWorkflowDefinition";

		// Token: 0x04004712 RID: 18194
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004713 RID: 18195
		internal static int __PropertyOffset_ImportFilePath;

		// Token: 0x04004714 RID: 18196
		[Nullable(2)]
		private FFilePath _ImportFilePath;

		// Token: 0x04004715 RID: 18197
		internal static int __PropertyOffset_FactorySettings;

		// Token: 0x04004716 RID: 18198
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FImportFactorySettingValues> _FactorySettings;
	}
}
