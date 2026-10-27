using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001620 RID: 5664
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.AnimNode_SlotBlend")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 104)]
	public class FAnimNode_SlotBlend : FAnimNode_Base, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601479E RID: 83870 RVA: 0x001E1E5C File Offset: 0x001E005C
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_SlotBlend._ScriptStructPtr != 0) ? FAnimNode_SlotBlend._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.AnimNode_SlotBlend", ref FAnimNode_SlotBlend._ScriptStructPtr);
		}

		// Token: 0x17005091 RID: 20625
		// (get) Token: 0x0601479F RID: 83871 RVA: 0x001E1E80 File Offset: 0x001E0080
		// (set) Token: 0x060147A0 RID: 83872 RVA: 0x001E1EC3 File Offset: 0x001E00C3
		public FPoseLink A
		{
			get
			{
				base.FastCheckIsValid();
				FPoseLink result;
				if ((result = this._A) == null)
				{
					result = (this._A = new FPoseLink(base.NativePtr + (IntPtr)FAnimNode_SlotBlend.__PropertyOffset_A, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_SlotBlend.__PropertyOffset_A, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005092 RID: 20626
		// (get) Token: 0x060147A1 RID: 83873 RVA: 0x001E1EE4 File Offset: 0x001E00E4
		// (set) Token: 0x060147A2 RID: 83874 RVA: 0x001E1F27 File Offset: 0x001E0127
		public FPoseLink B
		{
			get
			{
				base.FastCheckIsValid();
				FPoseLink result;
				if ((result = this._B) == null)
				{
					result = (this._B = new FPoseLink(base.NativePtr + (IntPtr)FAnimNode_SlotBlend.__PropertyOffset_B, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_SlotBlend.__PropertyOffset_B, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005093 RID: 20627
		// (get) Token: 0x060147A3 RID: 83875 RVA: 0x001E1F48 File Offset: 0x001E0148
		// (set) Token: 0x060147A4 RID: 83876 RVA: 0x001E1F61 File Offset: 0x001E0161
		public unsafe bool bResetChildOnActivation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_SlotBlend.__PropertyOffset_bResetChildOnActivation) & FAnimNode_SlotBlend.__PropertyMask_bResetChildOnActivation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_SlotBlend.__PropertyOffset_bResetChildOnActivation) = ((*(base.NativePtr + (IntPtr)FAnimNode_SlotBlend.__PropertyOffset_bResetChildOnActivation) & ~FAnimNode_SlotBlend.__PropertyMask_bResetChildOnActivation) | (value ? FAnimNode_SlotBlend.__PropertyMask_bResetChildOnActivation : 0));
			}
		}

		// Token: 0x17005094 RID: 20628
		// (get) Token: 0x060147A5 RID: 83877 RVA: 0x001E1F91 File Offset: 0x001E0191
		// (set) Token: 0x060147A6 RID: 83878 RVA: 0x001E1FA5 File Offset: 0x001E01A5
		public unsafe FName SlotName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_SlotBlend.__PropertyOffset_SlotName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_SlotBlend.__PropertyOffset_SlotName) = value;
			}
		}

		// Token: 0x060147A7 RID: 83879 RVA: 0x001E1FBA File Offset: 0x001E01BA
		public FAnimNode_SlotBlend()
		{
		}

		// Token: 0x060147A8 RID: 83880 RVA: 0x001E1FC2 File Offset: 0x001E01C2
		public FAnimNode_SlotBlend(FPoseLink A, FPoseLink B, bool bResetChildOnActivation, FName SlotName)
		{
			this.A = A;
			this.B = B;
			this.bResetChildOnActivation = bResetChildOnActivation;
			this.SlotName = SlotName;
		}

		// Token: 0x060147A9 RID: 83881 RVA: 0x001E1FE7 File Offset: 0x001E01E7
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_SlotBlend.StaticStruct();
		}

		// Token: 0x060147AA RID: 83882 RVA: 0x001E1FF3 File Offset: 0x001E01F3
		[NullableContext(2)]
		public FAnimNode_SlotBlend(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060147AB RID: 83883 RVA: 0x001E1FFD File Offset: 0x001E01FD
		public FAnimNode_SlotBlend(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060147AC RID: 83884 RVA: 0x001E2008 File Offset: 0x001E0208
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_SlotBlend(Pointer, false, true);
		}

		// Token: 0x060147AD RID: 83885 RVA: 0x001E2012 File Offset: 0x001E0212
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_SlotBlend(Pointer, MemoryOwner);
		}

		// Token: 0x0400B231 RID: 45617
		public new const string __ObjectPath = "/Script/KuroAnim.AnimNode_SlotBlend";

		// Token: 0x0400B232 RID: 45618
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B233 RID: 45619
		internal static int __PropertyOffset_A;

		// Token: 0x0400B234 RID: 45620
		[Nullable(2)]
		private FPoseLink _A;

		// Token: 0x0400B235 RID: 45621
		internal static int __PropertyOffset_B;

		// Token: 0x0400B236 RID: 45622
		[Nullable(2)]
		private FPoseLink _B;

		// Token: 0x0400B237 RID: 45623
		internal static int __PropertyOffset_bResetChildOnActivation;

		// Token: 0x0400B238 RID: 45624
		internal static byte __PropertyMask_bResetChildOnActivation;

		// Token: 0x0400B239 RID: 45625
		internal static int __PropertyOffset_SlotName;
	}
}
