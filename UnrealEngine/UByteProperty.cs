using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000709 RID: 1801
	[UnrealObjectPath("/Script/CoreUObject.ByteProperty")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UByteProperty : UNumericProperty, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006181 RID: 24961 RVA: 0x0008BCAA File Offset: 0x00089EAA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UByteProperty._ClassPtr;
		}

		// Token: 0x06006182 RID: 24962 RVA: 0x0008BCB8 File Offset: 0x00089EB8
		public UByteProperty() : this(BuiltinUtils.AllocNativeUObject(UByteProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006183 RID: 24963 RVA: 0x0008BCE0 File Offset: 0x00089EE0
		[NullableContext(1)]
		public UByteProperty(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UByteProperty.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06006184 RID: 24964 RVA: 0x0008BD13 File Offset: 0x00089F13
		static UByteProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.ByteProperty");
		}

		// Token: 0x06006185 RID: 24965 RVA: 0x0008BD21 File Offset: 0x00089F21
		protected UByteProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002D99 RID: 11673
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.ByteProperty";

		// Token: 0x04002D9A RID: 11674
		private static IntPtr _ClassPtr;

		// Token: 0x04002D9B RID: 11675
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
