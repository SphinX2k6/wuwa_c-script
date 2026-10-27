using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000CD RID: 205
	[UnrealObjectPath("/Script/ACLPlugin.AnimBoneCompressionCodec_ACL")]
	[UnrealStructLayout(280, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 280)]
	public class UAnimBoneCompressionCodec_ACL : UAnimBoneCompressionCodec_ACLBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001140 RID: 4416 RVA: 0x00019BAA File Offset: 0x00017DAA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimBoneCompressionCodec_ACL._ClassPtr;
		}

		// Token: 0x06001141 RID: 4417 RVA: 0x00019BB8 File Offset: 0x00017DB8
		public UAnimBoneCompressionCodec_ACL() : this(BuiltinUtils.AllocNativeUObject(UAnimBoneCompressionCodec_ACL.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001142 RID: 4418 RVA: 0x00019BE0 File Offset: 0x00017DE0
		[NullableContext(1)]
		public UAnimBoneCompressionCodec_ACL(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAnimBoneCompressionCodec_ACL.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06001143 RID: 4419 RVA: 0x00019C13 File Offset: 0x00017E13
		static UAnimBoneCompressionCodec_ACL()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ACLPlugin.AnimBoneCompressionCodec_ACL");
		}

		// Token: 0x06001144 RID: 4420 RVA: 0x00019C21 File Offset: 0x00017E21
		protected UAnimBoneCompressionCodec_ACL(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000296 RID: 662
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ACLPlugin.AnimBoneCompressionCodec_ACL";

		// Token: 0x04000297 RID: 663
		private static IntPtr _ClassPtr;

		// Token: 0x04000298 RID: 664
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
