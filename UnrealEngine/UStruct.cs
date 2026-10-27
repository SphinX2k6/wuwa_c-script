using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000767 RID: 1895
	[UnrealObjectPath("/Script/CoreUObject.Struct")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UStruct : UField, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060063A9 RID: 25513 RVA: 0x0008F156 File Offset: 0x0008D356
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UStruct._ClassPtr;
		}

		// Token: 0x060063AA RID: 25514 RVA: 0x0008F164 File Offset: 0x0008D364
		public UStruct() : this(BuiltinUtils.AllocNativeUObject(UStruct.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060063AB RID: 25515 RVA: 0x0008F18C File Offset: 0x0008D38C
		[NullableContext(1)]
		public UStruct(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UStruct.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060063AC RID: 25516 RVA: 0x0008F1BF File Offset: 0x0008D3BF
		static UStruct()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.Struct");
		}

		// Token: 0x060063AD RID: 25517 RVA: 0x0008F1CD File Offset: 0x0008D3CD
		protected UStruct(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002FC5 RID: 12229
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.Struct";

		// Token: 0x04002FC6 RID: 12230
		private static IntPtr _ClassPtr;

		// Token: 0x04002FC7 RID: 12231
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
