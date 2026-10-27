using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001BF0 RID: 7152
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroWpoFogCorrSetting")]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 28)]
	public class FKuroWpoFogCorrSetting : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601B88A RID: 112778 RVA: 0x00288AB0 File Offset: 0x00286CB0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroWpoFogCorrSetting._ScriptStructPtr != 0) ? FKuroWpoFogCorrSetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroWpoFogCorrSetting", ref FKuroWpoFogCorrSetting._ScriptStructPtr);
		}

		// Token: 0x17006EDE RID: 28382
		// (get) Token: 0x0601B88B RID: 112779 RVA: 0x00288AD4 File Offset: 0x00286CD4
		// (set) Token: 0x0601B88C RID: 112780 RVA: 0x00288AED File Offset: 0x00286CED
		public unsafe bool bOverride_WpoFogCorrEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroWpoFogCorrSetting.__PropertyOffset_bOverride_WpoFogCorrEnabled) & FKuroWpoFogCorrSetting.__PropertyMask_bOverride_WpoFogCorrEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroWpoFogCorrSetting.__PropertyOffset_bOverride_WpoFogCorrEnabled) = ((*(base.NativePtr + (IntPtr)FKuroWpoFogCorrSetting.__PropertyOffset_bOverride_WpoFogCorrEnabled) & ~FKuroWpoFogCorrSetting.__PropertyMask_bOverride_WpoFogCorrEnabled) | (value ? FKuroWpoFogCorrSetting.__PropertyMask_bOverride_WpoFogCorrEnabled : 0));
			}
		}

		// Token: 0x17006EDF RID: 28383
		// (get) Token: 0x0601B88D RID: 112781 RVA: 0x00288B1D File Offset: 0x00286D1D
		// (set) Token: 0x0601B88E RID: 112782 RVA: 0x00288B36 File Offset: 0x00286D36
		public unsafe bool bOverride_WpoFogCorrX0
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroWpoFogCorrSetting.__PropertyOffset_bOverride_WpoFogCorrX0) & FKuroWpoFogCorrSetting.__PropertyMask_bOverride_WpoFogCorrX0) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroWpoFogCorrSetting.__PropertyOffset_bOverride_WpoFogCorrX0) = ((*(base.NativePtr + (IntPtr)FKuroWpoFogCorrSetting.__PropertyOffset_bOverride_WpoFogCorrX0) & ~FKuroWpoFogCorrSetting.__PropertyMask_bOverride_WpoFogCorrX0) | (value ? FKuroWpoFogCorrSetting.__PropertyMask_bOverride_WpoFogCorrX0 : 0));
			}
		}

		// Token: 0x17006EE0 RID: 28384
		// (get) Token: 0x0601B88F RID: 112783 RVA: 0x00288B66 File Offset: 0x00286D66
		// (set) Token: 0x0601B890 RID: 112784 RVA: 0x00288B7F File Offset: 0x00286D7F
		public unsafe bool bOverride_WpoFogCorrR
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroWpoFogCorrSetting.__PropertyOffset_bOverride_WpoFogCorrR) & FKuroWpoFogCorrSetting.__PropertyMask_bOverride_WpoFogCorrR) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroWpoFogCorrSetting.__PropertyOffset_bOverride_WpoFogCorrR) = ((*(base.NativePtr + (IntPtr)FKuroWpoFogCorrSetting.__PropertyOffset_bOverride_WpoFogCorrR) & ~FKuroWpoFogCorrSetting.__PropertyMask_bOverride_WpoFogCorrR) | (value ? FKuroWpoFogCorrSetting.__PropertyMask_bOverride_WpoFogCorrR : 0));
			}
		}

		// Token: 0x17006EE1 RID: 28385
		// (get) Token: 0x0601B891 RID: 112785 RVA: 0x00288BAF File Offset: 0x00286DAF
		// (set) Token: 0x0601B892 RID: 112786 RVA: 0x00288BC8 File Offset: 0x00286DC8
		public unsafe bool bOverride_WpoFogCorrXMin
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroWpoFogCorrSetting.__PropertyOffset_bOverride_WpoFogCorrXMin) & FKuroWpoFogCorrSetting.__PropertyMask_bOverride_WpoFogCorrXMin) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroWpoFogCorrSetting.__PropertyOffset_bOverride_WpoFogCorrXMin) = ((*(base.NativePtr + (IntPtr)FKuroWpoFogCorrSetting.__PropertyOffset_bOverride_WpoFogCorrXMin) & ~FKuroWpoFogCorrSetting.__PropertyMask_bOverride_WpoFogCorrXMin) | (value ? FKuroWpoFogCorrSetting.__PropertyMask_bOverride_WpoFogCorrXMin : 0));
			}
		}

		// Token: 0x17006EE2 RID: 28386
		// (get) Token: 0x0601B893 RID: 112787 RVA: 0x00288BF8 File Offset: 0x00286DF8
		// (set) Token: 0x0601B894 RID: 112788 RVA: 0x00288C11 File Offset: 0x00286E11
		public unsafe bool bOverride_WpoFogCorrXMax
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroWpoFogCorrSetting.__PropertyOffset_bOverride_WpoFogCorrXMax) & FKuroWpoFogCorrSetting.__PropertyMask_bOverride_WpoFogCorrXMax) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroWpoFogCorrSetting.__PropertyOffset_bOverride_WpoFogCorrXMax) = ((*(base.NativePtr + (IntPtr)FKuroWpoFogCorrSetting.__PropertyOffset_bOverride_WpoFogCorrXMax) & ~FKuroWpoFogCorrSetting.__PropertyMask_bOverride_WpoFogCorrXMax) | (value ? FKuroWpoFogCorrSetting.__PropertyMask_bOverride_WpoFogCorrXMax : 0));
			}
		}

		// Token: 0x17006EE3 RID: 28387
		// (get) Token: 0x0601B895 RID: 112789 RVA: 0x00288C41 File Offset: 0x00286E41
		// (set) Token: 0x0601B896 RID: 112790 RVA: 0x00288C5A File Offset: 0x00286E5A
		public unsafe bool bOverride_WpoFogCorrYMin
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroWpoFogCorrSetting.__PropertyOffset_bOverride_WpoFogCorrYMin) & FKuroWpoFogCorrSetting.__PropertyMask_bOverride_WpoFogCorrYMin) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroWpoFogCorrSetting.__PropertyOffset_bOverride_WpoFogCorrYMin) = ((*(base.NativePtr + (IntPtr)FKuroWpoFogCorrSetting.__PropertyOffset_bOverride_WpoFogCorrYMin) & ~FKuroWpoFogCorrSetting.__PropertyMask_bOverride_WpoFogCorrYMin) | (value ? FKuroWpoFogCorrSetting.__PropertyMask_bOverride_WpoFogCorrYMin : 0));
			}
		}

		// Token: 0x17006EE4 RID: 28388
		// (get) Token: 0x0601B897 RID: 112791 RVA: 0x00288C8A File Offset: 0x00286E8A
		// (set) Token: 0x0601B898 RID: 112792 RVA: 0x00288C9A File Offset: 0x00286E9A
		public unsafe bool WpoFogCorrEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroWpoFogCorrSetting.__PropertyOffset_WpoFogCorrEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroWpoFogCorrSetting.__PropertyOffset_WpoFogCorrEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006EE5 RID: 28389
		// (get) Token: 0x0601B899 RID: 112793 RVA: 0x00288CAB File Offset: 0x00286EAB
		// (set) Token: 0x0601B89A RID: 112794 RVA: 0x00288CBB File Offset: 0x00286EBB
		public unsafe float WpoFogCorrX0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroWpoFogCorrSetting.__PropertyOffset_WpoFogCorrX0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroWpoFogCorrSetting.__PropertyOffset_WpoFogCorrX0) = value;
			}
		}

		// Token: 0x17006EE6 RID: 28390
		// (get) Token: 0x0601B89B RID: 112795 RVA: 0x00288CCC File Offset: 0x00286ECC
		// (set) Token: 0x0601B89C RID: 112796 RVA: 0x00288CDC File Offset: 0x00286EDC
		public unsafe float WpoFogCorrR
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroWpoFogCorrSetting.__PropertyOffset_WpoFogCorrR);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroWpoFogCorrSetting.__PropertyOffset_WpoFogCorrR) = value;
			}
		}

		// Token: 0x17006EE7 RID: 28391
		// (get) Token: 0x0601B89D RID: 112797 RVA: 0x00288CED File Offset: 0x00286EED
		// (set) Token: 0x0601B89E RID: 112798 RVA: 0x00288CFD File Offset: 0x00286EFD
		public unsafe float WpoFogCorrXMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroWpoFogCorrSetting.__PropertyOffset_WpoFogCorrXMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroWpoFogCorrSetting.__PropertyOffset_WpoFogCorrXMin) = value;
			}
		}

		// Token: 0x17006EE8 RID: 28392
		// (get) Token: 0x0601B89F RID: 112799 RVA: 0x00288D0E File Offset: 0x00286F0E
		// (set) Token: 0x0601B8A0 RID: 112800 RVA: 0x00288D1E File Offset: 0x00286F1E
		public unsafe float WpoFogCorrXMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroWpoFogCorrSetting.__PropertyOffset_WpoFogCorrXMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroWpoFogCorrSetting.__PropertyOffset_WpoFogCorrXMax) = value;
			}
		}

		// Token: 0x17006EE9 RID: 28393
		// (get) Token: 0x0601B8A1 RID: 112801 RVA: 0x00288D2F File Offset: 0x00286F2F
		// (set) Token: 0x0601B8A2 RID: 112802 RVA: 0x00288D3F File Offset: 0x00286F3F
		public unsafe float WpoFogCorrYMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroWpoFogCorrSetting.__PropertyOffset_WpoFogCorrYMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroWpoFogCorrSetting.__PropertyOffset_WpoFogCorrYMin) = value;
			}
		}

		// Token: 0x0601B8A3 RID: 112803 RVA: 0x00288D50 File Offset: 0x00286F50
		public FKuroWpoFogCorrSetting()
		{
		}

		// Token: 0x0601B8A4 RID: 112804 RVA: 0x00288D58 File Offset: 0x00286F58
		public FKuroWpoFogCorrSetting(bool bOverride_WpoFogCorrEnabled, bool bOverride_WpoFogCorrX0, bool bOverride_WpoFogCorrR, bool bOverride_WpoFogCorrXMin, bool bOverride_WpoFogCorrXMax, bool bOverride_WpoFogCorrYMin, bool WpoFogCorrEnabled, float WpoFogCorrX0, float WpoFogCorrR, float WpoFogCorrXMin, float WpoFogCorrXMax, float WpoFogCorrYMin)
		{
			this.bOverride_WpoFogCorrEnabled = bOverride_WpoFogCorrEnabled;
			this.bOverride_WpoFogCorrX0 = bOverride_WpoFogCorrX0;
			this.bOverride_WpoFogCorrR = bOverride_WpoFogCorrR;
			this.bOverride_WpoFogCorrXMin = bOverride_WpoFogCorrXMin;
			this.bOverride_WpoFogCorrXMax = bOverride_WpoFogCorrXMax;
			this.bOverride_WpoFogCorrYMin = bOverride_WpoFogCorrYMin;
			this.WpoFogCorrEnabled = WpoFogCorrEnabled;
			this.WpoFogCorrX0 = WpoFogCorrX0;
			this.WpoFogCorrR = WpoFogCorrR;
			this.WpoFogCorrXMin = WpoFogCorrXMin;
			this.WpoFogCorrXMax = WpoFogCorrXMax;
			this.WpoFogCorrYMin = WpoFogCorrYMin;
		}

		// Token: 0x0601B8A5 RID: 112805 RVA: 0x00288DC8 File Offset: 0x00286FC8
		protected override IntPtr GetUStructPtr()
		{
			return FKuroWpoFogCorrSetting.StaticStruct();
		}

		// Token: 0x0601B8A6 RID: 112806 RVA: 0x00288DD4 File Offset: 0x00286FD4
		[NullableContext(2)]
		public FKuroWpoFogCorrSetting(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601B8A7 RID: 112807 RVA: 0x00288DDE File Offset: 0x00286FDE
		public FKuroWpoFogCorrSetting(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601B8A8 RID: 112808 RVA: 0x00288DE9 File Offset: 0x00286FE9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroWpoFogCorrSetting(Pointer, false, true);
		}

		// Token: 0x0601B8A9 RID: 112809 RVA: 0x00288DF3 File Offset: 0x00286FF3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroWpoFogCorrSetting(Pointer, MemoryOwner);
		}

		// Token: 0x0400ED05 RID: 60677
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroWpoFogCorrSetting";

		// Token: 0x0400ED06 RID: 60678
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400ED07 RID: 60679
		internal static int __PropertyOffset_bOverride_WpoFogCorrEnabled;

		// Token: 0x0400ED08 RID: 60680
		internal static byte __PropertyMask_bOverride_WpoFogCorrEnabled;

		// Token: 0x0400ED09 RID: 60681
		internal static int __PropertyOffset_bOverride_WpoFogCorrX0;

		// Token: 0x0400ED0A RID: 60682
		internal static byte __PropertyMask_bOverride_WpoFogCorrX0;

		// Token: 0x0400ED0B RID: 60683
		internal static int __PropertyOffset_bOverride_WpoFogCorrR;

		// Token: 0x0400ED0C RID: 60684
		internal static byte __PropertyMask_bOverride_WpoFogCorrR;

		// Token: 0x0400ED0D RID: 60685
		internal static int __PropertyOffset_bOverride_WpoFogCorrXMin;

		// Token: 0x0400ED0E RID: 60686
		internal static byte __PropertyMask_bOverride_WpoFogCorrXMin;

		// Token: 0x0400ED0F RID: 60687
		internal static int __PropertyOffset_bOverride_WpoFogCorrXMax;

		// Token: 0x0400ED10 RID: 60688
		internal static byte __PropertyMask_bOverride_WpoFogCorrXMax;

		// Token: 0x0400ED11 RID: 60689
		internal static int __PropertyOffset_bOverride_WpoFogCorrYMin;

		// Token: 0x0400ED12 RID: 60690
		internal static byte __PropertyMask_bOverride_WpoFogCorrYMin;

		// Token: 0x0400ED13 RID: 60691
		internal static int __PropertyOffset_WpoFogCorrEnabled;

		// Token: 0x0400ED14 RID: 60692
		internal static int __PropertyOffset_WpoFogCorrX0;

		// Token: 0x0400ED15 RID: 60693
		internal static int __PropertyOffset_WpoFogCorrR;

		// Token: 0x0400ED16 RID: 60694
		internal static int __PropertyOffset_WpoFogCorrXMin;

		// Token: 0x0400ED17 RID: 60695
		internal static int __PropertyOffset_WpoFogCorrXMax;

		// Token: 0x0400ED18 RID: 60696
		internal static int __PropertyOffset_WpoFogCorrYMin;
	}
}
