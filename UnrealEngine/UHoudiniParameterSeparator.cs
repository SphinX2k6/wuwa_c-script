using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014FA RID: 5370
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniParameterSeparator")]
	[UnrealStructLayout(272, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 272)]
	public class UHoudiniParameterSeparator : UHoudiniParameter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013779 RID: 79737 RVA: 0x001C9EB9 File Offset: 0x001C80B9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniParameterSeparator._ClassPtr;
		}

		// Token: 0x0601377A RID: 79738 RVA: 0x001C9EC8 File Offset: 0x001C80C8
		public UHoudiniParameterSeparator() : this(BuiltinUtils.AllocNativeUObject(UHoudiniParameterSeparator.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601377B RID: 79739 RVA: 0x001C9EF0 File Offset: 0x001C80F0
		[NullableContext(1)]
		public UHoudiniParameterSeparator(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniParameterSeparator.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601377C RID: 79740 RVA: 0x001C9F23 File Offset: 0x001C8123
		static UHoudiniParameterSeparator()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniParameterSeparator");
		}

		// Token: 0x0601377D RID: 79741 RVA: 0x001C9F31 File Offset: 0x001C8131
		protected UHoudiniParameterSeparator(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A85E RID: 43102
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniParameterSeparator";

		// Token: 0x0400A85F RID: 43103
		private static IntPtr _ClassPtr;

		// Token: 0x0400A860 RID: 43104
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
