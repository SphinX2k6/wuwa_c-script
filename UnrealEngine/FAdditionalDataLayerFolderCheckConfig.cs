using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020007D1 RID: 2001
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AdditionalDataLayerFolderCheckConfig")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FAdditionalDataLayerFolderCheckConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006AAF RID: 27311 RVA: 0x00099B8F File Offset: 0x00097D8F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAdditionalDataLayerFolderCheckConfig._ScriptStructPtr != 0) ? FAdditionalDataLayerFolderCheckConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AdditionalDataLayerFolderCheckConfig", ref FAdditionalDataLayerFolderCheckConfig._ScriptStructPtr);
		}

		// Token: 0x17001924 RID: 6436
		// (get) Token: 0x06006AB0 RID: 27312 RVA: 0x00099BB3 File Offset: 0x00097DB3
		// (set) Token: 0x06006AB1 RID: 27313 RVA: 0x00099BC7 File Offset: 0x00097DC7
		public unsafe string FolderKey
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAdditionalDataLayerFolderCheckConfig.__PropertyOffset_FolderKey)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAdditionalDataLayerFolderCheckConfig.__PropertyOffset_FolderKey)), value);
			}
		}

		// Token: 0x17001925 RID: 6437
		// (get) Token: 0x06006AB2 RID: 27314 RVA: 0x00099BDC File Offset: 0x00097DDC
		// (set) Token: 0x06006AB3 RID: 27315 RVA: 0x00099C1F File Offset: 0x00097E1F
		public TArray<string> DataLayers
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._DataLayers) == null)
				{
					result = (this._DataLayers = new TArray<string>(base.NativePtr + (IntPtr)FAdditionalDataLayerFolderCheckConfig.__PropertyOffset_DataLayers, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DataLayers.CopyAssign(value);
			}
		}

		// Token: 0x06006AB4 RID: 27316 RVA: 0x00099C2D File Offset: 0x00097E2D
		public FAdditionalDataLayerFolderCheckConfig()
		{
		}

		// Token: 0x06006AB5 RID: 27317 RVA: 0x00099C35 File Offset: 0x00097E35
		public FAdditionalDataLayerFolderCheckConfig(string FolderKey, TArray<string> DataLayers)
		{
			this.FolderKey = FolderKey;
			this.DataLayers = DataLayers;
		}

		// Token: 0x06006AB6 RID: 27318 RVA: 0x00099C4B File Offset: 0x00097E4B
		protected override IntPtr GetUStructPtr()
		{
			return FAdditionalDataLayerFolderCheckConfig.StaticStruct();
		}

		// Token: 0x06006AB7 RID: 27319 RVA: 0x00099C57 File Offset: 0x00097E57
		[NullableContext(2)]
		public FAdditionalDataLayerFolderCheckConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006AB8 RID: 27320 RVA: 0x00099C61 File Offset: 0x00097E61
		public FAdditionalDataLayerFolderCheckConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006AB9 RID: 27321 RVA: 0x00099C6C File Offset: 0x00097E6C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAdditionalDataLayerFolderCheckConfig(Pointer, false, true);
		}

		// Token: 0x06006ABA RID: 27322 RVA: 0x00099C76 File Offset: 0x00097E76
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAdditionalDataLayerFolderCheckConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04003359 RID: 13145
		public const string __ObjectPath = "/Script/Engine.AdditionalDataLayerFolderCheckConfig";

		// Token: 0x0400335A RID: 13146
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400335B RID: 13147
		internal static int __PropertyOffset_FolderKey;

		// Token: 0x0400335C RID: 13148
		internal static int __PropertyOffset_DataLayers;

		// Token: 0x0400335D RID: 13149
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _DataLayers;
	}
}
