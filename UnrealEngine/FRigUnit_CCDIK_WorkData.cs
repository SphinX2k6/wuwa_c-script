using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200055D RID: 1373
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_CCDIK_WorkData")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FRigUnit_CCDIK_WorkData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060048BF RID: 18623 RVA: 0x0006BCD7 File Offset: 0x00069ED7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_CCDIK_WorkData._ScriptStructPtr != 0) ? FRigUnit_CCDIK_WorkData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_CCDIK_WorkData", ref FRigUnit_CCDIK_WorkData._ScriptStructPtr);
		}

		// Token: 0x170011C0 RID: 4544
		// (get) Token: 0x060048C0 RID: 18624 RVA: 0x0006BCFC File Offset: 0x00069EFC
		// (set) Token: 0x060048C1 RID: 18625 RVA: 0x0006BD3F File Offset: 0x00069F3F
		public TArray<FCCDIKChainLink> Chain
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FCCDIKChainLink> result;
				if ((result = this._Chain) == null)
				{
					result = (this._Chain = new TArray<FCCDIKChainLink>(base.NativePtr + (IntPtr)FRigUnit_CCDIK_WorkData.__PropertyOffset_Chain, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Chain.CopyAssign(value);
			}
		}

		// Token: 0x170011C1 RID: 4545
		// (get) Token: 0x060048C2 RID: 18626 RVA: 0x0006BD50 File Offset: 0x00069F50
		// (set) Token: 0x060048C3 RID: 18627 RVA: 0x0006BD93 File Offset: 0x00069F93
		public TArray<FCachedRigElement> CachedItems
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FCachedRigElement> result;
				if ((result = this._CachedItems) == null)
				{
					result = (this._CachedItems = new TArray<FCachedRigElement>(base.NativePtr + (IntPtr)FRigUnit_CCDIK_WorkData.__PropertyOffset_CachedItems, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CachedItems.CopyAssign(value);
			}
		}

		// Token: 0x170011C2 RID: 4546
		// (get) Token: 0x060048C4 RID: 18628 RVA: 0x0006BDA4 File Offset: 0x00069FA4
		// (set) Token: 0x060048C5 RID: 18629 RVA: 0x0006BDE7 File Offset: 0x00069FE7
		public TArray<int> RotationLimitIndex
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._RotationLimitIndex) == null)
				{
					result = (this._RotationLimitIndex = new TArray<int>(base.NativePtr + (IntPtr)FRigUnit_CCDIK_WorkData.__PropertyOffset_RotationLimitIndex, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.RotationLimitIndex.CopyAssign(value);
			}
		}

		// Token: 0x170011C3 RID: 4547
		// (get) Token: 0x060048C6 RID: 18630 RVA: 0x0006BDF8 File Offset: 0x00069FF8
		// (set) Token: 0x060048C7 RID: 18631 RVA: 0x0006BE3B File Offset: 0x0006A03B
		public TArray<float> RotationLimitsPerItem
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._RotationLimitsPerItem) == null)
				{
					result = (this._RotationLimitsPerItem = new TArray<float>(base.NativePtr + (IntPtr)FRigUnit_CCDIK_WorkData.__PropertyOffset_RotationLimitsPerItem, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.RotationLimitsPerItem.CopyAssign(value);
			}
		}

		// Token: 0x170011C4 RID: 4548
		// (get) Token: 0x060048C8 RID: 18632 RVA: 0x0006BE4C File Offset: 0x0006A04C
		// (set) Token: 0x060048C9 RID: 18633 RVA: 0x0006BE8F File Offset: 0x0006A08F
		public FCachedRigElement CachedEffector
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedEffector) == null)
				{
					result = (this._CachedEffector = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_CCDIK_WorkData.__PropertyOffset_CachedEffector, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_CCDIK_WorkData.__PropertyOffset_CachedEffector, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060048CA RID: 18634 RVA: 0x0006BEB0 File Offset: 0x0006A0B0
		public FRigUnit_CCDIK_WorkData()
		{
		}

		// Token: 0x060048CB RID: 18635 RVA: 0x0006BEB8 File Offset: 0x0006A0B8
		public FRigUnit_CCDIK_WorkData(TArray<FCCDIKChainLink> Chain, TArray<FCachedRigElement> CachedItems, TArray<int> RotationLimitIndex, TArray<float> RotationLimitsPerItem, FCachedRigElement CachedEffector)
		{
			this.Chain = Chain;
			this.CachedItems = CachedItems;
			this.RotationLimitIndex = RotationLimitIndex;
			this.RotationLimitsPerItem = RotationLimitsPerItem;
			this.CachedEffector = CachedEffector;
		}

		// Token: 0x060048CC RID: 18636 RVA: 0x0006BEE5 File Offset: 0x0006A0E5
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_CCDIK_WorkData.StaticStruct();
		}

		// Token: 0x060048CD RID: 18637 RVA: 0x0006BEF1 File Offset: 0x0006A0F1
		[NullableContext(2)]
		public FRigUnit_CCDIK_WorkData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060048CE RID: 18638 RVA: 0x0006BEFB File Offset: 0x0006A0FB
		public FRigUnit_CCDIK_WorkData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060048CF RID: 18639 RVA: 0x0006BF06 File Offset: 0x0006A106
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_CCDIK_WorkData(Pointer, false, true);
		}

		// Token: 0x060048D0 RID: 18640 RVA: 0x0006BF10 File Offset: 0x0006A110
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_CCDIK_WorkData(Pointer, MemoryOwner);
		}

		// Token: 0x04002347 RID: 9031
		public const string __ObjectPath = "/Script/ControlRig.RigUnit_CCDIK_WorkData";

		// Token: 0x04002348 RID: 9032
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002349 RID: 9033
		internal static int __PropertyOffset_Chain;

		// Token: 0x0400234A RID: 9034
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCCDIKChainLink> _Chain;

		// Token: 0x0400234B RID: 9035
		internal static int __PropertyOffset_CachedItems;

		// Token: 0x0400234C RID: 9036
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCachedRigElement> _CachedItems;

		// Token: 0x0400234D RID: 9037
		internal static int __PropertyOffset_RotationLimitIndex;

		// Token: 0x0400234E RID: 9038
		[Nullable(2)]
		private TArray<int> _RotationLimitIndex;

		// Token: 0x0400234F RID: 9039
		internal static int __PropertyOffset_RotationLimitsPerItem;

		// Token: 0x04002350 RID: 9040
		[Nullable(2)]
		private TArray<float> _RotationLimitsPerItem;

		// Token: 0x04002351 RID: 9041
		internal static int __PropertyOffset_CachedEffector;

		// Token: 0x04002352 RID: 9042
		[Nullable(2)]
		private FCachedRigElement _CachedEffector;
	}
}
