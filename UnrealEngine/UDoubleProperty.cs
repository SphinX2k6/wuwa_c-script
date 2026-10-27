using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200070E RID: 1806
	[UnrealObjectPath("/Script/CoreUObject.DoubleProperty")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UDoubleProperty : UNumericProperty, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600619C RID: 24988 RVA: 0x0008BF0A File Offset: 0x0008A10A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDoubleProperty._ClassPtr;
		}

		// Token: 0x0600619D RID: 24989 RVA: 0x0008BF18 File Offset: 0x0008A118
		public UDoubleProperty() : this(BuiltinUtils.AllocNativeUObject(UDoubleProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600619E RID: 24990 RVA: 0x0008BF40 File Offset: 0x0008A140
		[NullableContext(1)]
		public UDoubleProperty(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDoubleProperty.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600619F RID: 24991 RVA: 0x0008BF73 File Offset: 0x0008A173
		static UDoubleProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.DoubleProperty");
		}

		// Token: 0x060061A0 RID: 24992 RVA: 0x0008BF81 File Offset: 0x0008A181
		protected UDoubleProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002DA7 RID: 11687
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.DoubleProperty";

		// Token: 0x04002DA8 RID: 11688
		private static IntPtr _ClassPtr;

		// Token: 0x04002DA9 RID: 11689
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
