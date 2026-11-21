using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020007F4 RID: 2036
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/SharpherealTest.SharpherealTestStruct_FixedArray")]
	[UnrealStructLayout(96, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FSharpherealTestStruct_FixedArray : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600AE89 RID: 44681 RVA: 0x00102F6D File Offset: 0x0010116D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSharpherealTestStruct_FixedArray._ScriptStructPtr != 0) ? FSharpherealTestStruct_FixedArray._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SharpherealTest.SharpherealTestStruct_FixedArray", ref FSharpherealTestStruct_FixedArray._ScriptStructPtr);
		}

		// Token: 0x170020A4 RID: 8356
		// (get) Token: 0x0600AE8A RID: 44682 RVA: 0x00102F91 File Offset: 0x00101191
		// (set) Token: 0x0600AE8B RID: 44683 RVA: 0x00102FA5 File Offset: 0x001011A5
		public unsafe FVector V
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSharpherealTestStruct_FixedArray.__PropertyOffset_V);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSharpherealTestStruct_FixedArray.__PropertyOffset_V) = value;
			}
		}

		// Token: 0x170020A5 RID: 8357
		// (get) Token: 0x0600AE8C RID: 44684 RVA: 0x00102FBC File Offset: 0x001011BC
		// (set) Token: 0x0600AE8D RID: 44685 RVA: 0x00103000 File Offset: 0x00101200
		public TFixedArray<FQuat> Q
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<FQuat> result;
				if ((result = this._Q) == null)
				{
					result = (this._Q = new TFixedArray<FQuat>(base.NativePtr + (IntPtr)FSharpherealTestStruct_FixedArray.__PropertyOffset_Q, 2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Q.CopyAssign(value);
			}
		}

		// Token: 0x170020A6 RID: 8358
		// (get) Token: 0x0600AE8E RID: 44686 RVA: 0x0010300E File Offset: 0x0010120E
		// (set) Token: 0x0600AE8F RID: 44687 RVA: 0x00103022 File Offset: 0x00101222
		public unsafe string S
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FSharpherealTestStruct_FixedArray.__PropertyOffset_S)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FSharpherealTestStruct_FixedArray.__PropertyOffset_S)), value);
			}
		}

		// Token: 0x170020A7 RID: 8359
		// (get) Token: 0x0600AE90 RID: 44688 RVA: 0x00103038 File Offset: 0x00101238
		// (set) Token: 0x0600AE91 RID: 44689 RVA: 0x0010307C File Offset: 0x0010127C
		public TFixedArray<UObject> O
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<UObject> result;
				if ((result = this._O) == null)
				{
					result = (this._O = new TFixedArray<UObject>(base.NativePtr + (IntPtr)FSharpherealTestStruct_FixedArray.__PropertyOffset_O, 3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.O.CopyAssign(value);
			}
		}

		// Token: 0x0600AE92 RID: 44690 RVA: 0x0010308A File Offset: 0x0010128A
		public FSharpherealTestStruct_FixedArray()
		{
		}

		// Token: 0x0600AE93 RID: 44691 RVA: 0x00103092 File Offset: 0x00101292
		protected override IntPtr GetUStructPtr()
		{
			return FSharpherealTestStruct_FixedArray.StaticStruct();
		}

		// Token: 0x0600AE94 RID: 44692 RVA: 0x0010309E File Offset: 0x0010129E
		[NullableContext(2)]
		public FSharpherealTestStruct_FixedArray(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600AE95 RID: 44693 RVA: 0x001030A8 File Offset: 0x001012A8
		public FSharpherealTestStruct_FixedArray(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600AE96 RID: 44694 RVA: 0x001030B3 File Offset: 0x001012B3
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSharpherealTestStruct_FixedArray(Pointer, false, true);
		}

		// Token: 0x0600AE97 RID: 44695 RVA: 0x001030BD File Offset: 0x001012BD
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSharpherealTestStruct_FixedArray(Pointer, MemoryOwner);
		}

		// Token: 0x04004B9E RID: 19358
		public const string __ObjectPath = "/Script/SharpherealTest.SharpherealTestStruct_FixedArray";

		// Token: 0x04004B9F RID: 19359
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004BA0 RID: 19360
		internal static int __PropertyOffset_V;

		// Token: 0x04004BA1 RID: 19361
		internal static int __PropertyOffset_Q;

		// Token: 0x04004BA2 RID: 19362
		[Nullable(2)]
		private TFixedArray<FQuat> _Q;

		// Token: 0x04004BA3 RID: 19363
		internal static int __PropertyOffset_S;

		// Token: 0x04004BA4 RID: 19364
		internal static int __PropertyOffset_O;

		// Token: 0x04004BA5 RID: 19365
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<UObject> _O;
	}
}
