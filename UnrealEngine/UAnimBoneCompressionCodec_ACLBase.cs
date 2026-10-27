using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000CE RID: 206
	[UnrealObjectPath("/Script/ACLPlugin.AnimBoneCompressionCodec_ACLBase")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public abstract class UAnimBoneCompressionCodec_ACLBase : UAnimBoneCompressionCodec, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001145 RID: 4421 RVA: 0x00019C2A File Offset: 0x00017E2A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimBoneCompressionCodec_ACLBase._ClassPtr;
		}

		// Token: 0x06001146 RID: 4422 RVA: 0x00019C36 File Offset: 0x00017E36
		static UAnimBoneCompressionCodec_ACLBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ACLPlugin.AnimBoneCompressionCodec_ACLBase");
		}

		// Token: 0x06001147 RID: 4423 RVA: 0x00019C44 File Offset: 0x00017E44
		protected UAnimBoneCompressionCodec_ACLBase() : this(BuiltinUtils.AllocNativeUObject(UAnimBoneCompressionCodec_ACLBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001148 RID: 4424 RVA: 0x00019C6C File Offset: 0x00017E6C
		protected UAnimBoneCompressionCodec_ACLBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000299 RID: 665
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ACLPlugin.AnimBoneCompressionCodec_ACLBase";

		// Token: 0x0400029A RID: 666
		private static IntPtr _ClassPtr;

		// Token: 0x0400029B RID: 667
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
