using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002147 RID: 8519
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIDynSpriteData")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UUIDynSpriteData : ULGUISpriteData_BaseObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060201DA RID: 131546 RVA: 0x002FBE8A File Offset: 0x002FA08A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIDynSpriteData._ClassPtr;
		}

		// Token: 0x060201DB RID: 131547 RVA: 0x002FBE98 File Offset: 0x002FA098
		public UUIDynSpriteData() : this(BuiltinUtils.AllocNativeUObject(UUIDynSpriteData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060201DC RID: 131548 RVA: 0x002FBEC0 File Offset: 0x002FA0C0
		public UUIDynSpriteData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIDynSpriteData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007E17 RID: 32279
		// (get) Token: 0x060201DD RID: 131549 RVA: 0x002FBEF3 File Offset: 0x002FA0F3
		// (set) Token: 0x060201DE RID: 131550 RVA: 0x002FBF07 File Offset: 0x002FA107
		[Nullable(2)]
		public unsafe UTexture2D DynAtlasTexture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + UUIDynSpriteData.__PropertyOffset_DynAtlasTexture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUIDynSpriteData.__PropertyOffset_DynAtlasTexture, value);
			}
		}

		// Token: 0x17007E18 RID: 32280
		// (get) Token: 0x060201DF RID: 131551 RVA: 0x002FBF1C File Offset: 0x002FA11C
		// (set) Token: 0x060201E0 RID: 131552 RVA: 0x002FBF55 File Offset: 0x002FA155
		public FLGUISpriteInfo SpriteInfo
		{
			get
			{
				base.FastCheckIsValid();
				FLGUISpriteInfo result;
				if ((result = this._SpriteInfo) == null)
				{
					result = (this._SpriteInfo = new FLGUISpriteInfo(base.NativePtr + (IntPtr)UUIDynSpriteData.__PropertyOffset_SpriteInfo, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLGUISpriteInfo.StaticStruct(), base.NativePtr + (IntPtr)UUIDynSpriteData.__PropertyOffset_SpriteInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007E19 RID: 32281
		// (get) Token: 0x060201E1 RID: 131553 RVA: 0x002FBF78 File Offset: 0x002FA178
		// (set) Token: 0x060201E2 RID: 131554 RVA: 0x002FBFB1 File Offset: 0x002FA1B1
		public FSoftObjectPath OriginSpritePath
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._OriginSpritePath) == null)
				{
					result = (this._OriginSpritePath = new FSoftObjectPath(base.NativePtr + (IntPtr)UUIDynSpriteData.__PropertyOffset_OriginSpritePath, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)UUIDynSpriteData.__PropertyOffset_OriginSpritePath, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007E1A RID: 32282
		// (get) Token: 0x060201E3 RID: 131555 RVA: 0x002FBFD2 File Offset: 0x002FA1D2
		// (set) Token: 0x060201E4 RID: 131556 RVA: 0x002FBFE2 File Offset: 0x002FA1E2
		public unsafe float CustomUVOffsetX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIDynSpriteData.__PropertyOffset_CustomUVOffsetX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIDynSpriteData.__PropertyOffset_CustomUVOffsetX) = value;
			}
		}

		// Token: 0x17007E1B RID: 32283
		// (get) Token: 0x060201E5 RID: 131557 RVA: 0x002FBFF3 File Offset: 0x002FA1F3
		// (set) Token: 0x060201E6 RID: 131558 RVA: 0x002FC003 File Offset: 0x002FA203
		public unsafe float CustomUVOffsetY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIDynSpriteData.__PropertyOffset_CustomUVOffsetY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIDynSpriteData.__PropertyOffset_CustomUVOffsetY) = value;
			}
		}

		// Token: 0x060201E7 RID: 131559 RVA: 0x002FC014 File Offset: 0x002FA214
		static UUIDynSpriteData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIDynSpriteData");
		}

		// Token: 0x060201E8 RID: 131560 RVA: 0x002FC022 File Offset: 0x002FA222
		protected UUIDynSpriteData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011477 RID: 70775
		public new const string __ObjectPath = "/Script/LGUI.UIDynSpriteData";

		// Token: 0x04011478 RID: 70776
		private static IntPtr _ClassPtr;

		// Token: 0x04011479 RID: 70777
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401147A RID: 70778
		internal static int __PropertyOffset_DynAtlasTexture;

		// Token: 0x0401147B RID: 70779
		internal static int __PropertyOffset_SpriteInfo;

		// Token: 0x0401147C RID: 70780
		[Nullable(2)]
		private FLGUISpriteInfo _SpriteInfo;

		// Token: 0x0401147D RID: 70781
		internal static int __PropertyOffset_OriginSpritePath;

		// Token: 0x0401147E RID: 70782
		[Nullable(2)]
		private FSoftObjectPath _OriginSpritePath;

		// Token: 0x0401147F RID: 70783
		internal static int __PropertyOffset_CustomUVOffsetX;

		// Token: 0x04011480 RID: 70784
		internal static int __PropertyOffset_CustomUVOffsetY;
	}
}
