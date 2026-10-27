using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000732 RID: 1842
	[UnrealObjectPath("/Script/CoreUObject.Int8Property")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UInt8Property : UNumericProperty, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006223 RID: 25123 RVA: 0x0008CB8E File Offset: 0x0008AD8E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInt8Property._ClassPtr;
		}

		// Token: 0x06006224 RID: 25124 RVA: 0x0008CB9C File Offset: 0x0008AD9C
		public UInt8Property() : this(BuiltinUtils.AllocNativeUObject(UInt8Property.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006225 RID: 25125 RVA: 0x0008CBC4 File Offset: 0x0008ADC4
		[NullableContext(1)]
		public UInt8Property(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInt8Property.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06006226 RID: 25126 RVA: 0x0008CBF7 File Offset: 0x0008ADF7
		static UInt8Property()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.Int8Property");
		}

		// Token: 0x06006227 RID: 25127 RVA: 0x0008CC05 File Offset: 0x0008AE05
		protected UInt8Property(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002EDD RID: 11997
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.Int8Property";

		// Token: 0x04002EDE RID: 11998
		private static IntPtr _ClassPtr;

		// Token: 0x04002EDF RID: 11999
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
