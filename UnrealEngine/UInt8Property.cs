using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000118 RID: 280
	[UnrealObjectPath("/Script/CoreUObject.Int8Property")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UInt8Property : UNumericProperty, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001186 RID: 4486 RVA: 0x0001BBE2 File Offset: 0x00019DE2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInt8Property._ClassPtr;
		}

		// Token: 0x06001187 RID: 4487 RVA: 0x0001BBF0 File Offset: 0x00019DF0
		public UInt8Property() : this(BuiltinUtils.AllocNativeUObject(UInt8Property.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001188 RID: 4488 RVA: 0x0001BC18 File Offset: 0x00019E18
		[NullableContext(1)]
		public UInt8Property(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInt8Property.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06001189 RID: 4489 RVA: 0x0001BC4B File Offset: 0x00019E4B
		static UInt8Property()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.Int8Property");
		}

		// Token: 0x0600118A RID: 4490 RVA: 0x0001BC59 File Offset: 0x00019E59
		protected UInt8Property(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000513 RID: 1299
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.Int8Property";

		// Token: 0x04000514 RID: 1300
		private static IntPtr _ClassPtr;

		// Token: 0x04000515 RID: 1301
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
