using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F44 RID: 8004
	[UnrealObjectPath("/Script/KuroVoxelRuntime.KuroVoxelPartitionActor")]
	[UnrealStructLayout(1064, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1064)]
	public class AKuroVoxelPartitionActor : AKuroWorldPartitionActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E726 RID: 124710 RVA: 0x002D43AB File Offset: 0x002D25AB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroVoxelPartitionActor._ClassPtr;
		}

		// Token: 0x0601E727 RID: 124711 RVA: 0x002D43B8 File Offset: 0x002D25B8
		public AKuroVoxelPartitionActor() : this(BuiltinUtils.AllocNativeUObject(AKuroVoxelPartitionActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E728 RID: 124712 RVA: 0x002D43E0 File Offset: 0x002D25E0
		[NullableContext(1)]
		public AKuroVoxelPartitionActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroVoxelPartitionActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700791D RID: 31005
		// (get) Token: 0x0601E729 RID: 124713 RVA: 0x002D4413 File Offset: 0x002D2613
		// (set) Token: 0x0601E72A RID: 124714 RVA: 0x002D4427 File Offset: 0x002D2627
		[Nullable(2)]
		public unsafe UKuroVoxelPartitionComponent KuroVoxelPartitionComp
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroVoxelPartitionComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroVoxelPartitionActor.__PropertyOffset_KuroVoxelPartitionComp);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroVoxelPartitionActor.__PropertyOffset_KuroVoxelPartitionComp, value);
			}
		}

		// Token: 0x1700791E RID: 31006
		// (get) Token: 0x0601E72B RID: 124715 RVA: 0x002D443C File Offset: 0x002D263C
		// (set) Token: 0x0601E72C RID: 124716 RVA: 0x002D444C File Offset: 0x002D264C
		public unsafe bool bCanAddToMgrWhenChunkIDCollision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroVoxelPartitionActor.__PropertyOffset_bCanAddToMgrWhenChunkIDCollision) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroVoxelPartitionActor.__PropertyOffset_bCanAddToMgrWhenChunkIDCollision) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601E72D RID: 124717 RVA: 0x002D445D File Offset: 0x002D265D
		static AKuroVoxelPartitionActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroVoxelRuntime.KuroVoxelPartitionActor");
		}

		// Token: 0x0601E72E RID: 124718 RVA: 0x002D446B File Offset: 0x002D266B
		protected AKuroVoxelPartitionActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040106D6 RID: 67286
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroVoxelRuntime.KuroVoxelPartitionActor";

		// Token: 0x040106D7 RID: 67287
		private static IntPtr _ClassPtr;

		// Token: 0x040106D8 RID: 67288
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040106D9 RID: 67289
		internal static int __PropertyOffset_KuroVoxelPartitionComp;

		// Token: 0x040106DA RID: 67290
		internal static int __PropertyOffset_bCanAddToMgrWhenChunkIDCollision;
	}
}
