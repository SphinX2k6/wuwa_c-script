using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B1B RID: 6939
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroGrassInteractionSphereComponent")]
	[UnrealStructLayout(576, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 576)]
	public class UKuroGrassInteractionSphereComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601A1C3 RID: 106947 RVA: 0x00268959 File Offset: 0x00266B59
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroGrassInteractionSphereComponent._ClassPtr;
		}

		// Token: 0x0601A1C4 RID: 106948 RVA: 0x00268968 File Offset: 0x00266B68
		public UKuroGrassInteractionSphereComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroGrassInteractionSphereComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601A1C5 RID: 106949 RVA: 0x00268990 File Offset: 0x00266B90
		[NullableContext(1)]
		public UKuroGrassInteractionSphereComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroGrassInteractionSphereComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170068D7 RID: 26839
		// (get) Token: 0x0601A1C6 RID: 106950 RVA: 0x002689C3 File Offset: 0x00266BC3
		// (set) Token: 0x0601A1C7 RID: 106951 RVA: 0x002689D3 File Offset: 0x00266BD3
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

		// Token: 0x170068D8 RID: 26840
		// (get) Token: 0x0601A1C8 RID: 106952 RVA: 0x002689E4 File Offset: 0x00266BE4
		// (set) Token: 0x0601A1C9 RID: 106953 RVA: 0x002689F4 File Offset: 0x00266BF4
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

		// Token: 0x0601A1CA RID: 106954 RVA: 0x00268A05 File Offset: 0x00266C05
		static UKuroGrassInteractionSphereComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroGrassInteractionSphereComponent");
		}

		// Token: 0x0601A1CB RID: 106955 RVA: 0x00268A13 File Offset: 0x00266C13
		protected UKuroGrassInteractionSphereComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E2D9 RID: 58073
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroGrassInteractionSphereComponent";

		// Token: 0x0400E2DA RID: 58074
		private static IntPtr _ClassPtr;

		// Token: 0x0400E2DB RID: 58075
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E2DC RID: 58076
		internal static int __PropertyOffset_Radius;

		// Token: 0x0400E2DD RID: 58077
		internal static int __PropertyOffset_bEnabled;
	}
}
