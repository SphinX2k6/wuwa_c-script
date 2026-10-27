using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200298F RID: 10639
	[UnrealObjectPath("/Script/UMG.NamedSlot")]
	[UnrealStructLayout(696, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 696)]
	public class UNamedSlot : UContentWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027634 RID: 161332 RVA: 0x003C0D89 File Offset: 0x003BEF89
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNamedSlot._ClassPtr;
		}

		// Token: 0x06027635 RID: 161333 RVA: 0x003C0D98 File Offset: 0x003BEF98
		public UNamedSlot() : this(BuiltinUtils.AllocNativeUObject(UNamedSlot.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027636 RID: 161334 RVA: 0x003C0DC0 File Offset: 0x003BEFC0
		[NullableContext(1)]
		public UNamedSlot(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNamedSlot.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06027637 RID: 161335 RVA: 0x003C0DF3 File Offset: 0x003BEFF3
		static UNamedSlot()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.NamedSlot");
		}

		// Token: 0x06027638 RID: 161336 RVA: 0x003C0E01 File Offset: 0x003BF001
		protected UNamedSlot(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015A13 RID: 88595
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.NamedSlot";

		// Token: 0x04015A14 RID: 88596
		private static IntPtr _ClassPtr;

		// Token: 0x04015A15 RID: 88597
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
