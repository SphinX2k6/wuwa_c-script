using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020011FF RID: 4607
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.TransformCurve")]
	[UnrealStructLayout(1344, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1344)]
	public class FTransformCurve : FAnimCurveBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010FC2 RID: 69570 RVA: 0x0018ECFC File Offset: 0x0018CEFC
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTransformCurve._ScriptStructPtr != 0) ? FTransformCurve._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.TransformCurve", ref FTransformCurve._ScriptStructPtr);
		}

		// Token: 0x1700425E RID: 16990
		// (get) Token: 0x06010FC3 RID: 69571 RVA: 0x0018ED20 File Offset: 0x0018CF20
		// (set) Token: 0x06010FC4 RID: 69572 RVA: 0x0018ED63 File Offset: 0x0018CF63
		public FVectorCurve TranslationCurve
		{
			get
			{
				base.FastCheckIsValid();
				FVectorCurve result;
				if ((result = this._TranslationCurve) == null)
				{
					result = (this._TranslationCurve = new FVectorCurve(base.NativePtr + (IntPtr)FTransformCurve.__PropertyOffset_TranslationCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FVectorCurve.StaticStruct(), base.NativePtr + (IntPtr)FTransformCurve.__PropertyOffset_TranslationCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700425F RID: 16991
		// (get) Token: 0x06010FC5 RID: 69573 RVA: 0x0018ED84 File Offset: 0x0018CF84
		// (set) Token: 0x06010FC6 RID: 69574 RVA: 0x0018EDC7 File Offset: 0x0018CFC7
		public FVectorCurve RotationCurve
		{
			get
			{
				base.FastCheckIsValid();
				FVectorCurve result;
				if ((result = this._RotationCurve) == null)
				{
					result = (this._RotationCurve = new FVectorCurve(base.NativePtr + (IntPtr)FTransformCurve.__PropertyOffset_RotationCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FVectorCurve.StaticStruct(), base.NativePtr + (IntPtr)FTransformCurve.__PropertyOffset_RotationCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004260 RID: 16992
		// (get) Token: 0x06010FC7 RID: 69575 RVA: 0x0018EDE8 File Offset: 0x0018CFE8
		// (set) Token: 0x06010FC8 RID: 69576 RVA: 0x0018EE2B File Offset: 0x0018D02B
		public FVectorCurve ScaleCurve
		{
			get
			{
				base.FastCheckIsValid();
				FVectorCurve result;
				if ((result = this._ScaleCurve) == null)
				{
					result = (this._ScaleCurve = new FVectorCurve(base.NativePtr + (IntPtr)FTransformCurve.__PropertyOffset_ScaleCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FVectorCurve.StaticStruct(), base.NativePtr + (IntPtr)FTransformCurve.__PropertyOffset_ScaleCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06010FC9 RID: 69577 RVA: 0x0018EE4C File Offset: 0x0018D04C
		public FTransformCurve()
		{
		}

		// Token: 0x06010FCA RID: 69578 RVA: 0x0018EE54 File Offset: 0x0018D054
		public FTransformCurve(FVectorCurve TranslationCurve, FVectorCurve RotationCurve, FVectorCurve ScaleCurve, FName LastObservedName_DEPRECATED, FSmartName Name, FLinearColor Color, int CurveTypeFlags)
		{
			this.TranslationCurve = TranslationCurve;
			this.RotationCurve = RotationCurve;
			this.ScaleCurve = ScaleCurve;
			base.LastObservedName_DEPRECATED = LastObservedName_DEPRECATED;
			base.Name = Name;
			base.CurveTypeFlags = CurveTypeFlags;
		}

		// Token: 0x06010FCB RID: 69579 RVA: 0x0018EE89 File Offset: 0x0018D089
		protected override IntPtr GetUStructPtr()
		{
			return FTransformCurve.StaticStruct();
		}

		// Token: 0x06010FCC RID: 69580 RVA: 0x0018EE95 File Offset: 0x0018D095
		[NullableContext(2)]
		public FTransformCurve(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010FCD RID: 69581 RVA: 0x0018EE9F File Offset: 0x0018D09F
		public FTransformCurve(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010FCE RID: 69582 RVA: 0x0018EEAA File Offset: 0x0018D0AA
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTransformCurve(Pointer, false, true);
		}

		// Token: 0x06010FCF RID: 69583 RVA: 0x0018EEB4 File Offset: 0x0018D0B4
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTransformCurve(Pointer, MemoryOwner);
		}

		// Token: 0x04009184 RID: 37252
		public new const string __ObjectPath = "/Script/Engine.TransformCurve";

		// Token: 0x04009185 RID: 37253
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009186 RID: 37254
		internal static int __PropertyOffset_TranslationCurve;

		// Token: 0x04009187 RID: 37255
		[Nullable(2)]
		private FVectorCurve _TranslationCurve;

		// Token: 0x04009188 RID: 37256
		internal static int __PropertyOffset_RotationCurve;

		// Token: 0x04009189 RID: 37257
		[Nullable(2)]
		private FVectorCurve _RotationCurve;

		// Token: 0x0400918A RID: 37258
		internal static int __PropertyOffset_ScaleCurve;

		// Token: 0x0400918B RID: 37259
		[Nullable(2)]
		private FVectorCurve _ScaleCurve;
	}
}
