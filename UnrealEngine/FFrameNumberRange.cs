using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000728 RID: 1832
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/CoreUObject.FrameNumberRange")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FFrameNumberRange : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060061D6 RID: 25046 RVA: 0x0008C454 File Offset: 0x0008A654
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFrameNumberRange._ScriptStructPtr != 0) ? FFrameNumberRange._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.FrameNumberRange", ref FFrameNumberRange._ScriptStructPtr);
		}

		// Token: 0x1700177F RID: 6015
		// (get) Token: 0x060061D7 RID: 25047 RVA: 0x0008C478 File Offset: 0x0008A678
		// (set) Token: 0x060061D8 RID: 25048 RVA: 0x0008C4BB File Offset: 0x0008A6BB
		public FFrameNumberRangeBound LowerBound
		{
			get
			{
				base.FastCheckIsValid();
				FFrameNumberRangeBound result;
				if ((result = this._LowerBound) == null)
				{
					result = (this._LowerBound = new FFrameNumberRangeBound(base.NativePtr + (IntPtr)FFrameNumberRange.__PropertyOffset_LowerBound, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumberRangeBound.StaticStruct(), base.NativePtr + (IntPtr)FFrameNumberRange.__PropertyOffset_LowerBound, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001780 RID: 6016
		// (get) Token: 0x060061D9 RID: 25049 RVA: 0x0008C4DC File Offset: 0x0008A6DC
		// (set) Token: 0x060061DA RID: 25050 RVA: 0x0008C51F File Offset: 0x0008A71F
		public FFrameNumberRangeBound UpperBound
		{
			get
			{
				base.FastCheckIsValid();
				FFrameNumberRangeBound result;
				if ((result = this._UpperBound) == null)
				{
					result = (this._UpperBound = new FFrameNumberRangeBound(base.NativePtr + (IntPtr)FFrameNumberRange.__PropertyOffset_UpperBound, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumberRangeBound.StaticStruct(), base.NativePtr + (IntPtr)FFrameNumberRange.__PropertyOffset_UpperBound, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060061DB RID: 25051 RVA: 0x0008C540 File Offset: 0x0008A740
		public FFrameNumberRange()
		{
		}

		// Token: 0x060061DC RID: 25052 RVA: 0x0008C548 File Offset: 0x0008A748
		public FFrameNumberRange(FFrameNumberRangeBound LowerBound, FFrameNumberRangeBound UpperBound)
		{
			this.LowerBound = LowerBound;
			this.UpperBound = UpperBound;
		}

		// Token: 0x060061DD RID: 25053 RVA: 0x0008C55E File Offset: 0x0008A75E
		protected override IntPtr GetUStructPtr()
		{
			return FFrameNumberRange.StaticStruct();
		}

		// Token: 0x060061DE RID: 25054 RVA: 0x0008C56A File Offset: 0x0008A76A
		[NullableContext(2)]
		public FFrameNumberRange(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060061DF RID: 25055 RVA: 0x0008C574 File Offset: 0x0008A774
		public FFrameNumberRange(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060061E0 RID: 25056 RVA: 0x0008C57F File Offset: 0x0008A77F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FFrameNumberRange(Pointer, false, true);
		}

		// Token: 0x060061E1 RID: 25057 RVA: 0x0008C589 File Offset: 0x0008A789
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FFrameNumberRange(Pointer, MemoryOwner);
		}

		// Token: 0x04002EB5 RID: 11957
		public const string __ObjectPath = "/Script/CoreUObject.FrameNumberRange";

		// Token: 0x04002EB6 RID: 11958
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002EB7 RID: 11959
		internal static int __PropertyOffset_LowerBound;

		// Token: 0x04002EB8 RID: 11960
		[Nullable(2)]
		private FFrameNumberRangeBound _LowerBound;

		// Token: 0x04002EB9 RID: 11961
		internal static int __PropertyOffset_UpperBound;

		// Token: 0x04002EBA RID: 11962
		[Nullable(2)]
		private FFrameNumberRangeBound _UpperBound;
	}
}
