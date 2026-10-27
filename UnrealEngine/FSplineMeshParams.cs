using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200117D RID: 4477
	[UnrealObjectPath("/Script/Engine.SplineMeshParams")]
	[UnrealStructLayout(88, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FSplineMeshParams : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601072E RID: 67374 RVA: 0x0018280C File Offset: 0x00180A0C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSplineMeshParams._ScriptStructPtr != 0) ? FSplineMeshParams._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SplineMeshParams", ref FSplineMeshParams._ScriptStructPtr);
		}

		// Token: 0x1700401D RID: 16413
		// (get) Token: 0x0601072F RID: 67375 RVA: 0x00182830 File Offset: 0x00180A30
		// (set) Token: 0x06010730 RID: 67376 RVA: 0x00182844 File Offset: 0x00180A44
		public unsafe FVector StartPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSplineMeshParams.__PropertyOffset_StartPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSplineMeshParams.__PropertyOffset_StartPos) = value;
			}
		}

		// Token: 0x1700401E RID: 16414
		// (get) Token: 0x06010731 RID: 67377 RVA: 0x00182859 File Offset: 0x00180A59
		// (set) Token: 0x06010732 RID: 67378 RVA: 0x0018286D File Offset: 0x00180A6D
		public unsafe FVector StartTangent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSplineMeshParams.__PropertyOffset_StartTangent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSplineMeshParams.__PropertyOffset_StartTangent) = value;
			}
		}

		// Token: 0x1700401F RID: 16415
		// (get) Token: 0x06010733 RID: 67379 RVA: 0x00182882 File Offset: 0x00180A82
		// (set) Token: 0x06010734 RID: 67380 RVA: 0x00182896 File Offset: 0x00180A96
		public unsafe FVector2D StartScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSplineMeshParams.__PropertyOffset_StartScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSplineMeshParams.__PropertyOffset_StartScale) = value;
			}
		}

		// Token: 0x17004020 RID: 16416
		// (get) Token: 0x06010735 RID: 67381 RVA: 0x001828AB File Offset: 0x00180AAB
		// (set) Token: 0x06010736 RID: 67382 RVA: 0x001828BB File Offset: 0x00180ABB
		public unsafe float StartRoll
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSplineMeshParams.__PropertyOffset_StartRoll);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSplineMeshParams.__PropertyOffset_StartRoll) = value;
			}
		}

		// Token: 0x17004021 RID: 16417
		// (get) Token: 0x06010737 RID: 67383 RVA: 0x001828CC File Offset: 0x00180ACC
		// (set) Token: 0x06010738 RID: 67384 RVA: 0x001828E0 File Offset: 0x00180AE0
		public unsafe FVector2D StartOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSplineMeshParams.__PropertyOffset_StartOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSplineMeshParams.__PropertyOffset_StartOffset) = value;
			}
		}

		// Token: 0x17004022 RID: 16418
		// (get) Token: 0x06010739 RID: 67385 RVA: 0x001828F5 File Offset: 0x00180AF5
		// (set) Token: 0x0601073A RID: 67386 RVA: 0x00182909 File Offset: 0x00180B09
		public unsafe FVector EndPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSplineMeshParams.__PropertyOffset_EndPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSplineMeshParams.__PropertyOffset_EndPos) = value;
			}
		}

		// Token: 0x17004023 RID: 16419
		// (get) Token: 0x0601073B RID: 67387 RVA: 0x0018291E File Offset: 0x00180B1E
		// (set) Token: 0x0601073C RID: 67388 RVA: 0x00182932 File Offset: 0x00180B32
		public unsafe FVector2D EndScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSplineMeshParams.__PropertyOffset_EndScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSplineMeshParams.__PropertyOffset_EndScale) = value;
			}
		}

		// Token: 0x17004024 RID: 16420
		// (get) Token: 0x0601073D RID: 67389 RVA: 0x00182947 File Offset: 0x00180B47
		// (set) Token: 0x0601073E RID: 67390 RVA: 0x0018295B File Offset: 0x00180B5B
		public unsafe FVector EndTangent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSplineMeshParams.__PropertyOffset_EndTangent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSplineMeshParams.__PropertyOffset_EndTangent) = value;
			}
		}

		// Token: 0x17004025 RID: 16421
		// (get) Token: 0x0601073F RID: 67391 RVA: 0x00182970 File Offset: 0x00180B70
		// (set) Token: 0x06010740 RID: 67392 RVA: 0x00182980 File Offset: 0x00180B80
		public unsafe float EndRoll
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSplineMeshParams.__PropertyOffset_EndRoll);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSplineMeshParams.__PropertyOffset_EndRoll) = value;
			}
		}

		// Token: 0x17004026 RID: 16422
		// (get) Token: 0x06010741 RID: 67393 RVA: 0x00182991 File Offset: 0x00180B91
		// (set) Token: 0x06010742 RID: 67394 RVA: 0x001829A5 File Offset: 0x00180BA5
		public unsafe FVector2D EndOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSplineMeshParams.__PropertyOffset_EndOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSplineMeshParams.__PropertyOffset_EndOffset) = value;
			}
		}

		// Token: 0x06010743 RID: 67395 RVA: 0x001829BA File Offset: 0x00180BBA
		public FSplineMeshParams()
		{
		}

		// Token: 0x06010744 RID: 67396 RVA: 0x001829C4 File Offset: 0x00180BC4
		public FSplineMeshParams(FVector StartPos, FVector StartTangent, FVector2D StartScale, float StartRoll, FVector2D StartOffset, FVector EndPos, FVector2D EndScale, FVector EndTangent, float EndRoll, FVector2D EndOffset)
		{
			this.StartPos = StartPos;
			this.StartTangent = StartTangent;
			this.StartScale = StartScale;
			this.StartRoll = StartRoll;
			this.StartOffset = StartOffset;
			this.EndPos = EndPos;
			this.EndScale = EndScale;
			this.EndTangent = EndTangent;
			this.EndRoll = EndRoll;
			this.EndOffset = EndOffset;
		}

		// Token: 0x06010745 RID: 67397 RVA: 0x00182A24 File Offset: 0x00180C24
		protected override IntPtr GetUStructPtr()
		{
			return FSplineMeshParams.StaticStruct();
		}

		// Token: 0x06010746 RID: 67398 RVA: 0x00182A30 File Offset: 0x00180C30
		[NullableContext(2)]
		public FSplineMeshParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010747 RID: 67399 RVA: 0x00182A3A File Offset: 0x00180C3A
		public FSplineMeshParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010748 RID: 67400 RVA: 0x00182A45 File Offset: 0x00180C45
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSplineMeshParams(Pointer, false, true);
		}

		// Token: 0x06010749 RID: 67401 RVA: 0x00182A4F File Offset: 0x00180C4F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSplineMeshParams(Pointer, MemoryOwner);
		}

		// Token: 0x04008CC7 RID: 36039
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.SplineMeshParams";

		// Token: 0x04008CC8 RID: 36040
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008CC9 RID: 36041
		internal static int __PropertyOffset_StartPos;

		// Token: 0x04008CCA RID: 36042
		internal static int __PropertyOffset_StartTangent;

		// Token: 0x04008CCB RID: 36043
		internal static int __PropertyOffset_StartScale;

		// Token: 0x04008CCC RID: 36044
		internal static int __PropertyOffset_StartRoll;

		// Token: 0x04008CCD RID: 36045
		internal static int __PropertyOffset_StartOffset;

		// Token: 0x04008CCE RID: 36046
		internal static int __PropertyOffset_EndPos;

		// Token: 0x04008CCF RID: 36047
		internal static int __PropertyOffset_EndScale;

		// Token: 0x04008CD0 RID: 36048
		internal static int __PropertyOffset_EndTangent;

		// Token: 0x04008CD1 RID: 36049
		internal static int __PropertyOffset_EndRoll;

		// Token: 0x04008CD2 RID: 36050
		internal static int __PropertyOffset_EndOffset;
	}
}
