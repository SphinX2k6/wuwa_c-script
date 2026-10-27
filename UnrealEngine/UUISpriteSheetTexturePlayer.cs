using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021C3 RID: 8643
	[UnrealObjectPath("/Script/LGUI.UISpriteSheetTexturePlayer")]
	[UnrealStructLayout(264, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 264)]
	public class UUISpriteSheetTexturePlayer : ULGUIImageSequencePlayer, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020E1A RID: 134682 RVA: 0x003090ED File Offset: 0x003072ED
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUISpriteSheetTexturePlayer._ClassPtr;
		}

		// Token: 0x06020E1B RID: 134683 RVA: 0x003090FC File Offset: 0x003072FC
		public UUISpriteSheetTexturePlayer() : this(BuiltinUtils.AllocNativeUObject(UUISpriteSheetTexturePlayer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020E1C RID: 134684 RVA: 0x00309124 File Offset: 0x00307324
		[NullableContext(1)]
		public UUISpriteSheetTexturePlayer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUISpriteSheetTexturePlayer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700806A RID: 32874
		// (get) Token: 0x06020E1D RID: 134685 RVA: 0x00309157 File Offset: 0x00307357
		// (set) Token: 0x06020E1E RID: 134686 RVA: 0x0030916B File Offset: 0x0030736B
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UUITexture> texture
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUISpriteSheetTexturePlayer.__PropertyOffset_texture);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUISpriteSheetTexturePlayer.__PropertyOffset_texture) = value;
			}
		}

		// Token: 0x1700806B RID: 32875
		// (get) Token: 0x06020E1F RID: 134687 RVA: 0x00309180 File Offset: 0x00307380
		// (set) Token: 0x06020E20 RID: 134688 RVA: 0x00309190 File Offset: 0x00307390
		public unsafe int widthCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISpriteSheetTexturePlayer.__PropertyOffset_widthCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISpriteSheetTexturePlayer.__PropertyOffset_widthCount) = value;
			}
		}

		// Token: 0x1700806C RID: 32876
		// (get) Token: 0x06020E21 RID: 134689 RVA: 0x003091A1 File Offset: 0x003073A1
		// (set) Token: 0x06020E22 RID: 134690 RVA: 0x003091B1 File Offset: 0x003073B1
		public unsafe int heightCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISpriteSheetTexturePlayer.__PropertyOffset_heightCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISpriteSheetTexturePlayer.__PropertyOffset_heightCount) = value;
			}
		}

		// Token: 0x06020E23 RID: 134691 RVA: 0x003091C2 File Offset: 0x003073C2
		public void SetWidthCount(int value)
		{
			UUISpriteSheetTexturePlayer.__SetWidthCount_Internal(base.NativePtr, value);
		}

		// Token: 0x06020E24 RID: 134692 RVA: 0x003091D0 File Offset: 0x003073D0
		public void SetHeightCount(int value)
		{
			UUISpriteSheetTexturePlayer.__SetHeightCount_Internal(base.NativePtr, value);
		}

		// Token: 0x06020E25 RID: 134693 RVA: 0x003091DE File Offset: 0x003073DE
		public int GetWidthCount()
		{
			return UUISpriteSheetTexturePlayer.__GetWidthCount_Internal(base.NativePtr);
		}

		// Token: 0x06020E26 RID: 134694 RVA: 0x003091EB File Offset: 0x003073EB
		public int GetHeightCount()
		{
			return UUISpriteSheetTexturePlayer.__GetHeightCount_Internal(base.NativePtr);
		}

		// Token: 0x06020E27 RID: 134695
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWidthCount_Internal(IntPtr @this, int value);

		// Token: 0x06020E28 RID: 134696
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHeightCount_Internal(IntPtr @this, int value);

		// Token: 0x06020E29 RID: 134697
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetWidthCount_Internal(IntPtr @this);

		// Token: 0x06020E2A RID: 134698
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetHeightCount_Internal(IntPtr @this);

		// Token: 0x06020E2B RID: 134699 RVA: 0x003091F8 File Offset: 0x003073F8
		static UUISpriteSheetTexturePlayer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UISpriteSheetTexturePlayer");
		}

		// Token: 0x06020E2C RID: 134700 RVA: 0x00309206 File Offset: 0x00307406
		protected UUISpriteSheetTexturePlayer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011903 RID: 71939
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UISpriteSheetTexturePlayer";

		// Token: 0x04011904 RID: 71940
		private static IntPtr _ClassPtr;

		// Token: 0x04011905 RID: 71941
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011906 RID: 71942
		internal static int __PropertyOffset_texture;

		// Token: 0x04011907 RID: 71943
		internal static int __PropertyOffset_widthCount;

		// Token: 0x04011908 RID: 71944
		internal static int __PropertyOffset_heightCount;
	}
}
