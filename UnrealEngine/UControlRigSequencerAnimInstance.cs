using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004D2 RID: 1234
	[UnrealObjectPath("/Script/ControlRig.ControlRigSequencerAnimInstance")]
	[UnrealStructLayout(2176, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2176)]
	public class UControlRigSequencerAnimInstance : UAnimSequencerInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06004254 RID: 16980 RVA: 0x00063268 File Offset: 0x00061468
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UControlRigSequencerAnimInstance._ClassPtr;
		}

		// Token: 0x06004255 RID: 16981 RVA: 0x00063274 File Offset: 0x00061474
		public UControlRigSequencerAnimInstance() : this(BuiltinUtils.AllocNativeUObject(UControlRigSequencerAnimInstance.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06004256 RID: 16982 RVA: 0x0006329C File Offset: 0x0006149C
		[NullableContext(1)]
		public UControlRigSequencerAnimInstance(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UControlRigSequencerAnimInstance.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06004257 RID: 16983 RVA: 0x000632CF File Offset: 0x000614CF
		static UControlRigSequencerAnimInstance()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ControlRig.ControlRigSequencerAnimInstance");
		}

		// Token: 0x06004258 RID: 16984 RVA: 0x000632DD File Offset: 0x000614DD
		protected UControlRigSequencerAnimInstance(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001F86 RID: 8070
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.ControlRigSequencerAnimInstance";

		// Token: 0x04001F87 RID: 8071
		private static IntPtr _ClassPtr;

		// Token: 0x04001F88 RID: 8072
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
