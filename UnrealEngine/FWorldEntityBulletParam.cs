using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000338 RID: 824
	[UnrealObjectPath("/Script/KuroBullet.WorldEntityBulletParam")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FWorldEntityBulletParam : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005593 RID: 21907 RVA: 0x00077AD5 File Offset: 0x00075CD5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWorldEntityBulletParam._ScriptStructPtr != 0) ? FWorldEntityBulletParam._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroBullet.WorldEntityBulletParam", ref FWorldEntityBulletParam._ScriptStructPtr);
		}

		// Token: 0x170010DE RID: 4318
		// (get) Token: 0x06005594 RID: 21908 RVA: 0x00077AF9 File Offset: 0x00075CF9
		// (set) Token: 0x06005595 RID: 21909 RVA: 0x00077B09 File Offset: 0x00075D09
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

		// Token: 0x170010DF RID: 4319
		// (get) Token: 0x06005596 RID: 21910 RVA: 0x00077B1A File Offset: 0x00075D1A
		// (set) Token: 0x06005597 RID: 21911 RVA: 0x00077B2A File Offset: 0x00075D2A
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

		// Token: 0x170010E0 RID: 4320
		// (get) Token: 0x06005598 RID: 21912 RVA: 0x00077B3B File Offset: 0x00075D3B
		// (set) Token: 0x06005599 RID: 21913 RVA: 0x00077B4B File Offset: 0x00075D4B
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

		// Token: 0x0600559A RID: 21914 RVA: 0x00077B5C File Offset: 0x00075D5C
		public FWorldEntityBulletParam()
		{
		}

		// Token: 0x0600559B RID: 21915 RVA: 0x00077B64 File Offset: 0x00075D64
		protected override IntPtr GetUStructPtr()
		{
			return FWorldEntityBulletParam.StaticStruct();
		}

		// Token: 0x0600559C RID: 21916 RVA: 0x00077B70 File Offset: 0x00075D70
		[NullableContext(2)]
		public FWorldEntityBulletParam(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600559D RID: 21917 RVA: 0x00077B7A File Offset: 0x00075D7A
		public FWorldEntityBulletParam(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600559E RID: 21918 RVA: 0x00077B85 File Offset: 0x00075D85
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWorldEntityBulletParam(Pointer, false, true);
		}

		// Token: 0x0600559F RID: 21919 RVA: 0x00077B8F File Offset: 0x00075D8F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWorldEntityBulletParam(Pointer, MemoryOwner);
		}

		// Token: 0x040022FB RID: 8955
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroBullet.WorldEntityBulletParam";

		// Token: 0x040022FC RID: 8956
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040022FD RID: 8957
		internal static int __PropertyOffset_MessageId;

		// Token: 0x040022FE RID: 8958
		internal static int __PropertyOffset_SkillId;

		// Token: 0x040022FF RID: 8959
		internal static int __PropertyOffset_SkillMessageId;
	}
}
