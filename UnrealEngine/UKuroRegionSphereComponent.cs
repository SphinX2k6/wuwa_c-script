using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200034A RID: 842
	[UnrealObjectPath("/Script/KuroComponent.KuroRegionSphereComponent")]
	[UnrealStructLayout(592, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 592)]
	public class UKuroRegionSphereComponent : UKuroRegionShapeComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600564D RID: 22093 RVA: 0x00078F99 File Offset: 0x00077199
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroRegionSphereComponent._ClassPtr;
		}

		// Token: 0x0600564E RID: 22094 RVA: 0x00078FA8 File Offset: 0x000771A8
		public UKuroRegionSphereComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroRegionSphereComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600564F RID: 22095 RVA: 0x00078FD0 File Offset: 0x000771D0
		[NullableContext(1)]
		public UKuroRegionSphereComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroRegionSphereComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170010F5 RID: 4341
		// (get) Token: 0x06005650 RID: 22096 RVA: 0x00079003 File Offset: 0x00077203
		// (set) Token: 0x06005651 RID: 22097 RVA: 0x00079013 File Offset: 0x00077213
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroRegionSphereComponent.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroRegionSphereComponent.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x06005652 RID: 22098 RVA: 0x00079024 File Offset: 0x00077224
		static UKuroRegionSphereComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroComponent.KuroRegionSphereComponent");
		}

		// Token: 0x06005653 RID: 22099 RVA: 0x00079032 File Offset: 0x00077232
		protected UKuroRegionSphereComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002367 RID: 9063
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroComponent.KuroRegionSphereComponent";

		// Token: 0x04002368 RID: 9064
		private static IntPtr _ClassPtr;

		// Token: 0x04002369 RID: 9065
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400236A RID: 9066
		internal static int __PropertyOffset_Radius;
	}
}
