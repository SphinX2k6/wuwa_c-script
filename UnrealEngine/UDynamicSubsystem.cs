using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001C8 RID: 456
	[UnrealObjectPath("/Script/Engine.DynamicSubsystem")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public abstract class UDynamicSubsystem : USubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600216C RID: 8556 RVA: 0x00030FAC File Offset: 0x0002F1AC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDynamicSubsystem._ClassPtr;
		}

		// Token: 0x0600216D RID: 8557 RVA: 0x00030FB8 File Offset: 0x0002F1B8
		static UDynamicSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.DynamicSubsystem");
		}

		// Token: 0x0600216E RID: 8558 RVA: 0x00030FC8 File Offset: 0x0002F1C8
		protected UDynamicSubsystem() : this(BuiltinUtils.AllocNativeUObject(UDynamicSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600216F RID: 8559 RVA: 0x00030FF0 File Offset: 0x0002F1F0
		protected UDynamicSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000B25 RID: 2853
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.DynamicSubsystem";

		// Token: 0x04000B26 RID: 2854
		private static IntPtr _ClassPtr;

		// Token: 0x04000B27 RID: 2855
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
