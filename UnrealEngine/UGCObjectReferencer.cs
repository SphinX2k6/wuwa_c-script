using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200072D RID: 1837
	[UnrealObjectPath("/Script/CoreUObject.GCObjectReferencer")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UGCObjectReferencer : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006206 RID: 25094 RVA: 0x0008C8B6 File Offset: 0x0008AAB6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGCObjectReferencer._ClassPtr;
		}

		// Token: 0x06006207 RID: 25095 RVA: 0x0008C8C4 File Offset: 0x0008AAC4
		public UGCObjectReferencer() : this(BuiltinUtils.AllocNativeUObject(UGCObjectReferencer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006208 RID: 25096 RVA: 0x0008C8EC File Offset: 0x0008AAEC
		[NullableContext(1)]
		public UGCObjectReferencer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGCObjectReferencer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06006209 RID: 25097 RVA: 0x0008C91F File Offset: 0x0008AB1F
		static UGCObjectReferencer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.GCObjectReferencer");
		}

		// Token: 0x0600620A RID: 25098 RVA: 0x0008C92D File Offset: 0x0008AB2D
		protected UGCObjectReferencer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002ECC RID: 11980
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.GCObjectReferencer";

		// Token: 0x04002ECD RID: 11981
		private static IntPtr _ClassPtr;

		// Token: 0x04002ECE RID: 11982
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
