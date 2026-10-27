using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002B4 RID: 692
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimationCore.AimConstraintDescription")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FAimConstraintDescription : FConstraintDescriptionEx, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002694 RID: 9876 RVA: 0x0003A05B File Offset: 0x0003825B
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAimConstraintDescription._ScriptStructPtr != 0) ? FAimConstraintDescription._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimationCore.AimConstraintDescription", ref FAimConstraintDescription._ScriptStructPtr);
		}

		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x06002695 RID: 9877 RVA: 0x0003A080 File Offset: 0x00038280
		// (set) Token: 0x06002696 RID: 9878 RVA: 0x0003A0C3 File Offset: 0x000382C3
		public FAxis LookAt_Axis
		{
			get
			{
				base.FastCheckIsValid();
				FAxis result;
				if ((result = this._LookAt_Axis) == null)
				{
					result = (this._LookAt_Axis = new FAxis(base.NativePtr + (IntPtr)FAimConstraintDescription.__PropertyOffset_LookAt_Axis, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAxis.StaticStruct(), base.NativePtr + (IntPtr)FAimConstraintDescription.__PropertyOffset_LookAt_Axis, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x06002697 RID: 9879 RVA: 0x0003A0E4 File Offset: 0x000382E4
		// (set) Token: 0x06002698 RID: 9880 RVA: 0x0003A127 File Offset: 0x00038327
		public FAxis LookUp_Axis
		{
			get
			{
				base.FastCheckIsValid();
				FAxis result;
				if ((result = this._LookUp_Axis) == null)
				{
					result = (this._LookUp_Axis = new FAxis(base.NativePtr + (IntPtr)FAimConstraintDescription.__PropertyOffset_LookUp_Axis, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAxis.StaticStruct(), base.NativePtr + (IntPtr)FAimConstraintDescription.__PropertyOffset_LookUp_Axis, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x06002699 RID: 9881 RVA: 0x0003A148 File Offset: 0x00038348
		// (set) Token: 0x0600269A RID: 9882 RVA: 0x0003A158 File Offset: 0x00038358
		public unsafe bool bUseLookUp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAimConstraintDescription.__PropertyOffset_bUseLookUp) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAimConstraintDescription.__PropertyOffset_bUseLookUp) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x0600269B RID: 9883 RVA: 0x0003A169 File Offset: 0x00038369
		// (set) Token: 0x0600269C RID: 9884 RVA: 0x0003A17D File Offset: 0x0003837D
		public unsafe FVector LookUpTarget
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAimConstraintDescription.__PropertyOffset_LookUpTarget);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAimConstraintDescription.__PropertyOffset_LookUpTarget) = value;
			}
		}

		// Token: 0x0600269D RID: 9885 RVA: 0x0003A192 File Offset: 0x00038392
		public FAimConstraintDescription()
		{
		}

		// Token: 0x0600269E RID: 9886 RVA: 0x0003A19A File Offset: 0x0003839A
		public FAimConstraintDescription(FAxis LookAt_Axis, FAxis LookUp_Axis, bool bUseLookUp, FVector LookUpTarget, FFilterOptionPerAxis AxesFilterOption)
		{
			this.LookAt_Axis = LookAt_Axis;
			this.LookUp_Axis = LookUp_Axis;
			this.bUseLookUp = bUseLookUp;
			this.LookUpTarget = LookUpTarget;
			base.AxesFilterOption = AxesFilterOption;
		}

		// Token: 0x0600269F RID: 9887 RVA: 0x0003A1C7 File Offset: 0x000383C7
		protected override IntPtr GetUStructPtr()
		{
			return FAimConstraintDescription.StaticStruct();
		}

		// Token: 0x060026A0 RID: 9888 RVA: 0x0003A1D3 File Offset: 0x000383D3
		[NullableContext(2)]
		public FAimConstraintDescription(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060026A1 RID: 9889 RVA: 0x0003A1DD File Offset: 0x000383DD
		public FAimConstraintDescription(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060026A2 RID: 9890 RVA: 0x0003A1E8 File Offset: 0x000383E8
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAimConstraintDescription(Pointer, false, true);
		}

		// Token: 0x060026A3 RID: 9891 RVA: 0x0003A1F2 File Offset: 0x000383F2
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAimConstraintDescription(Pointer, MemoryOwner);
		}

		// Token: 0x04000F25 RID: 3877
		public new const string __ObjectPath = "/Script/AnimationCore.AimConstraintDescription";

		// Token: 0x04000F26 RID: 3878
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000F27 RID: 3879
		internal static int __PropertyOffset_LookAt_Axis;

		// Token: 0x04000F28 RID: 3880
		[Nullable(2)]
		private FAxis _LookAt_Axis;

		// Token: 0x04000F29 RID: 3881
		internal static int __PropertyOffset_LookUp_Axis;

		// Token: 0x04000F2A RID: 3882
		[Nullable(2)]
		private FAxis _LookUp_Axis;

		// Token: 0x04000F2B RID: 3883
		internal static int __PropertyOffset_bUseLookUp;

		// Token: 0x04000F2C RID: 3884
		internal static int __PropertyOffset_LookUpTarget;
	}
}
