using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000896 RID: 2198
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BakedBoneSplitTexture2DArray")]
	[UnrealStructLayout(4064, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 4064)]
	public class UBakedBoneSplitTexture2DArray : UTexture2DArray, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600782A RID: 30762 RVA: 0x000AC166 File Offset: 0x000AA366
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBakedBoneSplitTexture2DArray._ClassPtr;
		}

		// Token: 0x0600782B RID: 30763 RVA: 0x000AC174 File Offset: 0x000AA374
		public UBakedBoneSplitTexture2DArray() : this(BuiltinUtils.AllocNativeUObject(UBakedBoneSplitTexture2DArray.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600782C RID: 30764 RVA: 0x000AC19C File Offset: 0x000AA39C
		public UBakedBoneSplitTexture2DArray(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBakedBoneSplitTexture2DArray.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001C5E RID: 7262
		// (get) Token: 0x0600782D RID: 30765 RVA: 0x000AC1CF File Offset: 0x000AA3CF
		// (set) Token: 0x0600782E RID: 30766 RVA: 0x000AC1DF File Offset: 0x000AA3DF
		public unsafe int TextureWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBakedBoneSplitTexture2DArray.__PropertyOffset_TextureWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBakedBoneSplitTexture2DArray.__PropertyOffset_TextureWidth) = value;
			}
		}

		// Token: 0x17001C5F RID: 7263
		// (get) Token: 0x0600782F RID: 30767 RVA: 0x000AC1F0 File Offset: 0x000AA3F0
		// (set) Token: 0x06007830 RID: 30768 RVA: 0x000AC200 File Offset: 0x000AA400
		public unsafe int TextureHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBakedBoneSplitTexture2DArray.__PropertyOffset_TextureHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBakedBoneSplitTexture2DArray.__PropertyOffset_TextureHeight) = value;
			}
		}

		// Token: 0x17001C60 RID: 7264
		// (get) Token: 0x06007831 RID: 30769 RVA: 0x000AC211 File Offset: 0x000AA411
		// (set) Token: 0x06007832 RID: 30770 RVA: 0x000AC221 File Offset: 0x000AA421
		public unsafe int NumSlices
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBakedBoneSplitTexture2DArray.__PropertyOffset_NumSlices);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBakedBoneSplitTexture2DArray.__PropertyOffset_NumSlices) = value;
			}
		}

		// Token: 0x17001C61 RID: 7265
		// (get) Token: 0x06007833 RID: 30771 RVA: 0x000AC232 File Offset: 0x000AA432
		// (set) Token: 0x06007834 RID: 30772 RVA: 0x000AC242 File Offset: 0x000AA442
		public unsafe bool IsCompressedData
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBakedBoneSplitTexture2DArray.__PropertyOffset_IsCompressedData) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBakedBoneSplitTexture2DArray.__PropertyOffset_IsCompressedData) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001C62 RID: 7266
		// (get) Token: 0x06007835 RID: 30773 RVA: 0x000AC254 File Offset: 0x000AA454
		// (set) Token: 0x06007836 RID: 30774 RVA: 0x000AC28D File Offset: 0x000AA48D
		public TArray<FBakedBoneSplitAnimSection> AnimSections
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBakedBoneSplitAnimSection> result;
				if ((result = this._AnimSections) == null)
				{
					result = (this._AnimSections = new TArray<FBakedBoneSplitAnimSection>(base.NativePtr + (IntPtr)UBakedBoneSplitTexture2DArray.__PropertyOffset_AnimSections, this));
				}
				return result;
			}
			set
			{
				this.AnimSections.CopyAssign(value);
			}
		}

		// Token: 0x06007837 RID: 30775 RVA: 0x000AC29B File Offset: 0x000AA49B
		static UBakedBoneSplitTexture2DArray()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.BakedBoneSplitTexture2DArray");
		}

		// Token: 0x06007838 RID: 30776 RVA: 0x000AC2A9 File Offset: 0x000AA4A9
		protected UBakedBoneSplitTexture2DArray(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040039B6 RID: 14774
		public new const string __ObjectPath = "/Script/Engine.BakedBoneSplitTexture2DArray";

		// Token: 0x040039B7 RID: 14775
		private static IntPtr _ClassPtr;

		// Token: 0x040039B8 RID: 14776
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040039B9 RID: 14777
		internal static int __PropertyOffset_TextureWidth;

		// Token: 0x040039BA RID: 14778
		internal static int __PropertyOffset_TextureHeight;

		// Token: 0x040039BB RID: 14779
		internal static int __PropertyOffset_NumSlices;

		// Token: 0x040039BC RID: 14780
		internal static int __PropertyOffset_IsCompressedData;

		// Token: 0x040039BD RID: 14781
		internal static int __PropertyOffset_AnimSections;

		// Token: 0x040039BE RID: 14782
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBakedBoneSplitAnimSection> _AnimSections;
	}
}
