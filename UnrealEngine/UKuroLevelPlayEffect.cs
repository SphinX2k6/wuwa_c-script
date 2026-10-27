using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018E8 RID: 6376
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroLevelPlayEffect")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 184)]
	public class UKuroLevelPlayEffect : UKuroLevelStateAction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017A45 RID: 96837 RVA: 0x0022A629 File Offset: 0x00228829
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroLevelPlayEffect._ClassPtr;
		}

		// Token: 0x06017A46 RID: 96838 RVA: 0x0022A638 File Offset: 0x00228838
		public UKuroLevelPlayEffect() : this(BuiltinUtils.AllocNativeUObject(UKuroLevelPlayEffect.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017A47 RID: 96839 RVA: 0x0022A660 File Offset: 0x00228860
		public UKuroLevelPlayEffect(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroLevelPlayEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005F46 RID: 24390
		// (get) Token: 0x06017A48 RID: 96840 RVA: 0x0022A694 File Offset: 0x00228894
		// (set) Token: 0x06017A49 RID: 96841 RVA: 0x0022A6CD File Offset: 0x002288CD
		public TArray<AKuroSceneEffectActor> EffectActors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AKuroSceneEffectActor> result;
				if ((result = this._EffectActors) == null)
				{
					result = (this._EffectActors = new TArray<AKuroSceneEffectActor>(base.NativePtr + (IntPtr)UKuroLevelPlayEffect.__PropertyOffset_EffectActors, this));
				}
				return result;
			}
			set
			{
				this.EffectActors.CopyAssign(value);
			}
		}

		// Token: 0x17005F47 RID: 24391
		// (get) Token: 0x06017A4A RID: 96842 RVA: 0x0022A6DB File Offset: 0x002288DB
		// (set) Token: 0x06017A4B RID: 96843 RVA: 0x0022A6EB File Offset: 0x002288EB
		public unsafe bool bImmediatelyStop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroLevelPlayEffect.__PropertyOffset_bImmediatelyStop) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroLevelPlayEffect.__PropertyOffset_bImmediatelyStop) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005F48 RID: 24392
		// (get) Token: 0x06017A4C RID: 96844 RVA: 0x0022A6FC File Offset: 0x002288FC
		// (set) Token: 0x06017A4D RID: 96845 RVA: 0x0022A735 File Offset: 0x00228935
		public TMap<FName, bool> StopModifiers
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, bool> result;
				if ((result = this._StopModifiers) == null)
				{
					result = (this._StopModifiers = new TMap<FName, bool>(base.NativePtr + (IntPtr)UKuroLevelPlayEffect.__PropertyOffset_StopModifiers, this));
				}
				return result;
			}
			set
			{
				this.StopModifiers.CopyAssign(value);
			}
		}

		// Token: 0x06017A4E RID: 96846 RVA: 0x0022A743 File Offset: 0x00228943
		static UKuroLevelPlayEffect()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroLevelPlayEffect");
		}

		// Token: 0x06017A4F RID: 96847 RVA: 0x0022A751 File Offset: 0x00228951
		protected UKuroLevelPlayEffect(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CD79 RID: 52601
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroLevelPlayEffect";

		// Token: 0x0400CD7A RID: 52602
		private static IntPtr _ClassPtr;

		// Token: 0x0400CD7B RID: 52603
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400CD7C RID: 52604
		internal static int __PropertyOffset_EffectActors;

		// Token: 0x0400CD7D RID: 52605
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AKuroSceneEffectActor> _EffectActors;

		// Token: 0x0400CD7E RID: 52606
		internal static int __PropertyOffset_bImmediatelyStop;

		// Token: 0x0400CD7F RID: 52607
		internal static int __PropertyOffset_StopModifiers;

		// Token: 0x0400CD80 RID: 52608
		[Nullable(2)]
		private TMap<FName, bool> _StopModifiers;
	}
}
