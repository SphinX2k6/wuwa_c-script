using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004B0 RID: 1200
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.AnimNode_ControlRigInputPose")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FAnimNode_ControlRigInputPose : FAnimNode_Base, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06003FE6 RID: 16358 RVA: 0x000601EC File Offset: 0x0005E3EC
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_ControlRigInputPose._ScriptStructPtr != 0) ? FAnimNode_ControlRigInputPose._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.AnimNode_ControlRigInputPose", ref FAnimNode_ControlRigInputPose._ScriptStructPtr);
		}

		// Token: 0x17000FA4 RID: 4004
		// (get) Token: 0x06003FE7 RID: 16359 RVA: 0x00060210 File Offset: 0x0005E410
		// (set) Token: 0x06003FE8 RID: 16360 RVA: 0x00060253 File Offset: 0x0005E453
		public FPoseLink InputPose
		{
			get
			{
				base.FastCheckIsValid();
				FPoseLink result;
				if ((result = this._InputPose) == null)
				{
					result = (this._InputPose = new FPoseLink(base.NativePtr + (IntPtr)FAnimNode_ControlRigInputPose.__PropertyOffset_InputPose, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_ControlRigInputPose.__PropertyOffset_InputPose, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06003FE9 RID: 16361 RVA: 0x00060274 File Offset: 0x0005E474
		public FAnimNode_ControlRigInputPose()
		{
		}

		// Token: 0x06003FEA RID: 16362 RVA: 0x0006027C File Offset: 0x0005E47C
		public FAnimNode_ControlRigInputPose(FPoseLink InputPose)
		{
			this.InputPose = InputPose;
		}

		// Token: 0x06003FEB RID: 16363 RVA: 0x0006028B File Offset: 0x0005E48B
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_ControlRigInputPose.StaticStruct();
		}

		// Token: 0x06003FEC RID: 16364 RVA: 0x00060297 File Offset: 0x0005E497
		[NullableContext(2)]
		public FAnimNode_ControlRigInputPose(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003FED RID: 16365 RVA: 0x000602A1 File Offset: 0x0005E4A1
		public FAnimNode_ControlRigInputPose(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003FEE RID: 16366 RVA: 0x000602AC File Offset: 0x0005E4AC
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_ControlRigInputPose(Pointer, false, true);
		}

		// Token: 0x06003FEF RID: 16367 RVA: 0x000602B6 File Offset: 0x0005E4B6
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_ControlRigInputPose(Pointer, MemoryOwner);
		}

		// Token: 0x04001E94 RID: 7828
		public new const string __ObjectPath = "/Script/ControlRig.AnimNode_ControlRigInputPose";

		// Token: 0x04001E95 RID: 7829
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001E96 RID: 7830
		internal static int __PropertyOffset_InputPose;

		// Token: 0x04001E97 RID: 7831
		[Nullable(2)]
		private FPoseLink _InputPose;
	}
}
