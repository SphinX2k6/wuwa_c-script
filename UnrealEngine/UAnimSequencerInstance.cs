using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200030F RID: 783
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimSequencerInstance")]
	[UnrealStructLayout(2176, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2176)]
	public class UAnimSequencerInstance : UAnimInstance, IUnrealUObject, IUnrealObject, ISequencerAnimationSupport, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06002D2F RID: 11567 RVA: 0x00045564 File Offset: 0x00043764
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimSequencerInstance._ClassPtr;
		}

		// Token: 0x06002D30 RID: 11568 RVA: 0x00045570 File Offset: 0x00043770
		int ISequencerAnimationSupport.InterfaceOffset()
		{
			return UAnimSequencerInstance.__InterfaceOffset_ISequencerAnimationSupport;
		}

		// Token: 0x06002D31 RID: 11569 RVA: 0x00045578 File Offset: 0x00043778
		public UAnimSequencerInstance() : this(BuiltinUtils.AllocNativeUObject(UAnimSequencerInstance.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06002D32 RID: 11570 RVA: 0x000455A0 File Offset: 0x000437A0
		[NullableContext(1)]
		public UAnimSequencerInstance(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAnimSequencerInstance.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06002D33 RID: 11571 RVA: 0x000455D3 File Offset: 0x000437D3
		static UAnimSequencerInstance()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AnimGraphRuntime.AnimSequencerInstance");
		}

		// Token: 0x06002D34 RID: 11572 RVA: 0x000455E1 File Offset: 0x000437E1
		protected UAnimSequencerInstance(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040012B9 RID: 4793
		internal static int __InterfaceOffset_ISequencerAnimationSupport;

		// Token: 0x040012BA RID: 4794
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.AnimSequencerInstance";

		// Token: 0x040012BB RID: 4795
		private static IntPtr _ClassPtr;

		// Token: 0x040012BC RID: 4796
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
