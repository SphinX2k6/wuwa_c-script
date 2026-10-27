using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200074B RID: 1867
	[UnrealObjectPath("/Script/CoreUObject.MulticastInlineDelegateProperty")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UMulticastInlineDelegateProperty : UMulticastDelegateProperty, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060062ED RID: 25325 RVA: 0x0008DF96 File Offset: 0x0008C196
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMulticastInlineDelegateProperty._ClassPtr;
		}

		// Token: 0x060062EE RID: 25326 RVA: 0x0008DFA4 File Offset: 0x0008C1A4
		public UMulticastInlineDelegateProperty() : this(BuiltinUtils.AllocNativeUObject(UMulticastInlineDelegateProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060062EF RID: 25327 RVA: 0x0008DFCC File Offset: 0x0008C1CC
		[NullableContext(1)]
		public UMulticastInlineDelegateProperty(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMulticastInlineDelegateProperty.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060062F0 RID: 25328 RVA: 0x0008DFFF File Offset: 0x0008C1FF
		static UMulticastInlineDelegateProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.MulticastInlineDelegateProperty");
		}

		// Token: 0x060062F1 RID: 25329 RVA: 0x0008E00D File Offset: 0x0008C20D
		protected UMulticastInlineDelegateProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002F58 RID: 12120
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.MulticastInlineDelegateProperty";

		// Token: 0x04002F59 RID: 12121
		private static IntPtr _ClassPtr;

		// Token: 0x04002F5A RID: 12122
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
