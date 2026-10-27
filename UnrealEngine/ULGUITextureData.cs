using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020D5 RID: 8405
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.LGUITextureData")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 200)]
	public class ULGUITextureData : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FA9B RID: 129691 RVA: 0x002F1691 File Offset: 0x002EF891
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUITextureData._ClassPtr;
		}

		// Token: 0x0601FA9C RID: 129692 RVA: 0x002F16A0 File Offset: 0x002EF8A0
		public ULGUITextureData() : this(BuiltinUtils.AllocNativeUObject(ULGUITextureData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FA9D RID: 129693 RVA: 0x002F16C8 File Offset: 0x002EF8C8
		public ULGUITextureData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUITextureData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007CD7 RID: 31959
		// (get) Token: 0x0601FA9E RID: 129694 RVA: 0x002F16FB File Offset: 0x002EF8FB
		// (set) Token: 0x0601FA9F RID: 129695 RVA: 0x002F170F File Offset: 0x002EF90F
		[Nullable(2)]
		public unsafe UTexture2D Texture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + ULGUITextureData.__PropertyOffset_Texture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULGUITextureData.__PropertyOffset_Texture, value);
			}
		}

		// Token: 0x17007CD8 RID: 31960
		// (get) Token: 0x0601FAA0 RID: 129696 RVA: 0x002F1724 File Offset: 0x002EF924
		// (set) Token: 0x0601FAA1 RID: 129697 RVA: 0x002F175D File Offset: 0x002EF95D
		public FLGUISpriteInfo SpriteInfo
		{
			get
			{
				base.FastCheckIsValid();
				FLGUISpriteInfo result;
				if ((result = this._SpriteInfo) == null)
				{
					result = (this._SpriteInfo = new FLGUISpriteInfo(base.NativePtr + (IntPtr)ULGUITextureData.__PropertyOffset_SpriteInfo, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLGUISpriteInfo.StaticStruct(), base.NativePtr + (IntPtr)ULGUITextureData.__PropertyOffset_SpriteInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601FAA2 RID: 129698 RVA: 0x002F177E File Offset: 0x002EF97E
		static ULGUITextureData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUITextureData");
		}

		// Token: 0x0601FAA3 RID: 129699 RVA: 0x002F178C File Offset: 0x002EF98C
		protected ULGUITextureData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011156 RID: 69974
		public new const string __ObjectPath = "/Script/LGUI.LGUITextureData";

		// Token: 0x04011157 RID: 69975
		private static IntPtr _ClassPtr;

		// Token: 0x04011158 RID: 69976
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011159 RID: 69977
		internal static int __PropertyOffset_Texture;

		// Token: 0x0401115A RID: 69978
		internal static int __PropertyOffset_SpriteInfo;

		// Token: 0x0401115B RID: 69979
		[Nullable(2)]
		private FLGUISpriteInfo _SpriteInfo;
	}
}
