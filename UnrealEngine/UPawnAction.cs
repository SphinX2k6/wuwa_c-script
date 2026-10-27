using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001D4 RID: 468
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.PawnAction")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public abstract class UPawnAction : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001B96 RID: 7062 RVA: 0x0002926E File Offset: 0x0002746E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPawnAction._ClassPtr;
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x06001B97 RID: 7063 RVA: 0x0002927A File Offset: 0x0002747A
		// (set) Token: 0x06001B98 RID: 7064 RVA: 0x0002928E File Offset: 0x0002748E
		public unsafe UPawnAction ChildAction
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPawnAction>(base.NativePtr / (IntPtr)sizeof(void*) + UPawnAction.__PropertyOffset_ChildAction);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UPawnAction.__PropertyOffset_ChildAction, value);
			}
		}

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x06001B99 RID: 7065 RVA: 0x000292A3 File Offset: 0x000274A3
		// (set) Token: 0x06001B9A RID: 7066 RVA: 0x000292B7 File Offset: 0x000274B7
		public unsafe UPawnAction ParentAction
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPawnAction>(base.NativePtr / (IntPtr)sizeof(void*) + UPawnAction.__PropertyOffset_ParentAction);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UPawnAction.__PropertyOffset_ParentAction, value);
			}
		}

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x06001B9B RID: 7067 RVA: 0x000292CC File Offset: 0x000274CC
		// (set) Token: 0x06001B9C RID: 7068 RVA: 0x000292E0 File Offset: 0x000274E0
		public unsafe UPawnActionsComponent OwnerComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPawnActionsComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UPawnAction.__PropertyOffset_OwnerComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UPawnAction.__PropertyOffset_OwnerComponent, value);
			}
		}

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x06001B9D RID: 7069 RVA: 0x000292F5 File Offset: 0x000274F5
		// (set) Token: 0x06001B9E RID: 7070 RVA: 0x00029309 File Offset: 0x00027509
		public unsafe UObject Instigator
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + UPawnAction.__PropertyOffset_Instigator);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UPawnAction.__PropertyOffset_Instigator, value);
			}
		}

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x06001B9F RID: 7071 RVA: 0x0002931E File Offset: 0x0002751E
		// (set) Token: 0x06001BA0 RID: 7072 RVA: 0x00029332 File Offset: 0x00027532
		public unsafe UBrainComponent BrainComp
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBrainComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UPawnAction.__PropertyOffset_BrainComp);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UPawnAction.__PropertyOffset_BrainComp, value);
			}
		}

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x06001BA1 RID: 7073 RVA: 0x00029347 File Offset: 0x00027547
		// (set) Token: 0x06001BA2 RID: 7074 RVA: 0x00029360 File Offset: 0x00027560
		public unsafe bool bAllowNewSameClassInstance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPawnAction.__PropertyOffset_bAllowNewSameClassInstance) & UPawnAction.__PropertyMask_bAllowNewSameClassInstance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPawnAction.__PropertyOffset_bAllowNewSameClassInstance) = ((*(base.NativePtr + (IntPtr)UPawnAction.__PropertyOffset_bAllowNewSameClassInstance) & ~UPawnAction.__PropertyMask_bAllowNewSameClassInstance) | (value ? UPawnAction.__PropertyMask_bAllowNewSameClassInstance : 0));
			}
		}

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x06001BA3 RID: 7075 RVA: 0x00029390 File Offset: 0x00027590
		// (set) Token: 0x06001BA4 RID: 7076 RVA: 0x000293A9 File Offset: 0x000275A9
		public unsafe bool bReplaceActiveSameClassInstance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPawnAction.__PropertyOffset_bReplaceActiveSameClassInstance) & UPawnAction.__PropertyMask_bReplaceActiveSameClassInstance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPawnAction.__PropertyOffset_bReplaceActiveSameClassInstance) = ((*(base.NativePtr + (IntPtr)UPawnAction.__PropertyOffset_bReplaceActiveSameClassInstance) & ~UPawnAction.__PropertyMask_bReplaceActiveSameClassInstance) | (value ? UPawnAction.__PropertyMask_bReplaceActiveSameClassInstance : 0));
			}
		}

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x06001BA5 RID: 7077 RVA: 0x000293D9 File Offset: 0x000275D9
		// (set) Token: 0x06001BA6 RID: 7078 RVA: 0x000293F2 File Offset: 0x000275F2
		public unsafe bool bShouldPauseMovement
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPawnAction.__PropertyOffset_bShouldPauseMovement) & UPawnAction.__PropertyMask_bShouldPauseMovement) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPawnAction.__PropertyOffset_bShouldPauseMovement) = ((*(base.NativePtr + (IntPtr)UPawnAction.__PropertyOffset_bShouldPauseMovement) & ~UPawnAction.__PropertyMask_bShouldPauseMovement) | (value ? UPawnAction.__PropertyMask_bShouldPauseMovement : 0));
			}
		}

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x06001BA7 RID: 7079 RVA: 0x00029422 File Offset: 0x00027622
		// (set) Token: 0x06001BA8 RID: 7080 RVA: 0x0002943B File Offset: 0x0002763B
		public unsafe bool bAlwaysNotifyOnFinished
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPawnAction.__PropertyOffset_bAlwaysNotifyOnFinished) & UPawnAction.__PropertyMask_bAlwaysNotifyOnFinished) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPawnAction.__PropertyOffset_bAlwaysNotifyOnFinished) = ((*(base.NativePtr + (IntPtr)UPawnAction.__PropertyOffset_bAlwaysNotifyOnFinished) & ~UPawnAction.__PropertyMask_bAlwaysNotifyOnFinished) | (value ? UPawnAction.__PropertyMask_bAlwaysNotifyOnFinished : 0));
			}
		}

		// Token: 0x06001BA9 RID: 7081 RVA: 0x0002946B File Offset: 0x0002766B
		[NullableContext(0)]
		public TEnumAsByte<EAIRequestPriority> GetActionPriority()
		{
			return UPawnAction.__GetActionPriority_Internal(base.NativePtr);
		}

		// Token: 0x06001BAA RID: 7082 RVA: 0x00029478 File Offset: 0x00027678
		public void Finish(EPawnActionResult WithResult)
		{
			UPawnAction.__Finish_Internal(base.NativePtr, WithResult);
		}

		// Token: 0x06001BAB RID: 7083 RVA: 0x0002948B File Offset: 0x0002768B
		public static UPawnAction CreateActionInstance(UObject WorldContextObject, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UPawnAction> ActionClass)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UPawnAction>(UPawnAction.__CreateActionInstance_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, ActionClass._NativePtr));
		}

		// Token: 0x06001BAC RID: 7084
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TEnumAsByte<EAIRequestPriority> __GetActionPriority_Internal(IntPtr @this);

		// Token: 0x06001BAD RID: 7085
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Finish_Internal(IntPtr @this, TEnumAsByte<EPawnActionResult> WithResult);

		// Token: 0x06001BAE RID: 7086
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateActionInstance_Internal(IntPtr WorldContextObject, IntPtr ActionClass);

		// Token: 0x06001BAF RID: 7087 RVA: 0x000294AD File Offset: 0x000276AD
		static UPawnAction()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.PawnAction");
		}

		// Token: 0x06001BB0 RID: 7088 RVA: 0x000294BC File Offset: 0x000276BC
		protected UPawnAction() : this(BuiltinUtils.AllocNativeUObject(UPawnAction.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001BB1 RID: 7089 RVA: 0x000294E4 File Offset: 0x000276E4
		protected UPawnAction(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040008D8 RID: 2264
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.PawnAction";

		// Token: 0x040008D9 RID: 2265
		private static IntPtr _ClassPtr;

		// Token: 0x040008DA RID: 2266
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040008DB RID: 2267
		internal static int __PropertyOffset_ChildAction;

		// Token: 0x040008DC RID: 2268
		internal static int __PropertyOffset_ParentAction;

		// Token: 0x040008DD RID: 2269
		internal static int __PropertyOffset_OwnerComponent;

		// Token: 0x040008DE RID: 2270
		internal static int __PropertyOffset_Instigator;

		// Token: 0x040008DF RID: 2271
		internal static int __PropertyOffset_BrainComp;

		// Token: 0x040008E0 RID: 2272
		internal static int __PropertyOffset_bAllowNewSameClassInstance;

		// Token: 0x040008E1 RID: 2273
		internal static byte __PropertyMask_bAllowNewSameClassInstance;

		// Token: 0x040008E2 RID: 2274
		internal static int __PropertyOffset_bReplaceActiveSameClassInstance;

		// Token: 0x040008E3 RID: 2275
		internal static byte __PropertyMask_bReplaceActiveSameClassInstance;

		// Token: 0x040008E4 RID: 2276
		internal static int __PropertyOffset_bShouldPauseMovement;

		// Token: 0x040008E5 RID: 2277
		internal static byte __PropertyMask_bShouldPauseMovement;

		// Token: 0x040008E6 RID: 2278
		internal static int __PropertyOffset_bAlwaysNotifyOnFinished;

		// Token: 0x040008E7 RID: 2279
		internal static byte __PropertyMask_bAlwaysNotifyOnFinished;
	}
}
