using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200017C RID: 380
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AnimNotifyEvent")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 224)]
	public class FAnimNotifyEvent : FAnimLinkableElement, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06001816 RID: 6166 RVA: 0x00024DB1 File Offset: 0x00022FB1
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNotifyEvent._ScriptStructPtr != 0) ? FAnimNotifyEvent._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimNotifyEvent", ref FAnimNotifyEvent._ScriptStructPtr);
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06001817 RID: 6167 RVA: 0x00024DD5 File Offset: 0x00022FD5
		// (set) Token: 0x06001818 RID: 6168 RVA: 0x00024DE5 File Offset: 0x00022FE5
		public unsafe float DisplayTime_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_DisplayTime_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_DisplayTime_DEPRECATED) = value;
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06001819 RID: 6169 RVA: 0x00024DF6 File Offset: 0x00022FF6
		// (set) Token: 0x0600181A RID: 6170 RVA: 0x00024E06 File Offset: 0x00023006
		public unsafe float TriggerTimeOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_TriggerTimeOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_TriggerTimeOffset) = value;
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x0600181B RID: 6171 RVA: 0x00024E17 File Offset: 0x00023017
		// (set) Token: 0x0600181C RID: 6172 RVA: 0x00024E27 File Offset: 0x00023027
		public unsafe float EndTriggerTimeOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_EndTriggerTimeOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_EndTriggerTimeOffset) = value;
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x0600181D RID: 6173 RVA: 0x00024E38 File Offset: 0x00023038
		// (set) Token: 0x0600181E RID: 6174 RVA: 0x00024E48 File Offset: 0x00023048
		public unsafe float TriggerWeightThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_TriggerWeightThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_TriggerWeightThreshold) = value;
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x0600181F RID: 6175 RVA: 0x00024E59 File Offset: 0x00023059
		// (set) Token: 0x06001820 RID: 6176 RVA: 0x00024E6D File Offset: 0x0002306D
		public unsafe FName NotifyName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_NotifyName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_NotifyName) = value;
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06001821 RID: 6177 RVA: 0x00024E82 File Offset: 0x00023082
		// (set) Token: 0x06001822 RID: 6178 RVA: 0x00024E96 File Offset: 0x00023096
		public unsafe UAnimNotify Notify
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimNotify>(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNotifyEvent.__PropertyOffset_Notify);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNotifyEvent.__PropertyOffset_Notify, value);
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06001823 RID: 6179 RVA: 0x00024EAB File Offset: 0x000230AB
		// (set) Token: 0x06001824 RID: 6180 RVA: 0x00024EBF File Offset: 0x000230BF
		public unsafe UAnimNotifyState NotifyStateClass
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimNotifyState>(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNotifyEvent.__PropertyOffset_NotifyStateClass);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNotifyEvent.__PropertyOffset_NotifyStateClass, value);
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06001825 RID: 6181 RVA: 0x00024ED4 File Offset: 0x000230D4
		// (set) Token: 0x06001826 RID: 6182 RVA: 0x00024EE4 File Offset: 0x000230E4
		public unsafe float Duration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_Duration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_Duration) = value;
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06001827 RID: 6183 RVA: 0x00024EF8 File Offset: 0x000230F8
		// (set) Token: 0x06001828 RID: 6184 RVA: 0x00024F3B File Offset: 0x0002313B
		[Nullable(1)]
		public FAnimLinkableElement EndLink
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FAnimLinkableElement result;
				if ((result = this._EndLink) == null)
				{
					result = (this._EndLink = new FAnimLinkableElement(base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_EndLink, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAnimLinkableElement.StaticStruct(), base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_EndLink, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06001829 RID: 6185 RVA: 0x00024F5C File Offset: 0x0002315C
		// (set) Token: 0x0600182A RID: 6186 RVA: 0x00024F6C File Offset: 0x0002316C
		public unsafe bool bConvertedFromBranchingPoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_bConvertedFromBranchingPoint) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_bConvertedFromBranchingPoint) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x0600182B RID: 6187 RVA: 0x00024F7D File Offset: 0x0002317D
		// (set) Token: 0x0600182C RID: 6188 RVA: 0x00024F8D File Offset: 0x0002318D
		public unsafe bool bEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_bEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_bEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x0600182D RID: 6189 RVA: 0x00024F9E File Offset: 0x0002319E
		// (set) Token: 0x0600182E RID: 6190 RVA: 0x00024FAE File Offset: 0x000231AE
		public unsafe float NotifyTriggerChance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_NotifyTriggerChance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_NotifyTriggerChance) = value;
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x0600182F RID: 6191 RVA: 0x00024FBF File Offset: 0x000231BF
		// (set) Token: 0x06001830 RID: 6192 RVA: 0x00024FCF File Offset: 0x000231CF
		public unsafe int NotifyFilterLOD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_NotifyFilterLOD);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_NotifyFilterLOD) = value;
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06001831 RID: 6193 RVA: 0x00024FE0 File Offset: 0x000231E0
		// (set) Token: 0x06001832 RID: 6194 RVA: 0x00024FF0 File Offset: 0x000231F0
		public unsafe bool bTriggerOnDedicatedServer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_bTriggerOnDedicatedServer) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_bTriggerOnDedicatedServer) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06001833 RID: 6195 RVA: 0x00025001 File Offset: 0x00023201
		// (set) Token: 0x06001834 RID: 6196 RVA: 0x00025011 File Offset: 0x00023211
		public unsafe bool bTriggerOnFollower
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_bTriggerOnFollower) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_bTriggerOnFollower) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06001835 RID: 6197 RVA: 0x00025022 File Offset: 0x00023222
		// (set) Token: 0x06001836 RID: 6198 RVA: 0x00025032 File Offset: 0x00023232
		public unsafe bool bForceTriggerOnState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_bForceTriggerOnState) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_bForceTriggerOnState) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06001837 RID: 6199 RVA: 0x00025043 File Offset: 0x00023243
		// (set) Token: 0x06001838 RID: 6200 RVA: 0x00025053 File Offset: 0x00023253
		public unsafe int TrackIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_TrackIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_TrackIndex) = value;
			}
		}

		// Token: 0x06001839 RID: 6201 RVA: 0x00025064 File Offset: 0x00023264
		public FAnimNotifyEvent()
		{
		}

		// Token: 0x0600183A RID: 6202 RVA: 0x0002506C File Offset: 0x0002326C
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNotifyEvent.StaticStruct();
		}

		// Token: 0x0600183B RID: 6203 RVA: 0x00025078 File Offset: 0x00023278
		public FAnimNotifyEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600183C RID: 6204 RVA: 0x00025082 File Offset: 0x00023282
		public FAnimNotifyEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600183D RID: 6205 RVA: 0x0002508D File Offset: 0x0002328D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNotifyEvent(Pointer, false, true);
		}

		// Token: 0x0600183E RID: 6206 RVA: 0x00025097 File Offset: 0x00023297
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNotifyEvent(Pointer, MemoryOwner);
		}

		// Token: 0x0400079A RID: 1946
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AnimNotifyEvent";

		// Token: 0x0400079B RID: 1947
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400079C RID: 1948
		internal static int __PropertyOffset_DisplayTime_DEPRECATED;

		// Token: 0x0400079D RID: 1949
		internal static int __PropertyOffset_TriggerTimeOffset;

		// Token: 0x0400079E RID: 1950
		internal static int __PropertyOffset_EndTriggerTimeOffset;

		// Token: 0x0400079F RID: 1951
		internal static int __PropertyOffset_TriggerWeightThreshold;

		// Token: 0x040007A0 RID: 1952
		internal static int __PropertyOffset_NotifyName;

		// Token: 0x040007A1 RID: 1953
		internal static int __PropertyOffset_Notify;

		// Token: 0x040007A2 RID: 1954
		internal static int __PropertyOffset_NotifyStateClass;

		// Token: 0x040007A3 RID: 1955
		internal static int __PropertyOffset_Duration;

		// Token: 0x040007A4 RID: 1956
		internal static int __PropertyOffset_EndLink;

		// Token: 0x040007A5 RID: 1957
		private FAnimLinkableElement _EndLink;

		// Token: 0x040007A6 RID: 1958
		internal static int __PropertyOffset_bConvertedFromBranchingPoint;

		// Token: 0x040007A7 RID: 1959
		internal static int __PropertyOffset_bEnabled;

		// Token: 0x040007A8 RID: 1960
		internal static int __PropertyOffset_NotifyTriggerChance;

		// Token: 0x040007A9 RID: 1961
		internal static int __PropertyOffset_NotifyFilterLOD;

		// Token: 0x040007AA RID: 1962
		internal static int __PropertyOffset_bTriggerOnDedicatedServer;

		// Token: 0x040007AB RID: 1963
		internal static int __PropertyOffset_bTriggerOnFollower;

		// Token: 0x040007AC RID: 1964
		internal static int __PropertyOffset_bForceTriggerOnState;

		// Token: 0x040007AD RID: 1965
		internal static int __PropertyOffset_TrackIndex;
	}
}
