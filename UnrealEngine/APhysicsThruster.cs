using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FE8 RID: 4072
	[UnrealObjectPath("/Script/Engine.PhysicsThruster")]
	[UnrealStructLayout(1056, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1056)]
	public class APhysicsThruster : ARigidBodyBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600DC95 RID: 56469 RVA: 0x00144ACD File Offset: 0x00142CCD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return APhysicsThruster._ClassPtr;
		}

		// Token: 0x0600DC96 RID: 56470 RVA: 0x00144ADC File Offset: 0x00142CDC
		public APhysicsThruster() : this(BuiltinUtils.AllocNativeUObject(APhysicsThruster.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600DC97 RID: 56471 RVA: 0x00144B04 File Offset: 0x00142D04
		[NullableContext(1)]
		public APhysicsThruster(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(APhysicsThruster.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170033FF RID: 13311
		// (get) Token: 0x0600DC98 RID: 56472 RVA: 0x00144B37 File Offset: 0x00142D37
		// (set) Token: 0x0600DC99 RID: 56473 RVA: 0x00144B4B File Offset: 0x00142D4B
		[Nullable(2)]
		public unsafe UPhysicsThrusterComponent ThrusterComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicsThrusterComponent>(base.NativePtr / (IntPtr)sizeof(void*) + APhysicsThruster.__PropertyOffset_ThrusterComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + APhysicsThruster.__PropertyOffset_ThrusterComponent, value);
			}
		}

		// Token: 0x0600DC9A RID: 56474 RVA: 0x00144B60 File Offset: 0x00142D60
		static APhysicsThruster()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PhysicsThruster");
		}

		// Token: 0x0600DC9B RID: 56475 RVA: 0x00144B6E File Offset: 0x00142D6E
		protected APhysicsThruster(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400772C RID: 30508
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.PhysicsThruster";

		// Token: 0x0400772D RID: 30509
		private static IntPtr _ClassPtr;

		// Token: 0x0400772E RID: 30510
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400772F RID: 30511
		internal static int __PropertyOffset_ThrusterComponent;
	}
}
