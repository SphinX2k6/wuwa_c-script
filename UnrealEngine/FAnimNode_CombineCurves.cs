using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001606 RID: 5638
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.AnimNode_CombineCurves")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FAnimNode_CombineCurves : FAnimNode_Base, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601452A RID: 83242 RVA: 0x001DDB45 File Offset: 0x001DBD45
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_CombineCurves._ScriptStructPtr != 0) ? FAnimNode_CombineCurves._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.AnimNode_CombineCurves", ref FAnimNode_CombineCurves._ScriptStructPtr);
		}

		// Token: 0x17004FBF RID: 20415
		// (get) Token: 0x0601452B RID: 83243 RVA: 0x001DDB6C File Offset: 0x001DBD6C
		// (set) Token: 0x0601452C RID: 83244 RVA: 0x001DDBAF File Offset: 0x001DBDAF
		public FPoseLink Base
		{
			get
			{
				base.FastCheckIsValid();
				FPoseLink result;
				if ((result = this._Base) == null)
				{
					result = (this._Base = new FPoseLink(base.NativePtr + (IntPtr)FAnimNode_CombineCurves.__PropertyOffset_Base, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_CombineCurves.__PropertyOffset_Base, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004FC0 RID: 20416
		// (get) Token: 0x0601452D RID: 83245 RVA: 0x001DDBD0 File Offset: 0x001DBDD0
		// (set) Token: 0x0601452E RID: 83246 RVA: 0x001DDC13 File Offset: 0x001DBE13
		public FPoseLink CurveAnim
		{
			get
			{
				base.FastCheckIsValid();
				FPoseLink result;
				if ((result = this._CurveAnim) == null)
				{
					result = (this._CurveAnim = new FPoseLink(base.NativePtr + (IntPtr)FAnimNode_CombineCurves.__PropertyOffset_CurveAnim, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_CombineCurves.__PropertyOffset_CurveAnim, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004FC1 RID: 20417
		// (get) Token: 0x0601452F RID: 83247 RVA: 0x001DDC34 File Offset: 0x001DBE34
		// (set) Token: 0x06014530 RID: 83248 RVA: 0x001DDC44 File Offset: 0x001DBE44
		public unsafe ECombineCurveMode CombineMode
		{
			get
			{
				return (ECombineCurveMode)(*(base.NativePtr + (IntPtr)FAnimNode_CombineCurves.__PropertyOffset_CombineMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_CombineCurves.__PropertyOffset_CombineMode) = (byte)value;
			}
		}

		// Token: 0x17004FC2 RID: 20418
		// (get) Token: 0x06014531 RID: 83249 RVA: 0x001DDC55 File Offset: 0x001DBE55
		// (set) Token: 0x06014532 RID: 83250 RVA: 0x001DDC65 File Offset: 0x001DBE65
		public unsafe float Alpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_CombineCurves.__PropertyOffset_Alpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_CombineCurves.__PropertyOffset_Alpha) = value;
			}
		}

		// Token: 0x17004FC3 RID: 20419
		// (get) Token: 0x06014533 RID: 83251 RVA: 0x001DDC76 File Offset: 0x001DBE76
		// (set) Token: 0x06014534 RID: 83252 RVA: 0x001DDC8A File Offset: 0x001DBE8A
		public unsafe FName CleanAlphaCurveName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_CombineCurves.__PropertyOffset_CleanAlphaCurveName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_CombineCurves.__PropertyOffset_CleanAlphaCurveName) = value;
			}
		}

		// Token: 0x17004FC4 RID: 20420
		// (get) Token: 0x06014535 RID: 83253 RVA: 0x001DDCA0 File Offset: 0x001DBEA0
		// (set) Token: 0x06014536 RID: 83254 RVA: 0x001DDCE3 File Offset: 0x001DBEE3
		public TArray<FName> CleanCurves
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._CleanCurves) == null)
				{
					result = (this._CleanCurves = new TArray<FName>(base.NativePtr + (IntPtr)FAnimNode_CombineCurves.__PropertyOffset_CleanCurves, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CleanCurves.CopyAssign(value);
			}
		}

		// Token: 0x06014537 RID: 83255 RVA: 0x001DDCF1 File Offset: 0x001DBEF1
		public FAnimNode_CombineCurves()
		{
		}

		// Token: 0x06014538 RID: 83256 RVA: 0x001DDCF9 File Offset: 0x001DBEF9
		public FAnimNode_CombineCurves(FPoseLink Base, FPoseLink CurveAnim, ECombineCurveMode CombineMode, float Alpha, FName CleanAlphaCurveName, TArray<FName> CleanCurves)
		{
			this.Base = Base;
			this.CurveAnim = CurveAnim;
			this.CombineMode = CombineMode;
			this.Alpha = Alpha;
			this.CleanAlphaCurveName = CleanAlphaCurveName;
			this.CleanCurves = CleanCurves;
		}

		// Token: 0x06014539 RID: 83257 RVA: 0x001DDD2E File Offset: 0x001DBF2E
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_CombineCurves.StaticStruct();
		}

		// Token: 0x0601453A RID: 83258 RVA: 0x001DDD3A File Offset: 0x001DBF3A
		[NullableContext(2)]
		public FAnimNode_CombineCurves(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601453B RID: 83259 RVA: 0x001DDD44 File Offset: 0x001DBF44
		public FAnimNode_CombineCurves(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601453C RID: 83260 RVA: 0x001DDD4F File Offset: 0x001DBF4F
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_CombineCurves(Pointer, false, true);
		}

		// Token: 0x0601453D RID: 83261 RVA: 0x001DDD59 File Offset: 0x001DBF59
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_CombineCurves(Pointer, MemoryOwner);
		}

		// Token: 0x0400B0F1 RID: 45297
		public new const string __ObjectPath = "/Script/KuroAnim.AnimNode_CombineCurves";

		// Token: 0x0400B0F2 RID: 45298
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B0F3 RID: 45299
		internal static int __PropertyOffset_Base;

		// Token: 0x0400B0F4 RID: 45300
		[Nullable(2)]
		private FPoseLink _Base;

		// Token: 0x0400B0F5 RID: 45301
		internal static int __PropertyOffset_CurveAnim;

		// Token: 0x0400B0F6 RID: 45302
		[Nullable(2)]
		private FPoseLink _CurveAnim;

		// Token: 0x0400B0F7 RID: 45303
		internal static int __PropertyOffset_CombineMode;

		// Token: 0x0400B0F8 RID: 45304
		internal static int __PropertyOffset_Alpha;

		// Token: 0x0400B0F9 RID: 45305
		internal static int __PropertyOffset_CleanAlphaCurveName;

		// Token: 0x0400B0FA RID: 45306
		internal static int __PropertyOffset_CleanCurves;

		// Token: 0x0400B0FB RID: 45307
		[Nullable(2)]
		private TArray<FName> _CleanCurves;
	}
}
