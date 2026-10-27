using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DF1 RID: 7665
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Listener_DelayTime")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UKSC_Listener_DelayTime : UKSC_EventListener, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D4C1 RID: 120001 RVA: 0x002B4174 File Offset: 0x002B2374
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Listener_DelayTime._ClassPtr;
		}

		// Token: 0x0601D4C2 RID: 120002 RVA: 0x002B4180 File Offset: 0x002B2380
		public UKSC_Listener_DelayTime() : this(BuiltinUtils.AllocNativeUObject(UKSC_Listener_DelayTime.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D4C3 RID: 120003 RVA: 0x002B41A8 File Offset: 0x002B23A8
		[NullableContext(1)]
		public UKSC_Listener_DelayTime(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Listener_DelayTime.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007653 RID: 30291
		// (get) Token: 0x0601D4C4 RID: 120004 RVA: 0x002B41DB File Offset: 0x002B23DB
		// (set) Token: 0x0601D4C5 RID: 120005 RVA: 0x002B41EB File Offset: 0x002B23EB
		public unsafe float DelaySeconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_Listener_DelayTime.__PropertyOffset_DelaySeconds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_Listener_DelayTime.__PropertyOffset_DelaySeconds) = value;
			}
		}

		// Token: 0x0601D4C6 RID: 120006 RVA: 0x002B41FC File Offset: 0x002B23FC
		public void OnDelayFinished()
		{
			UKSC_Listener_DelayTime.__OnDelayFinished_Internal(base.NativePtr);
		}

		// Token: 0x0601D4C7 RID: 120007
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnDelayFinished_Internal(IntPtr @this);

		// Token: 0x0601D4C8 RID: 120008 RVA: 0x002B4209 File Offset: 0x002B2409
		static UKSC_Listener_DelayTime()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Listener_DelayTime");
		}

		// Token: 0x0601D4C9 RID: 120009 RVA: 0x002B4217 File Offset: 0x002B2417
		protected UKSC_Listener_DelayTime(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FE56 RID: 65110
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Listener_DelayTime";

		// Token: 0x0400FE57 RID: 65111
		private static IntPtr _ClassPtr;

		// Token: 0x0400FE58 RID: 65112
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FE59 RID: 65113
		internal static int __PropertyOffset_DelaySeconds;
	}
}
