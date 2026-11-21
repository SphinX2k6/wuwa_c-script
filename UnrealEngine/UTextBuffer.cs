using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200014F RID: 335
	[UnrealObjectPath("/Script/CoreUObject.TextBuffer")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class UTextBuffer : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600130B RID: 4875 RVA: 0x0001E14A File Offset: 0x0001C34A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTextBuffer._ClassPtr;
		}

		// Token: 0x0600130C RID: 4876 RVA: 0x0001E158 File Offset: 0x0001C358
		public UTextBuffer() : this(BuiltinUtils.AllocNativeUObject(UTextBuffer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600130D RID: 4877 RVA: 0x0001E180 File Offset: 0x0001C380
		[NullableContext(1)]
		public UTextBuffer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTextBuffer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600130E RID: 4878 RVA: 0x0001E1B3 File Offset: 0x0001C3B3
		static UTextBuffer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.TextBuffer");
		}

		// Token: 0x0600130F RID: 4879 RVA: 0x0001E1C1 File Offset: 0x0001C3C1
		protected UTextBuffer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000601 RID: 1537
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.TextBuffer";

		// Token: 0x04000602 RID: 1538
		private static IntPtr _ClassPtr;

		// Token: 0x04000603 RID: 1539
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
