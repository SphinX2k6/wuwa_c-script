using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F43 RID: 8003
	[UnrealObjectPath("/Script/KuroVoxelRuntime.KuroVoxelModifierVolume")]
	[UnrealStructLayout(1136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1136)]
	public class AKuroVoxelModifierVolume : ANavModifierVolume, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E71F RID: 124703 RVA: 0x002D430B File Offset: 0x002D250B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroVoxelModifierVolume._ClassPtr;
		}

		// Token: 0x0601E720 RID: 124704 RVA: 0x002D4318 File Offset: 0x002D2518
		public AKuroVoxelModifierVolume() : this(BuiltinUtils.AllocNativeUObject(AKuroVoxelModifierVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E721 RID: 124705 RVA: 0x002D4340 File Offset: 0x002D2540
		[NullableContext(1)]
		public AKuroVoxelModifierVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroVoxelModifierVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700791C RID: 31004
		// (get) Token: 0x0601E722 RID: 124706 RVA: 0x002D4373 File Offset: 0x002D2573
		// (set) Token: 0x0601E723 RID: 124707 RVA: 0x002D4383 File Offset: 0x002D2583
		public unsafe EKuroVoxelCaveType CaveType
		{
			get
			{
				return (EKuroVoxelCaveType)(*(base.NativePtr + (IntPtr)AKuroVoxelModifierVolume.__PropertyOffset_CaveType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroVoxelModifierVolume.__PropertyOffset_CaveType) = (byte)value;
			}
		}

		// Token: 0x0601E724 RID: 124708 RVA: 0x002D4394 File Offset: 0x002D2594
		static AKuroVoxelModifierVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroVoxelRuntime.KuroVoxelModifierVolume");
		}

		// Token: 0x0601E725 RID: 124709 RVA: 0x002D43A2 File Offset: 0x002D25A2
		protected AKuroVoxelModifierVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040106D2 RID: 67282
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroVoxelRuntime.KuroVoxelModifierVolume";

		// Token: 0x040106D3 RID: 67283
		private static IntPtr _ClassPtr;

		// Token: 0x040106D4 RID: 67284
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040106D5 RID: 67285
		internal static int __PropertyOffset_CaveType;
	}
}
