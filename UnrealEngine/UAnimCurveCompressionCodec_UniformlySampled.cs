using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000803 RID: 2051
	[UnrealObjectPath("/Script/Engine.AnimCurveCompressionCodec_UniformlySampled")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UAnimCurveCompressionCodec_UniformlySampled : UAnimCurveCompressionCodec, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006D62 RID: 28002 RVA: 0x0009D736 File Offset: 0x0009B936
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimCurveCompressionCodec_UniformlySampled._ClassPtr;
		}

		// Token: 0x06006D63 RID: 28003 RVA: 0x0009D744 File Offset: 0x0009B944
		public UAnimCurveCompressionCodec_UniformlySampled() : this(BuiltinUtils.AllocNativeUObject(UAnimCurveCompressionCodec_UniformlySampled.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006D64 RID: 28004 RVA: 0x0009D76C File Offset: 0x0009B96C
		[NullableContext(1)]
		public UAnimCurveCompressionCodec_UniformlySampled(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAnimCurveCompressionCodec_UniformlySampled.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06006D65 RID: 28005 RVA: 0x0009D79F File Offset: 0x0009B99F
		static UAnimCurveCompressionCodec_UniformlySampled()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AnimCurveCompressionCodec_UniformlySampled");
		}

		// Token: 0x06006D66 RID: 28006 RVA: 0x0009D7AD File Offset: 0x0009B9AD
		protected UAnimCurveCompressionCodec_UniformlySampled(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040034D8 RID: 13528
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AnimCurveCompressionCodec_UniformlySampled";

		// Token: 0x040034D9 RID: 13529
		private static IntPtr _ClassPtr;

		// Token: 0x040034DA RID: 13530
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
