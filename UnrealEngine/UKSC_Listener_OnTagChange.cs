using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DFB RID: 7675
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Listener_OnTagChange")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UKSC_Listener_OnTagChange : UKSC_EventListener, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D523 RID: 120099 RVA: 0x002B4A82 File Offset: 0x002B2C82
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Listener_OnTagChange._ClassPtr;
		}

		// Token: 0x0601D524 RID: 120100 RVA: 0x002B4A90 File Offset: 0x002B2C90
		public UKSC_Listener_OnTagChange() : this(BuiltinUtils.AllocNativeUObject(UKSC_Listener_OnTagChange.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D525 RID: 120101 RVA: 0x002B4AB8 File Offset: 0x002B2CB8
		public UKSC_Listener_OnTagChange(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Listener_OnTagChange.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007661 RID: 30305
		// (get) Token: 0x0601D526 RID: 120102 RVA: 0x002B4AEC File Offset: 0x002B2CEC
		// (set) Token: 0x0601D527 RID: 120103 RVA: 0x002B4B25 File Offset: 0x002B2D25
		public FGameplayTagContainer ListenTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._ListenTags) == null)
				{
					result = (this._ListenTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)UKSC_Listener_OnTagChange.__PropertyOffset_ListenTags, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)UKSC_Listener_OnTagChange.__PropertyOffset_ListenTags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007662 RID: 30306
		// (get) Token: 0x0601D528 RID: 120104 RVA: 0x002B4B46 File Offset: 0x002B2D46
		// (set) Token: 0x0601D529 RID: 120105 RVA: 0x002B4B56 File Offset: 0x002B2D56
		public unsafe bool bListenAdd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_Listener_OnTagChange.__PropertyOffset_bListenAdd) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_Listener_OnTagChange.__PropertyOffset_bListenAdd) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007663 RID: 30307
		// (get) Token: 0x0601D52A RID: 120106 RVA: 0x002B4B67 File Offset: 0x002B2D67
		// (set) Token: 0x0601D52B RID: 120107 RVA: 0x002B4B77 File Offset: 0x002B2D77
		public unsafe bool bListenRemove
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_Listener_OnTagChange.__PropertyOffset_bListenRemove) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_Listener_OnTagChange.__PropertyOffset_bListenRemove) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601D52C RID: 120108 RVA: 0x002B4B88 File Offset: 0x002B2D88
		[NullableContext(2)]
		public void OnTagRemoveCallback(UKSC_SkillComp SkillComp, in FGameplayTag Tag, int CountDelta)
		{
			UKSC_Listener_OnTagChange.__OnTagRemoveCallback_Internal(base.NativePtr, (SkillComp != null) ? SkillComp.NativePtr : IntPtr.Zero, Tag, CountDelta);
		}

		// Token: 0x0601D52D RID: 120109 RVA: 0x002B4BA7 File Offset: 0x002B2DA7
		[NullableContext(2)]
		public void OnTagAddCallback(UKSC_SkillComp SkillComp, in FGameplayTag Tag, int CountDelta)
		{
			UKSC_Listener_OnTagChange.__OnTagAddCallback_Internal(base.NativePtr, (SkillComp != null) ? SkillComp.NativePtr : IntPtr.Zero, Tag, CountDelta);
		}

		// Token: 0x0601D52E RID: 120110
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnTagRemoveCallback_Internal(IntPtr @this, IntPtr SkillComp, in FGameplayTag Tag, int CountDelta);

		// Token: 0x0601D52F RID: 120111
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnTagAddCallback_Internal(IntPtr @this, IntPtr SkillComp, in FGameplayTag Tag, int CountDelta);

		// Token: 0x0601D530 RID: 120112 RVA: 0x002B4BC6 File Offset: 0x002B2DC6
		static UKSC_Listener_OnTagChange()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Listener_OnTagChange");
		}

		// Token: 0x0601D531 RID: 120113 RVA: 0x002B4BD4 File Offset: 0x002B2DD4
		protected UKSC_Listener_OnTagChange(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FE86 RID: 65158
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Listener_OnTagChange";

		// Token: 0x0400FE87 RID: 65159
		private static IntPtr _ClassPtr;

		// Token: 0x0400FE88 RID: 65160
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FE89 RID: 65161
		internal static int __PropertyOffset_ListenTags;

		// Token: 0x0400FE8A RID: 65162
		[Nullable(2)]
		private FGameplayTagContainer _ListenTags;

		// Token: 0x0400FE8B RID: 65163
		internal static int __PropertyOffset_bListenAdd;

		// Token: 0x0400FE8C RID: 65164
		internal static int __PropertyOffset_bListenRemove;
	}
}
