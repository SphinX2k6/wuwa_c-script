using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200131E RID: 4894
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.ActiveGameplayEffect")]
	[UnrealStructLayout(896, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 896)]
	public class FActiveGameplayEffect : FFastArraySerializerItem, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601207C RID: 73852 RVA: 0x001A794B File Offset: 0x001A5B4B
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FActiveGameplayEffect._ScriptStructPtr != 0) ? FActiveGameplayEffect._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.ActiveGameplayEffect", ref FActiveGameplayEffect._ScriptStructPtr);
		}

		// Token: 0x17004651 RID: 18001
		// (get) Token: 0x0601207D RID: 73853 RVA: 0x001A7970 File Offset: 0x001A5B70
		// (set) Token: 0x0601207E RID: 73854 RVA: 0x001A79B3 File Offset: 0x001A5BB3
		public FGameplayEffectSpec Spec
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayEffectSpec result;
				if ((result = this._Spec) == null)
				{
					result = (this._Spec = new FGameplayEffectSpec(base.NativePtr + (IntPtr)FActiveGameplayEffect.__PropertyOffset_Spec, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayEffectSpec.StaticStruct(), base.NativePtr + (IntPtr)FActiveGameplayEffect.__PropertyOffset_Spec, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004652 RID: 18002
		// (get) Token: 0x0601207F RID: 73855 RVA: 0x001A79D4 File Offset: 0x001A5BD4
		// (set) Token: 0x06012080 RID: 73856 RVA: 0x001A7A17 File Offset: 0x001A5C17
		public FPredictionKey PredictionKey
		{
			get
			{
				base.FastCheckIsValid();
				FPredictionKey result;
				if ((result = this._PredictionKey) == null)
				{
					result = (this._PredictionKey = new FPredictionKey(base.NativePtr + (IntPtr)FActiveGameplayEffect.__PropertyOffset_PredictionKey, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPredictionKey.StaticStruct(), base.NativePtr + (IntPtr)FActiveGameplayEffect.__PropertyOffset_PredictionKey, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004653 RID: 18003
		// (get) Token: 0x06012081 RID: 73857 RVA: 0x001A7A38 File Offset: 0x001A5C38
		// (set) Token: 0x06012082 RID: 73858 RVA: 0x001A7A48 File Offset: 0x001A5C48
		public unsafe float StartServerWorldTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FActiveGameplayEffect.__PropertyOffset_StartServerWorldTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FActiveGameplayEffect.__PropertyOffset_StartServerWorldTime) = value;
			}
		}

		// Token: 0x17004654 RID: 18004
		// (get) Token: 0x06012083 RID: 73859 RVA: 0x001A7A59 File Offset: 0x001A5C59
		// (set) Token: 0x06012084 RID: 73860 RVA: 0x001A7A69 File Offset: 0x001A5C69
		public unsafe float CachedStartServerWorldTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FActiveGameplayEffect.__PropertyOffset_CachedStartServerWorldTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FActiveGameplayEffect.__PropertyOffset_CachedStartServerWorldTime) = value;
			}
		}

		// Token: 0x17004655 RID: 18005
		// (get) Token: 0x06012085 RID: 73861 RVA: 0x001A7A7A File Offset: 0x001A5C7A
		// (set) Token: 0x06012086 RID: 73862 RVA: 0x001A7A8A File Offset: 0x001A5C8A
		public unsafe float StartWorldTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FActiveGameplayEffect.__PropertyOffset_StartWorldTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FActiveGameplayEffect.__PropertyOffset_StartWorldTime) = value;
			}
		}

		// Token: 0x17004656 RID: 18006
		// (get) Token: 0x06012087 RID: 73863 RVA: 0x001A7A9B File Offset: 0x001A5C9B
		// (set) Token: 0x06012088 RID: 73864 RVA: 0x001A7AAB File Offset: 0x001A5CAB
		public unsafe float PauseStartTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FActiveGameplayEffect.__PropertyOffset_PauseStartTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FActiveGameplayEffect.__PropertyOffset_PauseStartTime) = value;
			}
		}

		// Token: 0x17004657 RID: 18007
		// (get) Token: 0x06012089 RID: 73865 RVA: 0x001A7ABC File Offset: 0x001A5CBC
		// (set) Token: 0x0601208A RID: 73866 RVA: 0x001A7ACC File Offset: 0x001A5CCC
		public unsafe bool bIsInhibited
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FActiveGameplayEffect.__PropertyOffset_bIsInhibited) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FActiveGameplayEffect.__PropertyOffset_bIsInhibited) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601208B RID: 73867 RVA: 0x001A7ADD File Offset: 0x001A5CDD
		public FActiveGameplayEffect()
		{
		}

		// Token: 0x0601208C RID: 73868 RVA: 0x001A7AE8 File Offset: 0x001A5CE8
		public FActiveGameplayEffect(FGameplayEffectSpec Spec, FPredictionKey PredictionKey, float StartServerWorldTime, float CachedStartServerWorldTime, float StartWorldTime, float PauseStartTime, bool bIsInhibited, int ReplicationID, int ReplicationKey, int MostRecentArrayReplicationKey)
		{
			this.Spec = Spec;
			this.PredictionKey = PredictionKey;
			this.StartServerWorldTime = StartServerWorldTime;
			this.CachedStartServerWorldTime = CachedStartServerWorldTime;
			this.StartWorldTime = StartWorldTime;
			this.PauseStartTime = PauseStartTime;
			this.bIsInhibited = bIsInhibited;
			base.ReplicationID = ReplicationID;
			base.ReplicationKey = ReplicationKey;
			base.MostRecentArrayReplicationKey = MostRecentArrayReplicationKey;
		}

		// Token: 0x0601208D RID: 73869 RVA: 0x001A7B48 File Offset: 0x001A5D48
		protected override IntPtr GetUStructPtr()
		{
			return FActiveGameplayEffect.StaticStruct();
		}

		// Token: 0x0601208E RID: 73870 RVA: 0x001A7B54 File Offset: 0x001A5D54
		[NullableContext(2)]
		public FActiveGameplayEffect(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601208F RID: 73871 RVA: 0x001A7B5E File Offset: 0x001A5D5E
		public FActiveGameplayEffect(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012090 RID: 73872 RVA: 0x001A7B69 File Offset: 0x001A5D69
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FActiveGameplayEffect(Pointer, false, true);
		}

		// Token: 0x06012091 RID: 73873 RVA: 0x001A7B73 File Offset: 0x001A5D73
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FActiveGameplayEffect(Pointer, MemoryOwner);
		}

		// Token: 0x04009A1B RID: 39451
		public new const string __ObjectPath = "/Script/GameplayAbilities.ActiveGameplayEffect";

		// Token: 0x04009A1C RID: 39452
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009A1D RID: 39453
		internal static int __PropertyOffset_Spec;

		// Token: 0x04009A1E RID: 39454
		[Nullable(2)]
		private FGameplayEffectSpec _Spec;

		// Token: 0x04009A1F RID: 39455
		internal static int __PropertyOffset_PredictionKey;

		// Token: 0x04009A20 RID: 39456
		[Nullable(2)]
		private FPredictionKey _PredictionKey;

		// Token: 0x04009A21 RID: 39457
		internal static int __PropertyOffset_StartServerWorldTime;

		// Token: 0x04009A22 RID: 39458
		internal static int __PropertyOffset_CachedStartServerWorldTime;

		// Token: 0x04009A23 RID: 39459
		internal static int __PropertyOffset_StartWorldTime;

		// Token: 0x04009A24 RID: 39460
		internal static int __PropertyOffset_PauseStartTime;

		// Token: 0x04009A25 RID: 39461
		internal static int __PropertyOffset_bIsInhibited;
	}
}
