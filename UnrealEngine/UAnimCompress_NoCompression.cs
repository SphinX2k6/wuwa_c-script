using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007F9 RID: 2041
	[UnrealObjectPath("/Script/Engine.AnimCompress_NoCompression")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UAnimCompress_NoCompression : UAnimCompress, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006CD1 RID: 27857 RVA: 0x0009CA52 File Offset: 0x0009AC52
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimCompress_NoCompression._ClassPtr;
		}

		// Token: 0x06006CD2 RID: 27858 RVA: 0x0009CA60 File Offset: 0x0009AC60
		public UAnimCompress_NoCompression() : this(BuiltinUtils.AllocNativeUObject(UAnimCompress_NoCompression.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006CD3 RID: 27859 RVA: 0x0009CA88 File Offset: 0x0009AC88
		[NullableContext(1)]
		public UAnimCompress_NoCompression(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAnimCompress_NoCompression.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06006CD4 RID: 27860 RVA: 0x0009CABB File Offset: 0x0009ACBB
		static UAnimCompress_NoCompression()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AnimCompress_NoCompression");
		}

		// Token: 0x06006CD5 RID: 27861 RVA: 0x0009CAC9 File Offset: 0x0009ACC9
		protected UAnimCompress_NoCompression(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003482 RID: 13442
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AnimCompress_NoCompression";

		// Token: 0x04003483 RID: 13443
		private static IntPtr _ClassPtr;

		// Token: 0x04003484 RID: 13444
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
