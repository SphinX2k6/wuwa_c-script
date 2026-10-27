using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200158D RID: 5517
	[UnrealObjectPath("/Script/InteractiveToolsFramework.MultiClickSequenceInputBehavior")]
	[UnrealStructLayout(336, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 336)]
	public class UMultiClickSequenceInputBehavior : UAnyButtonInputBehavior, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013E8F RID: 81551 RVA: 0x001D3CAA File Offset: 0x001D1EAA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMultiClickSequenceInputBehavior._ClassPtr;
		}

		// Token: 0x06013E90 RID: 81552 RVA: 0x001D3CB8 File Offset: 0x001D1EB8
		public UMultiClickSequenceInputBehavior() : this(BuiltinUtils.AllocNativeUObject(UMultiClickSequenceInputBehavior.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013E91 RID: 81553 RVA: 0x001D3CE0 File Offset: 0x001D1EE0
		[NullableContext(1)]
		public UMultiClickSequenceInputBehavior(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMultiClickSequenceInputBehavior.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06013E92 RID: 81554 RVA: 0x001D3D13 File Offset: 0x001D1F13
		static UMultiClickSequenceInputBehavior()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.MultiClickSequenceInputBehavior");
		}

		// Token: 0x06013E93 RID: 81555 RVA: 0x001D3D21 File Offset: 0x001D1F21
		protected UMultiClickSequenceInputBehavior(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AC6A RID: 44138
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.MultiClickSequenceInputBehavior";

		// Token: 0x0400AC6B RID: 44139
		private static IntPtr _ClassPtr;

		// Token: 0x0400AC6C RID: 44140
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
