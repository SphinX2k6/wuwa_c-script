using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000BE2 RID: 3042
	[UnrealObjectPath("/Script/Engine.FoldedBoneInfo")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FFoldedBoneInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060095A6 RID: 38310 RVA: 0x000D564E File Offset: 0x000D384E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFoldedBoneInfo._ScriptStructPtr != 0) ? FFoldedBoneInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.FoldedBoneInfo", ref FFoldedBoneInfo._ScriptStructPtr);
		}

		// Token: 0x170023D2 RID: 9170
		// (get) Token: 0x060095A7 RID: 38311 RVA: 0x000D5672 File Offset: 0x000D3872
		// (set) Token: 0x060095A8 RID: 38312 RVA: 0x000D5682 File Offset: 0x000D3882
		public unsafe ushort BoneIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFoldedBoneInfo.__PropertyOffset_BoneIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFoldedBoneInfo.__PropertyOffset_BoneIndex) = (short)value;
			}
		}

		// Token: 0x170023D3 RID: 9171
		// (get) Token: 0x060095A9 RID: 38313 RVA: 0x000D5693 File Offset: 0x000D3893
		// (set) Token: 0x060095AA RID: 38314 RVA: 0x000D56A7 File Offset: 0x000D38A7
		public unsafe FName BoneName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFoldedBoneInfo.__PropertyOffset_BoneName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFoldedBoneInfo.__PropertyOffset_BoneName) = value;
			}
		}

		// Token: 0x060095AB RID: 38315 RVA: 0x000D56BC File Offset: 0x000D38BC
		public FFoldedBoneInfo()
		{
		}

		// Token: 0x060095AC RID: 38316 RVA: 0x000D56C4 File Offset: 0x000D38C4
		public FFoldedBoneInfo(ushort BoneIndex, FName BoneName)
		{
			this.BoneIndex = BoneIndex;
			this.BoneName = BoneName;
		}

		// Token: 0x060095AD RID: 38317 RVA: 0x000D56DA File Offset: 0x000D38DA
		protected override IntPtr GetUStructPtr()
		{
			return FFoldedBoneInfo.StaticStruct();
		}

		// Token: 0x060095AE RID: 38318 RVA: 0x000D56E6 File Offset: 0x000D38E6
		[NullableContext(2)]
		public FFoldedBoneInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060095AF RID: 38319 RVA: 0x000D56F0 File Offset: 0x000D38F0
		public FFoldedBoneInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060095B0 RID: 38320 RVA: 0x000D56FB File Offset: 0x000D38FB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FFoldedBoneInfo(Pointer, false, true);
		}

		// Token: 0x060095B1 RID: 38321 RVA: 0x000D5705 File Offset: 0x000D3905
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FFoldedBoneInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040053F4 RID: 21492
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.FoldedBoneInfo";

		// Token: 0x040053F5 RID: 21493
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040053F6 RID: 21494
		internal static int __PropertyOffset_BoneIndex;

		// Token: 0x040053F7 RID: 21495
		internal static int __PropertyOffset_BoneName;
	}
}
