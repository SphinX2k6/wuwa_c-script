using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012B3 RID: 4787
	[UnrealObjectPath("/Script/FieldSystemEngine.FieldSystemMetaData")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 200)]
	public class UFieldSystemMetaData : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601188A RID: 71818 RVA: 0x0019BA21 File Offset: 0x00199C21
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UFieldSystemMetaData._ClassPtr;
		}

		// Token: 0x0601188B RID: 71819 RVA: 0x0019BA30 File Offset: 0x00199C30
		public UFieldSystemMetaData() : this(BuiltinUtils.AllocNativeUObject(UFieldSystemMetaData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601188C RID: 71820 RVA: 0x0019BA58 File Offset: 0x00199C58
		[NullableContext(1)]
		public UFieldSystemMetaData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UFieldSystemMetaData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601188D RID: 71821 RVA: 0x0019BA8B File Offset: 0x00199C8B
		static UFieldSystemMetaData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/FieldSystemEngine.FieldSystemMetaData");
		}

		// Token: 0x0601188E RID: 71822 RVA: 0x0019BA99 File Offset: 0x00199C99
		protected UFieldSystemMetaData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400964B RID: 38475
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/FieldSystemEngine.FieldSystemMetaData";

		// Token: 0x0400964C RID: 38476
		private static IntPtr _ClassPtr;

		// Token: 0x0400964D RID: 38477
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
