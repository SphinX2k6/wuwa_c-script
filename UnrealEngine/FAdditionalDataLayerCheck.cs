using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020007CF RID: 1999
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AdditionalDataLayerCheck")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FAdditionalDataLayerCheck : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006A97 RID: 27287 RVA: 0x000999AB File Offset: 0x00097BAB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAdditionalDataLayerCheck._ScriptStructPtr != 0) ? FAdditionalDataLayerCheck._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AdditionalDataLayerCheck", ref FAdditionalDataLayerCheck._ScriptStructPtr);
		}

		// Token: 0x17001920 RID: 6432
		// (get) Token: 0x06006A98 RID: 27288 RVA: 0x000999D0 File Offset: 0x00097BD0
		// (set) Token: 0x06006A99 RID: 27289 RVA: 0x00099A13 File Offset: 0x00097C13
		public TArray<FAdditionalDataLayerCheckConfig> AdditionalDataLayerConfig
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAdditionalDataLayerCheckConfig> result;
				if ((result = this._AdditionalDataLayerConfig) == null)
				{
					result = (this._AdditionalDataLayerConfig = new TArray<FAdditionalDataLayerCheckConfig>(base.NativePtr + (IntPtr)FAdditionalDataLayerCheck.__PropertyOffset_AdditionalDataLayerConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AdditionalDataLayerConfig.CopyAssign(value);
			}
		}

		// Token: 0x17001921 RID: 6433
		// (get) Token: 0x06006A9A RID: 27290 RVA: 0x00099A24 File Offset: 0x00097C24
		// (set) Token: 0x06006A9B RID: 27291 RVA: 0x00099A67 File Offset: 0x00097C67
		public TArray<FAdditionalDataLayerFolderCheckConfig> AdditionalDataLayerFolderConfig
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAdditionalDataLayerFolderCheckConfig> result;
				if ((result = this._AdditionalDataLayerFolderConfig) == null)
				{
					result = (this._AdditionalDataLayerFolderConfig = new TArray<FAdditionalDataLayerFolderCheckConfig>(base.NativePtr + (IntPtr)FAdditionalDataLayerCheck.__PropertyOffset_AdditionalDataLayerFolderConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AdditionalDataLayerFolderConfig.CopyAssign(value);
			}
		}

		// Token: 0x06006A9C RID: 27292 RVA: 0x00099A75 File Offset: 0x00097C75
		public FAdditionalDataLayerCheck()
		{
		}

		// Token: 0x06006A9D RID: 27293 RVA: 0x00099A7D File Offset: 0x00097C7D
		public FAdditionalDataLayerCheck(TArray<FAdditionalDataLayerCheckConfig> AdditionalDataLayerConfig, TArray<FAdditionalDataLayerFolderCheckConfig> AdditionalDataLayerFolderConfig)
		{
			this.AdditionalDataLayerConfig = AdditionalDataLayerConfig;
			this.AdditionalDataLayerFolderConfig = AdditionalDataLayerFolderConfig;
		}

		// Token: 0x06006A9E RID: 27294 RVA: 0x00099A93 File Offset: 0x00097C93
		protected override IntPtr GetUStructPtr()
		{
			return FAdditionalDataLayerCheck.StaticStruct();
		}

		// Token: 0x06006A9F RID: 27295 RVA: 0x00099A9F File Offset: 0x00097C9F
		[NullableContext(2)]
		public FAdditionalDataLayerCheck(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006AA0 RID: 27296 RVA: 0x00099AA9 File Offset: 0x00097CA9
		public FAdditionalDataLayerCheck(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006AA1 RID: 27297 RVA: 0x00099AB4 File Offset: 0x00097CB4
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAdditionalDataLayerCheck(Pointer, false, true);
		}

		// Token: 0x06006AA2 RID: 27298 RVA: 0x00099ABE File Offset: 0x00097CBE
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAdditionalDataLayerCheck(Pointer, MemoryOwner);
		}

		// Token: 0x0400334F RID: 13135
		public const string __ObjectPath = "/Script/Engine.AdditionalDataLayerCheck";

		// Token: 0x04003350 RID: 13136
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003351 RID: 13137
		internal static int __PropertyOffset_AdditionalDataLayerConfig;

		// Token: 0x04003352 RID: 13138
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAdditionalDataLayerCheckConfig> _AdditionalDataLayerConfig;

		// Token: 0x04003353 RID: 13139
		internal static int __PropertyOffset_AdditionalDataLayerFolderConfig;

		// Token: 0x04003354 RID: 13140
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAdditionalDataLayerFolderCheckConfig> _AdditionalDataLayerFolderConfig;
	}
}
