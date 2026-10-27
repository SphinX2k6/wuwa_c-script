using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000334 RID: 820
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.MorphTargetModifierConfig")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FMorphTargetModifierConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002DA1 RID: 11681 RVA: 0x00045EA1 File Offset: 0x000440A1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMorphTargetModifierConfig._ScriptStructPtr != 0) ? FMorphTargetModifierConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.MorphTargetModifierConfig", ref FMorphTargetModifierConfig._ScriptStructPtr);
		}

		// Token: 0x17000B4E RID: 2894
		// (get) Token: 0x06002DA2 RID: 11682 RVA: 0x00045EC5 File Offset: 0x000440C5
		// (set) Token: 0x06002DA3 RID: 11683 RVA: 0x00045ED5 File Offset: 0x000440D5
		public unsafe EMorphTargetModMethod MorphTargetModMethod
		{
			get
			{
				return (EMorphTargetModMethod)(*(base.NativePtr + (IntPtr)FMorphTargetModifierConfig.__PropertyOffset_MorphTargetModMethod));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMorphTargetModifierConfig.__PropertyOffset_MorphTargetModMethod) = (byte)value;
			}
		}

		// Token: 0x17000B4F RID: 2895
		// (get) Token: 0x06002DA4 RID: 11684 RVA: 0x00045EE8 File Offset: 0x000440E8
		// (set) Token: 0x06002DA5 RID: 11685 RVA: 0x00045F2B File Offset: 0x0004412B
		public TArray<FMorphTargetModWeightCurve> ModWeightCurves
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMorphTargetModWeightCurve> result;
				if ((result = this._ModWeightCurves) == null)
				{
					result = (this._ModWeightCurves = new TArray<FMorphTargetModWeightCurve>(base.NativePtr + (IntPtr)FMorphTargetModifierConfig.__PropertyOffset_ModWeightCurves, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ModWeightCurves.CopyAssign(value);
			}
		}

		// Token: 0x06002DA6 RID: 11686 RVA: 0x00045F39 File Offset: 0x00044139
		public FMorphTargetModifierConfig()
		{
		}

		// Token: 0x06002DA7 RID: 11687 RVA: 0x00045F41 File Offset: 0x00044141
		public FMorphTargetModifierConfig(EMorphTargetModMethod MorphTargetModMethod, float CurrentModifierFactor, TArray<FMorphTargetModWeightCurve> ModWeightCurves)
		{
			this.MorphTargetModMethod = MorphTargetModMethod;
			this.ModWeightCurves = ModWeightCurves;
		}

		// Token: 0x06002DA8 RID: 11688 RVA: 0x00045F57 File Offset: 0x00044157
		protected override IntPtr GetUStructPtr()
		{
			return FMorphTargetModifierConfig.StaticStruct();
		}

		// Token: 0x06002DA9 RID: 11689 RVA: 0x00045F63 File Offset: 0x00044163
		[NullableContext(2)]
		public FMorphTargetModifierConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002DAA RID: 11690 RVA: 0x00045F6D File Offset: 0x0004416D
		public FMorphTargetModifierConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002DAB RID: 11691 RVA: 0x00045F78 File Offset: 0x00044178
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMorphTargetModifierConfig(Pointer, false, true);
		}

		// Token: 0x06002DAC RID: 11692 RVA: 0x00045F82 File Offset: 0x00044182
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMorphTargetModifierConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04001384 RID: 4996
		public const string __ObjectPath = "/Script/AnimGraphRuntime.MorphTargetModifierConfig";

		// Token: 0x04001385 RID: 4997
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001386 RID: 4998
		internal static int __PropertyOffset_MorphTargetModMethod;

		// Token: 0x04001387 RID: 4999
		internal static int __PropertyOffset_ModWeightCurves;

		// Token: 0x04001388 RID: 5000
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMorphTargetModWeightCurve> _ModWeightCurves;
	}
}
