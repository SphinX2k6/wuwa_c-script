using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020007E1 RID: 2017
	[UnrealObjectPath("/Script/Engine.AnimationGroupReference")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FAnimationGroupReference : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006B68 RID: 27496 RVA: 0x0009A9A1 File Offset: 0x00098BA1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimationGroupReference._ScriptStructPtr != 0) ? FAnimationGroupReference._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimationGroupReference", ref FAnimationGroupReference._ScriptStructPtr);
		}

		// Token: 0x17001942 RID: 6466
		// (get) Token: 0x06006B69 RID: 27497 RVA: 0x0009A9C5 File Offset: 0x00098BC5
		// (set) Token: 0x06006B6A RID: 27498 RVA: 0x0009A9D9 File Offset: 0x00098BD9
		public unsafe FName GroupName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimationGroupReference.__PropertyOffset_GroupName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimationGroupReference.__PropertyOffset_GroupName) = value;
			}
		}

		// Token: 0x17001943 RID: 6467
		// (get) Token: 0x06006B6B RID: 27499 RVA: 0x0009A9EE File Offset: 0x00098BEE
		// (set) Token: 0x06006B6C RID: 27500 RVA: 0x0009AA02 File Offset: 0x00098C02
		public unsafe TEnumAsByte<EAnimGroupRole> GroupRole
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimationGroupReference.__PropertyOffset_GroupRole);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimationGroupReference.__PropertyOffset_GroupRole) = value;
			}
		}

		// Token: 0x17001944 RID: 6468
		// (get) Token: 0x06006B6D RID: 27501 RVA: 0x0009AA17 File Offset: 0x00098C17
		// (set) Token: 0x06006B6E RID: 27502 RVA: 0x0009AA27 File Offset: 0x00098C27
		public unsafe EAnimSyncGroupScope GroupScope
		{
			get
			{
				return (EAnimSyncGroupScope)(*(base.NativePtr + (IntPtr)FAnimationGroupReference.__PropertyOffset_GroupScope));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimationGroupReference.__PropertyOffset_GroupScope) = (byte)value;
			}
		}

		// Token: 0x06006B6F RID: 27503 RVA: 0x0009AA38 File Offset: 0x00098C38
		public FAnimationGroupReference()
		{
		}

		// Token: 0x06006B70 RID: 27504 RVA: 0x0009AA40 File Offset: 0x00098C40
		public FAnimationGroupReference(FName GroupName, TEnumAsByte<EAnimGroupRole> GroupRole, EAnimSyncGroupScope GroupScope)
		{
			this.GroupName = GroupName;
			this.GroupRole = GroupRole;
			this.GroupScope = GroupScope;
		}

		// Token: 0x06006B71 RID: 27505 RVA: 0x0009AA5D File Offset: 0x00098C5D
		protected override IntPtr GetUStructPtr()
		{
			return FAnimationGroupReference.StaticStruct();
		}

		// Token: 0x06006B72 RID: 27506 RVA: 0x0009AA69 File Offset: 0x00098C69
		[NullableContext(2)]
		public FAnimationGroupReference(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006B73 RID: 27507 RVA: 0x0009AA73 File Offset: 0x00098C73
		public FAnimationGroupReference(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006B74 RID: 27508 RVA: 0x0009AA7E File Offset: 0x00098C7E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimationGroupReference(Pointer, false, true);
		}

		// Token: 0x06006B75 RID: 27509 RVA: 0x0009AA88 File Offset: 0x00098C88
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimationGroupReference(Pointer, MemoryOwner);
		}

		// Token: 0x040033B0 RID: 13232
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.AnimationGroupReference";

		// Token: 0x040033B1 RID: 13233
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040033B2 RID: 13234
		internal static int __PropertyOffset_GroupName;

		// Token: 0x040033B3 RID: 13235
		internal static int __PropertyOffset_GroupRole;

		// Token: 0x040033B4 RID: 13236
		internal static int __PropertyOffset_GroupScope;
	}
}
