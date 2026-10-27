using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000984 RID: 2436
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.CurveTrack")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FCurveTrack : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060089B9 RID: 35257 RVA: 0x000C553A File Offset: 0x000C373A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCurveTrack._ScriptStructPtr != 0) ? FCurveTrack._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.CurveTrack", ref FCurveTrack._ScriptStructPtr);
		}

		// Token: 0x1700207A RID: 8314
		// (get) Token: 0x060089BA RID: 35258 RVA: 0x000C555E File Offset: 0x000C375E
		// (set) Token: 0x060089BB RID: 35259 RVA: 0x000C5572 File Offset: 0x000C3772
		public unsafe FName CurveName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCurveTrack.__PropertyOffset_CurveName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCurveTrack.__PropertyOffset_CurveName) = value;
			}
		}

		// Token: 0x1700207B RID: 8315
		// (get) Token: 0x060089BC RID: 35260 RVA: 0x000C5588 File Offset: 0x000C3788
		// (set) Token: 0x060089BD RID: 35261 RVA: 0x000C55CB File Offset: 0x000C37CB
		public TArray<float> CurveWeights
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._CurveWeights) == null)
				{
					result = (this._CurveWeights = new TArray<float>(base.NativePtr + (IntPtr)FCurveTrack.__PropertyOffset_CurveWeights, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CurveWeights.CopyAssign(value);
			}
		}

		// Token: 0x060089BE RID: 35262 RVA: 0x000C55D9 File Offset: 0x000C37D9
		public FCurveTrack()
		{
		}

		// Token: 0x060089BF RID: 35263 RVA: 0x000C55E1 File Offset: 0x000C37E1
		public FCurveTrack(FName CurveName, TArray<float> CurveWeights)
		{
			this.CurveName = CurveName;
			this.CurveWeights = CurveWeights;
		}

		// Token: 0x060089C0 RID: 35264 RVA: 0x000C55F7 File Offset: 0x000C37F7
		protected override IntPtr GetUStructPtr()
		{
			return FCurveTrack.StaticStruct();
		}

		// Token: 0x060089C1 RID: 35265 RVA: 0x000C5603 File Offset: 0x000C3803
		[NullableContext(2)]
		public FCurveTrack(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060089C2 RID: 35266 RVA: 0x000C560D File Offset: 0x000C380D
		public FCurveTrack(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060089C3 RID: 35267 RVA: 0x000C5618 File Offset: 0x000C3818
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCurveTrack(Pointer, false, true);
		}

		// Token: 0x060089C4 RID: 35268 RVA: 0x000C5622 File Offset: 0x000C3822
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCurveTrack(Pointer, MemoryOwner);
		}

		// Token: 0x04004166 RID: 16742
		public const string __ObjectPath = "/Script/Engine.CurveTrack";

		// Token: 0x04004167 RID: 16743
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004168 RID: 16744
		internal static int __PropertyOffset_CurveName;

		// Token: 0x04004169 RID: 16745
		internal static int __PropertyOffset_CurveWeights;

		// Token: 0x0400416A RID: 16746
		[Nullable(2)]
		private TArray<float> _CurveWeights;
	}
}
