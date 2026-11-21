using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000F4 RID: 244
	[UnrealObjectPath("/Script/CoreUObject.ByteProperty")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UByteProperty : UNumericProperty, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060010E8 RID: 4328 RVA: 0x0001AD46 File Offset: 0x00018F46
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UByteProperty._ClassPtr;
		}

		// Token: 0x060010E9 RID: 4329 RVA: 0x0001AD54 File Offset: 0x00018F54
		public UByteProperty() : this(BuiltinUtils.AllocNativeUObject(UByteProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060010EA RID: 4330 RVA: 0x0001AD7C File Offset: 0x00018F7C
		[NullableContext(1)]
		public UByteProperty(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UByteProperty.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060010EB RID: 4331 RVA: 0x0001ADAF File Offset: 0x00018FAF
		static UByteProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.ByteProperty");
		}

		// Token: 0x060010EC RID: 4332 RVA: 0x0001ADBD File Offset: 0x00018FBD
		protected UByteProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000428 RID: 1064
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.ByteProperty";

		// Token: 0x04000429 RID: 1065
		private static IntPtr _ClassPtr;

		// Token: 0x0400042A RID: 1066
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
