using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000736 RID: 1846
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/CoreUObject.InterpCurveLinearColor")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FInterpCurveLinearColor : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600623F RID: 25151 RVA: 0x0008CDEC File Offset: 0x0008AFEC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInterpCurveLinearColor._ScriptStructPtr != 0) ? FInterpCurveLinearColor._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.InterpCurveLinearColor", ref FInterpCurveLinearColor._ScriptStructPtr);
		}

		// Token: 0x17001788 RID: 6024
		// (get) Token: 0x06006240 RID: 25152 RVA: 0x0008CE10 File Offset: 0x0008B010
		// (set) Token: 0x06006241 RID: 25153 RVA: 0x0008CE53 File Offset: 0x0008B053
		public TArray<FInterpCurvePointLinearColor> Points
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FInterpCurvePointLinearColor> result;
				if ((result = this._Points) == null)
				{
					result = (this._Points = new TArray<FInterpCurvePointLinearColor>(base.NativePtr + (IntPtr)FInterpCurveLinearColor.__PropertyOffset_Points, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Points.CopyAssign(value);
			}
		}

		// Token: 0x17001789 RID: 6025
		// (get) Token: 0x06006242 RID: 25154 RVA: 0x0008CE61 File Offset: 0x0008B061
		// (set) Token: 0x06006243 RID: 25155 RVA: 0x0008CE71 File Offset: 0x0008B071
		public unsafe bool bIsLooped
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInterpCurveLinearColor.__PropertyOffset_bIsLooped) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInterpCurveLinearColor.__PropertyOffset_bIsLooped) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700178A RID: 6026
		// (get) Token: 0x06006244 RID: 25156 RVA: 0x0008CE82 File Offset: 0x0008B082
		// (set) Token: 0x06006245 RID: 25157 RVA: 0x0008CE92 File Offset: 0x0008B092
		public unsafe float LoopKeyOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInterpCurveLinearColor.__PropertyOffset_LoopKeyOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInterpCurveLinearColor.__PropertyOffset_LoopKeyOffset) = value;
			}
		}

		// Token: 0x06006246 RID: 25158 RVA: 0x0008CEA3 File Offset: 0x0008B0A3
		public FInterpCurveLinearColor()
		{
		}

		// Token: 0x06006247 RID: 25159 RVA: 0x0008CEAB File Offset: 0x0008B0AB
		public FInterpCurveLinearColor(TArray<FInterpCurvePointLinearColor> Points, bool bIsLooped, float LoopKeyOffset)
		{
			this.Points = Points;
			this.bIsLooped = bIsLooped;
			this.LoopKeyOffset = LoopKeyOffset;
		}

		// Token: 0x06006248 RID: 25160 RVA: 0x0008CEC8 File Offset: 0x0008B0C8
		protected override IntPtr GetUStructPtr()
		{
			return FInterpCurveLinearColor.StaticStruct();
		}

		// Token: 0x06006249 RID: 25161 RVA: 0x0008CED4 File Offset: 0x0008B0D4
		[NullableContext(2)]
		public FInterpCurveLinearColor(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600624A RID: 25162 RVA: 0x0008CEDE File Offset: 0x0008B0DE
		public FInterpCurveLinearColor(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600624B RID: 25163 RVA: 0x0008CEE9 File Offset: 0x0008B0E9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FInterpCurveLinearColor(Pointer, false, true);
		}

		// Token: 0x0600624C RID: 25164 RVA: 0x0008CEF3 File Offset: 0x0008B0F3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FInterpCurveLinearColor(Pointer, MemoryOwner);
		}

		// Token: 0x04002EEC RID: 12012
		public const string __ObjectPath = "/Script/CoreUObject.InterpCurveLinearColor";

		// Token: 0x04002EED RID: 12013
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002EEE RID: 12014
		internal static int __PropertyOffset_Points;

		// Token: 0x04002EEF RID: 12015
		[Nullable(2)]
		private TArray<FInterpCurvePointLinearColor> _Points;

		// Token: 0x04002EF0 RID: 12016
		internal static int __PropertyOffset_bIsLooped;

		// Token: 0x04002EF1 RID: 12017
		internal static int __PropertyOffset_LoopKeyOffset;
	}
}
