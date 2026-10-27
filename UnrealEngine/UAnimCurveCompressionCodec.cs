using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000800 RID: 2048
	[UnrealObjectPath("/Script/Engine.AnimCurveCompressionCodec")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public abstract class UAnimCurveCompressionCodec : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006D54 RID: 27988 RVA: 0x0009D5E7 File Offset: 0x0009B7E7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimCurveCompressionCodec._ClassPtr;
		}

		// Token: 0x06006D55 RID: 27989 RVA: 0x0009D5F3 File Offset: 0x0009B7F3
		static UAnimCurveCompressionCodec()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AnimCurveCompressionCodec");
		}

		// Token: 0x06006D56 RID: 27990 RVA: 0x0009D604 File Offset: 0x0009B804
		protected UAnimCurveCompressionCodec() : this(BuiltinUtils.AllocNativeUObject(UAnimCurveCompressionCodec.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006D57 RID: 27991 RVA: 0x0009D62C File Offset: 0x0009B82C
		protected UAnimCurveCompressionCodec(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040034CF RID: 13519
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AnimCurveCompressionCodec";

		// Token: 0x040034D0 RID: 13520
		private static IntPtr _ClassPtr;

		// Token: 0x040034D1 RID: 13521
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
