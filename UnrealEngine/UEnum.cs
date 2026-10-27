using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200071A RID: 1818
	[UnrealObjectPath("/Script/CoreUObject.Enum")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UEnum : UField, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060061A6 RID: 24998 RVA: 0x0008C00A File Offset: 0x0008A20A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEnum._ClassPtr;
		}

		// Token: 0x060061A7 RID: 24999 RVA: 0x0008C018 File Offset: 0x0008A218
		public UEnum() : this(BuiltinUtils.AllocNativeUObject(UEnum.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060061A8 RID: 25000 RVA: 0x0008C040 File Offset: 0x0008A240
		[NullableContext(1)]
		public UEnum(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEnum.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060061A9 RID: 25001 RVA: 0x0008C073 File Offset: 0x0008A273
		static UEnum()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.Enum");
		}

		// Token: 0x060061AA RID: 25002 RVA: 0x0008C081 File Offset: 0x0008A281
		protected UEnum(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002E0A RID: 11786
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.Enum";

		// Token: 0x04002E0B RID: 11787
		private static IntPtr _ClassPtr;

		// Token: 0x04002E0C RID: 11788
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
