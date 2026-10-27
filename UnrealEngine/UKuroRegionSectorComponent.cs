using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200175F RID: 5983
	[UnrealObjectPath("/Script/KuroComponent.KuroRegionSectorComponent")]
	[UnrealStructLayout(592, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 592)]
	public class UKuroRegionSectorComponent : UKuroRegionShapeComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06015828 RID: 88104 RVA: 0x001F9BD9 File Offset: 0x001F7DD9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroRegionSectorComponent._ClassPtr;
		}

		// Token: 0x06015829 RID: 88105 RVA: 0x001F9BE8 File Offset: 0x001F7DE8
		public UKuroRegionSectorComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroRegionSectorComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601582A RID: 88106 RVA: 0x001F9C10 File Offset: 0x001F7E10
		[NullableContext(1)]
		public UKuroRegionSectorComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroRegionSectorComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170054F1 RID: 21745
		// (get) Token: 0x0601582B RID: 88107 RVA: 0x001F9C43 File Offset: 0x001F7E43
		// (set) Token: 0x0601582C RID: 88108 RVA: 0x001F9C53 File Offset: 0x001F7E53
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

		// Token: 0x170054F2 RID: 21746
		// (get) Token: 0x0601582D RID: 88109 RVA: 0x001F9C64 File Offset: 0x001F7E64
		// (set) Token: 0x0601582E RID: 88110 RVA: 0x001F9C74 File Offset: 0x001F7E74
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

		// Token: 0x170054F3 RID: 21747
		// (get) Token: 0x0601582F RID: 88111 RVA: 0x001F9C85 File Offset: 0x001F7E85
		// (set) Token: 0x06015830 RID: 88112 RVA: 0x001F9C95 File Offset: 0x001F7E95
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

		// Token: 0x06015831 RID: 88113 RVA: 0x001F9CA6 File Offset: 0x001F7EA6
		static UKuroRegionSectorComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroComponent.KuroRegionSectorComponent");
		}

		// Token: 0x06015832 RID: 88114 RVA: 0x001F9CB4 File Offset: 0x001F7EB4
		protected UKuroRegionSectorComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400BBC4 RID: 48068
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroComponent.KuroRegionSectorComponent";

		// Token: 0x0400BBC5 RID: 48069
		private static IntPtr _ClassPtr;

		// Token: 0x0400BBC6 RID: 48070
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400BBC7 RID: 48071
		internal static int __PropertyOffset_Radius;

		// Token: 0x0400BBC8 RID: 48072
		internal static int __PropertyOffset_Angle;

		// Token: 0x0400BBC9 RID: 48073
		internal static int __PropertyOffset_HalfHeight;
	}
}
