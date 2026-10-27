using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001A2E RID: 6702
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroPointCloud.KuroPointCloudStreamer")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UKuroPointCloudStreamer : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018CD3 RID: 101587 RVA: 0x0024A619 File Offset: 0x00248819
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroPointCloudStreamer._ClassPtr;
		}

		// Token: 0x06018CD4 RID: 101588 RVA: 0x0024A628 File Offset: 0x00248828
		public UKuroPointCloudStreamer() : this(BuiltinUtils.AllocNativeUObject(UKuroPointCloudStreamer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018CD5 RID: 101589 RVA: 0x0024A650 File Offset: 0x00248850
		public UKuroPointCloudStreamer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroPointCloudStreamer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700624A RID: 25162
		// (get) Token: 0x06018CD6 RID: 101590 RVA: 0x0024A683 File Offset: 0x00248883
		// (set) Token: 0x06018CD7 RID: 101591 RVA: 0x0024A697 File Offset: 0x00248897
		[Nullable(2)]
		public unsafe UKuroPointCloudStreamingConfig Config
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPointCloudStreamingConfig>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroPointCloudStreamer.__PropertyOffset_Config);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroPointCloudStreamer.__PropertyOffset_Config, value);
			}
		}

		// Token: 0x1700624B RID: 25163
		// (get) Token: 0x06018CD8 RID: 101592 RVA: 0x0024A6AC File Offset: 0x002488AC
		// (set) Token: 0x06018CD9 RID: 101593 RVA: 0x0024A6E5 File Offset: 0x002488E5
		public TArray<AKuroPointCloudStreamingActor> SpawnedActors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AKuroPointCloudStreamingActor> result;
				if ((result = this._SpawnedActors) == null)
				{
					result = (this._SpawnedActors = new TArray<AKuroPointCloudStreamingActor>(base.NativePtr + (IntPtr)UKuroPointCloudStreamer.__PropertyOffset_SpawnedActors, this));
				}
				return result;
			}
			set
			{
				this.SpawnedActors.CopyAssign(value);
			}
		}

		// Token: 0x1700624C RID: 25164
		// (get) Token: 0x06018CDA RID: 101594 RVA: 0x0024A6F4 File Offset: 0x002488F4
		// (set) Token: 0x06018CDB RID: 101595 RVA: 0x0024A72D File Offset: 0x0024892D
		public TArray<AKuroPointCloudStreamingActor> ActorPool
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AKuroPointCloudStreamingActor> result;
				if ((result = this._ActorPool) == null)
				{
					result = (this._ActorPool = new TArray<AKuroPointCloudStreamingActor>(base.NativePtr + (IntPtr)UKuroPointCloudStreamer.__PropertyOffset_ActorPool, this));
				}
				return result;
			}
			set
			{
				this.ActorPool.CopyAssign(value);
			}
		}

		// Token: 0x06018CDC RID: 101596 RVA: 0x0024A73B File Offset: 0x0024893B
		static UKuroPointCloudStreamer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroPointCloud.KuroPointCloudStreamer");
		}

		// Token: 0x06018CDD RID: 101597 RVA: 0x0024A749 File Offset: 0x00248949
		protected UKuroPointCloudStreamer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D685 RID: 54917
		public new const string __ObjectPath = "/Script/KuroPointCloud.KuroPointCloudStreamer";

		// Token: 0x0400D686 RID: 54918
		private static IntPtr _ClassPtr;

		// Token: 0x0400D687 RID: 54919
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D688 RID: 54920
		internal static int __PropertyOffset_Config;

		// Token: 0x0400D689 RID: 54921
		internal static int __PropertyOffset_SpawnedActors;

		// Token: 0x0400D68A RID: 54922
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AKuroPointCloudStreamingActor> _SpawnedActors;

		// Token: 0x0400D68B RID: 54923
		internal static int __PropertyOffset_ActorPool;

		// Token: 0x0400D68C RID: 54924
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AKuroPointCloudStreamingActor> _ActorPool;
	}
}
