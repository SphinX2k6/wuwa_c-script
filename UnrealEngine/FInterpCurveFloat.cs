using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000735 RID: 1845
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/CoreUObject.InterpCurveFloat")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FInterpCurveFloat : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006231 RID: 25137 RVA: 0x0008CCDA File Offset: 0x0008AEDA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInterpCurveFloat._ScriptStructPtr != 0) ? FInterpCurveFloat._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.InterpCurveFloat", ref FInterpCurveFloat._ScriptStructPtr);
		}

		// Token: 0x17001785 RID: 6021
		// (get) Token: 0x06006232 RID: 25138 RVA: 0x0008CD00 File Offset: 0x0008AF00
		// (set) Token: 0x06006233 RID: 25139 RVA: 0x0008CD43 File Offset: 0x0008AF43
		public TArray<FInterpCurvePointFloat> Points
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FInterpCurvePointFloat> result;
				if ((result = this._Points) == null)
				{
					result = (this._Points = new TArray<FInterpCurvePointFloat>(base.NativePtr + (IntPtr)FInterpCurveFloat.__PropertyOffset_Points, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Points.CopyAssign(value);
			}
		}

		// Token: 0x17001786 RID: 6022
		// (get) Token: 0x06006234 RID: 25140 RVA: 0x0008CD51 File Offset: 0x0008AF51
		// (set) Token: 0x06006235 RID: 25141 RVA: 0x0008CD61 File Offset: 0x0008AF61
		public unsafe bool bIsLooped
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInterpCurveFloat.__PropertyOffset_bIsLooped) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInterpCurveFloat.__PropertyOffset_bIsLooped) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001787 RID: 6023
		// (get) Token: 0x06006236 RID: 25142 RVA: 0x0008CD72 File Offset: 0x0008AF72
		// (set) Token: 0x06006237 RID: 25143 RVA: 0x0008CD82 File Offset: 0x0008AF82
		public unsafe float LoopKeyOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInterpCurveFloat.__PropertyOffset_LoopKeyOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInterpCurveFloat.__PropertyOffset_LoopKeyOffset) = value;
			}
		}

		// Token: 0x06006238 RID: 25144 RVA: 0x0008CD93 File Offset: 0x0008AF93
		public FInterpCurveFloat()
		{
		}

		// Token: 0x06006239 RID: 25145 RVA: 0x0008CD9B File Offset: 0x0008AF9B
		public FInterpCurveFloat(TArray<FInterpCurvePointFloat> Points, bool bIsLooped, float LoopKeyOffset)
		{
			this.Points = Points;
			this.bIsLooped = bIsLooped;
			this.LoopKeyOffset = LoopKeyOffset;
		}

		// Token: 0x0600623A RID: 25146 RVA: 0x0008CDB8 File Offset: 0x0008AFB8
		protected override IntPtr GetUStructPtr()
		{
			return FInterpCurveFloat.StaticStruct();
		}

		// Token: 0x0600623B RID: 25147 RVA: 0x0008CDC4 File Offset: 0x0008AFC4
		[NullableContext(2)]
		public FInterpCurveFloat(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600623C RID: 25148 RVA: 0x0008CDCE File Offset: 0x0008AFCE
		public FInterpCurveFloat(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600623D RID: 25149 RVA: 0x0008CDD9 File Offset: 0x0008AFD9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FInterpCurveFloat(Pointer, false, true);
		}

		// Token: 0x0600623E RID: 25150 RVA: 0x0008CDE3 File Offset: 0x0008AFE3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FInterpCurveFloat(Pointer, MemoryOwner);
		}

		// Token: 0x04002EE6 RID: 12006
		public const string __ObjectPath = "/Script/CoreUObject.InterpCurveFloat";

		// Token: 0x04002EE7 RID: 12007
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002EE8 RID: 12008
		internal static int __PropertyOffset_Points;

		// Token: 0x04002EE9 RID: 12009
		[Nullable(2)]
		private TArray<FInterpCurvePointFloat> _Points;

		// Token: 0x04002EEA RID: 12010
		internal static int __PropertyOffset_bIsLooped;

		// Token: 0x04002EEB RID: 12011
		internal static int __PropertyOffset_LoopKeyOffset;
	}
}
