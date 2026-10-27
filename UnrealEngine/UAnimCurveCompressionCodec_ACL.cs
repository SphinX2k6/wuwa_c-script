using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000D2 RID: 210
	[UnrealObjectPath("/Script/ACLPlugin.AnimCurveCompressionCodec_ACL")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UAnimCurveCompressionCodec_ACL : UAnimCurveCompressionCodec, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600115A RID: 4442 RVA: 0x00019E1E File Offset: 0x0001801E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimCurveCompressionCodec_ACL._ClassPtr;
		}

		// Token: 0x0600115B RID: 4443 RVA: 0x00019E2C File Offset: 0x0001802C
		public UAnimCurveCompressionCodec_ACL() : this(BuiltinUtils.AllocNativeUObject(UAnimCurveCompressionCodec_ACL.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600115C RID: 4444 RVA: 0x00019E54 File Offset: 0x00018054
		[NullableContext(1)]
		public UAnimCurveCompressionCodec_ACL(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAnimCurveCompressionCodec_ACL.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600115D RID: 4445 RVA: 0x00019E87 File Offset: 0x00018087
		static UAnimCurveCompressionCodec_ACL()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ACLPlugin.AnimCurveCompressionCodec_ACL");
		}

		// Token: 0x0600115E RID: 4446 RVA: 0x00019E95 File Offset: 0x00018095
		protected UAnimCurveCompressionCodec_ACL(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040002A6 RID: 678
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ACLPlugin.AnimCurveCompressionCodec_ACL";

		// Token: 0x040002A7 RID: 679
		private static IntPtr _ClassPtr;

		// Token: 0x040002A8 RID: 680
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
