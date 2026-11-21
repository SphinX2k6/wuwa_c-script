using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000345 RID: 837
	[UnrealObjectPath("/Script/KuroComponent.KuroRegionCylinderComponent")]
	[UnrealStructLayout(592, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 592)]
	public class UKuroRegionCylinderComponent : UKuroRegionShapeComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005615 RID: 22037 RVA: 0x00078B0F File Offset: 0x00076D0F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroRegionCylinderComponent._ClassPtr;
		}

		// Token: 0x06005616 RID: 22038 RVA: 0x00078B1C File Offset: 0x00076D1C
		public UKuroRegionCylinderComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroRegionCylinderComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005617 RID: 22039 RVA: 0x00078B44 File Offset: 0x00076D44
		[NullableContext(1)]
		public UKuroRegionCylinderComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroRegionCylinderComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170010ED RID: 4333
		// (get) Token: 0x06005618 RID: 22040 RVA: 0x00078B77 File Offset: 0x00076D77
		// (set) Token: 0x06005619 RID: 22041 RVA: 0x00078B87 File Offset: 0x00076D87
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

		// Token: 0x170010EE RID: 4334
		// (get) Token: 0x0600561A RID: 22042 RVA: 0x00078B98 File Offset: 0x00076D98
		// (set) Token: 0x0600561B RID: 22043 RVA: 0x00078BA8 File Offset: 0x00076DA8
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

		// Token: 0x0600561C RID: 22044 RVA: 0x00078BB9 File Offset: 0x00076DB9
		static UKuroRegionCylinderComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroComponent.KuroRegionCylinderComponent");
		}

		// Token: 0x0600561D RID: 22045 RVA: 0x00078BC7 File Offset: 0x00076DC7
		protected UKuroRegionCylinderComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400234E RID: 9038
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroComponent.KuroRegionCylinderComponent";

		// Token: 0x0400234F RID: 9039
		private static IntPtr _ClassPtr;

		// Token: 0x04002350 RID: 9040
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002351 RID: 9041
		internal static int __PropertyOffset_Radius;

		// Token: 0x04002352 RID: 9042
		internal static int __PropertyOffset_HalfHeight;
	}
}
