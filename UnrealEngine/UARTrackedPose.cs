using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003D6 RID: 982
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AugmentedReality.ARTrackedPose")]
	[UnrealStructLayout(336, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 336)]
	public class UARTrackedPose : UARTrackedGeometry, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003713 RID: 14099 RVA: 0x00053966 File Offset: 0x00051B66
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UARTrackedPose._ClassPtr;
		}

		// Token: 0x06003714 RID: 14100 RVA: 0x00053974 File Offset: 0x00051B74
		public UARTrackedPose() : this(BuiltinUtils.AllocNativeUObject(UARTrackedPose.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003715 RID: 14101 RVA: 0x0005399C File Offset: 0x00051B9C
		public UARTrackedPose(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UARTrackedPose.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000D1A RID: 3354
		// (get) Token: 0x06003716 RID: 14102 RVA: 0x000539D0 File Offset: 0x00051BD0
		// (set) Token: 0x06003717 RID: 14103 RVA: 0x00053A09 File Offset: 0x00051C09
		public FARPose3D TrackedPose
		{
			get
			{
				base.FastCheckIsValid();
				FARPose3D result;
				if ((result = this._TrackedPose) == null)
				{
					result = (this._TrackedPose = new FARPose3D(base.NativePtr + (IntPtr)UARTrackedPose.__PropertyOffset_TrackedPose, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FARPose3D.StaticStruct(), base.NativePtr + (IntPtr)UARTrackedPose.__PropertyOffset_TrackedPose, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06003718 RID: 14104 RVA: 0x00053A2A File Offset: 0x00051C2A
		public FARPose3D GetTrackedPoseData()
		{
			return new FARPose3D(UARTrackedPose.__GetTrackedPoseData_Internal(base.NativePtr), null);
		}

		// Token: 0x06003719 RID: 14105
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetTrackedPoseData_Internal(IntPtr @this);

		// Token: 0x0600371A RID: 14106 RVA: 0x00053A3D File Offset: 0x00051C3D
		static UARTrackedPose()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AugmentedReality.ARTrackedPose");
		}

		// Token: 0x0600371B RID: 14107 RVA: 0x00053A4B File Offset: 0x00051C4B
		protected UARTrackedPose(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040017E1 RID: 6113
		public new const string __ObjectPath = "/Script/AugmentedReality.ARTrackedPose";

		// Token: 0x040017E2 RID: 6114
		private static IntPtr _ClassPtr;

		// Token: 0x040017E3 RID: 6115
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040017E4 RID: 6116
		internal static int __PropertyOffset_TrackedPose;

		// Token: 0x040017E5 RID: 6117
		[Nullable(2)]
		private FARPose3D _TrackedPose;
	}
}
