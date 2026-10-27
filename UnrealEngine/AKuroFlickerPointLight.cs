using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001AF7 RID: 6903
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroFlickerPointLight")]
	[UnrealStructLayout(1528, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1528)]
	public class AKuroFlickerPointLight : AKuroFlickerLightBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06019CB7 RID: 105655 RVA: 0x00261932 File Offset: 0x0025FB32
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroFlickerPointLight._ClassPtr;
		}

		// Token: 0x06019CB8 RID: 105656 RVA: 0x00261940 File Offset: 0x0025FB40
		public AKuroFlickerPointLight() : this(BuiltinUtils.AllocNativeUObject(AKuroFlickerPointLight.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06019CB9 RID: 105657 RVA: 0x00261968 File Offset: 0x0025FB68
		[NullableContext(1)]
		public AKuroFlickerPointLight(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroFlickerPointLight.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006737 RID: 26423
		// (get) Token: 0x06019CBA RID: 105658 RVA: 0x0026199B File Offset: 0x0025FB9B
		// (set) Token: 0x06019CBB RID: 105659 RVA: 0x002619AF File Offset: 0x0025FBAF
		[Nullable(2)]
		public unsafe UPointLightComponent PointLight
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPointLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroFlickerPointLight.__PropertyOffset_PointLight);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroFlickerPointLight.__PropertyOffset_PointLight, value);
			}
		}

		// Token: 0x06019CBC RID: 105660 RVA: 0x002619C4 File Offset: 0x0025FBC4
		static AKuroFlickerPointLight()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroFlickerPointLight");
		}

		// Token: 0x06019CBD RID: 105661 RVA: 0x002619D2 File Offset: 0x0025FBD2
		protected AKuroFlickerPointLight(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E073 RID: 57459
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroFlickerPointLight";

		// Token: 0x0400E074 RID: 57460
		private static IntPtr _ClassPtr;

		// Token: 0x0400E075 RID: 57461
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E076 RID: 57462
		internal static int __PropertyOffset_PointLight;
	}
}
