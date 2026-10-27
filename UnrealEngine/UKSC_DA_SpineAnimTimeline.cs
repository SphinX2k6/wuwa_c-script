using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DCD RID: 7629
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_SpineAnimTimeline")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UKSC_DA_SpineAnimTimeline : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D2A0 RID: 119456 RVA: 0x002B166E File Offset: 0x002AF86E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_SpineAnimTimeline._ClassPtr;
		}

		// Token: 0x0601D2A1 RID: 119457 RVA: 0x002B167C File Offset: 0x002AF87C
		public UKSC_DA_SpineAnimTimeline() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_SpineAnimTimeline.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D2A2 RID: 119458 RVA: 0x002B16A4 File Offset: 0x002AF8A4
		public UKSC_DA_SpineAnimTimeline(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_SpineAnimTimeline.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170075D4 RID: 30164
		// (get) Token: 0x0601D2A3 RID: 119459 RVA: 0x002B16D7 File Offset: 0x002AF8D7
		// (set) Token: 0x0601D2A4 RID: 119460 RVA: 0x002B16EB File Offset: 0x002AF8EB
		public unsafe string AnimName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UKSC_DA_SpineAnimTimeline.__PropertyOffset_AnimName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UKSC_DA_SpineAnimTimeline.__PropertyOffset_AnimName)), value);
			}
		}

		// Token: 0x170075D5 RID: 30165
		// (get) Token: 0x0601D2A5 RID: 119461 RVA: 0x002B1700 File Offset: 0x002AF900
		// (set) Token: 0x0601D2A6 RID: 119462 RVA: 0x002B1710 File Offset: 0x002AF910
		public unsafe bool IsLoop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_SpineAnimTimeline.__PropertyOffset_IsLoop) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_SpineAnimTimeline.__PropertyOffset_IsLoop) = (value ? 1 : 0);
			}
		}

		// Token: 0x170075D6 RID: 30166
		// (get) Token: 0x0601D2A7 RID: 119463 RVA: 0x002B1721 File Offset: 0x002AF921
		// (set) Token: 0x0601D2A8 RID: 119464 RVA: 0x002B1731 File Offset: 0x002AF931
		public unsafe float LoopTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_SpineAnimTimeline.__PropertyOffset_LoopTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_SpineAnimTimeline.__PropertyOffset_LoopTime) = value;
			}
		}

		// Token: 0x170075D7 RID: 30167
		// (get) Token: 0x0601D2A9 RID: 119465 RVA: 0x002B1742 File Offset: 0x002AF942
		// (set) Token: 0x0601D2AA RID: 119466 RVA: 0x002B1752 File Offset: 0x002AF952
		public unsafe bool IsIgnoreAnim
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_SpineAnimTimeline.__PropertyOffset_IsIgnoreAnim) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_SpineAnimTimeline.__PropertyOffset_IsIgnoreAnim) = (value ? 1 : 0);
			}
		}

		// Token: 0x170075D8 RID: 30168
		// (get) Token: 0x0601D2AB RID: 119467 RVA: 0x002B1763 File Offset: 0x002AF963
		// (set) Token: 0x0601D2AC RID: 119468 RVA: 0x002B1773 File Offset: 0x002AF973
		public unsafe float IgnoreAnimTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_SpineAnimTimeline.__PropertyOffset_IgnoreAnimTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_SpineAnimTimeline.__PropertyOffset_IgnoreAnimTime) = value;
			}
		}

		// Token: 0x170075D9 RID: 30169
		// (get) Token: 0x0601D2AD RID: 119469 RVA: 0x002B1784 File Offset: 0x002AF984
		// (set) Token: 0x0601D2AE RID: 119470 RVA: 0x002B17BD File Offset: 0x002AF9BD
		public TArray<FKSC_SpineAnimNotify> AnimNotifies
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKSC_SpineAnimNotify> result;
				if ((result = this._AnimNotifies) == null)
				{
					result = (this._AnimNotifies = new TArray<FKSC_SpineAnimNotify>(base.NativePtr + (IntPtr)UKSC_DA_SpineAnimTimeline.__PropertyOffset_AnimNotifies, this));
				}
				return result;
			}
			set
			{
				this.AnimNotifies.CopyAssign(value);
			}
		}

		// Token: 0x0601D2AF RID: 119471 RVA: 0x002B17CB File Offset: 0x002AF9CB
		static UKSC_DA_SpineAnimTimeline()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_SpineAnimTimeline");
		}

		// Token: 0x0601D2B0 RID: 119472 RVA: 0x002B17D9 File Offset: 0x002AF9D9
		protected UKSC_DA_SpineAnimTimeline(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FD59 RID: 64857
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_SpineAnimTimeline";

		// Token: 0x0400FD5A RID: 64858
		private static IntPtr _ClassPtr;

		// Token: 0x0400FD5B RID: 64859
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FD5C RID: 64860
		internal static int __PropertyOffset_AnimName;

		// Token: 0x0400FD5D RID: 64861
		internal static int __PropertyOffset_IsLoop;

		// Token: 0x0400FD5E RID: 64862
		internal static int __PropertyOffset_LoopTime;

		// Token: 0x0400FD5F RID: 64863
		internal static int __PropertyOffset_IsIgnoreAnim;

		// Token: 0x0400FD60 RID: 64864
		internal static int __PropertyOffset_IgnoreAnimTime;

		// Token: 0x0400FD61 RID: 64865
		internal static int __PropertyOffset_AnimNotifies;

		// Token: 0x0400FD62 RID: 64866
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKSC_SpineAnimNotify> _AnimNotifies;
	}
}
