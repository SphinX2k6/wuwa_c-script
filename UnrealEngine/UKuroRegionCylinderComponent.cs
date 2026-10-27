using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200175C RID: 5980
	[UnrealObjectPath("/Script/KuroComponent.KuroRegionCylinderComponent")]
	[UnrealStructLayout(592, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 592)]
	public class UKuroRegionCylinderComponent : UKuroRegionShapeComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060157FD RID: 88061 RVA: 0x001F9837 File Offset: 0x001F7A37
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroRegionCylinderComponent._ClassPtr;
		}

		// Token: 0x060157FE RID: 88062 RVA: 0x001F9844 File Offset: 0x001F7A44
		public UKuroRegionCylinderComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroRegionCylinderComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060157FF RID: 88063 RVA: 0x001F986C File Offset: 0x001F7A6C
		[NullableContext(1)]
		public UKuroRegionCylinderComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroRegionCylinderComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170054EB RID: 21739
		// (get) Token: 0x06015800 RID: 88064 RVA: 0x001F989F File Offset: 0x001F7A9F
		// (set) Token: 0x06015801 RID: 88065 RVA: 0x001F98AF File Offset: 0x001F7AAF
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroRegionCylinderComponent.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroRegionCylinderComponent.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x170054EC RID: 21740
		// (get) Token: 0x06015802 RID: 88066 RVA: 0x001F98C0 File Offset: 0x001F7AC0
		// (set) Token: 0x06015803 RID: 88067 RVA: 0x001F98D0 File Offset: 0x001F7AD0
		public unsafe float HalfHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroRegionCylinderComponent.__PropertyOffset_HalfHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroRegionCylinderComponent.__PropertyOffset_HalfHeight) = value;
			}
		}

		// Token: 0x06015804 RID: 88068 RVA: 0x001F98E1 File Offset: 0x001F7AE1
		static UKuroRegionCylinderComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroComponent.KuroRegionCylinderComponent");
		}

		// Token: 0x06015805 RID: 88069 RVA: 0x001F98EF File Offset: 0x001F7AEF
		protected UKuroRegionCylinderComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400BBB2 RID: 48050
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroComponent.KuroRegionCylinderComponent";

		// Token: 0x0400BBB3 RID: 48051
		private static IntPtr _ClassPtr;

		// Token: 0x0400BBB4 RID: 48052
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400BBB5 RID: 48053
		internal static int __PropertyOffset_Radius;

		// Token: 0x0400BBB6 RID: 48054
		internal static int __PropertyOffset_HalfHeight;
	}
}
