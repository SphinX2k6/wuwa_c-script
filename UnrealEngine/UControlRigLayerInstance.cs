using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004CA RID: 1226
	[UnrealObjectPath("/Script/ControlRig.ControlRigLayerInstance")]
	[UnrealStructLayout(2176, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2176)]
	public class UControlRigLayerInstance : UAnimInstance, IUnrealUObject, IUnrealObject, ISequencerAnimationSupport, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x060041FC RID: 16892 RVA: 0x00062B1A File Offset: 0x00060D1A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UControlRigLayerInstance._ClassPtr;
		}

		// Token: 0x060041FD RID: 16893 RVA: 0x00062B26 File Offset: 0x00060D26
		int ISequencerAnimationSupport.InterfaceOffset()
		{
			return UControlRigLayerInstance.__InterfaceOffset_ISequencerAnimationSupport;
		}

		// Token: 0x060041FE RID: 16894 RVA: 0x00062B30 File Offset: 0x00060D30
		public UControlRigLayerInstance() : this(BuiltinUtils.AllocNativeUObject(UControlRigLayerInstance.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060041FF RID: 16895 RVA: 0x00062B58 File Offset: 0x00060D58
		[NullableContext(1)]
		public UControlRigLayerInstance(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UControlRigLayerInstance.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06004200 RID: 16896 RVA: 0x00062B8B File Offset: 0x00060D8B
		static UControlRigLayerInstance()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ControlRig.ControlRigLayerInstance");
		}

		// Token: 0x06004201 RID: 16897 RVA: 0x00062B99 File Offset: 0x00060D99
		protected UControlRigLayerInstance(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001F5A RID: 8026
		internal static int __InterfaceOffset_ISequencerAnimationSupport;

		// Token: 0x04001F5B RID: 8027
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.ControlRigLayerInstance";

		// Token: 0x04001F5C RID: 8028
		private static IntPtr _ClassPtr;

		// Token: 0x04001F5D RID: 8029
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
