using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000113 RID: 275
	[UnrealObjectPath("/Script/CoreUObject.GCObjectReferencer")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UGCObjectReferencer : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001169 RID: 4457 RVA: 0x0001B90A File Offset: 0x00019B0A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGCObjectReferencer._ClassPtr;
		}

		// Token: 0x0600116A RID: 4458 RVA: 0x0001B918 File Offset: 0x00019B18
		public UGCObjectReferencer() : this(BuiltinUtils.AllocNativeUObject(UGCObjectReferencer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600116B RID: 4459 RVA: 0x0001B940 File Offset: 0x00019B40
		[NullableContext(1)]
		public UGCObjectReferencer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGCObjectReferencer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600116C RID: 4460 RVA: 0x0001B973 File Offset: 0x00019B73
		static UGCObjectReferencer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.GCObjectReferencer");
		}

		// Token: 0x0600116D RID: 4461 RVA: 0x0001B981 File Offset: 0x00019B81
		protected UGCObjectReferencer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000502 RID: 1282
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.GCObjectReferencer";

		// Token: 0x04000503 RID: 1283
		private static IntPtr _ClassPtr;

		// Token: 0x04000504 RID: 1284
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
