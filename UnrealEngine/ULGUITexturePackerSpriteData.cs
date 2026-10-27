using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021EA RID: 8682
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI_TexturePackerImporter.LGUITexturePackerSpriteData")]
	[UnrealStructLayout(280, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 280)]
	public class ULGUITexturePackerSpriteData : ULGUISpriteData_BaseObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060211D7 RID: 135639 RVA: 0x0030D536 File Offset: 0x0030B736
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUITexturePackerSpriteData._ClassPtr;
		}

		// Token: 0x060211D8 RID: 135640 RVA: 0x0030D544 File Offset: 0x0030B744
		public ULGUITexturePackerSpriteData() : this(BuiltinUtils.AllocNativeUObject(ULGUITexturePackerSpriteData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060211D9 RID: 135641 RVA: 0x0030D56C File Offset: 0x0030B76C
		public ULGUITexturePackerSpriteData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUITexturePackerSpriteData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700814F RID: 33103
		// (get) Token: 0x060211DA RID: 135642 RVA: 0x0030D59F File Offset: 0x0030B79F
		// (set) Token: 0x060211DB RID: 135643 RVA: 0x0030D5AF File Offset: 0x0030B7AF
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

		// Token: 0x17008150 RID: 33104
		// (get) Token: 0x060211DC RID: 135644 RVA: 0x0030D5C0 File Offset: 0x0030B7C0
		// (set) Token: 0x060211DD RID: 135645 RVA: 0x0030D5D0 File Offset: 0x0030B7D0
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

		// Token: 0x17008151 RID: 33105
		// (get) Token: 0x060211DE RID: 135646 RVA: 0x0030D5E1 File Offset: 0x0030B7E1
		// (set) Token: 0x060211DF RID: 135647 RVA: 0x0030D5F1 File Offset: 0x0030B7F1
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

		// Token: 0x17008152 RID: 33106
		// (get) Token: 0x060211E0 RID: 135648 RVA: 0x0030D602 File Offset: 0x0030B802
		// (set) Token: 0x060211E1 RID: 135649 RVA: 0x0030D612 File Offset: 0x0030B812
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

		// Token: 0x17008153 RID: 33107
		// (get) Token: 0x060211E2 RID: 135650 RVA: 0x0030D623 File Offset: 0x0030B823
		// (set) Token: 0x060211E3 RID: 135651 RVA: 0x0030D633 File Offset: 0x0030B833
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

		// Token: 0x17008154 RID: 33108
		// (get) Token: 0x060211E4 RID: 135652 RVA: 0x0030D644 File Offset: 0x0030B844
		// (set) Token: 0x060211E5 RID: 135653 RVA: 0x0030D654 File Offset: 0x0030B854
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

		// Token: 0x17008155 RID: 33109
		// (get) Token: 0x060211E6 RID: 135654 RVA: 0x0030D665 File Offset: 0x0030B865
		// (set) Token: 0x060211E7 RID: 135655 RVA: 0x0030D675 File Offset: 0x0030B875
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

		// Token: 0x17008156 RID: 33110
		// (get) Token: 0x060211E8 RID: 135656 RVA: 0x0030D686 File Offset: 0x0030B886
		// (set) Token: 0x060211E9 RID: 135657 RVA: 0x0030D696 File Offset: 0x0030B896
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

		// Token: 0x17008157 RID: 33111
		// (get) Token: 0x060211EA RID: 135658 RVA: 0x0030D6A8 File Offset: 0x0030B8A8
		// (set) Token: 0x060211EB RID: 135659 RVA: 0x0030D6E1 File Offset: 0x0030B8E1
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

		// Token: 0x17008158 RID: 33112
		// (get) Token: 0x060211EC RID: 135660 RVA: 0x0030D6F0 File Offset: 0x0030B8F0
		// (set) Token: 0x060211ED RID: 135661 RVA: 0x0030D729 File Offset: 0x0030B929
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

		// Token: 0x17008159 RID: 33113
		// (get) Token: 0x060211EE RID: 135662 RVA: 0x0030D737 File Offset: 0x0030B937
		// (set) Token: 0x060211EF RID: 135663 RVA: 0x0030D747 File Offset: 0x0030B947
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

		// Token: 0x1700815A RID: 33114
		// (get) Token: 0x060211F0 RID: 135664 RVA: 0x0030D758 File Offset: 0x0030B958
		// (set) Token: 0x060211F1 RID: 135665 RVA: 0x0030D768 File Offset: 0x0030B968
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

		// Token: 0x1700815B RID: 33115
		// (get) Token: 0x060211F2 RID: 135666 RVA: 0x0030D779 File Offset: 0x0030B979
		// (set) Token: 0x060211F3 RID: 135667 RVA: 0x0030D78D File Offset: 0x0030B98D
		[Nullable(2)]
		public unsafe ULGUITexturePackerImporterData Importer
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULGUITexturePackerImporterData>(base.NativePtr / (IntPtr)sizeof(void*) + ULGUITexturePackerSpriteData.__PropertyOffset_Importer);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULGUITexturePackerSpriteData.__PropertyOffset_Importer, value);
			}
		}

		// Token: 0x1700815C RID: 33116
		// (get) Token: 0x060211F4 RID: 135668 RVA: 0x0030D7A2 File Offset: 0x0030B9A2
		// (set) Token: 0x060211F5 RID: 135669 RVA: 0x0030D7B6 File Offset: 0x0030B9B6
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

		// Token: 0x1700815D RID: 33117
		// (get) Token: 0x060211F6 RID: 135670 RVA: 0x0030D7CC File Offset: 0x0030B9CC
		// (set) Token: 0x060211F7 RID: 135671 RVA: 0x0030D805 File Offset: 0x0030BA05
		public FLGUISpriteInfo CacheSpriteInfo
		{
			get
			{
				base.FastCheckIsValid();
				FLGUISpriteInfo result;
				if ((result = this._CacheSpriteInfo) == null)
				{
					result = (this._CacheSpriteInfo = new FLGUISpriteInfo(base.NativePtr + (IntPtr)ULGUITexturePackerSpriteData.__PropertyOffset_CacheSpriteInfo, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLGUISpriteInfo.StaticStruct(), base.NativePtr + (IntPtr)ULGUITexturePackerSpriteData.__PropertyOffset_CacheSpriteInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700815E RID: 33118
		// (get) Token: 0x060211F8 RID: 135672 RVA: 0x0030D826 File Offset: 0x0030BA26
		// (set) Token: 0x060211F9 RID: 135673 RVA: 0x0030D836 File Offset: 0x0030BA36
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

		// Token: 0x060211FA RID: 135674 RVA: 0x0030D847 File Offset: 0x0030BA47
		static ULGUITexturePackerSpriteData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI_TexturePackerImporter.LGUITexturePackerSpriteData");
		}

		// Token: 0x060211FB RID: 135675 RVA: 0x0030D855 File Offset: 0x0030BA55
		protected ULGUITexturePackerSpriteData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011AAE RID: 72366
		public new const string __ObjectPath = "/Script/LGUI_TexturePackerImporter.LGUITexturePackerSpriteData";

		// Token: 0x04011AAF RID: 72367
		private static IntPtr _ClassPtr;

		// Token: 0x04011AB0 RID: 72368
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011AB1 RID: 72369
		internal static int __PropertyOffset_BorderLeft;

		// Token: 0x04011AB2 RID: 72370
		internal static int __PropertyOffset_BorderRight;

		// Token: 0x04011AB3 RID: 72371
		internal static int __PropertyOffset_BorderTop;

		// Token: 0x04011AB4 RID: 72372
		internal static int __PropertyOffset_BorderBottom;

		// Token: 0x04011AB5 RID: 72373
		internal static int __PropertyOffset_StartLeft;

		// Token: 0x04011AB6 RID: 72374
		internal static int __PropertyOffset_EndRight;

		// Token: 0x04011AB7 RID: 72375
		internal static int __PropertyOffset_EndTop;

		// Token: 0x04011AB8 RID: 72376
		internal static int __PropertyOffset_StartBottom;

		// Token: 0x04011AB9 RID: 72377
		internal static int __PropertyOffset_BorderHorizontalArray;

		// Token: 0x04011ABA RID: 72378
		[Nullable(2)]
		private TArray<ushort> _BorderHorizontalArray;

		// Token: 0x04011ABB RID: 72379
		internal static int __PropertyOffset_BorderVerticalArray;

		// Token: 0x04011ABC RID: 72380
		[Nullable(2)]
		private TArray<ushort> _BorderVerticalArray;

		// Token: 0x04011ABD RID: 72381
		internal static int __PropertyOffset_CustomUVOffsetX;

		// Token: 0x04011ABE RID: 72382
		internal static int __PropertyOffset_CustomUVOffsetY;

		// Token: 0x04011ABF RID: 72383
		internal static int __PropertyOffset_Importer;

		// Token: 0x04011AC0 RID: 72384
		internal static int __PropertyOffset_Texture2D;

		// Token: 0x04011AC1 RID: 72385
		internal static int __PropertyOffset_CacheSpriteInfo;

		// Token: 0x04011AC2 RID: 72386
		[Nullable(2)]
		private FLGUISpriteInfo _CacheSpriteInfo;

		// Token: 0x04011AC3 RID: 72387
		internal static int __PropertyOffset_Version;
	}
}
