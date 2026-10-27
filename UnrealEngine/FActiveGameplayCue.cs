using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200131C RID: 4892
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.ActiveGameplayCue")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 240)]
	public class FActiveGameplayCue : FFastArraySerializerItem, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06012060 RID: 73824 RVA: 0x001A7698 File Offset: 0x001A5898
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FActiveGameplayCue._ScriptStructPtr != 0) ? FActiveGameplayCue._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.ActiveGameplayCue", ref FActiveGameplayCue._ScriptStructPtr);
		}

		// Token: 0x1700464B RID: 17995
		// (get) Token: 0x06012061 RID: 73825 RVA: 0x001A76BC File Offset: 0x001A58BC
		// (set) Token: 0x06012062 RID: 73826 RVA: 0x001A76D0 File Offset: 0x001A58D0
		public unsafe FGameplayTag GameplayCueTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FActiveGameplayCue.__PropertyOffset_GameplayCueTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FActiveGameplayCue.__PropertyOffset_GameplayCueTag) = value;
			}
		}

		// Token: 0x1700464C RID: 17996
		// (get) Token: 0x06012063 RID: 73827 RVA: 0x001A76E8 File Offset: 0x001A58E8
		// (set) Token: 0x06012064 RID: 73828 RVA: 0x001A772B File Offset: 0x001A592B
		public FPredictionKey PredictionKey
		{
			get
			{
				base.FastCheckIsValid();
				FPredictionKey result;
				if ((result = this._PredictionKey) == null)
				{
					result = (this._PredictionKey = new FPredictionKey(base.NativePtr + (IntPtr)FActiveGameplayCue.__PropertyOffset_PredictionKey, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPredictionKey.StaticStruct(), base.NativePtr + (IntPtr)FActiveGameplayCue.__PropertyOffset_PredictionKey, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700464D RID: 17997
		// (get) Token: 0x06012065 RID: 73829 RVA: 0x001A774C File Offset: 0x001A594C
		// (set) Token: 0x06012066 RID: 73830 RVA: 0x001A778F File Offset: 0x001A598F
		public FGameplayCueParameters Parameters
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayCueParameters result;
				if ((result = this._Parameters) == null)
				{
					result = (this._Parameters = new FGameplayCueParameters(base.NativePtr + (IntPtr)FActiveGameplayCue.__PropertyOffset_Parameters, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayCueParameters.StaticStruct(), base.NativePtr + (IntPtr)FActiveGameplayCue.__PropertyOffset_Parameters, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700464E RID: 17998
		// (get) Token: 0x06012067 RID: 73831 RVA: 0x001A77B0 File Offset: 0x001A59B0
		// (set) Token: 0x06012068 RID: 73832 RVA: 0x001A77C0 File Offset: 0x001A59C0
		public unsafe bool bPredictivelyRemoved
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FActiveGameplayCue.__PropertyOffset_bPredictivelyRemoved) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FActiveGameplayCue.__PropertyOffset_bPredictivelyRemoved) = (value ? 1 : 0);
			}
		}

		// Token: 0x06012069 RID: 73833 RVA: 0x001A77D1 File Offset: 0x001A59D1
		public FActiveGameplayCue()
		{
		}

		// Token: 0x0601206A RID: 73834 RVA: 0x001A77D9 File Offset: 0x001A59D9
		public FActiveGameplayCue(FGameplayTag GameplayCueTag, FPredictionKey PredictionKey, FGameplayCueParameters Parameters, bool bPredictivelyRemoved, int ReplicationID, int ReplicationKey, int MostRecentArrayReplicationKey)
		{
			this.GameplayCueTag = GameplayCueTag;
			this.PredictionKey = PredictionKey;
			this.Parameters = Parameters;
			this.bPredictivelyRemoved = bPredictivelyRemoved;
			base.ReplicationID = ReplicationID;
			base.ReplicationKey = ReplicationKey;
			base.MostRecentArrayReplicationKey = MostRecentArrayReplicationKey;
		}

		// Token: 0x0601206B RID: 73835 RVA: 0x001A7816 File Offset: 0x001A5A16
		protected override IntPtr GetUStructPtr()
		{
			return FActiveGameplayCue.StaticStruct();
		}

		// Token: 0x0601206C RID: 73836 RVA: 0x001A7822 File Offset: 0x001A5A22
		[NullableContext(2)]
		public FActiveGameplayCue(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601206D RID: 73837 RVA: 0x001A782C File Offset: 0x001A5A2C
		public FActiveGameplayCue(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601206E RID: 73838 RVA: 0x001A7837 File Offset: 0x001A5A37
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FActiveGameplayCue(Pointer, false, true);
		}

		// Token: 0x0601206F RID: 73839 RVA: 0x001A7841 File Offset: 0x001A5A41
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FActiveGameplayCue(Pointer, MemoryOwner);
		}

		// Token: 0x04009A0E RID: 39438
		public new const string __ObjectPath = "/Script/GameplayAbilities.ActiveGameplayCue";

		// Token: 0x04009A0F RID: 39439
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009A10 RID: 39440
		internal static int __PropertyOffset_GameplayCueTag;

		// Token: 0x04009A11 RID: 39441
		internal static int __PropertyOffset_PredictionKey;

		// Token: 0x04009A12 RID: 39442
		[Nullable(2)]
		private FPredictionKey _PredictionKey;

		// Token: 0x04009A13 RID: 39443
		internal static int __PropertyOffset_Parameters;

		// Token: 0x04009A14 RID: 39444
		[Nullable(2)]
		private FGameplayCueParameters _Parameters;

		// Token: 0x04009A15 RID: 39445
		internal static int __PropertyOffset_bPredictivelyRemoved;
	}
}
