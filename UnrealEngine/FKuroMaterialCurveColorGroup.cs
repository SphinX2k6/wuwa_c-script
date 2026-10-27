using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B60 RID: 7008
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialCurveColorGroup")]
	[UnrealStructLayout(1632, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1632)]
	public class FKuroMaterialCurveColorGroup : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601A882 RID: 108674 RVA: 0x00271EAE File Offset: 0x002700AE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMaterialCurveColorGroup._ScriptStructPtr != 0) ? FKuroMaterialCurveColorGroup._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialCurveColorGroup", ref FKuroMaterialCurveColorGroup._ScriptStructPtr);
		}

		// Token: 0x17006AA5 RID: 27301
		// (get) Token: 0x0601A883 RID: 108675 RVA: 0x00271ED4 File Offset: 0x002700D4
		// (set) Token: 0x0601A884 RID: 108676 RVA: 0x00271F17 File Offset: 0x00270117
		public FKuroCurveLinearColor StartCurve
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._StartCurve) == null)
				{
					result = (this._StartCurve = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)FKuroMaterialCurveColorGroup.__PropertyOffset_StartCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)FKuroMaterialCurveColorGroup.__PropertyOffset_StartCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006AA6 RID: 27302
		// (get) Token: 0x0601A885 RID: 108677 RVA: 0x00271F38 File Offset: 0x00270138
		// (set) Token: 0x0601A886 RID: 108678 RVA: 0x00271F7B File Offset: 0x0027017B
		public FKuroCurveLinearColor LoopCurve
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._LoopCurve) == null)
				{
					result = (this._LoopCurve = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)FKuroMaterialCurveColorGroup.__PropertyOffset_LoopCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)FKuroMaterialCurveColorGroup.__PropertyOffset_LoopCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006AA7 RID: 27303
		// (get) Token: 0x0601A887 RID: 108679 RVA: 0x00271F9C File Offset: 0x0027019C
		// (set) Token: 0x0601A888 RID: 108680 RVA: 0x00271FDF File Offset: 0x002701DF
		public FKuroCurveLinearColor EndCurve
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._EndCurve) == null)
				{
					result = (this._EndCurve = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)FKuroMaterialCurveColorGroup.__PropertyOffset_EndCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)FKuroMaterialCurveColorGroup.__PropertyOffset_EndCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601A889 RID: 108681 RVA: 0x00272000 File Offset: 0x00270200
		public FKuroMaterialCurveColorGroup()
		{
		}

		// Token: 0x0601A88A RID: 108682 RVA: 0x00272008 File Offset: 0x00270208
		public FKuroMaterialCurveColorGroup(FKuroCurveLinearColor StartCurve, FKuroCurveLinearColor LoopCurve, FKuroCurveLinearColor EndCurve)
		{
			this.StartCurve = StartCurve;
			this.LoopCurve = LoopCurve;
			this.EndCurve = EndCurve;
		}

		// Token: 0x0601A88B RID: 108683 RVA: 0x00272025 File Offset: 0x00270225
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMaterialCurveColorGroup.StaticStruct();
		}

		// Token: 0x0601A88C RID: 108684 RVA: 0x00272031 File Offset: 0x00270231
		[NullableContext(2)]
		public FKuroMaterialCurveColorGroup(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601A88D RID: 108685 RVA: 0x0027203B File Offset: 0x0027023B
		public FKuroMaterialCurveColorGroup(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601A88E RID: 108686 RVA: 0x00272046 File Offset: 0x00270246
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMaterialCurveColorGroup(Pointer, false, true);
		}

		// Token: 0x0601A88F RID: 108687 RVA: 0x00272050 File Offset: 0x00270250
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMaterialCurveColorGroup(Pointer, MemoryOwner);
		}

		// Token: 0x0400E5E6 RID: 58854
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialCurveColorGroup";

		// Token: 0x0400E5E7 RID: 58855
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E5E8 RID: 58856
		internal static int __PropertyOffset_StartCurve;

		// Token: 0x0400E5E9 RID: 58857
		[Nullable(2)]
		private FKuroCurveLinearColor _StartCurve;

		// Token: 0x0400E5EA RID: 58858
		internal static int __PropertyOffset_LoopCurve;

		// Token: 0x0400E5EB RID: 58859
		[Nullable(2)]
		private FKuroCurveLinearColor _LoopCurve;

		// Token: 0x0400E5EC RID: 58860
		internal static int __PropertyOffset_EndCurve;

		// Token: 0x0400E5ED RID: 58861
		[Nullable(2)]
		private FKuroCurveLinearColor _EndCurve;
	}
}
