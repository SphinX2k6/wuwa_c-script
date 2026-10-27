using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200088A RID: 2186
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BakedBoneSplitAnimInfo")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 136)]
	public class FBakedBoneSplitAnimInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600778D RID: 30605 RVA: 0x000AB3AA File Offset: 0x000A95AA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBakedBoneSplitAnimInfo._ScriptStructPtr != 0) ? FBakedBoneSplitAnimInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BakedBoneSplitAnimInfo", ref FBakedBoneSplitAnimInfo._ScriptStructPtr);
		}

		// Token: 0x17001C38 RID: 7224
		// (get) Token: 0x0600778E RID: 30606 RVA: 0x000AB3CE File Offset: 0x000A95CE
		// (set) Token: 0x0600778F RID: 30607 RVA: 0x000AB3E2 File Offset: 0x000A95E2
		[Nullable(2)]
		public unsafe UBakedBoneSplitTexture2DArray AnimTextureArray
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBakedBoneSplitTexture2DArray>(base.NativePtr / (IntPtr)sizeof(void*) + FBakedBoneSplitAnimInfo.__PropertyOffset_AnimTextureArray);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FBakedBoneSplitAnimInfo.__PropertyOffset_AnimTextureArray, value);
			}
		}

		// Token: 0x17001C39 RID: 7225
		// (get) Token: 0x06007790 RID: 30608 RVA: 0x000AB3F7 File Offset: 0x000A95F7
		// (set) Token: 0x06007791 RID: 30609 RVA: 0x000AB40B File Offset: 0x000A960B
		[Nullable(2)]
		public unsafe UBakedBoneSplitAnimBufferData AnimBufferData
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBakedBoneSplitAnimBufferData>(base.NativePtr / (IntPtr)sizeof(void*) + FBakedBoneSplitAnimInfo.__PropertyOffset_AnimBufferData);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FBakedBoneSplitAnimInfo.__PropertyOffset_AnimBufferData, value);
			}
		}

		// Token: 0x17001C3A RID: 7226
		// (get) Token: 0x06007792 RID: 30610 RVA: 0x000AB420 File Offset: 0x000A9620
		// (set) Token: 0x06007793 RID: 30611 RVA: 0x000AB43F File Offset: 0x000A963F
		public TSoftObjectPtr<UBakedBoneSplitTexture2DArray> AnimTextureArraySoftPtr
		{
			get
			{
				return new TSoftObjectPtr<UBakedBoneSplitTexture2DArray>(base.NativePtr + (IntPtr)FBakedBoneSplitAnimInfo.__PropertyOffset_AnimTextureArraySoftPtr, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)FBakedBoneSplitAnimInfo.__PropertyOffset_AnimTextureArraySoftPtr, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17001C3B RID: 7227
		// (get) Token: 0x06007794 RID: 30612 RVA: 0x000AB464 File Offset: 0x000A9664
		// (set) Token: 0x06007795 RID: 30613 RVA: 0x000AB483 File Offset: 0x000A9683
		public TSoftObjectPtr<UBakedBoneSplitAnimBufferData> AnimBufferDataSoftPtr
		{
			get
			{
				return new TSoftObjectPtr<UBakedBoneSplitAnimBufferData>(base.NativePtr + (IntPtr)FBakedBoneSplitAnimInfo.__PropertyOffset_AnimBufferDataSoftPtr, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)FBakedBoneSplitAnimInfo.__PropertyOffset_AnimBufferDataSoftPtr, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x06007796 RID: 30614 RVA: 0x000AB4A8 File Offset: 0x000A96A8
		public FBakedBoneSplitAnimInfo()
		{
		}

		// Token: 0x06007797 RID: 30615 RVA: 0x000AB4B0 File Offset: 0x000A96B0
		public FBakedBoneSplitAnimInfo(UBakedBoneSplitTexture2DArray AnimTextureArray, UBakedBoneSplitAnimBufferData AnimBufferData, TSoftObjectPtr<UBakedBoneSplitTexture2DArray> AnimTextureArraySoftPtr, TSoftObjectPtr<UBakedBoneSplitAnimBufferData> AnimBufferDataSoftPtr)
		{
			this.AnimTextureArray = AnimTextureArray;
			this.AnimBufferData = AnimBufferData;
			this.AnimTextureArraySoftPtr = AnimTextureArraySoftPtr;
			this.AnimBufferDataSoftPtr = AnimBufferDataSoftPtr;
		}

		// Token: 0x06007798 RID: 30616 RVA: 0x000AB4D5 File Offset: 0x000A96D5
		protected override IntPtr GetUStructPtr()
		{
			return FBakedBoneSplitAnimInfo.StaticStruct();
		}

		// Token: 0x06007799 RID: 30617 RVA: 0x000AB4E1 File Offset: 0x000A96E1
		[NullableContext(2)]
		public FBakedBoneSplitAnimInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600779A RID: 30618 RVA: 0x000AB4EB File Offset: 0x000A96EB
		public FBakedBoneSplitAnimInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600779B RID: 30619 RVA: 0x000AB4F6 File Offset: 0x000A96F6
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBakedBoneSplitAnimInfo(Pointer, false, true);
		}

		// Token: 0x0600779C RID: 30620 RVA: 0x000AB500 File Offset: 0x000A9700
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBakedBoneSplitAnimInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04003969 RID: 14697
		public const string __ObjectPath = "/Script/Engine.BakedBoneSplitAnimInfo";

		// Token: 0x0400396A RID: 14698
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400396B RID: 14699
		internal static int __PropertyOffset_AnimTextureArray;

		// Token: 0x0400396C RID: 14700
		internal static int __PropertyOffset_AnimBufferData;

		// Token: 0x0400396D RID: 14701
		internal static int __PropertyOffset_AnimTextureArraySoftPtr;

		// Token: 0x0400396E RID: 14702
		internal static int __PropertyOffset_AnimBufferDataSoftPtr;
	}
}
