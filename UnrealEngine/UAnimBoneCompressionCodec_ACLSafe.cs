using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000D1 RID: 209
	[UnrealObjectPath("/Script/ACLPlugin.AnimBoneCompressionCodec_ACLSafe")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UAnimBoneCompressionCodec_ACLSafe : UAnimBoneCompressionCodec_ACLBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001155 RID: 4437 RVA: 0x00019D9F File Offset: 0x00017F9F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimBoneCompressionCodec_ACLSafe._ClassPtr;
		}

		// Token: 0x06001156 RID: 4438 RVA: 0x00019DAC File Offset: 0x00017FAC
		public UAnimBoneCompressionCodec_ACLSafe() : this(BuiltinUtils.AllocNativeUObject(UAnimBoneCompressionCodec_ACLSafe.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001157 RID: 4439 RVA: 0x00019DD4 File Offset: 0x00017FD4
		[NullableContext(1)]
		public UAnimBoneCompressionCodec_ACLSafe(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAnimBoneCompressionCodec_ACLSafe.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06001158 RID: 4440 RVA: 0x00019E07 File Offset: 0x00018007
		static UAnimBoneCompressionCodec_ACLSafe()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ACLPlugin.AnimBoneCompressionCodec_ACLSafe");
		}

		// Token: 0x06001159 RID: 4441 RVA: 0x00019E15 File Offset: 0x00018015
		protected UAnimBoneCompressionCodec_ACLSafe(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040002A3 RID: 675
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ACLPlugin.AnimBoneCompressionCodec_ACLSafe";

		// Token: 0x040002A4 RID: 676
		private static IntPtr _ClassPtr;

		// Token: 0x040002A5 RID: 677
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
