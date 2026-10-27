using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000EB9 RID: 3769
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MorphTargetModifierSettings")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UMorphTargetModifierSettings : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600CBEA RID: 52202 RVA: 0x00129335 File Offset: 0x00127535
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMorphTargetModifierSettings._ClassPtr;
		}

		// Token: 0x0600CBEB RID: 52203 RVA: 0x00129344 File Offset: 0x00127544
		public UMorphTargetModifierSettings() : this(BuiltinUtils.AllocNativeUObject(UMorphTargetModifierSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600CBEC RID: 52204 RVA: 0x0012936C File Offset: 0x0012756C
		public UMorphTargetModifierSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMorphTargetModifierSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002FFB RID: 12283
		// (get) Token: 0x0600CBED RID: 52205 RVA: 0x0012939F File Offset: 0x0012759F
		// (set) Token: 0x0600CBEE RID: 52206 RVA: 0x001293B3 File Offset: 0x001275B3
		[Nullable(2)]
		public unsafe UMorphTargetModifier Modifier
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMorphTargetModifier>(base.NativePtr / (IntPtr)sizeof(void*) + UMorphTargetModifierSettings.__PropertyOffset_Modifier);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMorphTargetModifierSettings.__PropertyOffset_Modifier, value);
			}
		}

		// Token: 0x17002FFC RID: 12284
		// (get) Token: 0x0600CBEF RID: 52207 RVA: 0x001293C8 File Offset: 0x001275C8
		// (set) Token: 0x0600CBF0 RID: 52208 RVA: 0x00129401 File Offset: 0x00127601
		public FPerPlatformInt MinModifyLOD
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformInt result;
				if ((result = this._MinModifyLOD) == null)
				{
					result = (this._MinModifyLOD = new FPerPlatformInt(base.NativePtr + (IntPtr)UMorphTargetModifierSettings.__PropertyOffset_MinModifyLOD, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformInt.StaticStruct(), base.NativePtr + (IntPtr)UMorphTargetModifierSettings.__PropertyOffset_MinModifyLOD, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002FFD RID: 12285
		// (get) Token: 0x0600CBF1 RID: 52209 RVA: 0x00129424 File Offset: 0x00127624
		// (set) Token: 0x0600CBF2 RID: 52210 RVA: 0x0012945D File Offset: 0x0012765D
		public FPerPlatformInt MaxModifyLOD
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformInt result;
				if ((result = this._MaxModifyLOD) == null)
				{
					result = (this._MaxModifyLOD = new FPerPlatformInt(base.NativePtr + (IntPtr)UMorphTargetModifierSettings.__PropertyOffset_MaxModifyLOD, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformInt.StaticStruct(), base.NativePtr + (IntPtr)UMorphTargetModifierSettings.__PropertyOffset_MaxModifyLOD, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002FFE RID: 12286
		// (get) Token: 0x0600CBF3 RID: 52211 RVA: 0x00129480 File Offset: 0x00127680
		// (set) Token: 0x0600CBF4 RID: 52212 RVA: 0x001294B9 File Offset: 0x001276B9
		public TArray<FMorphTargetModWeightCurve> ModWeightCurves
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMorphTargetModWeightCurve> result;
				if ((result = this._ModWeightCurves) == null)
				{
					result = (this._ModWeightCurves = new TArray<FMorphTargetModWeightCurve>(base.NativePtr + (IntPtr)UMorphTargetModifierSettings.__PropertyOffset_ModWeightCurves, this));
				}
				return result;
			}
			set
			{
				this.ModWeightCurves.CopyAssign(value);
			}
		}

		// Token: 0x0600CBF5 RID: 52213 RVA: 0x001294C7 File Offset: 0x001276C7
		static UMorphTargetModifierSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MorphTargetModifierSettings");
		}

		// Token: 0x0600CBF6 RID: 52214 RVA: 0x001294D5 File Offset: 0x001276D5
		protected UMorphTargetModifierSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006DE0 RID: 28128
		public new const string __ObjectPath = "/Script/Engine.MorphTargetModifierSettings";

		// Token: 0x04006DE1 RID: 28129
		private static IntPtr _ClassPtr;

		// Token: 0x04006DE2 RID: 28130
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006DE3 RID: 28131
		internal static int __PropertyOffset_Modifier;

		// Token: 0x04006DE4 RID: 28132
		internal static int __PropertyOffset_MinModifyLOD;

		// Token: 0x04006DE5 RID: 28133
		[Nullable(2)]
		private FPerPlatformInt _MinModifyLOD;

		// Token: 0x04006DE6 RID: 28134
		internal static int __PropertyOffset_MaxModifyLOD;

		// Token: 0x04006DE7 RID: 28135
		[Nullable(2)]
		private FPerPlatformInt _MaxModifyLOD;

		// Token: 0x04006DE8 RID: 28136
		internal static int __PropertyOffset_ModWeightCurves;

		// Token: 0x04006DE9 RID: 28137
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMorphTargetModWeightCurve> _ModWeightCurves;
	}
}
