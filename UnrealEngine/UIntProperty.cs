using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000127 RID: 295
	[UnrealObjectPath("/Script/CoreUObject.IntProperty")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UIntProperty : UNumericProperty, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001216 RID: 4630 RVA: 0x0001C987 File Offset: 0x0001AB87
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UIntProperty._ClassPtr;
		}

		// Token: 0x06001217 RID: 4631 RVA: 0x0001C994 File Offset: 0x0001AB94
		public UIntProperty() : this(BuiltinUtils.AllocNativeUObject(UIntProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001218 RID: 4632 RVA: 0x0001C9BC File Offset: 0x0001ABBC
		[NullableContext(1)]
		public UIntProperty(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UIntProperty.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06001219 RID: 4633 RVA: 0x0001C9EF File Offset: 0x0001ABEF
		static UIntProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.IntProperty");
		}

		// Token: 0x0600121A RID: 4634 RVA: 0x0001C9FD File Offset: 0x0001ABFD
		protected UIntProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400056A RID: 1386
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.IntProperty";

		// Token: 0x0400056B RID: 1387
		private static IntPtr _ClassPtr;

		// Token: 0x0400056C RID: 1388
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
