using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200073E RID: 1854
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/CoreUObject.InterpCurveTwoVectors")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FInterpCurveTwoVectors : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006290 RID: 25232 RVA: 0x0008D6D8 File Offset: 0x0008B8D8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInterpCurveTwoVectors._ScriptStructPtr != 0) ? FInterpCurveTwoVectors._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.InterpCurveTwoVectors", ref FInterpCurveTwoVectors._ScriptStructPtr);
		}

		// Token: 0x17001793 RID: 6035
		// (get) Token: 0x06006291 RID: 25233 RVA: 0x0008D6FC File Offset: 0x0008B8FC
		// (set) Token: 0x06006292 RID: 25234 RVA: 0x0008D73F File Offset: 0x0008B93F
		public TArray<FInterpCurvePointTwoVectors> Points
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FInterpCurvePointTwoVectors> result;
				if ((result = this._Points) == null)
				{
					result = (this._Points = new TArray<FInterpCurvePointTwoVectors>(base.NativePtr + (IntPtr)FInterpCurveTwoVectors.__PropertyOffset_Points, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Points.CopyAssign(value);
			}
		}

		// Token: 0x17001794 RID: 6036
		// (get) Token: 0x06006293 RID: 25235 RVA: 0x0008D74D File Offset: 0x0008B94D
		// (set) Token: 0x06006294 RID: 25236 RVA: 0x0008D75D File Offset: 0x0008B95D
		public unsafe bool bIsLooped
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInterpCurveTwoVectors.__PropertyOffset_bIsLooped) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInterpCurveTwoVectors.__PropertyOffset_bIsLooped) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001795 RID: 6037
		// (get) Token: 0x06006295 RID: 25237 RVA: 0x0008D76E File Offset: 0x0008B96E
		// (set) Token: 0x06006296 RID: 25238 RVA: 0x0008D77E File Offset: 0x0008B97E
		public unsafe float LoopKeyOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInterpCurveTwoVectors.__PropertyOffset_LoopKeyOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInterpCurveTwoVectors.__PropertyOffset_LoopKeyOffset) = value;
			}
		}

		// Token: 0x06006297 RID: 25239 RVA: 0x0008D78F File Offset: 0x0008B98F
		public FInterpCurveTwoVectors()
		{
		}

		// Token: 0x06006298 RID: 25240 RVA: 0x0008D797 File Offset: 0x0008B997
		public FInterpCurveTwoVectors(TArray<FInterpCurvePointTwoVectors> Points, bool bIsLooped, float LoopKeyOffset)
		{
			this.Points = Points;
			this.bIsLooped = bIsLooped;
			this.LoopKeyOffset = LoopKeyOffset;
		}

		// Token: 0x06006299 RID: 25241 RVA: 0x0008D7B4 File Offset: 0x0008B9B4
		protected override IntPtr GetUStructPtr()
		{
			return FInterpCurveTwoVectors.StaticStruct();
		}

		// Token: 0x0600629A RID: 25242 RVA: 0x0008D7C0 File Offset: 0x0008B9C0
		[NullableContext(2)]
		public FInterpCurveTwoVectors(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600629B RID: 25243 RVA: 0x0008D7CA File Offset: 0x0008B9CA
		public FInterpCurveTwoVectors(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600629C RID: 25244 RVA: 0x0008D7D5 File Offset: 0x0008B9D5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FInterpCurveTwoVectors(Pointer, false, true);
		}

		// Token: 0x0600629D RID: 25245 RVA: 0x0008D7DF File Offset: 0x0008B9DF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FInterpCurveTwoVectors(Pointer, MemoryOwner);
		}

		// Token: 0x04002F22 RID: 12066
		public const string __ObjectPath = "/Script/CoreUObject.InterpCurveTwoVectors";

		// Token: 0x04002F23 RID: 12067
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002F24 RID: 12068
		internal static int __PropertyOffset_Points;

		// Token: 0x04002F25 RID: 12069
		[Nullable(2)]
		private TArray<FInterpCurvePointTwoVectors> _Points;

		// Token: 0x04002F26 RID: 12070
		internal static int __PropertyOffset_bIsLooped;

		// Token: 0x04002F27 RID: 12071
		internal static int __PropertyOffset_LoopKeyOffset;
	}
}
