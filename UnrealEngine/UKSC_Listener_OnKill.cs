using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DF9 RID: 7673
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Listener_OnKill")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UKSC_Listener_OnKill : UKSC_EventListener, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D50F RID: 120079 RVA: 0x002B48AC File Offset: 0x002B2AAC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Listener_OnKill._ClassPtr;
		}

		// Token: 0x0601D510 RID: 120080 RVA: 0x002B48B8 File Offset: 0x002B2AB8
		public UKSC_Listener_OnKill() : this(BuiltinUtils.AllocNativeUObject(UKSC_Listener_OnKill.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D511 RID: 120081 RVA: 0x002B48E0 File Offset: 0x002B2AE0
		public UKSC_Listener_OnKill(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Listener_OnKill.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700765E RID: 30302
		// (get) Token: 0x0601D512 RID: 120082 RVA: 0x002B4914 File Offset: 0x002B2B14
		// (set) Token: 0x0601D513 RID: 120083 RVA: 0x002B494D File Offset: 0x002B2B4D
		public FKSC_TagFilter TargetTagFilter
		{
			get
			{
				base.FastCheckIsValid();
				FKSC_TagFilter result;
				if ((result = this._TargetTagFilter) == null)
				{
					result = (this._TargetTagFilter = new FKSC_TagFilter(base.NativePtr + (IntPtr)UKSC_Listener_OnKill.__PropertyOffset_TargetTagFilter, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKSC_TagFilter.StaticStruct(), base.NativePtr + (IntPtr)UKSC_Listener_OnKill.__PropertyOffset_TargetTagFilter, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700765F RID: 30303
		// (get) Token: 0x0601D514 RID: 120084 RVA: 0x002B496E File Offset: 0x002B2B6E
		// (set) Token: 0x0601D515 RID: 120085 RVA: 0x002B497E File Offset: 0x002B2B7E
		public unsafe EKSC_Event_HitTarget CheckTarget
		{
			get
			{
				return (EKSC_Event_HitTarget)(*(base.NativePtr + (IntPtr)UKSC_Listener_OnKill.__PropertyOffset_CheckTarget));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_Listener_OnKill.__PropertyOffset_CheckTarget) = (byte)value;
			}
		}

		// Token: 0x0601D516 RID: 120086 RVA: 0x002B498F File Offset: 0x002B2B8F
		[NullableContext(2)]
		public void OnKillCallback(UKSC_SkillComp FromComp, UKSC_SkillComp DeadComp)
		{
			UKSC_Listener_OnKill.__OnKillCallback_Internal(base.NativePtr, (FromComp != null) ? FromComp.NativePtr : IntPtr.Zero, (DeadComp != null) ? DeadComp.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601D517 RID: 120087
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnKillCallback_Internal(IntPtr @this, IntPtr FromComp, IntPtr DeadComp);

		// Token: 0x0601D518 RID: 120088 RVA: 0x002B49BC File Offset: 0x002B2BBC
		static UKSC_Listener_OnKill()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Listener_OnKill");
		}

		// Token: 0x0601D519 RID: 120089 RVA: 0x002B49CA File Offset: 0x002B2BCA
		protected UKSC_Listener_OnKill(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FE7C RID: 65148
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Listener_OnKill";

		// Token: 0x0400FE7D RID: 65149
		private static IntPtr _ClassPtr;

		// Token: 0x0400FE7E RID: 65150
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FE7F RID: 65151
		internal static int __PropertyOffset_TargetTagFilter;

		// Token: 0x0400FE80 RID: 65152
		[Nullable(2)]
		private FKSC_TagFilter _TargetTagFilter;

		// Token: 0x0400FE81 RID: 65153
		internal static int __PropertyOffset_CheckTarget;
	}
}
