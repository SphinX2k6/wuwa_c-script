using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F41 RID: 8001
	[UnrealObjectPath("/Script/KuroVoxelRuntime.KuroVoxelGlobalComponent")]
	[UnrealStructLayout(688, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 688)]
	public class UKuroVoxelGlobalComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E70C RID: 124684 RVA: 0x002D41B3 File Offset: 0x002D23B3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroVoxelGlobalComponent._ClassPtr;
		}

		// Token: 0x0601E70D RID: 124685 RVA: 0x002D41C0 File Offset: 0x002D23C0
		public UKuroVoxelGlobalComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroVoxelGlobalComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E70E RID: 124686 RVA: 0x002D41E8 File Offset: 0x002D23E8
		[NullableContext(1)]
		public UKuroVoxelGlobalComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroVoxelGlobalComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007919 RID: 31001
		// (get) Token: 0x0601E70F RID: 124687 RVA: 0x002D421B File Offset: 0x002D241B
		// (set) Token: 0x0601E710 RID: 124688 RVA: 0x002D422B File Offset: 0x002D242B
		public unsafe int Version
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVoxelGlobalComponent.__PropertyOffset_Version);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVoxelGlobalComponent.__PropertyOffset_Version) = value;
			}
		}

		// Token: 0x0601E711 RID: 124689 RVA: 0x002D423C File Offset: 0x002D243C
		static UKuroVoxelGlobalComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroVoxelRuntime.KuroVoxelGlobalComponent");
		}

		// Token: 0x0601E712 RID: 124690 RVA: 0x002D424A File Offset: 0x002D244A
		protected UKuroVoxelGlobalComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040106CA RID: 67274
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroVoxelRuntime.KuroVoxelGlobalComponent";

		// Token: 0x040106CB RID: 67275
		private static IntPtr _ClassPtr;

		// Token: 0x040106CC RID: 67276
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040106CD RID: 67277
		internal static int __PropertyOffset_Version;
	}
}
