using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200072E RID: 1838
	[UnrealObjectPath("/Script/CoreUObject.Int16Property")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UInt16Property : UNumericProperty, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600620B RID: 25099 RVA: 0x0008C936 File Offset: 0x0008AB36
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInt16Property._ClassPtr;
		}

		// Token: 0x0600620C RID: 25100 RVA: 0x0008C944 File Offset: 0x0008AB44
		public UInt16Property() : this(BuiltinUtils.AllocNativeUObject(UInt16Property.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600620D RID: 25101 RVA: 0x0008C96C File Offset: 0x0008AB6C
		[NullableContext(1)]
		public UInt16Property(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInt16Property.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600620E RID: 25102 RVA: 0x0008C99F File Offset: 0x0008AB9F
		static UInt16Property()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.Int16Property");
		}

		// Token: 0x0600620F RID: 25103 RVA: 0x0008C9AD File Offset: 0x0008ABAD
		protected UInt16Property(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002ECF RID: 11983
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.Int16Property";

		// Token: 0x04002ED0 RID: 11984
		private static IntPtr _ClassPtr;

		// Token: 0x04002ED1 RID: 11985
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
