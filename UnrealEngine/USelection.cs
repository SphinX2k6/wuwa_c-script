using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010E2 RID: 4322
	[UnrealObjectPath("/Script/Engine.Selection")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 168)]
	public class USelection : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600F7D4 RID: 63444 RVA: 0x0016EBA4 File Offset: 0x0016CDA4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USelection._ClassPtr;
		}

		// Token: 0x0600F7D5 RID: 63445 RVA: 0x0016EBB0 File Offset: 0x0016CDB0
		public USelection() : this(BuiltinUtils.AllocNativeUObject(USelection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F7D6 RID: 63446 RVA: 0x0016EBD8 File Offset: 0x0016CDD8
		[NullableContext(1)]
		public USelection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USelection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600F7D7 RID: 63447 RVA: 0x0016EC0B File Offset: 0x0016CE0B
		static USelection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.Selection");
		}

		// Token: 0x0600F7D8 RID: 63448 RVA: 0x0016EC19 File Offset: 0x0016CE19
		protected USelection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040085E8 RID: 34280
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.Selection";

		// Token: 0x040085E9 RID: 34281
		private static IntPtr _ClassPtr;

		// Token: 0x040085EA RID: 34282
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
