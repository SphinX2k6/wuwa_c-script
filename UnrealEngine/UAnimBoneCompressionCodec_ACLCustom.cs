using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000CF RID: 207
	[UnrealObjectPath("/Script/ACLPlugin.AnimBoneCompressionCodec_ACLCustom")]
	[UnrealStructLayout(288, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 288)]
	public class UAnimBoneCompressionCodec_ACLCustom : UAnimBoneCompressionCodec_ACLBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001149 RID: 4425 RVA: 0x00019C75 File Offset: 0x00017E75
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimBoneCompressionCodec_ACLCustom._ClassPtr;
		}

		// Token: 0x0600114A RID: 4426 RVA: 0x00019C84 File Offset: 0x00017E84
		public UAnimBoneCompressionCodec_ACLCustom() : this(BuiltinUtils.AllocNativeUObject(UAnimBoneCompressionCodec_ACLCustom.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600114B RID: 4427 RVA: 0x00019CAC File Offset: 0x00017EAC
		[NullableContext(1)]
		public UAnimBoneCompressionCodec_ACLCustom(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAnimBoneCompressionCodec_ACLCustom.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600114C RID: 4428 RVA: 0x00019CDF File Offset: 0x00017EDF
		static UAnimBoneCompressionCodec_ACLCustom()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ACLPlugin.AnimBoneCompressionCodec_ACLCustom");
		}

		// Token: 0x0600114D RID: 4429 RVA: 0x00019CED File Offset: 0x00017EED
		protected UAnimBoneCompressionCodec_ACLCustom(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400029C RID: 668
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ACLPlugin.AnimBoneCompressionCodec_ACLCustom";

		// Token: 0x0400029D RID: 669
		private static IntPtr _ClassPtr;

		// Token: 0x0400029E RID: 670
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
