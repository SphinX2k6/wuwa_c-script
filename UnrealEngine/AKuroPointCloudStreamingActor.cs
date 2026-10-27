using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001A2F RID: 6703
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroPointCloud.KuroPointCloudStreamingActor")]
	[UnrealStructLayout(1088, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1088)]
	public class AKuroPointCloudStreamingActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018CDE RID: 101598 RVA: 0x0024A752 File Offset: 0x00248952
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroPointCloudStreamingActor._ClassPtr;
		}

		// Token: 0x06018CDF RID: 101599 RVA: 0x0024A760 File Offset: 0x00248960
		public AKuroPointCloudStreamingActor() : this(BuiltinUtils.AllocNativeUObject(AKuroPointCloudStreamingActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018CE0 RID: 101600 RVA: 0x0024A788 File Offset: 0x00248988
		[NullableContext(1)]
		public AKuroPointCloudStreamingActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroPointCloudStreamingActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700624D RID: 25165
		// (get) Token: 0x06018CE1 RID: 101601 RVA: 0x0024A7BB File Offset: 0x002489BB
		// (set) Token: 0x06018CE2 RID: 101602 RVA: 0x0024A7CF File Offset: 0x002489CF
		public unsafe USceneComponent SceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroPointCloudStreamingActor.__PropertyOffset_SceneRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroPointCloudStreamingActor.__PropertyOffset_SceneRoot, value);
			}
		}

		// Token: 0x1700624E RID: 25166
		// (get) Token: 0x06018CE3 RID: 101603 RVA: 0x0024A7E4 File Offset: 0x002489E4
		// (set) Token: 0x06018CE4 RID: 101604 RVA: 0x0024A7F8 File Offset: 0x002489F8
		public unsafe UKuroPointCloudWorldComponent PointCloudWorldComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPointCloudWorldComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroPointCloudStreamingActor.__PropertyOffset_PointCloudWorldComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroPointCloudStreamingActor.__PropertyOffset_PointCloudWorldComponent, value);
			}
		}

		// Token: 0x1700624F RID: 25167
		// (get) Token: 0x06018CE5 RID: 101605 RVA: 0x0024A80D File Offset: 0x00248A0D
		// (set) Token: 0x06018CE6 RID: 101606 RVA: 0x0024A81D File Offset: 0x00248A1D
		public unsafe int CellX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroPointCloudStreamingActor.__PropertyOffset_CellX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroPointCloudStreamingActor.__PropertyOffset_CellX) = value;
			}
		}

		// Token: 0x17006250 RID: 25168
		// (get) Token: 0x06018CE7 RID: 101607 RVA: 0x0024A82E File Offset: 0x00248A2E
		// (set) Token: 0x06018CE8 RID: 101608 RVA: 0x0024A83E File Offset: 0x00248A3E
		public unsafe int CellY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroPointCloudStreamingActor.__PropertyOffset_CellY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroPointCloudStreamingActor.__PropertyOffset_CellY) = value;
			}
		}

		// Token: 0x06018CE9 RID: 101609 RVA: 0x0024A84F File Offset: 0x00248A4F
		static AKuroPointCloudStreamingActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroPointCloud.KuroPointCloudStreamingActor");
		}

		// Token: 0x06018CEA RID: 101610 RVA: 0x0024A85D File Offset: 0x00248A5D
		protected AKuroPointCloudStreamingActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D68D RID: 54925
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroPointCloud.KuroPointCloudStreamingActor";

		// Token: 0x0400D68E RID: 54926
		private static IntPtr _ClassPtr;

		// Token: 0x0400D68F RID: 54927
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D690 RID: 54928
		internal static int __PropertyOffset_SceneRoot;

		// Token: 0x0400D691 RID: 54929
		internal static int __PropertyOffset_PointCloudWorldComponent;

		// Token: 0x0400D692 RID: 54930
		internal static int __PropertyOffset_CellX;

		// Token: 0x0400D693 RID: 54931
		internal static int __PropertyOffset_CellY;
	}
}
