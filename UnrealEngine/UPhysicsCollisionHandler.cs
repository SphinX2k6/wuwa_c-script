using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FE0 RID: 4064
	[UnrealObjectPath("/Script/Engine.PhysicsCollisionHandler")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UPhysicsCollisionHandler : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600DB8A RID: 56202 RVA: 0x001437A2 File Offset: 0x001419A2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPhysicsCollisionHandler._ClassPtr;
		}

		// Token: 0x0600DB8B RID: 56203 RVA: 0x001437B0 File Offset: 0x001419B0
		public UPhysicsCollisionHandler() : this(BuiltinUtils.AllocNativeUObject(UPhysicsCollisionHandler.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600DB8C RID: 56204 RVA: 0x001437D8 File Offset: 0x001419D8
		[NullableContext(1)]
		public UPhysicsCollisionHandler(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPhysicsCollisionHandler.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170033C3 RID: 13251
		// (get) Token: 0x0600DB8D RID: 56205 RVA: 0x0014380B File Offset: 0x00141A0B
		// (set) Token: 0x0600DB8E RID: 56206 RVA: 0x0014381B File Offset: 0x00141A1B
		public unsafe float ImpactThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicsCollisionHandler.__PropertyOffset_ImpactThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicsCollisionHandler.__PropertyOffset_ImpactThreshold) = value;
			}
		}

		// Token: 0x170033C4 RID: 13252
		// (get) Token: 0x0600DB8F RID: 56207 RVA: 0x0014382C File Offset: 0x00141A2C
		// (set) Token: 0x0600DB90 RID: 56208 RVA: 0x0014383C File Offset: 0x00141A3C
		public unsafe float ImpactReFireDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicsCollisionHandler.__PropertyOffset_ImpactReFireDelay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicsCollisionHandler.__PropertyOffset_ImpactReFireDelay) = value;
			}
		}

		// Token: 0x170033C5 RID: 13253
		// (get) Token: 0x0600DB91 RID: 56209 RVA: 0x0014384D File Offset: 0x00141A4D
		// (set) Token: 0x0600DB92 RID: 56210 RVA: 0x00143861 File Offset: 0x00141A61
		[Nullable(2)]
		public unsafe USoundBase DefaultImpactSound
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USoundBase>(base.NativePtr / (IntPtr)sizeof(void*) + UPhysicsCollisionHandler.__PropertyOffset_DefaultImpactSound);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UPhysicsCollisionHandler.__PropertyOffset_DefaultImpactSound, value);
			}
		}

		// Token: 0x170033C6 RID: 13254
		// (get) Token: 0x0600DB93 RID: 56211 RVA: 0x00143876 File Offset: 0x00141A76
		// (set) Token: 0x0600DB94 RID: 56212 RVA: 0x00143886 File Offset: 0x00141A86
		public unsafe float LastImpactSoundTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicsCollisionHandler.__PropertyOffset_LastImpactSoundTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicsCollisionHandler.__PropertyOffset_LastImpactSoundTime) = value;
			}
		}

		// Token: 0x0600DB95 RID: 56213 RVA: 0x00143897 File Offset: 0x00141A97
		static UPhysicsCollisionHandler()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PhysicsCollisionHandler");
		}

		// Token: 0x0600DB96 RID: 56214 RVA: 0x001438A5 File Offset: 0x00141AA5
		protected UPhysicsCollisionHandler(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040076C9 RID: 30409
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.PhysicsCollisionHandler";

		// Token: 0x040076CA RID: 30410
		private static IntPtr _ClassPtr;

		// Token: 0x040076CB RID: 30411
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040076CC RID: 30412
		internal static int __PropertyOffset_ImpactThreshold;

		// Token: 0x040076CD RID: 30413
		internal static int __PropertyOffset_ImpactReFireDelay;

		// Token: 0x040076CE RID: 30414
		internal static int __PropertyOffset_DefaultImpactSound;

		// Token: 0x040076CF RID: 30415
		internal static int __PropertyOffset_LastImpactSoundTime;
	}
}
