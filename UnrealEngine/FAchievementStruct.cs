using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000526 RID: 1318
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSDK.AchievementStruct")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FAchievementStruct : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007B11 RID: 31505 RVA: 0x000B4A47 File Offset: 0x000B2C47
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAchievementStruct._ScriptStructPtr != 0) ? FAchievementStruct._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSDK.AchievementStruct", ref FAchievementStruct._ScriptStructPtr);
		}

		// Token: 0x170017EB RID: 6123
		// (get) Token: 0x06007B12 RID: 31506 RVA: 0x000B4A6B File Offset: 0x000B2C6B
		// (set) Token: 0x06007B13 RID: 31507 RVA: 0x000B4A7F File Offset: 0x000B2C7F
		public unsafe string AchievementId
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAchievementStruct.__PropertyOffset_AchievementId)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAchievementStruct.__PropertyOffset_AchievementId)), value);
			}
		}

		// Token: 0x170017EC RID: 6124
		// (get) Token: 0x06007B14 RID: 31508 RVA: 0x000B4A94 File Offset: 0x000B2C94
		// (set) Token: 0x06007B15 RID: 31509 RVA: 0x000B4AA4 File Offset: 0x000B2CA4
		public unsafe float Progress
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAchievementStruct.__PropertyOffset_Progress);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAchievementStruct.__PropertyOffset_Progress) = value;
			}
		}

		// Token: 0x06007B16 RID: 31510 RVA: 0x000B4AB5 File Offset: 0x000B2CB5
		public FAchievementStruct()
		{
		}

		// Token: 0x06007B17 RID: 31511 RVA: 0x000B4ABD File Offset: 0x000B2CBD
		protected override IntPtr GetUStructPtr()
		{
			return FAchievementStruct.StaticStruct();
		}

		// Token: 0x06007B18 RID: 31512 RVA: 0x000B4AC9 File Offset: 0x000B2CC9
		[NullableContext(2)]
		public FAchievementStruct(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007B19 RID: 31513 RVA: 0x000B4AD3 File Offset: 0x000B2CD3
		public FAchievementStruct(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007B1A RID: 31514 RVA: 0x000B4ADE File Offset: 0x000B2CDE
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAchievementStruct(Pointer, false, true);
		}

		// Token: 0x06007B1B RID: 31515 RVA: 0x000B4AE8 File Offset: 0x000B2CE8
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAchievementStruct(Pointer, MemoryOwner);
		}

		// Token: 0x04003452 RID: 13394
		public const string __ObjectPath = "/Script/KuroSDK.AchievementStruct";

		// Token: 0x04003453 RID: 13395
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003454 RID: 13396
		internal static int __PropertyOffset_AchievementId;

		// Token: 0x04003455 RID: 13397
		internal static int __PropertyOffset_Progress;
	}
}
