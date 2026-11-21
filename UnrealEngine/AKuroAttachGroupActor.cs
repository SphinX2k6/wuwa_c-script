using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000525 RID: 1317
	[UnrealObjectPath("/Script/KuroScene.KuroAttachGroupActor")]
	[UnrealStructLayout(1152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1152)]
	public class AKuroAttachGroupActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007AFC RID: 31484 RVA: 0x000B4924 File Offset: 0x000B2B24
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroAttachGroupActor._ClassPtr;
		}

		// Token: 0x06007AFD RID: 31485 RVA: 0x000B4930 File Offset: 0x000B2B30
		public AKuroAttachGroupActor() : this(BuiltinUtils.AllocNativeUObject(AKuroAttachGroupActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007AFE RID: 31486 RVA: 0x000B4958 File Offset: 0x000B2B58
		[NullableContext(1)]
		public AKuroAttachGroupActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroAttachGroupActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170017E8 RID: 6120
		// (get) Token: 0x06007AFF RID: 31487 RVA: 0x000B498B File Offset: 0x000B2B8B
		// (set) Token: 0x06007B00 RID: 31488 RVA: 0x000B499B File Offset: 0x000B2B9B
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

		// Token: 0x170017E9 RID: 6121
		// (get) Token: 0x06007B01 RID: 31489 RVA: 0x000B49AC File Offset: 0x000B2BAC
		// (set) Token: 0x06007B02 RID: 31490 RVA: 0x000B49BC File Offset: 0x000B2BBC
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

		// Token: 0x170017EA RID: 6122
		// (get) Token: 0x06007B03 RID: 31491 RVA: 0x000B49CD File Offset: 0x000B2BCD
		// (set) Token: 0x06007B04 RID: 31492 RVA: 0x000B49DD File Offset: 0x000B2BDD
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

		// Token: 0x06007B05 RID: 31493 RVA: 0x000B49EE File Offset: 0x000B2BEE
		public void ShowGroup()
		{
			AKuroAttachGroupActor.__ShowGroup_Internal(base.NativePtr);
		}

		// Token: 0x06007B06 RID: 31494 RVA: 0x000B49FB File Offset: 0x000B2BFB
		public void SetGroupHidden(bool bInHidden)
		{
			AKuroAttachGroupActor.__SetGroupHidden_Internal(base.NativePtr, bInHidden);
		}

		// Token: 0x06007B07 RID: 31495 RVA: 0x000B4A09 File Offset: 0x000B2C09
		public virtual void OnGroupShown()
		{
			AKuroAttachGroupActor.__OnGroupShown_Internal(base.NativePtr);
		}

		// Token: 0x06007B08 RID: 31496 RVA: 0x000B4A16 File Offset: 0x000B2C16
		public virtual void OnGroupHidden()
		{
			AKuroAttachGroupActor.__OnGroupHidden_Internal(base.NativePtr);
		}

		// Token: 0x06007B09 RID: 31497 RVA: 0x000B4A23 File Offset: 0x000B2C23
		public void HideGroup()
		{
			AKuroAttachGroupActor.__HideGroup_Internal(base.NativePtr);
		}

		// Token: 0x06007B0A RID: 31498
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ShowGroup_Internal(IntPtr @this);

		// Token: 0x06007B0B RID: 31499
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGroupHidden_Internal(IntPtr @this, bool bInHidden);

		// Token: 0x06007B0C RID: 31500
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnGroupShown_Internal(IntPtr @this);

		// Token: 0x06007B0D RID: 31501
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnGroupHidden_Internal(IntPtr @this);

		// Token: 0x06007B0E RID: 31502
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __HideGroup_Internal(IntPtr @this);

		// Token: 0x06007B0F RID: 31503 RVA: 0x000B4A30 File Offset: 0x000B2C30
		static AKuroAttachGroupActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroScene.KuroAttachGroupActor");
		}

		// Token: 0x06007B10 RID: 31504 RVA: 0x000B4A3E File Offset: 0x000B2C3E
		protected AKuroAttachGroupActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400344C RID: 13388
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroScene.KuroAttachGroupActor";

		// Token: 0x0400344D RID: 13389
		private static IntPtr _ClassPtr;

		// Token: 0x0400344E RID: 13390
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400344F RID: 13391
		internal static int __PropertyOffset_bRecursiveDescendants;

		// Token: 0x04003450 RID: 13392
		internal static int __PropertyOffset_bManageCollision;

		// Token: 0x04003451 RID: 13393
		internal static int __PropertyOffset_bIsGroupHidden;
	}
}
