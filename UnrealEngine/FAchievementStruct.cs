using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001C8D RID: 7309
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSDK.AchievementStruct")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FAchievementStruct : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601C5D0 RID: 116176 RVA: 0x0029CF6A File Offset: 0x0029B16A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAchievementStruct._ScriptStructPtr != 0) ? FAchievementStruct._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSDK.AchievementStruct", ref FAchievementStruct._ScriptStructPtr);
		}

		// Token: 0x1700729B RID: 29339
		// (get) Token: 0x0601C5D1 RID: 116177 RVA: 0x0029CF8E File Offset: 0x0029B18E
		// (set) Token: 0x0601C5D2 RID: 116178 RVA: 0x0029CFA2 File Offset: 0x0029B1A2
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

		// Token: 0x1700729C RID: 29340
		// (get) Token: 0x0601C5D3 RID: 116179 RVA: 0x0029CFB7 File Offset: 0x0029B1B7
		// (set) Token: 0x0601C5D4 RID: 116180 RVA: 0x0029CFC7 File Offset: 0x0029B1C7
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

		// Token: 0x0601C5D5 RID: 116181 RVA: 0x0029CFD8 File Offset: 0x0029B1D8
		public FAchievementStruct()
		{
		}

		// Token: 0x0601C5D6 RID: 116182 RVA: 0x0029CFE0 File Offset: 0x0029B1E0
		public FAchievementStruct(string AchievementId, float Progress)
		{
			this.AchievementId = AchievementId;
			this.Progress = Progress;
		}

		// Token: 0x0601C5D7 RID: 116183 RVA: 0x0029CFF6 File Offset: 0x0029B1F6
		protected override IntPtr GetUStructPtr()
		{
			return FAchievementStruct.StaticStruct();
		}

		// Token: 0x0601C5D8 RID: 116184 RVA: 0x0029D002 File Offset: 0x0029B202
		[NullableContext(2)]
		public FAchievementStruct(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C5D9 RID: 116185 RVA: 0x0029D00C File Offset: 0x0029B20C
		public FAchievementStruct(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C5DA RID: 116186 RVA: 0x0029D017 File Offset: 0x0029B217
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAchievementStruct(Pointer, false, true);
		}

		// Token: 0x0601C5DB RID: 116187 RVA: 0x0029D021 File Offset: 0x0029B221
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAchievementStruct(Pointer, MemoryOwner);
		}

		// Token: 0x0400F3E8 RID: 62440
		public const string __ObjectPath = "/Script/KuroSDK.AchievementStruct";

		// Token: 0x0400F3E9 RID: 62441
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400F3EA RID: 62442
		internal static int __PropertyOffset_AchievementId;

		// Token: 0x0400F3EB RID: 62443
		internal static int __PropertyOffset_Progress;
	}
}
