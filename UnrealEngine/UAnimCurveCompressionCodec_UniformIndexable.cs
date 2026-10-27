using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000802 RID: 2050
	[UnrealObjectPath("/Script/Engine.AnimCurveCompressionCodec_UniformIndexable")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UAnimCurveCompressionCodec_UniformIndexable : UAnimCurveCompressionCodec, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006D5D RID: 27997 RVA: 0x0009D6B6 File Offset: 0x0009B8B6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimCurveCompressionCodec_UniformIndexable._ClassPtr;
		}

		// Token: 0x06006D5E RID: 27998 RVA: 0x0009D6C4 File Offset: 0x0009B8C4
		public UAnimCurveCompressionCodec_UniformIndexable() : this(BuiltinUtils.AllocNativeUObject(UAnimCurveCompressionCodec_UniformIndexable.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006D5F RID: 27999 RVA: 0x0009D6EC File Offset: 0x0009B8EC
		[NullableContext(1)]
		public UAnimCurveCompressionCodec_UniformIndexable(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAnimCurveCompressionCodec_UniformIndexable.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06006D60 RID: 28000 RVA: 0x0009D71F File Offset: 0x0009B91F
		static UAnimCurveCompressionCodec_UniformIndexable()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AnimCurveCompressionCodec_UniformIndexable");
		}

		// Token: 0x06006D61 RID: 28001 RVA: 0x0009D72D File Offset: 0x0009B92D
		protected UAnimCurveCompressionCodec_UniformIndexable(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040034D5 RID: 13525
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AnimCurveCompressionCodec_UniformIndexable";

		// Token: 0x040034D6 RID: 13526
		private static IntPtr _ClassPtr;

		// Token: 0x040034D7 RID: 13527
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
