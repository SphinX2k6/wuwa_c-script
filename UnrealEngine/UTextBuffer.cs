using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000769 RID: 1897
	[UnrealObjectPath("/Script/CoreUObject.TextBuffer")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class UTextBuffer : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060063B3 RID: 25523 RVA: 0x0008F256 File Offset: 0x0008D456
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTextBuffer._ClassPtr;
		}

		// Token: 0x060063B4 RID: 25524 RVA: 0x0008F264 File Offset: 0x0008D464
		public UTextBuffer() : this(BuiltinUtils.AllocNativeUObject(UTextBuffer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060063B5 RID: 25525 RVA: 0x0008F28C File Offset: 0x0008D48C
		[NullableContext(1)]
		public UTextBuffer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTextBuffer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060063B6 RID: 25526 RVA: 0x0008F2BF File Offset: 0x0008D4BF
		static UTextBuffer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.TextBuffer");
		}

		// Token: 0x060063B7 RID: 25527 RVA: 0x0008F2CD File Offset: 0x0008D4CD
		protected UTextBuffer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002FCB RID: 12235
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.TextBuffer";

		// Token: 0x04002FCC RID: 12236
		private static IntPtr _ClassPtr;

		// Token: 0x04002FCD RID: 12237
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
