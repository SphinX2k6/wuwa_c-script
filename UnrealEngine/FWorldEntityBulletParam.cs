using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001738 RID: 5944
	[UnrealObjectPath("/Script/KuroBullet.WorldEntityBulletParam")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FWorldEntityBulletParam : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601564B RID: 87627 RVA: 0x001F6ED9 File Offset: 0x001F50D9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWorldEntityBulletParam._ScriptStructPtr != 0) ? FWorldEntityBulletParam._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroBullet.WorldEntityBulletParam", ref FWorldEntityBulletParam._ScriptStructPtr);
		}

		// Token: 0x17005485 RID: 21637
		// (get) Token: 0x0601564C RID: 87628 RVA: 0x001F6EFD File Offset: 0x001F50FD
		// (set) Token: 0x0601564D RID: 87629 RVA: 0x001F6F0D File Offset: 0x001F510D
		public unsafe long MessageId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWorldEntityBulletParam.__PropertyOffset_MessageId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWorldEntityBulletParam.__PropertyOffset_MessageId) = value;
			}
		}

		// Token: 0x17005486 RID: 21638
		// (get) Token: 0x0601564E RID: 87630 RVA: 0x001F6F1E File Offset: 0x001F511E
		// (set) Token: 0x0601564F RID: 87631 RVA: 0x001F6F2E File Offset: 0x001F512E
		public unsafe int SkillId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWorldEntityBulletParam.__PropertyOffset_SkillId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWorldEntityBulletParam.__PropertyOffset_SkillId) = value;
			}
		}

		// Token: 0x17005487 RID: 21639
		// (get) Token: 0x06015650 RID: 87632 RVA: 0x001F6F3F File Offset: 0x001F513F
		// (set) Token: 0x06015651 RID: 87633 RVA: 0x001F6F4F File Offset: 0x001F514F
		public unsafe long SkillMessageId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWorldEntityBulletParam.__PropertyOffset_SkillMessageId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWorldEntityBulletParam.__PropertyOffset_SkillMessageId) = value;
			}
		}

		// Token: 0x06015652 RID: 87634 RVA: 0x001F6F60 File Offset: 0x001F5160
		public FWorldEntityBulletParam()
		{
		}

		// Token: 0x06015653 RID: 87635 RVA: 0x001F6F68 File Offset: 0x001F5168
		public FWorldEntityBulletParam(long MessageId, int SkillId, long SkillMessageId)
		{
			this.MessageId = MessageId;
			this.SkillId = SkillId;
			this.SkillMessageId = SkillMessageId;
		}

		// Token: 0x06015654 RID: 87636 RVA: 0x001F6F85 File Offset: 0x001F5185
		protected override IntPtr GetUStructPtr()
		{
			return FWorldEntityBulletParam.StaticStruct();
		}

		// Token: 0x06015655 RID: 87637 RVA: 0x001F6F91 File Offset: 0x001F5191
		[NullableContext(2)]
		public FWorldEntityBulletParam(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06015656 RID: 87638 RVA: 0x001F6F9B File Offset: 0x001F519B
		public FWorldEntityBulletParam(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06015657 RID: 87639 RVA: 0x001F6FA6 File Offset: 0x001F51A6
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWorldEntityBulletParam(Pointer, false, true);
		}

		// Token: 0x06015658 RID: 87640 RVA: 0x001F6FB0 File Offset: 0x001F51B0
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWorldEntityBulletParam(Pointer, MemoryOwner);
		}

		// Token: 0x0400BAAA RID: 47786
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroBullet.WorldEntityBulletParam";

		// Token: 0x0400BAAB RID: 47787
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400BAAC RID: 47788
		internal static int __PropertyOffset_MessageId;

		// Token: 0x0400BAAD RID: 47789
		internal static int __PropertyOffset_SkillId;

		// Token: 0x0400BAAE RID: 47790
		internal static int __PropertyOffset_SkillMessageId;
	}
}
