using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000EBB RID: 3771
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MorphTargetModWeightCurve")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 152)]
	public class FMorphTargetModWeightCurve : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600CBFC RID: 52220 RVA: 0x0012955E File Offset: 0x0012775E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMorphTargetModWeightCurve._ScriptStructPtr != 0) ? FMorphTargetModWeightCurve._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.MorphTargetModWeightCurve", ref FMorphTargetModWeightCurve._ScriptStructPtr);
		}

		// Token: 0x17002FFF RID: 12287
		// (get) Token: 0x0600CBFD RID: 52221 RVA: 0x00129582 File Offset: 0x00127782
		// (set) Token: 0x0600CBFE RID: 52222 RVA: 0x00129596 File Offset: 0x00127796
		public unsafe FName MorphTargetName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMorphTargetModWeightCurve.__PropertyOffset_MorphTargetName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMorphTargetModWeightCurve.__PropertyOffset_MorphTargetName) = value;
			}
		}

		// Token: 0x17003000 RID: 12288
		// (get) Token: 0x0600CBFF RID: 52223 RVA: 0x001295AC File Offset: 0x001277AC
		// (set) Token: 0x0600CC00 RID: 52224 RVA: 0x001295EF File Offset: 0x001277EF
		public FRuntimeFloatCurve WeightCurve
		{
			get
			{
				base.FastCheckIsValid();
				FRuntimeFloatCurve result;
				if ((result = this._WeightCurve) == null)
				{
					result = (this._WeightCurve = new FRuntimeFloatCurve(base.NativePtr + (IntPtr)FMorphTargetModWeightCurve.__PropertyOffset_WeightCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRuntimeFloatCurve.StaticStruct(), base.NativePtr + (IntPtr)FMorphTargetModWeightCurve.__PropertyOffset_WeightCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600CC01 RID: 52225 RVA: 0x00129610 File Offset: 0x00127810
		public FMorphTargetModWeightCurve()
		{
		}

		// Token: 0x0600CC02 RID: 52226 RVA: 0x00129618 File Offset: 0x00127818
		public FMorphTargetModWeightCurve(FName MorphTargetName, float CurrentMorphTargetWeight, FRuntimeFloatCurve WeightCurve)
		{
			this.MorphTargetName = MorphTargetName;
			this.WeightCurve = WeightCurve;
		}

		// Token: 0x0600CC03 RID: 52227 RVA: 0x0012962E File Offset: 0x0012782E
		protected override IntPtr GetUStructPtr()
		{
			return FMorphTargetModWeightCurve.StaticStruct();
		}

		// Token: 0x0600CC04 RID: 52228 RVA: 0x0012963A File Offset: 0x0012783A
		[NullableContext(2)]
		public FMorphTargetModWeightCurve(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600CC05 RID: 52229 RVA: 0x00129644 File Offset: 0x00127844
		public FMorphTargetModWeightCurve(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600CC06 RID: 52230 RVA: 0x0012964F File Offset: 0x0012784F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMorphTargetModWeightCurve(Pointer, false, true);
		}

		// Token: 0x0600CC07 RID: 52231 RVA: 0x00129659 File Offset: 0x00127859
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMorphTargetModWeightCurve(Pointer, MemoryOwner);
		}

		// Token: 0x04006DED RID: 28141
		public const string __ObjectPath = "/Script/Engine.MorphTargetModWeightCurve";

		// Token: 0x04006DEE RID: 28142
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006DEF RID: 28143
		internal static int __PropertyOffset_MorphTargetName;

		// Token: 0x04006DF0 RID: 28144
		internal static int __PropertyOffset_WeightCurve;

		// Token: 0x04006DF1 RID: 28145
		[Nullable(2)]
		private FRuntimeFloatCurve _WeightCurve;
	}
}
