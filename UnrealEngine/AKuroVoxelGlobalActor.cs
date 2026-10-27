using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F40 RID: 8000
	[UnrealObjectPath("/Script/KuroVoxelRuntime.KuroVoxelGlobalActor")]
	[UnrealStructLayout(1048, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1048)]
	public class AKuroVoxelGlobalActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E705 RID: 124677 RVA: 0x002D410C File Offset: 0x002D230C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroVoxelGlobalActor._ClassPtr;
		}

		// Token: 0x0601E706 RID: 124678 RVA: 0x002D4118 File Offset: 0x002D2318
		public AKuroVoxelGlobalActor() : this(BuiltinUtils.AllocNativeUObject(AKuroVoxelGlobalActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E707 RID: 124679 RVA: 0x002D4140 File Offset: 0x002D2340
		[NullableContext(1)]
		public AKuroVoxelGlobalActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroVoxelGlobalActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007918 RID: 31000
		// (get) Token: 0x0601E708 RID: 124680 RVA: 0x002D4173 File Offset: 0x002D2373
		// (set) Token: 0x0601E709 RID: 124681 RVA: 0x002D4187 File Offset: 0x002D2387
		[Nullable(2)]
		public unsafe UKuroVoxelGlobalComponent KuroVoxelGlobalComp
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroVoxelGlobalComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroVoxelGlobalActor.__PropertyOffset_KuroVoxelGlobalComp);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroVoxelGlobalActor.__PropertyOffset_KuroVoxelGlobalComp, value);
			}
		}

		// Token: 0x0601E70A RID: 124682 RVA: 0x002D419C File Offset: 0x002D239C
		static AKuroVoxelGlobalActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroVoxelRuntime.KuroVoxelGlobalActor");
		}

		// Token: 0x0601E70B RID: 124683 RVA: 0x002D41AA File Offset: 0x002D23AA
		protected AKuroVoxelGlobalActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040106C6 RID: 67270
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroVoxelRuntime.KuroVoxelGlobalActor";

		// Token: 0x040106C7 RID: 67271
		private static IntPtr _ClassPtr;

		// Token: 0x040106C8 RID: 67272
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040106C9 RID: 67273
		internal static int __PropertyOffset_KuroVoxelGlobalComp;
	}
}
