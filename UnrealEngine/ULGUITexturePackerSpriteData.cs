using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200073F RID: 1855
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI_TexturePackerImporter.LGUITexturePackerSpriteData")]
	[UnrealStructLayout(280, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 280)]
	public class ULGUITexturePackerSpriteData : ULGUISpriteData_BaseObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A1D2 RID: 41426 RVA: 0x000EF064 File Offset: 0x000ED264
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUITexturePackerSpriteData._ClassPtr;
		}

		// Token: 0x0600A1D3 RID: 41427 RVA: 0x000EF070 File Offset: 0x000ED270
		public ULGUITexturePackerSpriteData() : this(BuiltinUtils.AllocNativeUObject(ULGUITexturePackerSpriteData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A1D4 RID: 41428 RVA: 0x000EF098 File Offset: 0x000ED298
		public ULGUITexturePackerSpriteData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUITexturePackerSpriteData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001E31 RID: 7729
		// (get) Token: 0x0600A1D5 RID: 41429 RVA: 0x000EF0CB File Offset: 0x000ED2CB
		// (set) Token: 0x0600A1D6 RID: 41430 RVA: 0x000EF0DB File Offset: 0x000ED2DB
		public unsafe ushort BorderLeft
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUITexturePackerSpriteData.__PropertyOffset_BorderLeft);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUITexturePackerSpriteData.__PropertyOffset_BorderLeft) = (short)value;
			}
		}

		// Token: 0x17001E32 RID: 7730
		// (get) Token: 0x0600A1D7 RID: 41431 RVA: 0x000EF0EC File Offset: 0x000ED2EC
		// (set) Token: 0x0600A1D8 RID: 41432 RVA: 0x000EF0FC File Offset: 0x000ED2FC
		public unsafe ushort BorderRight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUITexturePackerSpriteData.__PropertyOffset_BorderRight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUITexturePackerSpriteData.__PropertyOffset_BorderRight) = (short)value;
			}
		}

		// Token: 0x17001E33 RID: 7731
		// (get) Token: 0x0600A1D9 RID: 41433 RVA: 0x000EF10D File Offset: 0x000ED30D
		// (set) Token: 0x0600A1DA RID: 41434 RVA: 0x000EF11D File Offset: 0x000ED31D
		public unsafe ushort BorderTop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUITexturePackerSpriteData.__PropertyOffset_BorderTop);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUITexturePackerSpriteData.__PropertyOffset_BorderTop) = (short)value;
			}
		}

		// Token: 0x17001E34 RID: 7732
		// (get) Token: 0x0600A1DB RID: 41435 RVA: 0x000EF12E File Offset: 0x000ED32E
		// (set) Token: 0x0600A1DC RID: 41436 RVA: 0x000EF13E File Offset: 0x000ED33E
		public unsafe ushort BorderBottom
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUITexturePackerSpriteData.__PropertyOffset_BorderBottom);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUITexturePackerSpriteData.__PropertyOffset_BorderBottom) = (short)value;
			}
		}

		// Token: 0x17001E35 RID: 7733
		// (get) Token: 0x0600A1DD RID: 41437 RVA: 0x000EF14F File Offset: 0x000ED34F
		// (set) Token: 0x0600A1DE RID: 41438 RVA: 0x000EF15F File Offset: 0x000ED35F
		public unsafe ushort StartLeft
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUITexturePackerSpriteData.__PropertyOffset_StartLeft);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUITexturePackerSpriteData.__PropertyOffset_StartLeft) = (short)value;
			}
		}

		// Token: 0x17001E36 RID: 7734
		// (get) Token: 0x0600A1DF RID: 41439 RVA: 0x000EF170 File Offset: 0x000ED370
		// (set) Token: 0x0600A1E0 RID: 41440 RVA: 0x000EF180 File Offset: 0x000ED380
		public unsafe ushort EndRight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUITexturePackerSpriteData.__PropertyOffset_EndRight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUITexturePackerSpriteData.__PropertyOffset_EndRight) = (short)value;
			}
		}

		// Token: 0x17001E37 RID: 7735
		// (get) Token: 0x0600A1E1 RID: 41441 RVA: 0x000EF191 File Offset: 0x000ED391
		// (set) Token: 0x0600A1E2 RID: 41442 RVA: 0x000EF1A1 File Offset: 0x000ED3A1
		public unsafe ushort EndTop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUITexturePackerSpriteData.__PropertyOffset_EndTop);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUITexturePackerSpriteData.__PropertyOffset_EndTop) = (short)value;
			}
		}

		// Token: 0x17001E38 RID: 7736
		// (get) Token: 0x0600A1E3 RID: 41443 RVA: 0x000EF1B2 File Offset: 0x000ED3B2
		// (set) Token: 0x0600A1E4 RID: 41444 RVA: 0x000EF1C2 File Offset: 0x000ED3C2
		public unsafe ushort StartBottom
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUITexturePackerSpriteData.__PropertyOffset_StartBottom);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUITexturePackerSpriteData.__PropertyOffset_StartBottom) = (short)value;
			}
		}

		// Token: 0x17001E39 RID: 7737
		// (get) Token: 0x0600A1E5 RID: 41445 RVA: 0x000EF1D4 File Offset: 0x000ED3D4
		// (set) Token: 0x0600A1E6 RID: 41446 RVA: 0x000EF20D File Offset: 0x000ED40D
		public TArray<ushort> BorderHorizontalArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ushort> result;
				if ((result = this._BorderHorizontalArray) == null)
				{
					result = (this._BorderHorizontalArray = new TArray<ushort>(base.NativePtr + (IntPtr)ULGUITexturePackerSpriteData.__PropertyOffset_BorderHorizontalArray, this));
				}
				return result;
			}
			set
			{
				this.BorderHorizontalArray.CopyAssign(value);
			}
		}

		// Token: 0x17001E3A RID: 7738
		// (get) Token: 0x0600A1E7 RID: 41447 RVA: 0x000EF21C File Offset: 0x000ED41C
		// (set) Token: 0x0600A1E8 RID: 41448 RVA: 0x000EF255 File Offset: 0x000ED455
		public TArray<ushort> BorderVerticalArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ushort> result;
				if ((result = this._BorderVerticalArray) == null)
				{
					result = (this._BorderVerticalArray = new TArray<ushort>(base.NativePtr + (IntPtr)ULGUITexturePackerSpriteData.__PropertyOffset_BorderVerticalArray, this));
				}
				return result;
			}
			set
			{
				this.BorderVerticalArray.CopyAssign(value);
			}
		}

		// Token: 0x17001E3B RID: 7739
		// (get) Token: 0x0600A1E9 RID: 41449 RVA: 0x000EF263 File Offset: 0x000ED463
		// (set) Token: 0x0600A1EA RID: 41450 RVA: 0x000EF273 File Offset: 0x000ED473
		public unsafe float CustomUVOffsetX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUITexturePackerSpriteData.__PropertyOffset_CustomUVOffsetX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUITexturePackerSpriteData.__PropertyOffset_CustomUVOffsetX) = value;
			}
		}

		// Token: 0x17001E3C RID: 7740
		// (get) Token: 0x0600A1EB RID: 41451 RVA: 0x000EF284 File Offset: 0x000ED484
		// (set) Token: 0x0600A1EC RID: 41452 RVA: 0x000EF294 File Offset: 0x000ED494
		public unsafe float CustomUVOffsetY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUITexturePackerSpriteData.__PropertyOffset_CustomUVOffsetY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUITexturePackerSpriteData.__PropertyOffset_CustomUVOffsetY) = value;
			}
		}

		// Token: 0x17001E3D RID: 7741
		// (get) Token: 0x0600A1ED RID: 41453 RVA: 0x000EF2A5 File Offset: 0x000ED4A5
		// (set) Token: 0x0600A1EE RID: 41454 RVA: 0x000EF2B9 File Offset: 0x000ED4B9
		[Nullable(2)]
		public unsafe UTexture2D Texture2D
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + ULGUITexturePackerSpriteData.__PropertyOffset_Texture2D);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULGUITexturePackerSpriteData.__PropertyOffset_Texture2D, value);
			}
		}

		// Token: 0x17001E3E RID: 7742
		// (get) Token: 0x0600A1EF RID: 41455 RVA: 0x000EF2CE File Offset: 0x000ED4CE
		// (set) Token: 0x0600A1F0 RID: 41456 RVA: 0x000EF2DE File Offset: 0x000ED4DE
		public unsafe short Version
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUITexturePackerSpriteData.__PropertyOffset_Version);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUITexturePackerSpriteData.__PropertyOffset_Version) = value;
			}
		}

		// Token: 0x0600A1F1 RID: 41457 RVA: 0x000EF2EF File Offset: 0x000ED4EF
		static ULGUITexturePackerSpriteData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI_TexturePackerImporter.LGUITexturePackerSpriteData");
		}

		// Token: 0x0600A1F2 RID: 41458 RVA: 0x000EF2FD File Offset: 0x000ED4FD
		protected ULGUITexturePackerSpriteData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400454B RID: 17739
		public new const string __ObjectPath = "/Script/LGUI_TexturePackerImporter.LGUITexturePackerSpriteData";

		// Token: 0x0400454C RID: 17740
		private static IntPtr _ClassPtr;

		// Token: 0x0400454D RID: 17741
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400454E RID: 17742
		internal static int __PropertyOffset_BorderLeft;

		// Token: 0x0400454F RID: 17743
		internal static int __PropertyOffset_BorderRight;

		// Token: 0x04004550 RID: 17744
		internal static int __PropertyOffset_BorderTop;

		// Token: 0x04004551 RID: 17745
		internal static int __PropertyOffset_BorderBottom;

		// Token: 0x04004552 RID: 17746
		internal static int __PropertyOffset_StartLeft;

		// Token: 0x04004553 RID: 17747
		internal static int __PropertyOffset_EndRight;

		// Token: 0x04004554 RID: 17748
		internal static int __PropertyOffset_EndTop;

		// Token: 0x04004555 RID: 17749
		internal static int __PropertyOffset_StartBottom;

		// Token: 0x04004556 RID: 17750
		internal static int __PropertyOffset_BorderHorizontalArray;

		// Token: 0x04004557 RID: 17751
		[Nullable(2)]
		private TArray<ushort> _BorderHorizontalArray;

		// Token: 0x04004558 RID: 17752
		internal static int __PropertyOffset_BorderVerticalArray;

		// Token: 0x04004559 RID: 17753
		[Nullable(2)]
		private TArray<ushort> _BorderVerticalArray;

		// Token: 0x0400455A RID: 17754
		internal static int __PropertyOffset_CustomUVOffsetX;

		// Token: 0x0400455B RID: 17755
		internal static int __PropertyOffset_CustomUVOffsetY;

		// Token: 0x0400455C RID: 17756
		internal static int __PropertyOffset_Texture2D;

		// Token: 0x0400455D RID: 17757
		internal static int __PropertyOffset_Version;
	}
}
