using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F45 RID: 8005
	[UnrealObjectPath("/Script/KuroVoxelRuntime.KuroVoxelPartitionComponent")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public class UKuroVoxelPartitionComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E72F RID: 124719 RVA: 0x002D4474 File Offset: 0x002D2674
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroVoxelPartitionComponent._ClassPtr;
		}

		// Token: 0x0601E730 RID: 124720 RVA: 0x002D4480 File Offset: 0x002D2680
		public UKuroVoxelPartitionComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroVoxelPartitionComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E731 RID: 124721 RVA: 0x002D44A8 File Offset: 0x002D26A8
		[NullableContext(1)]
		public UKuroVoxelPartitionComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroVoxelPartitionComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700791F RID: 31007
		// (get) Token: 0x0601E732 RID: 124722 RVA: 0x002D44DB File Offset: 0x002D26DB
		// (set) Token: 0x0601E733 RID: 124723 RVA: 0x002D44EB File Offset: 0x002D26EB
		public unsafe int Priority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVoxelPartitionComponent.__PropertyOffset_Priority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVoxelPartitionComponent.__PropertyOffset_Priority) = value;
			}
		}

		// Token: 0x17007920 RID: 31008
		// (get) Token: 0x0601E734 RID: 124724 RVA: 0x002D44FC File Offset: 0x002D26FC
		// (set) Token: 0x0601E735 RID: 124725 RVA: 0x002D450C File Offset: 0x002D270C
		public unsafe int Version
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVoxelPartitionComponent.__PropertyOffset_Version);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVoxelPartitionComponent.__PropertyOffset_Version) = value;
			}
		}

		// Token: 0x0601E736 RID: 124726 RVA: 0x002D451D File Offset: 0x002D271D
		static UKuroVoxelPartitionComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroVoxelRuntime.KuroVoxelPartitionComponent");
		}

		// Token: 0x0601E737 RID: 124727 RVA: 0x002D452B File Offset: 0x002D272B
		protected UKuroVoxelPartitionComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040106DB RID: 67291
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroVoxelRuntime.KuroVoxelPartitionComponent";

		// Token: 0x040106DC RID: 67292
		private static IntPtr _ClassPtr;

		// Token: 0x040106DD RID: 67293
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040106DE RID: 67294
		internal static int __PropertyOffset_Priority;

		// Token: 0x040106DF RID: 67295
		internal static int __PropertyOffset_Version;
	}
}
