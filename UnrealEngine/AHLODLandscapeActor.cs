using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C34 RID: 3124
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.HLODLandscapeActor")]
	[UnrealStructLayout(1192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1192)]
	public class AHLODLandscapeActor : AStaticMeshActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009E5A RID: 40538 RVA: 0x000E1092 File Offset: 0x000DF292
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AHLODLandscapeActor._ClassPtr;
		}

		// Token: 0x06009E5B RID: 40539 RVA: 0x000E10A0 File Offset: 0x000DF2A0
		public AHLODLandscapeActor() : this(BuiltinUtils.AllocNativeUObject(AHLODLandscapeActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009E5C RID: 40540 RVA: 0x000E10C8 File Offset: 0x000DF2C8
		public AHLODLandscapeActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AHLODLandscapeActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170025D3 RID: 9683
		// (get) Token: 0x06009E5D RID: 40541 RVA: 0x000E10FB File Offset: 0x000DF2FB
		// (set) Token: 0x06009E5E RID: 40542 RVA: 0x000E110B File Offset: 0x000DF30B
		public unsafe int MaxProxiesShowCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AHLODLandscapeActor.__PropertyOffset_MaxProxiesShowCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AHLODLandscapeActor.__PropertyOffset_MaxProxiesShowCount) = value;
			}
		}

		// Token: 0x170025D4 RID: 9684
		// (get) Token: 0x06009E5F RID: 40543 RVA: 0x000E111C File Offset: 0x000DF31C
		// (set) Token: 0x06009E60 RID: 40544 RVA: 0x000E1155 File Offset: 0x000DF355
		public TMap<FName, int> ProxyRecordInfos
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, int> result;
				if ((result = this._ProxyRecordInfos) == null)
				{
					result = (this._ProxyRecordInfos = new TMap<FName, int>(base.NativePtr + (IntPtr)AHLODLandscapeActor.__PropertyOffset_ProxyRecordInfos, this));
				}
				return result;
			}
			set
			{
				this.ProxyRecordInfos.CopyAssign(value);
			}
		}

		// Token: 0x170025D5 RID: 9685
		// (get) Token: 0x06009E61 RID: 40545 RVA: 0x000E1164 File Offset: 0x000DF364
		// (set) Token: 0x06009E62 RID: 40546 RVA: 0x000E119D File Offset: 0x000DF39D
		public TArray<FSoftObjectPath> Resources
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSoftObjectPath> result;
				if ((result = this._Resources) == null)
				{
					result = (this._Resources = new TArray<FSoftObjectPath>(base.NativePtr + (IntPtr)AHLODLandscapeActor.__PropertyOffset_Resources, this));
				}
				return result;
			}
			set
			{
				this.Resources.CopyAssign(value);
			}
		}

		// Token: 0x170025D6 RID: 9686
		// (get) Token: 0x06009E63 RID: 40547 RVA: 0x000E11AC File Offset: 0x000DF3AC
		// (set) Token: 0x06009E64 RID: 40548 RVA: 0x000E11E5 File Offset: 0x000DF3E5
		public TArray<int> CurrentShowProxies
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._CurrentShowProxies) == null)
				{
					result = (this._CurrentShowProxies = new TArray<int>(base.NativePtr + (IntPtr)AHLODLandscapeActor.__PropertyOffset_CurrentShowProxies, this));
				}
				return result;
			}
			set
			{
				this.CurrentShowProxies.CopyAssign(value);
			}
		}

		// Token: 0x06009E65 RID: 40549 RVA: 0x000E11F3 File Offset: 0x000DF3F3
		static AHLODLandscapeActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.HLODLandscapeActor");
		}

		// Token: 0x06009E66 RID: 40550 RVA: 0x000E1201 File Offset: 0x000DF401
		protected AHLODLandscapeActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005746 RID: 22342
		public new const string __ObjectPath = "/Script/Engine.HLODLandscapeActor";

		// Token: 0x04005747 RID: 22343
		private static IntPtr _ClassPtr;

		// Token: 0x04005748 RID: 22344
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005749 RID: 22345
		internal static int __PropertyOffset_MaxProxiesShowCount;

		// Token: 0x0400574A RID: 22346
		internal static int __PropertyOffset_ProxyRecordInfos;

		// Token: 0x0400574B RID: 22347
		[Nullable(2)]
		private TMap<FName, int> _ProxyRecordInfos;

		// Token: 0x0400574C RID: 22348
		internal static int __PropertyOffset_Resources;

		// Token: 0x0400574D RID: 22349
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSoftObjectPath> _Resources;

		// Token: 0x0400574E RID: 22350
		internal static int __PropertyOffset_CurrentShowProxies;

		// Token: 0x0400574F RID: 22351
		[Nullable(2)]
		private TArray<int> _CurrentShowProxies;
	}
}
