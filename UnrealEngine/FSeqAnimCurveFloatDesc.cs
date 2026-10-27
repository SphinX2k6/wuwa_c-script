using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200270B RID: 9995
	[UnrealObjectPath("/Script/SequenceDialogue.SeqAnimCurveFloatDesc")]
	[UnrealStructLayout(36, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 36)]
	public class FSeqAnimCurveFloatDesc : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060250F3 RID: 151795 RVA: 0x0036DA8C File Offset: 0x0036BC8C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSeqAnimCurveFloatDesc._ScriptStructPtr != 0) ? FSeqAnimCurveFloatDesc._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SequenceDialogue.SeqAnimCurveFloatDesc", ref FSeqAnimCurveFloatDesc._ScriptStructPtr);
		}

		// Token: 0x17008EFE RID: 36606
		// (get) Token: 0x060250F4 RID: 151796 RVA: 0x0036DAB0 File Offset: 0x0036BCB0
		// (set) Token: 0x060250F5 RID: 151797 RVA: 0x0036DAC4 File Offset: 0x0036BCC4
		public unsafe FName Group
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSeqAnimCurveFloatDesc.__PropertyOffset_Group);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSeqAnimCurveFloatDesc.__PropertyOffset_Group) = value;
			}
		}

		// Token: 0x17008EFF RID: 36607
		// (get) Token: 0x060250F6 RID: 151798 RVA: 0x0036DAD9 File Offset: 0x0036BCD9
		// (set) Token: 0x060250F7 RID: 151799 RVA: 0x0036DAED File Offset: 0x0036BCED
		public unsafe FName DisplayName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSeqAnimCurveFloatDesc.__PropertyOffset_DisplayName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSeqAnimCurveFloatDesc.__PropertyOffset_DisplayName) = value;
			}
		}

		// Token: 0x17008F00 RID: 36608
		// (get) Token: 0x060250F8 RID: 151800 RVA: 0x0036DB02 File Offset: 0x0036BD02
		// (set) Token: 0x060250F9 RID: 151801 RVA: 0x0036DB16 File Offset: 0x0036BD16
		public unsafe FName CurveName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSeqAnimCurveFloatDesc.__PropertyOffset_CurveName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSeqAnimCurveFloatDesc.__PropertyOffset_CurveName) = value;
			}
		}

		// Token: 0x060250FA RID: 151802 RVA: 0x0036DB2B File Offset: 0x0036BD2B
		public FSeqAnimCurveFloatDesc()
		{
		}

		// Token: 0x060250FB RID: 151803 RVA: 0x0036DB33 File Offset: 0x0036BD33
		public FSeqAnimCurveFloatDesc(FName Group, FName DisplayName, FName CurveName)
		{
			this.Group = Group;
			this.DisplayName = DisplayName;
			this.CurveName = CurveName;
		}

		// Token: 0x060250FC RID: 151804 RVA: 0x0036DB50 File Offset: 0x0036BD50
		protected override IntPtr GetUStructPtr()
		{
			return FSeqAnimCurveFloatDesc.StaticStruct();
		}

		// Token: 0x060250FD RID: 151805 RVA: 0x0036DB5C File Offset: 0x0036BD5C
		[NullableContext(2)]
		public FSeqAnimCurveFloatDesc(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060250FE RID: 151806 RVA: 0x0036DB66 File Offset: 0x0036BD66
		public FSeqAnimCurveFloatDesc(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060250FF RID: 151807 RVA: 0x0036DB71 File Offset: 0x0036BD71
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSeqAnimCurveFloatDesc(Pointer, false, true);
		}

		// Token: 0x06025100 RID: 151808 RVA: 0x0036DB7B File Offset: 0x0036BD7B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSeqAnimCurveFloatDesc(Pointer, MemoryOwner);
		}

		// Token: 0x04013F6E RID: 81774
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SequenceDialogue.SeqAnimCurveFloatDesc";

		// Token: 0x04013F6F RID: 81775
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013F70 RID: 81776
		internal static int __PropertyOffset_Group;

		// Token: 0x04013F71 RID: 81777
		internal static int __PropertyOffset_DisplayName;

		// Token: 0x04013F72 RID: 81778
		internal static int __PropertyOffset_CurveName;
	}
}
