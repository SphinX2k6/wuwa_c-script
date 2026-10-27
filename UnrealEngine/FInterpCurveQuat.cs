using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200073D RID: 1853
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/CoreUObject.InterpCurveQuat")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FInterpCurveQuat : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006282 RID: 25218 RVA: 0x0008D5C6 File Offset: 0x0008B7C6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInterpCurveQuat._ScriptStructPtr != 0) ? FInterpCurveQuat._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.InterpCurveQuat", ref FInterpCurveQuat._ScriptStructPtr);
		}

		// Token: 0x17001790 RID: 6032
		// (get) Token: 0x06006283 RID: 25219 RVA: 0x0008D5EC File Offset: 0x0008B7EC
		// (set) Token: 0x06006284 RID: 25220 RVA: 0x0008D62F File Offset: 0x0008B82F
		public TArray<FInterpCurvePointQuat> Points
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FInterpCurvePointQuat> result;
				if ((result = this._Points) == null)
				{
					result = (this._Points = new TArray<FInterpCurvePointQuat>(base.NativePtr + (IntPtr)FInterpCurveQuat.__PropertyOffset_Points, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Points.CopyAssign(value);
			}
		}

		// Token: 0x17001791 RID: 6033
		// (get) Token: 0x06006285 RID: 25221 RVA: 0x0008D63D File Offset: 0x0008B83D
		// (set) Token: 0x06006286 RID: 25222 RVA: 0x0008D64D File Offset: 0x0008B84D
		public unsafe bool bIsLooped
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInterpCurveQuat.__PropertyOffset_bIsLooped) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInterpCurveQuat.__PropertyOffset_bIsLooped) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001792 RID: 6034
		// (get) Token: 0x06006287 RID: 25223 RVA: 0x0008D65E File Offset: 0x0008B85E
		// (set) Token: 0x06006288 RID: 25224 RVA: 0x0008D66E File Offset: 0x0008B86E
		public unsafe float LoopKeyOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInterpCurveQuat.__PropertyOffset_LoopKeyOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInterpCurveQuat.__PropertyOffset_LoopKeyOffset) = value;
			}
		}

		// Token: 0x06006289 RID: 25225 RVA: 0x0008D67F File Offset: 0x0008B87F
		public FInterpCurveQuat()
		{
		}

		// Token: 0x0600628A RID: 25226 RVA: 0x0008D687 File Offset: 0x0008B887
		public FInterpCurveQuat(TArray<FInterpCurvePointQuat> Points, bool bIsLooped, float LoopKeyOffset)
		{
			this.Points = Points;
			this.bIsLooped = bIsLooped;
			this.LoopKeyOffset = LoopKeyOffset;
		}

		// Token: 0x0600628B RID: 25227 RVA: 0x0008D6A4 File Offset: 0x0008B8A4
		protected override IntPtr GetUStructPtr()
		{
			return FInterpCurveQuat.StaticStruct();
		}

		// Token: 0x0600628C RID: 25228 RVA: 0x0008D6B0 File Offset: 0x0008B8B0
		[NullableContext(2)]
		public FInterpCurveQuat(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600628D RID: 25229 RVA: 0x0008D6BA File Offset: 0x0008B8BA
		public FInterpCurveQuat(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600628E RID: 25230 RVA: 0x0008D6C5 File Offset: 0x0008B8C5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FInterpCurveQuat(Pointer, false, true);
		}

		// Token: 0x0600628F RID: 25231 RVA: 0x0008D6CF File Offset: 0x0008B8CF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FInterpCurveQuat(Pointer, MemoryOwner);
		}

		// Token: 0x04002F1C RID: 12060
		public const string __ObjectPath = "/Script/CoreUObject.InterpCurveQuat";

		// Token: 0x04002F1D RID: 12061
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002F1E RID: 12062
		internal static int __PropertyOffset_Points;

		// Token: 0x04002F1F RID: 12063
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FInterpCurvePointQuat> _Points;

		// Token: 0x04002F20 RID: 12064
		internal static int __PropertyOffset_bIsLooped;

		// Token: 0x04002F21 RID: 12065
		internal static int __PropertyOffset_LoopKeyOffset;
	}
}
