using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000348 RID: 840
	[UnrealObjectPath("/Script/KuroComponent.KuroRegionSectorComponent")]
	[UnrealStructLayout(592, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 592)]
	public class UKuroRegionSectorComponent : UKuroRegionShapeComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600563E RID: 22078 RVA: 0x00078E69 File Offset: 0x00077069
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroRegionSectorComponent._ClassPtr;
		}

		// Token: 0x0600563F RID: 22079 RVA: 0x00078E78 File Offset: 0x00077078
		public UKuroRegionSectorComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroRegionSectorComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005640 RID: 22080 RVA: 0x00078EA0 File Offset: 0x000770A0
		[NullableContext(1)]
		public UKuroRegionSectorComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroRegionSectorComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170010F2 RID: 4338
		// (get) Token: 0x06005641 RID: 22081 RVA: 0x00078ED3 File Offset: 0x000770D3
		// (set) Token: 0x06005642 RID: 22082 RVA: 0x00078EE3 File Offset: 0x000770E3
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroRegionSectorComponent.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroRegionSectorComponent.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x170010F3 RID: 4339
		// (get) Token: 0x06005643 RID: 22083 RVA: 0x00078EF4 File Offset: 0x000770F4
		// (set) Token: 0x06005644 RID: 22084 RVA: 0x00078F04 File Offset: 0x00077104
		public unsafe float Angle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroRegionSectorComponent.__PropertyOffset_Angle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroRegionSectorComponent.__PropertyOffset_Angle) = value;
			}
		}

		// Token: 0x170010F4 RID: 4340
		// (get) Token: 0x06005645 RID: 22085 RVA: 0x00078F15 File Offset: 0x00077115
		// (set) Token: 0x06005646 RID: 22086 RVA: 0x00078F25 File Offset: 0x00077125
		public unsafe float HalfHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroRegionSectorComponent.__PropertyOffset_HalfHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroRegionSectorComponent.__PropertyOffset_HalfHeight) = value;
			}
		}

		// Token: 0x06005647 RID: 22087 RVA: 0x00078F36 File Offset: 0x00077136
		static UKuroRegionSectorComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroComponent.KuroRegionSectorComponent");
		}

		// Token: 0x06005648 RID: 22088 RVA: 0x00078F44 File Offset: 0x00077144
		protected UKuroRegionSectorComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400235E RID: 9054
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroComponent.KuroRegionSectorComponent";

		// Token: 0x0400235F RID: 9055
		private static IntPtr _ClassPtr;

		// Token: 0x04002360 RID: 9056
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002361 RID: 9057
		internal static int __PropertyOffset_Radius;

		// Token: 0x04002362 RID: 9058
		internal static int __PropertyOffset_Angle;

		// Token: 0x04002363 RID: 9059
		internal static int __PropertyOffset_HalfHeight;
	}
}
