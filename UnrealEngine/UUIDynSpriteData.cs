using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006F8 RID: 1784
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIDynSpriteData")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UUIDynSpriteData : ULGUISpriteData_BaseObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060097FF RID: 38911 RVA: 0x000E507E File Offset: 0x000E327E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIDynSpriteData._ClassPtr;
		}

		// Token: 0x06009800 RID: 38912 RVA: 0x000E508C File Offset: 0x000E328C
		public UUIDynSpriteData() : this(BuiltinUtils.AllocNativeUObject(UUIDynSpriteData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009801 RID: 38913 RVA: 0x000E50B4 File Offset: 0x000E32B4
		public UUIDynSpriteData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIDynSpriteData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001C39 RID: 7225
		// (get) Token: 0x06009802 RID: 38914 RVA: 0x000E50E7 File Offset: 0x000E32E7
		// (set) Token: 0x06009803 RID: 38915 RVA: 0x000E50FB File Offset: 0x000E32FB
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

		// Token: 0x17001C3A RID: 7226
		// (get) Token: 0x06009804 RID: 38916 RVA: 0x000E5110 File Offset: 0x000E3310
		// (set) Token: 0x06009805 RID: 38917 RVA: 0x000E5149 File Offset: 0x000E3349
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

		// Token: 0x17001C3B RID: 7227
		// (get) Token: 0x06009806 RID: 38918 RVA: 0x000E516A File Offset: 0x000E336A
		// (set) Token: 0x06009807 RID: 38919 RVA: 0x000E517A File Offset: 0x000E337A
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

		// Token: 0x17001C3C RID: 7228
		// (get) Token: 0x06009808 RID: 38920 RVA: 0x000E518B File Offset: 0x000E338B
		// (set) Token: 0x06009809 RID: 38921 RVA: 0x000E519B File Offset: 0x000E339B
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

		// Token: 0x0600980A RID: 38922 RVA: 0x000E51AC File Offset: 0x000E33AC
		static UUIDynSpriteData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIDynSpriteData");
		}

		// Token: 0x0600980B RID: 38923 RVA: 0x000E51BA File Offset: 0x000E33BA
		protected UUIDynSpriteData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400420D RID: 16909
		public new const string __ObjectPath = "/Script/LGUI.UIDynSpriteData";

		// Token: 0x0400420E RID: 16910
		private static IntPtr _ClassPtr;

		// Token: 0x0400420F RID: 16911
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004210 RID: 16912
		internal static int __PropertyOffset_DynAtlasTexture;

		// Token: 0x04004211 RID: 16913
		internal static int __PropertyOffset_OriginSpritePath;

		// Token: 0x04004212 RID: 16914
		[Nullable(2)]
		private FSoftObjectPath _OriginSpritePath;

		// Token: 0x04004213 RID: 16915
		internal static int __PropertyOffset_CustomUVOffsetX;

		// Token: 0x04004214 RID: 16916
		internal static int __PropertyOffset_CustomUVOffsetY;
	}
}
