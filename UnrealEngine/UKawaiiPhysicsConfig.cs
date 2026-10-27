using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020015D5 RID: 5589
	[UnrealObjectPath("/Script/KawaiiPhysics.KawaiiPhysicsConfig")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UKawaiiPhysicsConfig : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06014264 RID: 82532 RVA: 0x001D9852 File Offset: 0x001D7A52
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKawaiiPhysicsConfig._ClassPtr;
		}

		// Token: 0x06014265 RID: 82533 RVA: 0x001D9860 File Offset: 0x001D7A60
		public UKawaiiPhysicsConfig() : this(BuiltinUtils.AllocNativeUObject(UKawaiiPhysicsConfig.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06014266 RID: 82534 RVA: 0x001D9888 File Offset: 0x001D7A88
		[NullableContext(1)]
		public UKawaiiPhysicsConfig(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKawaiiPhysicsConfig.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004EFF RID: 20223
		// (get) Token: 0x06014267 RID: 82535 RVA: 0x001D98BB File Offset: 0x001D7ABB
		// (set) Token: 0x06014268 RID: 82536 RVA: 0x001D98CB File Offset: 0x001D7ACB
		public unsafe bool bEnableSimulate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKawaiiPhysicsConfig.__PropertyOffset_bEnableSimulate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKawaiiPhysicsConfig.__PropertyOffset_bEnableSimulate) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004F00 RID: 20224
		// (get) Token: 0x06014269 RID: 82537 RVA: 0x001D98DC File Offset: 0x001D7ADC
		// (set) Token: 0x0601426A RID: 82538 RVA: 0x001D98EC File Offset: 0x001D7AEC
		public unsafe int SimulateAllowLOD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKawaiiPhysicsConfig.__PropertyOffset_SimulateAllowLOD);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKawaiiPhysicsConfig.__PropertyOffset_SimulateAllowLOD) = value;
			}
		}

		// Token: 0x0601426B RID: 82539 RVA: 0x001D98FD File Offset: 0x001D7AFD
		static UKawaiiPhysicsConfig()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KawaiiPhysics.KawaiiPhysicsConfig");
		}

		// Token: 0x0601426C RID: 82540 RVA: 0x001D990B File Offset: 0x001D7B0B
		protected UKawaiiPhysicsConfig(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AF58 RID: 44888
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KawaiiPhysics.KawaiiPhysicsConfig";

		// Token: 0x0400AF59 RID: 44889
		private static IntPtr _ClassPtr;

		// Token: 0x0400AF5A RID: 44890
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400AF5B RID: 44891
		internal static int __PropertyOffset_bEnableSimulate;

		// Token: 0x0400AF5C RID: 44892
		internal static int __PropertyOffset_SimulateAllowLOD;
	}
}
