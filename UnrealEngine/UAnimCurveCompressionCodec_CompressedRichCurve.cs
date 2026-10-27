using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000801 RID: 2049
	[UnrealObjectPath("/Script/Engine.AnimCurveCompressionCodec_CompressedRichCurve")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UAnimCurveCompressionCodec_CompressedRichCurve : UAnimCurveCompressionCodec, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006D58 RID: 27992 RVA: 0x0009D635 File Offset: 0x0009B835
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimCurveCompressionCodec_CompressedRichCurve._ClassPtr;
		}

		// Token: 0x06006D59 RID: 27993 RVA: 0x0009D644 File Offset: 0x0009B844
		public UAnimCurveCompressionCodec_CompressedRichCurve() : this(BuiltinUtils.AllocNativeUObject(UAnimCurveCompressionCodec_CompressedRichCurve.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006D5A RID: 27994 RVA: 0x0009D66C File Offset: 0x0009B86C
		[NullableContext(1)]
		public UAnimCurveCompressionCodec_CompressedRichCurve(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAnimCurveCompressionCodec_CompressedRichCurve.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06006D5B RID: 27995 RVA: 0x0009D69F File Offset: 0x0009B89F
		static UAnimCurveCompressionCodec_CompressedRichCurve()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AnimCurveCompressionCodec_CompressedRichCurve");
		}

		// Token: 0x06006D5C RID: 27996 RVA: 0x0009D6AD File Offset: 0x0009B8AD
		protected UAnimCurveCompressionCodec_CompressedRichCurve(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040034D2 RID: 13522
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AnimCurveCompressionCodec_CompressedRichCurve";

		// Token: 0x040034D3 RID: 13523
		private static IntPtr _ClassPtr;

		// Token: 0x040034D4 RID: 13524
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
