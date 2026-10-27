using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020016A7 RID: 5799
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAutomationTool.KuroTestExpectation")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FKuroTestExpectation : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06015059 RID: 86105 RVA: 0x001EE3A2 File Offset: 0x001EC5A2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroTestExpectation._ScriptStructPtr != 0) ? FKuroTestExpectation._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAutomationTool.KuroTestExpectation", ref FKuroTestExpectation._ScriptStructPtr);
		}

		// Token: 0x1700532D RID: 21293
		// (get) Token: 0x0601505A RID: 86106 RVA: 0x001EE3C6 File Offset: 0x001EC5C6
		// (set) Token: 0x0601505B RID: 86107 RVA: 0x001EE3DA File Offset: 0x001EC5DA
		public unsafe string Metrics
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroTestExpectation.__PropertyOffset_Metrics)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroTestExpectation.__PropertyOffset_Metrics)), value);
			}
		}

		// Token: 0x1700532E RID: 21294
		// (get) Token: 0x0601505C RID: 86108 RVA: 0x001EE3EF File Offset: 0x001EC5EF
		// (set) Token: 0x0601505D RID: 86109 RVA: 0x001EE403 File Offset: 0x001EC603
		public unsafe string Compare
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroTestExpectation.__PropertyOffset_Compare)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroTestExpectation.__PropertyOffset_Compare)), value);
			}
		}

		// Token: 0x1700532F RID: 21295
		// (get) Token: 0x0601505E RID: 86110 RVA: 0x001EE418 File Offset: 0x001EC618
		// (set) Token: 0x0601505F RID: 86111 RVA: 0x001EE428 File Offset: 0x001EC628
		public unsafe int Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroTestExpectation.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroTestExpectation.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x06015060 RID: 86112 RVA: 0x001EE439 File Offset: 0x001EC639
		public FKuroTestExpectation()
		{
		}

		// Token: 0x06015061 RID: 86113 RVA: 0x001EE441 File Offset: 0x001EC641
		public FKuroTestExpectation(string Metrics, string Compare, int Value)
		{
			this.Metrics = Metrics;
			this.Compare = Compare;
			this.Value = Value;
		}

		// Token: 0x06015062 RID: 86114 RVA: 0x001EE45E File Offset: 0x001EC65E
		protected override IntPtr GetUStructPtr()
		{
			return FKuroTestExpectation.StaticStruct();
		}

		// Token: 0x06015063 RID: 86115 RVA: 0x001EE46A File Offset: 0x001EC66A
		[NullableContext(2)]
		public FKuroTestExpectation(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06015064 RID: 86116 RVA: 0x001EE474 File Offset: 0x001EC674
		public FKuroTestExpectation(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06015065 RID: 86117 RVA: 0x001EE47F File Offset: 0x001EC67F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroTestExpectation(Pointer, false, true);
		}

		// Token: 0x06015066 RID: 86118 RVA: 0x001EE489 File Offset: 0x001EC689
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroTestExpectation(Pointer, MemoryOwner);
		}

		// Token: 0x0400B71E RID: 46878
		public const string __ObjectPath = "/Script/KuroAutomationTool.KuroTestExpectation";

		// Token: 0x0400B71F RID: 46879
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B720 RID: 46880
		internal static int __PropertyOffset_Metrics;

		// Token: 0x0400B721 RID: 46881
		internal static int __PropertyOffset_Compare;

		// Token: 0x0400B722 RID: 46882
		internal static int __PropertyOffset_Value;
	}
}
