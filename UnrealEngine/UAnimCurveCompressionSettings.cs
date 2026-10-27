using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000804 RID: 2052
	[UnrealObjectPath("/Script/Engine.AnimCurveCompressionSettings")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UAnimCurveCompressionSettings : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006D67 RID: 28007 RVA: 0x0009D7B6 File Offset: 0x0009B9B6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimCurveCompressionSettings._ClassPtr;
		}

		// Token: 0x06006D68 RID: 28008 RVA: 0x0009D7C4 File Offset: 0x0009B9C4
		public UAnimCurveCompressionSettings() : this(BuiltinUtils.AllocNativeUObject(UAnimCurveCompressionSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006D69 RID: 28009 RVA: 0x0009D7EC File Offset: 0x0009B9EC
		[NullableContext(1)]
		public UAnimCurveCompressionSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAnimCurveCompressionSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170019DA RID: 6618
		// (get) Token: 0x06006D6A RID: 28010 RVA: 0x0009D81F File Offset: 0x0009BA1F
		// (set) Token: 0x06006D6B RID: 28011 RVA: 0x0009D833 File Offset: 0x0009BA33
		[Nullable(2)]
		public unsafe UAnimCurveCompressionCodec Codec
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimCurveCompressionCodec>(base.NativePtr / (IntPtr)sizeof(void*) + UAnimCurveCompressionSettings.__PropertyOffset_Codec);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAnimCurveCompressionSettings.__PropertyOffset_Codec, value);
			}
		}

		// Token: 0x06006D6C RID: 28012 RVA: 0x0009D848 File Offset: 0x0009BA48
		static UAnimCurveCompressionSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AnimCurveCompressionSettings");
		}

		// Token: 0x06006D6D RID: 28013 RVA: 0x0009D856 File Offset: 0x0009BA56
		protected UAnimCurveCompressionSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040034DB RID: 13531
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AnimCurveCompressionSettings";

		// Token: 0x040034DC RID: 13532
		private static IntPtr _ClassPtr;

		// Token: 0x040034DD RID: 13533
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040034DE RID: 13534
		internal static int __PropertyOffset_Codec;
	}
}
