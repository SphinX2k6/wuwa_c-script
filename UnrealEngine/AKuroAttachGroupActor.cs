using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C8B RID: 7307
	[UnrealObjectPath("/Script/KuroScene.KuroAttachGroupActor")]
	[UnrealStructLayout(1152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1152)]
	public class AKuroAttachGroupActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C5B4 RID: 116148 RVA: 0x0029CDA0 File Offset: 0x0029AFA0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroAttachGroupActor._ClassPtr;
		}

		// Token: 0x0601C5B5 RID: 116149 RVA: 0x0029CDAC File Offset: 0x0029AFAC
		public AKuroAttachGroupActor() : this(BuiltinUtils.AllocNativeUObject(AKuroAttachGroupActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C5B6 RID: 116150 RVA: 0x0029CDD4 File Offset: 0x0029AFD4
		[NullableContext(1)]
		public AKuroAttachGroupActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroAttachGroupActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007297 RID: 29335
		// (get) Token: 0x0601C5B7 RID: 116151 RVA: 0x0029CE07 File Offset: 0x0029B007
		// (set) Token: 0x0601C5B8 RID: 116152 RVA: 0x0029CE17 File Offset: 0x0029B017
		public unsafe bool bRecursiveDescendants
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroAttachGroupActor.__PropertyOffset_bRecursiveDescendants) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroAttachGroupActor.__PropertyOffset_bRecursiveDescendants) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007298 RID: 29336
		// (get) Token: 0x0601C5B9 RID: 116153 RVA: 0x0029CE28 File Offset: 0x0029B028
		// (set) Token: 0x0601C5BA RID: 116154 RVA: 0x0029CE38 File Offset: 0x0029B038
		public unsafe bool bManageCollision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroAttachGroupActor.__PropertyOffset_bManageCollision) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroAttachGroupActor.__PropertyOffset_bManageCollision) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007299 RID: 29337
		// (get) Token: 0x0601C5BB RID: 116155 RVA: 0x0029CE49 File Offset: 0x0029B049
		// (set) Token: 0x0601C5BC RID: 116156 RVA: 0x0029CE59 File Offset: 0x0029B059
		public unsafe bool bIsGroupHidden
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroAttachGroupActor.__PropertyOffset_bIsGroupHidden) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroAttachGroupActor.__PropertyOffset_bIsGroupHidden) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700729A RID: 29338
		// (get) Token: 0x0601C5BD RID: 116157 RVA: 0x0029CE6A File Offset: 0x0029B06A
		// (set) Token: 0x0601C5BE RID: 116158 RVA: 0x0029CE7E File Offset: 0x0029B07E
		[Nullable(2)]
		public unsafe UKuroAttachGroupRootComponent GroupRootComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroAttachGroupRootComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroAttachGroupActor.__PropertyOffset_GroupRootComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroAttachGroupActor.__PropertyOffset_GroupRootComponent, value);
			}
		}

		// Token: 0x0601C5BF RID: 116159 RVA: 0x0029CE93 File Offset: 0x0029B093
		public void ShowGroup()
		{
			AKuroAttachGroupActor.__ShowGroup_Internal(base.NativePtr);
		}

		// Token: 0x0601C5C0 RID: 116160 RVA: 0x0029CEA0 File Offset: 0x0029B0A0
		public void SetGroupHidden(bool bInHidden)
		{
			AKuroAttachGroupActor.__SetGroupHidden_Internal(base.NativePtr, bInHidden);
		}

		// Token: 0x0601C5C1 RID: 116161 RVA: 0x0029CEAE File Offset: 0x0029B0AE
		public virtual void OnGroupShown()
		{
			AKuroAttachGroupActor.__OnGroupShown_Internal(base.NativePtr);
		}

		// Token: 0x0601C5C2 RID: 116162 RVA: 0x0029CEBB File Offset: 0x0029B0BB
		public virtual void OnGroupHidden()
		{
			AKuroAttachGroupActor.__OnGroupHidden_Internal(base.NativePtr);
		}

		// Token: 0x0601C5C3 RID: 116163 RVA: 0x0029CEC8 File Offset: 0x0029B0C8
		public void HideGroup()
		{
			AKuroAttachGroupActor.__HideGroup_Internal(base.NativePtr);
		}

		// Token: 0x0601C5C4 RID: 116164
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ShowGroup_Internal(IntPtr @this);

		// Token: 0x0601C5C5 RID: 116165
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGroupHidden_Internal(IntPtr @this, bool bInHidden);

		// Token: 0x0601C5C6 RID: 116166
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnGroupShown_Internal(IntPtr @this);

		// Token: 0x0601C5C7 RID: 116167
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnGroupHidden_Internal(IntPtr @this);

		// Token: 0x0601C5C8 RID: 116168
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __HideGroup_Internal(IntPtr @this);

		// Token: 0x0601C5C9 RID: 116169 RVA: 0x0029CED5 File Offset: 0x0029B0D5
		static AKuroAttachGroupActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroScene.KuroAttachGroupActor");
		}

		// Token: 0x0601C5CA RID: 116170 RVA: 0x0029CEE3 File Offset: 0x0029B0E3
		protected AKuroAttachGroupActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F3DE RID: 62430
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroScene.KuroAttachGroupActor";

		// Token: 0x0400F3DF RID: 62431
		private static IntPtr _ClassPtr;

		// Token: 0x0400F3E0 RID: 62432
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F3E1 RID: 62433
		internal static int __PropertyOffset_bRecursiveDescendants;

		// Token: 0x0400F3E2 RID: 62434
		internal static int __PropertyOffset_bManageCollision;

		// Token: 0x0400F3E3 RID: 62435
		internal static int __PropertyOffset_bIsGroupHidden;

		// Token: 0x0400F3E4 RID: 62436
		internal static int __PropertyOffset_GroupRootComponent;
	}
}
