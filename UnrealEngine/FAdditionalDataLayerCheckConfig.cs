using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020007D0 RID: 2000
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AdditionalDataLayerCheckConfig")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FAdditionalDataLayerCheckConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006AA3 RID: 27299 RVA: 0x00099AC7 File Offset: 0x00097CC7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAdditionalDataLayerCheckConfig._ScriptStructPtr != 0) ? FAdditionalDataLayerCheckConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AdditionalDataLayerCheckConfig", ref FAdditionalDataLayerCheckConfig._ScriptStructPtr);
		}

		// Token: 0x17001922 RID: 6434
		// (get) Token: 0x06006AA4 RID: 27300 RVA: 0x00099AEB File Offset: 0x00097CEB
		// (set) Token: 0x06006AA5 RID: 27301 RVA: 0x00099AFF File Offset: 0x00097CFF
		public unsafe string ActorTagKey
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAdditionalDataLayerCheckConfig.__PropertyOffset_ActorTagKey)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAdditionalDataLayerCheckConfig.__PropertyOffset_ActorTagKey)), value);
			}
		}

		// Token: 0x17001923 RID: 6435
		// (get) Token: 0x06006AA6 RID: 27302 RVA: 0x00099B14 File Offset: 0x00097D14
		// (set) Token: 0x06006AA7 RID: 27303 RVA: 0x00099B28 File Offset: 0x00097D28
		public unsafe string DataLayer
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAdditionalDataLayerCheckConfig.__PropertyOffset_DataLayer)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAdditionalDataLayerCheckConfig.__PropertyOffset_DataLayer)), value);
			}
		}

		// Token: 0x06006AA8 RID: 27304 RVA: 0x00099B3D File Offset: 0x00097D3D
		public FAdditionalDataLayerCheckConfig()
		{
		}

		// Token: 0x06006AA9 RID: 27305 RVA: 0x00099B45 File Offset: 0x00097D45
		public FAdditionalDataLayerCheckConfig(string ActorTagKey, string DataLayer)
		{
			this.ActorTagKey = ActorTagKey;
			this.DataLayer = DataLayer;
		}

		// Token: 0x06006AAA RID: 27306 RVA: 0x00099B5B File Offset: 0x00097D5B
		protected override IntPtr GetUStructPtr()
		{
			return FAdditionalDataLayerCheckConfig.StaticStruct();
		}

		// Token: 0x06006AAB RID: 27307 RVA: 0x00099B67 File Offset: 0x00097D67
		[NullableContext(2)]
		public FAdditionalDataLayerCheckConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006AAC RID: 27308 RVA: 0x00099B71 File Offset: 0x00097D71
		public FAdditionalDataLayerCheckConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006AAD RID: 27309 RVA: 0x00099B7C File Offset: 0x00097D7C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAdditionalDataLayerCheckConfig(Pointer, false, true);
		}

		// Token: 0x06006AAE RID: 27310 RVA: 0x00099B86 File Offset: 0x00097D86
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAdditionalDataLayerCheckConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04003355 RID: 13141
		public const string __ObjectPath = "/Script/Engine.AdditionalDataLayerCheckConfig";

		// Token: 0x04003356 RID: 13142
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003357 RID: 13143
		internal static int __PropertyOffset_ActorTagKey;

		// Token: 0x04003358 RID: 13144
		internal static int __PropertyOffset_DataLayer;
	}
}
