using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200118E RID: 4494
	[UnrealObjectPath("/Script/Engine.StaticLevelInstanceLevelStreaming")]
	[UnrealStructLayout(608, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 608)]
	public class UStaticLevelInstanceLevelStreaming : ULevelStreamingDynamic, IUnrealUObject, IUnrealObject, ILevelInstanceLevelStreamingInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0601081F RID: 67615 RVA: 0x00183D1A File Offset: 0x00181F1A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UStaticLevelInstanceLevelStreaming._ClassPtr;
		}

		// Token: 0x06010820 RID: 67616 RVA: 0x00183D26 File Offset: 0x00181F26
		int ILevelInstanceLevelStreamingInterface.InterfaceOffset()
		{
			return UStaticLevelInstanceLevelStreaming.__InterfaceOffset_ILevelInstanceLevelStreamingInterface;
		}

		// Token: 0x06010821 RID: 67617 RVA: 0x00183D30 File Offset: 0x00181F30
		public UStaticLevelInstanceLevelStreaming() : this(BuiltinUtils.AllocNativeUObject(UStaticLevelInstanceLevelStreaming.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010822 RID: 67618 RVA: 0x00183D58 File Offset: 0x00181F58
		[NullableContext(1)]
		public UStaticLevelInstanceLevelStreaming(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UStaticLevelInstanceLevelStreaming.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06010823 RID: 67619 RVA: 0x00183D8B File Offset: 0x00181F8B
		static UStaticLevelInstanceLevelStreaming()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.StaticLevelInstanceLevelStreaming");
		}

		// Token: 0x06010824 RID: 67620 RVA: 0x00183D99 File Offset: 0x00181F99
		protected UStaticLevelInstanceLevelStreaming(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008D43 RID: 36163
		internal static int __InterfaceOffset_ILevelInstanceLevelStreamingInterface;

		// Token: 0x04008D44 RID: 36164
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.StaticLevelInstanceLevelStreaming";

		// Token: 0x04008D45 RID: 36165
		private static IntPtr _ClassPtr;

		// Token: 0x04008D46 RID: 36166
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
