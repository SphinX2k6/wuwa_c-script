using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200076F RID: 1903
	[UnrealObjectPath("/Script/CoreUObject.UInt32Property")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UUInt32Property : UNumericProperty, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060063DC RID: 25564 RVA: 0x0008F606 File Offset: 0x0008D806
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUInt32Property._ClassPtr;
		}

		// Token: 0x060063DD RID: 25565 RVA: 0x0008F614 File Offset: 0x0008D814
		public UUInt32Property() : this(BuiltinUtils.AllocNativeUObject(UUInt32Property.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060063DE RID: 25566 RVA: 0x0008F63C File Offset: 0x0008D83C
		[NullableContext(1)]
		public UUInt32Property(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUInt32Property.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060063DF RID: 25567 RVA: 0x0008F66F File Offset: 0x0008D86F
		static UUInt32Property()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.UInt32Property");
		}

		// Token: 0x060063E0 RID: 25568 RVA: 0x0008F67D File Offset: 0x0008D87D
		protected UUInt32Property(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002FE1 RID: 12257
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.UInt32Property";

		// Token: 0x04002FE2 RID: 12258
		private static IntPtr _ClassPtr;

		// Token: 0x04002FE3 RID: 12259
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
