using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002740 RID: 10048
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/SharpherealTest.SharpherealTestStruct_FixedArray")]
	[UnrealStructLayout(96, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FSharpherealTestStruct_FixedArray : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060253A6 RID: 152486 RVA: 0x00373298 File Offset: 0x00371498
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSharpherealTestStruct_FixedArray._ScriptStructPtr != 0) ? FSharpherealTestStruct_FixedArray._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SharpherealTest.SharpherealTestStruct_FixedArray", ref FSharpherealTestStruct_FixedArray._ScriptStructPtr);
		}

		// Token: 0x17008FBC RID: 36796
		// (get) Token: 0x060253A7 RID: 152487 RVA: 0x003732BC File Offset: 0x003714BC
		// (set) Token: 0x060253A8 RID: 152488 RVA: 0x003732D0 File Offset: 0x003714D0
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

		// Token: 0x17008FBD RID: 36797
		// (get) Token: 0x060253A9 RID: 152489 RVA: 0x003732E8 File Offset: 0x003714E8
		// (set) Token: 0x060253AA RID: 152490 RVA: 0x0037332C File Offset: 0x0037152C
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

		// Token: 0x17008FBE RID: 36798
		// (get) Token: 0x060253AB RID: 152491 RVA: 0x0037333A File Offset: 0x0037153A
		// (set) Token: 0x060253AC RID: 152492 RVA: 0x0037334E File Offset: 0x0037154E
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

		// Token: 0x17008FBF RID: 36799
		// (get) Token: 0x060253AD RID: 152493 RVA: 0x00373364 File Offset: 0x00371564
		// (set) Token: 0x060253AE RID: 152494 RVA: 0x003733A8 File Offset: 0x003715A8
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

		// Token: 0x060253AF RID: 152495 RVA: 0x003733B6 File Offset: 0x003715B6
		public FSharpherealTestStruct_FixedArray()
		{
		}

		// Token: 0x060253B0 RID: 152496 RVA: 0x003733BE File Offset: 0x003715BE
		public FSharpherealTestStruct_FixedArray(FVector V, TFixedArray<FQuat> Q, string S, TFixedArray<UObject> O)
		{
			this.V = V;
			this.Q = Q;
			this.S = S;
			this.O = O;
		}

		// Token: 0x060253B1 RID: 152497 RVA: 0x003733E3 File Offset: 0x003715E3
		protected override IntPtr GetUStructPtr()
		{
			return FSharpherealTestStruct_FixedArray.StaticStruct();
		}

		// Token: 0x060253B2 RID: 152498 RVA: 0x003733EF File Offset: 0x003715EF
		[NullableContext(2)]
		public FSharpherealTestStruct_FixedArray(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060253B3 RID: 152499 RVA: 0x003733F9 File Offset: 0x003715F9
		public FSharpherealTestStruct_FixedArray(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060253B4 RID: 152500 RVA: 0x00373404 File Offset: 0x00371604
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSharpherealTestStruct_FixedArray(Pointer, false, true);
		}

		// Token: 0x060253B5 RID: 152501 RVA: 0x0037340E File Offset: 0x0037160E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSharpherealTestStruct_FixedArray(Pointer, MemoryOwner);
		}

		// Token: 0x0401413F RID: 82239
		public const string __ObjectPath = "/Script/SharpherealTest.SharpherealTestStruct_FixedArray";

		// Token: 0x04014140 RID: 82240
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014141 RID: 82241
		internal static int __PropertyOffset_V;

		// Token: 0x04014142 RID: 82242
		internal static int __PropertyOffset_Q;

		// Token: 0x04014143 RID: 82243
		[Nullable(2)]
		private TFixedArray<FQuat> _Q;

		// Token: 0x04014144 RID: 82244
		internal static int __PropertyOffset_S;

		// Token: 0x04014145 RID: 82245
		internal static int __PropertyOffset_O;

		// Token: 0x04014146 RID: 82246
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<UObject> _O;
	}
}
