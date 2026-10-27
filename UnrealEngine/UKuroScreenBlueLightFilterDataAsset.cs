using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BAF RID: 7087
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroScreenBlueLightFilterDataAsset")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class UKuroScreenBlueLightFilterDataAsset : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601B1B2 RID: 111026 RVA: 0x0027F184 File Offset: 0x0027D384
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroScreenBlueLightFilterDataAsset._ClassPtr;
		}

		// Token: 0x0601B1B3 RID: 111027 RVA: 0x0027F190 File Offset: 0x0027D390
		public UKuroScreenBlueLightFilterDataAsset() : this(BuiltinUtils.AllocNativeUObject(UKuroScreenBlueLightFilterDataAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601B1B4 RID: 111028 RVA: 0x0027F1B8 File Offset: 0x0027D3B8
		[NullableContext(1)]
		public UKuroScreenBlueLightFilterDataAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroScreenBlueLightFilterDataAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006CA5 RID: 27813
		// (get) Token: 0x0601B1B5 RID: 111029 RVA: 0x0027F1EB File Offset: 0x0027D3EB
		// (set) Token: 0x0601B1B6 RID: 111030 RVA: 0x0027F1FF File Offset: 0x0027D3FF
		public unsafe UKuroScreenBlueLightFilterParameter ParameterA
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroScreenBlueLightFilterParameter>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroScreenBlueLightFilterDataAsset.__PropertyOffset_ParameterA);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroScreenBlueLightFilterDataAsset.__PropertyOffset_ParameterA, value);
			}
		}

		// Token: 0x17006CA6 RID: 27814
		// (get) Token: 0x0601B1B7 RID: 111031 RVA: 0x0027F214 File Offset: 0x0027D414
		// (set) Token: 0x0601B1B8 RID: 111032 RVA: 0x0027F228 File Offset: 0x0027D428
		public unsafe UKuroScreenBlueLightFilterParameter ParameterB
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroScreenBlueLightFilterParameter>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroScreenBlueLightFilterDataAsset.__PropertyOffset_ParameterB);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroScreenBlueLightFilterDataAsset.__PropertyOffset_ParameterB, value);
			}
		}

		// Token: 0x17006CA7 RID: 27815
		// (get) Token: 0x0601B1B9 RID: 111033 RVA: 0x0027F23D File Offset: 0x0027D43D
		// (set) Token: 0x0601B1BA RID: 111034 RVA: 0x0027F251 File Offset: 0x0027D451
		public unsafe UTexture GlobalScreenBlueLightTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroScreenBlueLightFilterDataAsset.__PropertyOffset_GlobalScreenBlueLightTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroScreenBlueLightFilterDataAsset.__PropertyOffset_GlobalScreenBlueLightTexture, value);
			}
		}

		// Token: 0x0601B1BB RID: 111035 RVA: 0x0027F266 File Offset: 0x0027D466
		static UKuroScreenBlueLightFilterDataAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroScreenBlueLightFilterDataAsset");
		}

		// Token: 0x0601B1BC RID: 111036 RVA: 0x0027F274 File Offset: 0x0027D474
		protected UKuroScreenBlueLightFilterDataAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E988 RID: 59784
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroScreenBlueLightFilterDataAsset";

		// Token: 0x0400E989 RID: 59785
		private static IntPtr _ClassPtr;

		// Token: 0x0400E98A RID: 59786
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E98B RID: 59787
		internal static int __PropertyOffset_ParameterA;

		// Token: 0x0400E98C RID: 59788
		internal static int __PropertyOffset_ParameterB;

		// Token: 0x0400E98D RID: 59789
		internal static int __PropertyOffset_GlobalScreenBlueLightTexture;
	}
}
