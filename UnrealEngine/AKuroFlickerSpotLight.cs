using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001AF9 RID: 6905
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroFlickerSpotLight")]
	[UnrealStructLayout(1528, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1528)]
	public class AKuroFlickerSpotLight : AKuroFlickerLightBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06019CCB RID: 105675 RVA: 0x00261AE6 File Offset: 0x0025FCE6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroFlickerSpotLight._ClassPtr;
		}

		// Token: 0x06019CCC RID: 105676 RVA: 0x00261AF4 File Offset: 0x0025FCF4
		public AKuroFlickerSpotLight() : this(BuiltinUtils.AllocNativeUObject(AKuroFlickerSpotLight.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06019CCD RID: 105677 RVA: 0x00261B1C File Offset: 0x0025FD1C
		[NullableContext(1)]
		public AKuroFlickerSpotLight(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroFlickerSpotLight.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700673C RID: 26428
		// (get) Token: 0x06019CCE RID: 105678 RVA: 0x00261B4F File Offset: 0x0025FD4F
		// (set) Token: 0x06019CCF RID: 105679 RVA: 0x00261B63 File Offset: 0x0025FD63
		[Nullable(2)]
		public unsafe USpotLightComponent SpotLight
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USpotLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroFlickerSpotLight.__PropertyOffset_SpotLight);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroFlickerSpotLight.__PropertyOffset_SpotLight, value);
			}
		}

		// Token: 0x06019CD0 RID: 105680 RVA: 0x00261B78 File Offset: 0x0025FD78
		static AKuroFlickerSpotLight()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroFlickerSpotLight");
		}

		// Token: 0x06019CD1 RID: 105681 RVA: 0x00261B86 File Offset: 0x0025FD86
		protected AKuroFlickerSpotLight(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E07E RID: 57470
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroFlickerSpotLight";

		// Token: 0x0400E07F RID: 57471
		private static IntPtr _ClassPtr;

		// Token: 0x0400E080 RID: 57472
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E081 RID: 57473
		internal static int __PropertyOffset_SpotLight;
	}
}
