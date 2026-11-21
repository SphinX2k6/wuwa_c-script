using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004CC RID: 1228
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroGrassInteractionSphereComponent")]
	[UnrealStructLayout(576, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 576)]
	public class UKuroGrassInteractionSphereComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007271 RID: 29297 RVA: 0x000A8453 File Offset: 0x000A6653
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroGrassInteractionSphereComponent._ClassPtr;
		}

		// Token: 0x06007272 RID: 29298 RVA: 0x000A8460 File Offset: 0x000A6660
		public UKuroGrassInteractionSphereComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroGrassInteractionSphereComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007273 RID: 29299 RVA: 0x000A8488 File Offset: 0x000A6688
		[NullableContext(1)]
		public UKuroGrassInteractionSphereComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroGrassInteractionSphereComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700168D RID: 5773
		// (get) Token: 0x06007274 RID: 29300 RVA: 0x000A84BB File Offset: 0x000A66BB
		// (set) Token: 0x06007275 RID: 29301 RVA: 0x000A84CB File Offset: 0x000A66CB
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroGrassInteractionSphereComponent.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGrassInteractionSphereComponent.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x1700168E RID: 5774
		// (get) Token: 0x06007276 RID: 29302 RVA: 0x000A84DC File Offset: 0x000A66DC
		// (set) Token: 0x06007277 RID: 29303 RVA: 0x000A84EC File Offset: 0x000A66EC
		public unsafe bool bEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroGrassInteractionSphereComponent.__PropertyOffset_bEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGrassInteractionSphereComponent.__PropertyOffset_bEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x06007278 RID: 29304 RVA: 0x000A84FD File Offset: 0x000A66FD
		static UKuroGrassInteractionSphereComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroGrassInteractionSphereComponent");
		}

		// Token: 0x06007279 RID: 29305 RVA: 0x000A850B File Offset: 0x000A670B
		protected UKuroGrassInteractionSphereComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400314B RID: 12619
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroGrassInteractionSphereComponent";

		// Token: 0x0400314C RID: 12620
		private static IntPtr _ClassPtr;

		// Token: 0x0400314D RID: 12621
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400314E RID: 12622
		internal static int __PropertyOffset_Radius;

		// Token: 0x0400314F RID: 12623
		internal static int __PropertyOffset_bEnabled;
	}
}
